using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of device script.</summary>
    public enum DeviceHealthScriptType {
        /// <summary>Indicates this is a device health script.</summary>
        [EnumMember(Value = "deviceHealthScript")]
        DeviceHealthScript,
        /// <summary>Indicates this is a managed installer script.</summary>
        [EnumMember(Value = "managedInstallerScript")]
        ManagedInstallerScript,
    }
}
