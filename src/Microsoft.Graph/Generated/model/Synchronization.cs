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
    /// The type Synchronization.
    /// </summary>
    public partial class Synchronization : Entity
    {
    
		///<summary>
		/// The Synchronization constructor
		///</summary>
        public Synchronization()
        {
            this.ODataType = "microsoft.graph.synchronization";
        }
	
        /// <summary>
        /// Gets or sets secrets.
        /// </summary>
        [JsonPropertyName("secrets")]
        public IEnumerable<SynchronizationSecretKeyStringValuePair> Secrets { get; set; }
    
        /// <summary>
        /// Gets or sets jobs.
        /// </summary>
        [JsonPropertyName("jobs")]
        public ISynchronizationJobsCollectionPage Jobs { get; set; }
    
        /// <summary>
        /// Gets or sets templates.
        /// </summary>
        [JsonPropertyName("templates")]
        public ISynchronizationTemplatesCollectionPage Templates { get; set; }
    
    }
}

