// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type DeviceManagementReportsGetDeviceManagementIntentSettingsReportRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementReportsGetDeviceManagementIntentSettingsReportRequestBody
    {
    
        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets Select.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "select", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Select { get; set; }
    
        /// <summary>
        /// Gets or sets Search.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "search", Required = Newtonsoft.Json.Required.Default)]
        public string Search { get; set; }
    
        /// <summary>
        /// Gets or sets GroupBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "groupBy", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> GroupBy { get; set; }
    
        /// <summary>
        /// Gets or sets OrderBy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderBy", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OrderBy { get; set; }
    
        /// <summary>
        /// Gets or sets Skip.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skip", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Skip { get; set; }
    
        /// <summary>
        /// Gets or sets Top.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "top", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Top { get; set; }
    
        /// <summary>
        /// Gets or sets SessionId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sessionId", Required = Newtonsoft.Json.Required.Default)]
        public string SessionId { get; set; }
    
        /// <summary>
        /// Gets or sets Filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filter", Required = Newtonsoft.Json.Required.Default)]
        public string Filter { get; set; }
    
    }
}
