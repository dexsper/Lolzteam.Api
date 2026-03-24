namespace Lolzteam.Codegen;

/// <summary>
/// Collects enum parameters from parsed groups, deduplicates by name+values,
/// and resolves naming conflicts (same param name, different values).
/// </summary>
internal static class EnumCollector
{
	/// <summary>
	/// Tracks where an enum was seen (group + operation + param name + values).
	/// </summary>
	private sealed record EnumOccurrence(
		string GroupName,
		string OperationId,
		string ParamName,
		bool IsIntEnum,
		List<EnumVariant> Values
	);

	/// <summary>
	/// Collect all enum definitions and build a mapping from (groupName, paramName) → enum type name.
	/// </summary>
	internal static (List<EnumDefinition> Enums, Dictionary<string, string> ParamToEnumType) Collect(List<ParsedGroup> groups)
	{
		var occurrences = new List<EnumOccurrence>();
		foreach (var group in groups)
		{
			foreach (var method in group.Methods)
			{
				foreach (var param in method.Params.QueryParams)
				{
					if (param.EnumValues is { Count: > 0 } values)
					{
						occurrences.Add(new EnumOccurrence(
							group.GroupName, method.OperationId, param.Name, values[0] is EnumVariant.IntVariant, values));
					}
				}
				foreach (var prop in method.BodyProperties)
				{
					if (prop.EnumValues is { Count: > 0 } values)
					{
						occurrences.Add(new EnumOccurrence(
							group.GroupName, method.OperationId, prop.Name, values[0] is EnumVariant.IntVariant, values));
					}
				}

                if (method.BodyOneOfVariants is not { Count: > 0 } variants)
                    continue;

                foreach (var variant in variants)
                {
                    foreach (var prop in variant.Properties)
                    {
                        if (prop.EnumValues is { Count: > 0 } values)
                        {
                            occurrences.Add(new EnumOccurrence(
                                group.GroupName, method.OperationId, prop.Name, values[0] is EnumVariant.IntVariant, values));
                        }
                    }
                }
            }
		}

		if (occurrences.Count == 0)
		{
			return ([], []);
		}

		var byName = new Dictionary<string, List<EnumOccurrence>>();
		foreach (var occ in occurrences)
		{
			if (!byName.TryGetValue(occ.ParamName, out var list))
			{
				list = [];
				byName[occ.ParamName] = list;
			}
			list.Add(occ);
		}

		var enumDefs = new Dictionary<string, EnumDefinition>();
		var paramToEnumType = new Dictionary<string, string>();

		foreach (var (paramName, occs) in byName)
		{
			var distinctValueSets = DeduplicateValueSets(occs);

			if (distinctValueSets.Count == 1)
			{
				var (isInt, values) = distinctValueSets[0];
                var typeName = EnsureUniqueTypeName(SafeEnumTypeName(paramName), enumDefs);
				var def = new EnumDefinition(typeName, isInt, values);

				enumDefs[typeName] = def;

				foreach (var occ in occs)
				{
					var key = occ.OperationId + ":" + occ.ParamName;
					paramToEnumType.TryAdd(key, typeName);
				}
			}
			else
			{
				foreach (var (isInt, values) in distinctValueSets)
				{
					var groupsForSet = new List<EnumOccurrence>();
					foreach (var occ in occs)
					{
						if (ValuesEqual(occ.Values, values))
						{
							groupsForSet.Add(occ);
						}
					}

					var distinctGroups = new SortedSet<string>();
					foreach (var occ in groupsForSet)
					{
						distinctGroups.Add(occ.GroupName);
					}

					var prefix = Naming.CapitalizeFirst(distinctGroups.First());
					var baseName = SafeEnumTypeName(paramName);
                    var typeName = EnsureUniqueTypeName(prefix + baseName, enumDefs);
					var def = new EnumDefinition(typeName, isInt, values);

					enumDefs[typeName] = def;

					foreach (var occ in groupsForSet)
					{
						var key = occ.OperationId + ":" + occ.ParamName;
						paramToEnumType.TryAdd(key, typeName);
					}
				}
			}
		}

		var sortedEnums = enumDefs.Values.OrderBy(e => e.TypeName).ToList();
		return (sortedEnums, paramToEnumType);
	}

	/// <summary>Deduplicate value sets, returning distinct (isInt, values) pairs.</summary>
	private static List<(bool IsInt, List<EnumVariant> Values)> DeduplicateValueSets(List<EnumOccurrence> occurrences)
	{
		var result = new List<(bool, List<EnumVariant>)>();
		foreach (var occ in occurrences)
		{
			var found = false;
			foreach (var (_, values) in result)
            {
                if (!ValuesEqual(occ.Values, values))
                    continue;

                found = true;
                break;
            }

            if (found) continue;
            result.Add((occ.IsIntEnum, occ.Values));
        }
		return result;
	}

	/// <summary>Check if two enum value lists are equal.</summary>
	private static bool ValuesEqual(List<EnumVariant> a, List<EnumVariant> b)
	{
		if (a.Count != b.Count) return false;
		var setA = new HashSet<string>(a.Select(VariantKey));
		var setB = new HashSet<string>(b.Select(VariantKey));

		return setA.SetEquals(setB);
	}

	private static string VariantKey(EnumVariant v) => v switch
	{
		EnumVariant.IntVariant i => "i:" + i.Value,
		EnumVariant.StringVariant s => "s:" + s.Value,
		_ => throw new InvalidOperationException(),
	};

	/// <summary>Convert a param name to a safe C# enum type name.</summary>
	private static string SafeEnumTypeName(string paramName)
	{
		var name = Naming.SnakeToPascal(Naming.SanitizeName(paramName));
		if (name.Length > 0 && char.IsDigit(name[0]))
		{
			name = "E" + name;
		}
		return name;
	}

	private static string EnsureUniqueTypeName(string name, Dictionary<string, EnumDefinition> existing)
	{
		if (!existing.ContainsKey(name)) return name;
		var suffix = 2;
		while (existing.ContainsKey(name + suffix)) suffix++;
		return name + suffix;
	}
}
