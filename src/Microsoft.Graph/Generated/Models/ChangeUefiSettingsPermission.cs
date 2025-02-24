// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Defines the permission level granted to users to enable them change Uefi settings</summary>
    public enum ChangeUefiSettingsPermission {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "notConfiguredOnly")]
        NotConfiguredOnly,
        /// <summary>Prevent change of UEFI setting permission</summary>
        [EnumMember(Value = "none")]
        None,
    }
}
