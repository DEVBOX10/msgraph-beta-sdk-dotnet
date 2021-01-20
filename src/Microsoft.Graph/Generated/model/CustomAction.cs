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
    /// The type CustomAction.
    /// </summary>
    public partial class CustomAction : InformationProtectionAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAction"/> class.
        /// </summary>
        public CustomAction()
        {
            this.ODataType = "microsoft.graph.customAction";
        }

        /// <summary>
        /// Gets or sets name.
        /// Name of the custom action.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// Properties, in key value pair format, of the action.
        /// </summary>
        [JsonPropertyName("properties")]
        public IEnumerable<KeyValuePair> Properties { get; set; }
    
    }
}
