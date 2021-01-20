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
    /// The type Imported Device Identity Result.
    /// </summary>
    public partial class ImportedDeviceIdentityResult : ImportedDeviceIdentity
    {
    
		///<summary>
		/// The ImportedDeviceIdentityResult constructor
		///</summary>
        public ImportedDeviceIdentityResult()
        {
            this.ODataType = "microsoft.graph.importedDeviceIdentityResult";
        }
	
        /// <summary>
        /// Gets or sets status.
        /// Status of imported device identity
        /// </summary>
        [JsonPropertyName("status")]
        public bool? Status { get; set; }
    
    }
}

