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
    /// The type Security.
    /// </summary>
    public partial class Security : Entity
    {
    
		///<summary>
		/// The Security constructor
		///</summary>
        public Security()
        {
            this.ODataType = "microsoft.graph.security";
        }
	
        /// <summary>
        /// Gets or sets provider status.
        /// </summary>
        [JsonPropertyName("providerStatus")]
        public IEnumerable<SecurityProviderStatus> ProviderStatus { get; set; }
    
        /// <summary>
        /// Gets or sets alerts.
        /// Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("alerts")]
        public ISecurityAlertsCollectionPage Alerts { get; set; }
    
        /// <summary>
        /// Gets or sets cloud app security profiles.
        /// </summary>
        [JsonPropertyName("cloudAppSecurityProfiles")]
        public ISecurityCloudAppSecurityProfilesCollectionPage CloudAppSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets domain security profiles.
        /// </summary>
        [JsonPropertyName("domainSecurityProfiles")]
        public ISecurityDomainSecurityProfilesCollectionPage DomainSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets file security profiles.
        /// </summary>
        [JsonPropertyName("fileSecurityProfiles")]
        public ISecurityFileSecurityProfilesCollectionPage FileSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets host security profiles.
        /// </summary>
        [JsonPropertyName("hostSecurityProfiles")]
        public ISecurityHostSecurityProfilesCollectionPage HostSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets ip security profiles.
        /// </summary>
        [JsonPropertyName("ipSecurityProfiles")]
        public ISecurityIpSecurityProfilesCollectionPage IpSecurityProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets provider tenant settings.
        /// </summary>
        [JsonPropertyName("providerTenantSettings")]
        public ISecurityProviderTenantSettingsCollectionPage ProviderTenantSettings { get; set; }
    
        /// <summary>
        /// Gets or sets secure score control profiles.
        /// </summary>
        [JsonPropertyName("secureScoreControlProfiles")]
        public ISecuritySecureScoreControlProfilesCollectionPage SecureScoreControlProfiles { get; set; }
    
        /// <summary>
        /// Gets or sets secure scores.
        /// </summary>
        [JsonPropertyName("secureScores")]
        public ISecuritySecureScoresCollectionPage SecureScores { get; set; }
    
        /// <summary>
        /// Gets or sets security actions.
        /// </summary>
        [JsonPropertyName("securityActions")]
        public ISecuritySecurityActionsCollectionPage SecurityActions { get; set; }
    
        /// <summary>
        /// Gets or sets ti indicators.
        /// </summary>
        [JsonPropertyName("tiIndicators")]
        public ISecurityTiIndicatorsCollectionPage TiIndicators { get; set; }
    
        /// <summary>
        /// Gets or sets user security profiles.
        /// </summary>
        [JsonPropertyName("userSecurityProfiles")]
        public ISecurityUserSecurityProfilesCollectionPage UserSecurityProfiles { get; set; }
    
    }
}

