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
    /// The type Mobile Threat Defense Connector.
    /// </summary>
    public partial class MobileThreatDefenseConnector : Entity
    {
    
		///<summary>
		/// The MobileThreatDefenseConnector constructor
		///</summary>
        public MobileThreatDefenseConnector()
        {
            this.ODataType = "microsoft.graph.mobileThreatDefenseConnector";
        }
	
        /// <summary>
        /// Gets or sets allow partner to collect iosapplication metadata.
        /// For IOS devices, allows the admin to configure whether the data sync partner may also collect metadata about installed applications from Intune
        /// </summary>
        [JsonPropertyName("allowPartnerToCollectIOSApplicationMetadata")]
        public bool? AllowPartnerToCollectIOSApplicationMetadata { get; set; }
    
        /// <summary>
        /// Gets or sets android device blocked on missing partner data.
        /// For Android, set whether Intune must receive data from the data sync partner prior to marking a device compliant
        /// </summary>
        [JsonPropertyName("androidDeviceBlockedOnMissingPartnerData")]
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }
    
        /// <summary>
        /// Gets or sets android enabled.
        /// For Android, set whether data from the data sync partner should be used during compliance evaluations
        /// </summary>
        [JsonPropertyName("androidEnabled")]
        public bool? AndroidEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets android mobile application management enabled.
        /// For Android, set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
        /// </summary>
        [JsonPropertyName("androidMobileApplicationManagementEnabled")]
        public bool? AndroidMobileApplicationManagementEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets ios device blocked on missing partner data.
        /// For IOS, set whether Intune must receive data from the data sync partner prior to marking a device compliant
        /// </summary>
        [JsonPropertyName("iosDeviceBlockedOnMissingPartnerData")]
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }
    
        /// <summary>
        /// Gets or sets ios enabled.
        /// For IOS, get or set whether data from the data sync partner should be used during compliance evaluations
        /// </summary>
        [JsonPropertyName("iosEnabled")]
        public bool? IosEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets ios mobile application management enabled.
        /// For IOS, get or set whether data from the data sync partner should be used during Mobile Application Management (MAM) evaluations. Only one partner per platform may be enabled for Mobile Application Management (MAM) evaluation.
        /// </summary>
        [JsonPropertyName("iosMobileApplicationManagementEnabled")]
        public bool? IosMobileApplicationManagementEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets last heartbeat date time.
        /// DateTime of last Heartbeat recieved from the Data Sync Partner
        /// </summary>
        [JsonPropertyName("lastHeartbeatDateTime")]
        public DateTimeOffset? LastHeartbeatDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets mac device blocked on missing partner data.
        /// For Mac, get or set whether Intune must receive data from the data sync partner prior to marking a device compliant
        /// </summary>
        [JsonPropertyName("macDeviceBlockedOnMissingPartnerData")]
        public bool? MacDeviceBlockedOnMissingPartnerData { get; set; }
    
        /// <summary>
        /// Gets or sets mac enabled.
        /// For Mac, get or set whether data from the data sync partner should be used during compliance evaluations
        /// </summary>
        [JsonPropertyName("macEnabled")]
        public bool? MacEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets partner state.
        /// Data Sync Partner state for this account. Possible values are: unavailable, available, enabled, unresponsive.
        /// </summary>
        [JsonPropertyName("partnerState")]
        public MobileThreatPartnerTenantState? PartnerState { get; set; }
    
        /// <summary>
        /// Gets or sets partner unresponsiveness threshold in days.
        /// Get or Set days the per tenant tolerance to unresponsiveness for this partner integration
        /// </summary>
        [JsonPropertyName("partnerUnresponsivenessThresholdInDays")]
        public Int32? PartnerUnresponsivenessThresholdInDays { get; set; }
    
        /// <summary>
        /// Gets or sets partner unsupported os version blocked.
        /// Get or set whether to block devices on the enabled platforms that do not meet the minimum version requirements of the Data Sync Partner
        /// </summary>
        [JsonPropertyName("partnerUnsupportedOsVersionBlocked")]
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets windows device blocked on missing partner data.
        /// For Windows, set whether Intune must receive data from the data sync partner prior to marking a device compliant
        /// </summary>
        [JsonPropertyName("windowsDeviceBlockedOnMissingPartnerData")]
        public bool? WindowsDeviceBlockedOnMissingPartnerData { get; set; }
    
        /// <summary>
        /// Gets or sets windows enabled.
        /// For Windows, get or set whether data from the data sync partner should be used during compliance evaluations
        /// </summary>
        [JsonPropertyName("windowsEnabled")]
        public bool? WindowsEnabled { get; set; }
    
    }
}

