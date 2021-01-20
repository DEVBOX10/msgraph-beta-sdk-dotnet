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
    /// The type Device Management Reports.
    /// </summary>
    public partial class DeviceManagementReports : Entity
    {
    
		///<summary>
		/// The DeviceManagementReports constructor
		///</summary>
        public DeviceManagementReports()
        {
            this.ODataType = "microsoft.graph.deviceManagementReports";
        }
	
        /// <summary>
        /// Gets or sets cached report configurations.
        /// Entity representing the configuration of a cached report
        /// </summary>
        [JsonPropertyName("cachedReportConfigurations")]
        public IDeviceManagementReportsCachedReportConfigurationsCollectionPage CachedReportConfigurations { get; set; }
    
        /// <summary>
        /// Gets or sets export jobs.
        /// Entity representing a job to export a report
        /// </summary>
        [JsonPropertyName("exportJobs")]
        public IDeviceManagementReportsExportJobsCollectionPage ExportJobs { get; set; }
    
        /// <summary>
        /// Gets or sets report schedules.
        /// Entity representing a schedule for which reports are delivered
        /// </summary>
        [JsonPropertyName("reportSchedules")]
        public IDeviceManagementReportsReportSchedulesCollectionPage ReportSchedules { get; set; }
    
    }
}

