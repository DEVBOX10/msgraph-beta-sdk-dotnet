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
    /// The type Legalhold.
    /// </summary>
    public partial class Legalhold : Entity
    {
    
		///<summary>
		/// The Legalhold constructor
		///</summary>
        public Legalhold()
        {
            this.ODataType = "microsoft.graph.legalhold";
        }
	
        /// <summary>
        /// Gets or sets content query.
        /// </summary>
        [JsonPropertyName("contentQuery")]
        public string ContentQuery { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets errors.
        /// </summary>
        [JsonPropertyName("errors")]
        public IEnumerable<string> Errors { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public LegalHoldStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets site sources.
        /// </summary>
        [JsonPropertyName("siteSources")]
        public ILegalholdSiteSourcesCollectionPage SiteSources { get; set; }
    
        /// <summary>
        /// Gets or sets unified group sources.
        /// </summary>
        [JsonPropertyName("unifiedGroupSources")]
        public ILegalholdUnifiedGroupSourcesCollectionPage UnifiedGroupSources { get; set; }
    
        /// <summary>
        /// Gets or sets user sources.
        /// </summary>
        [JsonPropertyName("userSources")]
        public ILegalholdUserSourcesCollectionPage UserSources { get; set; }
    
    }
}

