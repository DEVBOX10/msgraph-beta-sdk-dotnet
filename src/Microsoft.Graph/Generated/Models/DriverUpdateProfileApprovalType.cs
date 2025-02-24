// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum type to represent approval type of a driver update profile.</summary>
    public enum DriverUpdateProfileApprovalType {
        /// <summary>This indicates a driver and firmware profile needs to be approved manually.</summary>
        [EnumMember(Value = "manual")]
        Manual,
        /// <summary>This indicates a driver and firmware profile is approved automatically.</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
    }
}
