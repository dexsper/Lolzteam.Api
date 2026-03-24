// Polyfills for C# 9-11 features on netstandard2.0 / netstandard2.1

#if !NET5_0_OR_GREATER

namespace System.Runtime.CompilerServices
{
    // Enables init-only setters (C# 9 records) on older targets
    internal static class IsExternalInit { }
}

#endif

#if !NET7_0_OR_GREATER

namespace System.Runtime.CompilerServices
{
    // Enables the `required` keyword (C# 11) on older targets
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, Inherited = false)]
    internal sealed class RequiredMemberAttribute : Attribute { }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    internal sealed class CompilerFeatureRequiredAttribute : Attribute
    {
        // ReSharper disable once UnusedParameter.Local
        public CompilerFeatureRequiredAttribute(string featureName) { }
    }
}

namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsage(AttributeTargets.Constructor)]
    internal sealed class SetsRequiredMembersAttribute : Attribute { }
}

#endif
