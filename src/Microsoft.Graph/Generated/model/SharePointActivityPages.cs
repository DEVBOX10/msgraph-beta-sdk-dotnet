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
    /// The type Share Point Activity Pages.
    /// </summary>
    public partial class SharePointActivityPages : Entity
    {
    
		///<summary>
		/// The SharePointActivityPages constructor
		///</summary>
        public SharePointActivityPages()
        {
            this.ODataType = "microsoft.graph.sharePointActivityPages";
        }
	
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
    
        /// <summary>
        /// Gets or sets visited page count.
        /// </summary>
        [JsonPropertyName("visitedPageCount")]
        public Int64? VisitedPageCount { get; set; }
    
    }
}

