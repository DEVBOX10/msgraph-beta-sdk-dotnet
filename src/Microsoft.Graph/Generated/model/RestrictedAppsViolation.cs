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
    /// The type Restricted Apps Violation.
    /// </summary>
    public partial class RestrictedAppsViolation : Entity
    {
    
		///<summary>
		/// The RestrictedAppsViolation constructor
		///</summary>
        public RestrictedAppsViolation()
        {
            this.ODataType = "microsoft.graph.restrictedAppsViolation";
        }
	
        /// <summary>
        /// Gets or sets device configuration id.
        /// Device configuration profile unique identifier, must be Guid
        /// </summary>
        [JsonPropertyName("deviceConfigurationId")]
        public string DeviceConfigurationId { get; set; }
    
        /// <summary>
        /// Gets or sets device configuration name.
        /// Device configuration profile name
        /// </summary>
        [JsonPropertyName("deviceConfigurationName")]
        public string DeviceConfigurationName { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// Managed device unique identifier, must be Guid
        /// </summary>
        [JsonPropertyName("managedDeviceId")]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets platform type.
        /// Platform type. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, windows10XProfile, all.
        /// </summary>
        [JsonPropertyName("platformType")]
        public PolicyPlatformType? PlatformType { get; set; }
    
        /// <summary>
        /// Gets or sets restricted apps.
        /// List of violated restricted apps
        /// </summary>
        [JsonPropertyName("restrictedApps")]
        public IEnumerable<ManagedDeviceReportedApp> RestrictedApps { get; set; }
    
        /// <summary>
        /// Gets or sets restricted apps state.
        /// Restricted apps state. Possible values are: prohibitedApps, notApprovedApps.
        /// </summary>
        [JsonPropertyName("restrictedAppsState")]
        public RestrictedAppsState? RestrictedAppsState { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// User unique identifier, must be Guid
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// User name
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
    }
}

