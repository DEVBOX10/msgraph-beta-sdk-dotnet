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
    /// The type Device Management Intent Device State Summary.
    /// </summary>
    public partial class DeviceManagementIntentDeviceStateSummary : Entity
    {
    
		///<summary>
		/// The DeviceManagementIntentDeviceStateSummary constructor
		///</summary>
        public DeviceManagementIntentDeviceStateSummary()
        {
            this.ODataType = "microsoft.graph.deviceManagementIntentDeviceStateSummary";
        }
	
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
        /// Gets or sets failed count.
        /// Number of failed devices
        /// </summary>
        [JsonPropertyName("failedCount")]
        public Int32? FailedCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable count.
        /// Number of not applicable devices
        /// </summary>
        [JsonPropertyName("notApplicableCount")]
        public Int32? NotApplicableCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable platform count.
        /// Number of not applicable devices due to mismatch platform and policy
        /// </summary>
        [JsonPropertyName("notApplicablePlatformCount")]
        public Int32? NotApplicablePlatformCount { get; set; }
    
        /// <summary>
        /// Gets or sets success count.
        /// Number of succeeded devices
        /// </summary>
        [JsonPropertyName("successCount")]
        public Int32? SuccessCount { get; set; }
    
    }
}

