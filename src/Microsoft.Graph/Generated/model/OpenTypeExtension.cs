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
    /// The type Open Type Extension.
    /// </summary>
    public partial class OpenTypeExtension : Extension
    {
    
		///<summary>
		/// The OpenTypeExtension constructor
		///</summary>
        public OpenTypeExtension()
        {
            this.ODataType = "microsoft.graph.openTypeExtension";
        }
	
        /// <summary>
        /// Gets or sets extension name.
        /// A unique text identifier for an open type data extension. Required.
        /// </summary>
        [JsonPropertyName("extensionName")]
        public string ExtensionName { get; set; }
    
    }
}

