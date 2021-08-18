// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DisplayTemplate.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<DisplayTemplate>))]
    public partial class DisplayTemplate
    {

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets layout.
        /// </summary>
        [JsonPropertyName("layout")]
        public System.Text.Json.JsonDocument Layout { get; set; }
    
        /// <summary>
        /// Gets or sets priority.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
        /// <summary>
        /// Gets or sets rules.
        /// </summary>
        [JsonPropertyName("rules")]
        public IEnumerable<PropertyRule> Rules { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
