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
    /// The type Workbook Filter.
    /// </summary>
    public partial class WorkbookFilter : Entity
    {
    
		///<summary>
		/// The WorkbookFilter constructor
		///</summary>
        public WorkbookFilter()
        {
            this.ODataType = "microsoft.graph.workbookFilter";
        }
	
        /// <summary>
        /// Gets or sets criteria.
        /// The currently applied filter on the given column. Read-only.
        /// </summary>
        [JsonPropertyName("criteria")]
        public WorkbookFilterCriteria Criteria { get; set; }
    
    }
}

