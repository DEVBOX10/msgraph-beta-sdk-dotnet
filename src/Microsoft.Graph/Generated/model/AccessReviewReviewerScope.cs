// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AccessReviewReviewerScope.
    /// </summary>
    public partial class AccessReviewReviewerScope : AccessReviewScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewReviewerScope"/> class.
        /// </summary>
        public AccessReviewReviewerScope()
        {
            this.ODataType = "microsoft.graph.accessReviewReviewerScope";
        }

        /// <summary>
        /// Gets or sets queryRoot.
        /// In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query (i.e., ./manager) is specified.
        /// </summary>
        [JsonPropertyName("queryRoot")]
        public string QueryRoot { get; set; }
    
    }
}
