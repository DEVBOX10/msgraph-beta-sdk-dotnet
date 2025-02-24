// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents various network types for Zebra FOTA deployment.</summary>
    public enum ZebraFotaNetworkType {
        /// <summary>The device will install the update regardless of current network type.</summary>
        [EnumMember(Value = "any")]
        Any,
        /// <summary>The device will install the update only when connected to WiFi network.</summary>
        [EnumMember(Value = "wifi")]
        Wifi,
        /// <summary>The device will install the update only when connected a Cellular network.</summary>
        [EnumMember(Value = "cellular")]
        Cellular,
        /// <summary>The device will install the update when connected both WiFi and Cellular.</summary>
        [EnumMember(Value = "wifiAndCellular")]
        WifiAndCellular,
        /// <summary>Unknown future enum value.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
