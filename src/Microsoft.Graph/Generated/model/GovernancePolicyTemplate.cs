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
    /// The type Governance Policy Template.
    /// </summary>
    public partial class GovernancePolicyTemplate : Entity
    {
    
		///<summary>
		/// The GovernancePolicyTemplate constructor
		///</summary>
        public GovernancePolicyTemplate()
        {
            this.ODataType = "microsoft.graph.governancePolicyTemplate";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets policy.
        /// </summary>
        [JsonPropertyName("policy")]
        public GovernancePolicy Policy { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [JsonPropertyName("settings")]
        public BusinessFlowSettings Settings { get; set; }
    
    }
}

