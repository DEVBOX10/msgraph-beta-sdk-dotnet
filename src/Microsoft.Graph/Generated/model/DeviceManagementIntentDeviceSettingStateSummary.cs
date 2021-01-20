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
    /// The type Device Management Intent Device Setting State Summary.
    /// </summary>
    public partial class DeviceManagementIntentDeviceSettingStateSummary : Entity
    {
    
		///<summary>
		/// The DeviceManagementIntentDeviceSettingStateSummary constructor
		///</summary>
        public DeviceManagementIntentDeviceSettingStateSummary()
        {
            this.ODataType = "microsoft.graph.deviceManagementIntentDeviceSettingStateSummary";
        }
	
        /// <summary>
        /// Gets or sets compliant count.
        /// Number of compliant devices
        /// </summary>
        [JsonPropertyName("compliantCount")]
        public Int32? CompliantCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict count.
        /// Number of devices in conflict
        /// </summary>
        [JsonPropertyName("conflictCount")]
        public Int32? ConflictCount { get; set; }
    
        /// <summary>
        /// Gets or sets error count.
        /// Number of error devices
        /// </summary>
        [JsonPropertyName("errorCount")]
        public Int32? ErrorCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant count.
        /// Number of non compliant devices
        /// </summary>
        [JsonPropertyName("nonCompliantCount")]
        public Int32? NonCompliantCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable count.
        /// Number of not applicable devices
        /// </summary>
        [JsonPropertyName("notApplicableCount")]
        public Int32? NotApplicableCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated count.
        /// Number of remediated devices
        /// </summary>
        [JsonPropertyName("remediatedCount")]
        public Int32? RemediatedCount { get; set; }
    
        /// <summary>
        /// Gets or sets setting name.
        /// Name of a setting
        /// </summary>
        [JsonPropertyName("settingName")]
        public string SettingName { get; set; }
    
    }
}

