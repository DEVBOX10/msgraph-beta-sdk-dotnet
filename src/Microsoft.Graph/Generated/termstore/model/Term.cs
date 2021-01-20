// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.TermStore
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Term.
    /// </summary>
    public partial class Term : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The Term constructor
		///</summary>
        public Term()
        {
            this.ODataType = "microsoft.graph.termStore.term";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time of term creation. Read-only
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets descriptions.
        /// Description about term that is dependent on the languageTag
        /// </summary>
        [JsonPropertyName("descriptions")]
        public IEnumerable<LocalizedDescription> Descriptions { get; set; }
    
        /// <summary>
        /// Gets or sets labels.
        /// </summary>
        [JsonPropertyName("labels")]
        public IEnumerable<LocalizedLabel> Labels { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last date and time of term modification. Read-only
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// Collection of properties on the term
        /// </summary>
        [JsonPropertyName("properties")]
        public IEnumerable<Microsoft.Graph.KeyValue> Properties { get; set; }
    
        /// <summary>
        /// Gets or sets children.
        /// Children of current term
        /// </summary>
        [JsonPropertyName("children")]
        public ITermChildrenCollectionPage Children { get; set; }
    
        /// <summary>
        /// Gets or sets relations.
        /// To indicate which terms are related to the current term as either pinned or reused
        /// </summary>
        [JsonPropertyName("relations")]
        public ITermRelationsCollectionPage Relations { get; set; }
    
        /// <summary>
        /// Gets or sets set.
        /// The [set] in which the term is created
        /// </summary>
        [JsonPropertyName("set")]
        public Set Set { get; set; }
    
    }
}

