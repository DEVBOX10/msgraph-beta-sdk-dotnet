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
    /// The type Windows Health Monitoring Configuration.
    /// </summary>
    public partial class WindowsHealthMonitoringConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The WindowsHealthMonitoringConfiguration constructor
		///</summary>
        public WindowsHealthMonitoringConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsHealthMonitoringConfiguration";
        }
	
        /// <summary>
        /// Gets or sets allow device health monitoring.
        /// Enables device health monitoring on the device. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("allowDeviceHealthMonitoring")]
        public Enablement? AllowDeviceHealthMonitoring { get; set; }
    
        /// <summary>
        /// Gets or sets config device health monitoring custom scope.
        /// Specifies custom set of events collected from the device where health monitoring is enabled
        /// </summary>
        [JsonPropertyName("configDeviceHealthMonitoringCustomScope")]
        public string ConfigDeviceHealthMonitoringCustomScope { get; set; }
    
        /// <summary>
        /// Gets or sets config device health monitoring scope.
        /// Specifies set of events collected from the device where health monitoring is enabled. Possible values are: undefined, healthMonitoring, bootPerformance, windowsUpdates.
        /// </summary>
        [JsonPropertyName("configDeviceHealthMonitoringScope")]
        public WindowsHealthMonitoringScope? ConfigDeviceHealthMonitoringScope { get; set; }
    
    }
}

