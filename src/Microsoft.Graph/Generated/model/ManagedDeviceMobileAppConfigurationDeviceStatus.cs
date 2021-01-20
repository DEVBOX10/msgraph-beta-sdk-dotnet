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
    /// The type Managed Device Mobile App Configuration Device Status.
    /// </summary>
    public partial class ManagedDeviceMobileAppConfigurationDeviceStatus : Entity
    {
    
		///<summary>
		/// The ManagedDeviceMobileAppConfigurationDeviceStatus constructor
		///</summary>
        public ManagedDeviceMobileAppConfigurationDeviceStatus()
        {
            this.ODataType = "microsoft.graph.managedDeviceMobileAppConfigurationDeviceStatus";
        }
	
        /// <summary>
        /// Gets or sets compliance grace period expiration date time.
        /// The DateTime when device compliance grace period expires
        /// </summary>
        [JsonPropertyName("complianceGracePeriodExpirationDateTime")]
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device display name.
        /// Device name of the DevicePolicyStatus.
        /// </summary>
        [JsonPropertyName("deviceDisplayName")]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device model.
        /// The device model that is being reported
        /// </summary>
        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets last reported date time.
        /// Last modified date time of the policy report.
        /// </summary>
        [JsonPropertyName("lastReportedDateTime")]
        public DateTimeOffset? LastReportedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// Platform of the device that is being reported
        /// </summary>
        [JsonPropertyName("platform")]
        public Int32? Platform { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Compliance status of the policy report. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.
        /// </summary>
        [JsonPropertyName("status")]
        public ComplianceStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// The User Name that is being reported
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// UserPrincipalName.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

