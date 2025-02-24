// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates device event level. Possible values are: None, Verbose, Information, Warning, Error, Critical</summary>
    public enum DeviceEventLevel {
        /// <summary>Indicates that the device event level is none.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Indicates that the device event level is verbose.</summary>
        [EnumMember(Value = "verbose")]
        Verbose,
        /// <summary>Indicates that the device event level is information.</summary>
        [EnumMember(Value = "information")]
        Information,
        /// <summary>Indicates that the device event level is warning.</summary>
        [EnumMember(Value = "warning")]
        Warning,
        /// <summary>Indicates that the device event level is error.</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>Indicates that the device event level is critical.</summary>
        [EnumMember(Value = "critical")]
        Critical,
        /// <summary>Placeholder value for future expansion.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
