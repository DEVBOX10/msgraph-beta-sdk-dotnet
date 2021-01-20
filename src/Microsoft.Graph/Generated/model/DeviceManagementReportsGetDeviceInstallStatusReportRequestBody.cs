// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DeviceManagementReportsGetDeviceInstallStatusReportRequestBody.
    /// </summary>
    public partial class DeviceManagementReportsGetDeviceInstallStatusReportRequestBody
    {
    
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets Select.
        /// </summary>
        [JsonPropertyName("select")]
        public IEnumerable<string> Select { get; set; }
    
        /// <summary>
        /// Gets or sets Search.
        /// </summary>
        [JsonPropertyName("search")]
        public string Search { get; set; }
    
        /// <summary>
        /// Gets or sets GroupBy.
        /// </summary>
        [JsonPropertyName("groupBy")]
        public IEnumerable<string> GroupBy { get; set; }
    
        /// <summary>
        /// Gets or sets OrderBy.
        /// </summary>
        [JsonPropertyName("orderBy")]
        public IEnumerable<string> OrderBy { get; set; }
    
        /// <summary>
        /// Gets or sets Skip.
        /// </summary>
        [JsonPropertyName("skip")]
        public Int32? Skip { get; set; }
    
        /// <summary>
        /// Gets or sets Top.
        /// </summary>
        [JsonPropertyName("top")]
        public Int32? Top { get; set; }
    
        /// <summary>
        /// Gets or sets SessionId.
        /// </summary>
        [JsonPropertyName("sessionId")]
        public string SessionId { get; set; }
    
        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonPropertyName("filter")]
        public string Filter { get; set; }
    
    }
}
