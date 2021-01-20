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
    /// The type Ip Security Profile.
    /// </summary>
    public partial class IpSecurityProfile : Entity
    {
    
		///<summary>
		/// The IpSecurityProfile constructor
		///</summary>
        public IpSecurityProfile()
        {
            this.ODataType = "microsoft.graph.ipSecurityProfile";
        }
	
        /// <summary>
        /// Gets or sets activity group names.
        /// </summary>
        [JsonPropertyName("activityGroupNames")]
        public IEnumerable<string> ActivityGroupNames { get; set; }
    
        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    
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
        /// Gets or sets count hits.
        /// </summary>
        [JsonPropertyName("countHits")]
        public Int32? CountHits { get; set; }
    
        /// <summary>
        /// Gets or sets count hosts.
        /// </summary>
        [JsonPropertyName("countHosts")]
        public Int32? CountHosts { get; set; }
    
        /// <summary>
        /// Gets or sets first seen date time.
        /// </summary>
        [JsonPropertyName("firstSeenDateTime")]
        public DateTimeOffset? FirstSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets ip categories.
        /// </summary>
        [JsonPropertyName("ipCategories")]
        public IEnumerable<IpCategory> IpCategories { get; set; }
    
        /// <summary>
        /// Gets or sets ip reference data.
        /// </summary>
        [JsonPropertyName("ipReferenceData")]
        public IEnumerable<IpReferenceData> IpReferenceData { get; set; }
    
        /// <summary>
        /// Gets or sets last seen date time.
        /// </summary>
        [JsonPropertyName("lastSeenDateTime")]
        public DateTimeOffset? LastSeenDateTime { get; set; }
    
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

