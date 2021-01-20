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
    /// The type File Classification Request.
    /// </summary>
    public partial class FileClassificationRequestObject : Entity
    {
    
		///<summary>
		/// The FileClassificationRequest constructor
		///</summary>
        public FileClassificationRequestObject()
        {
            this.ODataType = "microsoft.graph.fileClassificationRequest";
        }
	
        /// <summary>
        /// Gets or sets file.
        /// </summary>
        [JsonPropertyName("file")]
        public Stream File { get; set; }
    
        /// <summary>
        /// Gets or sets sensitive type ids.
        /// </summary>
        [JsonPropertyName("sensitiveTypeIds")]
        public IEnumerable<string> SensitiveTypeIds { get; set; }
    
    }
}

