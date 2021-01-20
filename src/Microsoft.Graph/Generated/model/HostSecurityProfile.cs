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
    /// The type Host Security Profile.
    /// </summary>
    public partial class HostSecurityProfile : Entity
    {
    
		///<summary>
		/// The HostSecurityProfile constructor
		///</summary>
        public HostSecurityProfile()
        {
            this.ODataType = "microsoft.graph.hostSecurityProfile";
        }
	
        /// <summary>
        /// Gets or sets azure subscription id.
        /// </summary>
        [JsonPropertyName("azureSubscriptionId")]
        public string AzureSubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// </summary>
        [JsonPropertyName("azureTenantId")]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets first seen date time.
        /// </summary>
        [JsonPropertyName("firstSeenDateTime")]
        public DateTimeOffset? FirstSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets fqdn.
        /// </summary>
        [JsonPropertyName("fqdn")]
        public string Fqdn { get; set; }
    
        /// <summary>
        /// Gets or sets is azure ad joined.
        /// </summary>
        [JsonPropertyName("isAzureAdJoined")]
        public bool? IsAzureAdJoined { get; set; }
    
        /// <summary>
        /// Gets or sets is azure ad registered.
        /// </summary>
        [JsonPropertyName("isAzureAdRegistered")]
        public bool? IsAzureAdRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets is hybrid azure domain joined.
        /// </summary>
        [JsonPropertyName("isHybridAzureDomainJoined")]
        public bool? IsHybridAzureDomainJoined { get; set; }
    
        /// <summary>
        /// Gets or sets last seen date time.
        /// </summary>
        [JsonPropertyName("lastSeenDateTime")]
        public DateTimeOffset? LastSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets logon users.
        /// </summary>
        [JsonPropertyName("logonUsers")]
        public IEnumerable<LogonUser> LogonUsers { get; set; }
    
        /// <summary>
        /// Gets or sets net bios name.
        /// </summary>
        [JsonPropertyName("netBiosName")]
        public string NetBiosName { get; set; }
    
        /// <summary>
        /// Gets or sets network interfaces.
        /// </summary>
        [JsonPropertyName("networkInterfaces")]
        public IEnumerable<NetworkInterface> NetworkInterfaces { get; set; }
    
        /// <summary>
        /// Gets or sets os.
        /// </summary>
        [JsonPropertyName("os")]
        public string Os { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets parent host.
        /// </summary>
        [JsonPropertyName("parentHost")]
        public string ParentHost { get; set; }
    
        /// <summary>
        /// Gets or sets related host ids.
        /// </summary>
        [JsonPropertyName("relatedHostIds")]
        public IEnumerable<string> RelatedHostIds { get; set; }
    
        /// <summary>
        /// Gets or sets risk score.
        /// </summary>
        [JsonPropertyName("riskScore")]
        public string RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// </summary>
        [JsonPropertyName("vendorInformation")]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}

