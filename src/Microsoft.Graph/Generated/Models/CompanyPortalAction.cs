// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Action on a device that can be executed in the Company Portal</summary>
    public enum CompanyPortalAction {
        /// <summary>Unknown device action</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Remove device from Company Portal</summary>
        [EnumMember(Value = "remove")]
        Remove,
        /// <summary>Reset device enrolled in Company Portal</summary>
        [EnumMember(Value = "reset")]
        Reset,
    }
}
