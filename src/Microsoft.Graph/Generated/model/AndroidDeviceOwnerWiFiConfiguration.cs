// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Android Device Owner Wi Fi Configuration.
    /// </summary>
    public partial class AndroidDeviceOwnerWiFiConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The AndroidDeviceOwnerWiFiConfiguration constructor
		///</summary>
        public AndroidDeviceOwnerWiFiConfiguration()
        {
            this.ODataType = "microsoft.graph.androidDeviceOwnerWiFiConfiguration";
        }
	
        /// <summary>
        /// Gets or sets connect automatically.
        /// Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.
        /// </summary>
        [JsonPropertyName("connectAutomatically")]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// When set to true, this profile forces the device to connect to a network that doesn't broadcast its SSID to all devices.
        /// </summary>
        [JsonPropertyName("connectWhenNetworkNameIsHidden")]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets network name.
        /// Network Name
        /// </summary>
        [JsonPropertyName("networkName")]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets pre shared key.
        /// This is the pre-shared key for WPA Personal Wi-Fi network.
        /// </summary>
        [JsonPropertyName("preSharedKey")]
        public string PreSharedKey { get; set; }
    
        /// <summary>
        /// Gets or sets pre shared key is set.
        /// This is the pre-shared key for WPA Personal Wi-Fi network.
        /// </summary>
        [JsonPropertyName("preSharedKeyIsSet")]
        public bool? PreSharedKeyIsSet { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// This is the name of the Wi-Fi network that is broadcast to all devices.
        /// </summary>
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets wi fi security type.
        /// Indicates whether Wi-Fi endpoint uses an EAP based security type. Possible values are: open, wep, wpaPersonal, wpaEnterprise.
        /// </summary>
        [JsonPropertyName("wiFiSecurityType")]
        public AndroidDeviceOwnerWiFiSecurityType? WiFiSecurityType { get; set; }
    
    }
}

