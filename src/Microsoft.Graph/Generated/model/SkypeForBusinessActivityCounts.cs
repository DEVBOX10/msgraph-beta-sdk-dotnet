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
    /// The type Skype For Business Activity Counts.
    /// </summary>
    public partial class SkypeForBusinessActivityCounts : Entity
    {
    
		///<summary>
		/// The SkypeForBusinessActivityCounts constructor
		///</summary>
        public SkypeForBusinessActivityCounts()
        {
            this.ODataType = "microsoft.graph.skypeForBusinessActivityCounts";
        }
	
        /// <summary>
        /// Gets or sets organized.
        /// </summary>
        [JsonPropertyName("organized")]
        public Int64? Organized { get; set; }
    
        /// <summary>
        /// Gets or sets participated.
        /// </summary>
        [JsonPropertyName("participated")]
        public Int64? Participated { get; set; }
    
        /// <summary>
        /// Gets or sets peer to peer.
        /// </summary>
        [JsonPropertyName("peerToPeer")]
        public Int64? PeerToPeer { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonPropertyName("reportDate")]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonPropertyName("reportPeriod")]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonPropertyName("reportRefreshDate")]
        public Date ReportRefreshDate { get; set; }
    
    }
}

