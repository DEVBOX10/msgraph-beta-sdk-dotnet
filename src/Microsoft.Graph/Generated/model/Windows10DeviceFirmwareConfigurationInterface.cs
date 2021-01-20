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
    /// The type Windows10Device Firmware Configuration Interface.
    /// </summary>
    public partial class Windows10DeviceFirmwareConfigurationInterface : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows10DeviceFirmwareConfigurationInterface constructor
		///</summary>
        public Windows10DeviceFirmwareConfigurationInterface()
        {
            this.ODataType = "microsoft.graph.windows10DeviceFirmwareConfigurationInterface";
        }
	
        /// <summary>
        /// Gets or sets boot from built in network adapters.
        /// Defines whether a user is allowed to boot from built-in network adapters. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("bootFromBuiltInNetworkAdapters")]
        public Enablement? BootFromBuiltInNetworkAdapters { get; set; }
    
        /// <summary>
        /// Gets or sets boot from external media.
        /// Defines whether a user is allowed to boot from external media. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("bootFromExternalMedia")]
        public Enablement? BootFromExternalMedia { get; set; }
    
        /// <summary>
        /// Gets or sets cameras.
        /// Defines whether built-in cameras are enabled. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("cameras")]
        public Enablement? Cameras { get; set; }
    
        /// <summary>
        /// Gets or sets change uefi settings permission.
        /// Defines the permission level granted to users to change UEFI settings. Possible values are: notConfiguredOnly, none.
        /// </summary>
        [JsonPropertyName("changeUefiSettingsPermission")]
        public ChangeUefiSettingsPermission? ChangeUefiSettingsPermission { get; set; }
    
        /// <summary>
        /// Gets or sets microphones and speakers.
        /// Defines whether built-in microphones or speakers are enabled. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("microphonesAndSpeakers")]
        public Enablement? MicrophonesAndSpeakers { get; set; }
    
        /// <summary>
        /// Gets or sets radios.
        /// Defines whether built-in radios e.g. WIFI, NFC, Bluetooth, are enabled. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("radios")]
        public Enablement? Radios { get; set; }
    
        /// <summary>
        /// Gets or sets virtualization of cpu and io.
        /// Defines whether CPU and IO virtualization is enabled. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("virtualizationOfCpuAndIO")]
        public Enablement? VirtualizationOfCpuAndIO { get; set; }
    
    }
}

