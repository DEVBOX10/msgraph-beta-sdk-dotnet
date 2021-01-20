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
    /// The type Authentication Context Class Reference.
    /// </summary>
    public partial class AuthenticationContextClassReference : Entity
    {
    
		///<summary>
		/// The AuthenticationContextClassReference constructor
		///</summary>
        public AuthenticationContextClassReference()
        {
            this.ODataType = "microsoft.graph.authenticationContextClassReference";
        }
	
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
        /// Gets or sets is available.
        /// </summary>
        [JsonPropertyName("isAvailable")]
        public bool? IsAvailable { get; set; }
    
    }
}

