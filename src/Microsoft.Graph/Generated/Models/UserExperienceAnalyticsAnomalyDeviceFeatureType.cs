using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the device&apos;s feature type. Possible values are: manufacturer, model, osVersion, application or driver.</summary>
    public enum UserExperienceAnalyticsAnomalyDeviceFeatureType {
        /// <summary>Indicates the manufacturer name as device feature type.</summary>
        [EnumMember(Value = "manufacturer")]
        Manufacturer,
        /// <summary>Indicates the model as a device feature type.</summary>
        [EnumMember(Value = "model")]
        Model,
        /// <summary>Indicates the OS as a device feature type.</summary>
        [EnumMember(Value = "osVersion")]
        OsVersion,
        /// <summary>Indicates the application as a device feature type.</summary>
        [EnumMember(Value = "application")]
        Application,
        /// <summary>Indicates the driver as a device feature type.</summary>
        [EnumMember(Value = "driver")]
        Driver,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
