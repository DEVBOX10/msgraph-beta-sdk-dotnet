// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the dependency type associated with a relationship between two mobile apps.</summary>
    public enum MobileAppDependencyType {
        /// <summary>Indicates that the child app should be detected before installing the parent app.</summary>
        [EnumMember(Value = "detect")]
        Detect,
        /// <summary>Indicates that the child app should be installed before installing the parent app.</summary>
        [EnumMember(Value = "autoInstall")]
        AutoInstall,
    }
}
