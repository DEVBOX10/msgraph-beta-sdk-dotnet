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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DeviceManagementConfigurationReferenceSettingValue.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementConfigurationReferenceSettingValue : DeviceManagementConfigurationStringSettingValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationReferenceSettingValue"/> class.
        /// </summary>
        public DeviceManagementConfigurationReferenceSettingValue()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationReferenceSettingValue";
        }

        /// <summary>
        /// Gets or sets note.
        /// A note that admin can use to put some contextual information
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "note", Required = Newtonsoft.Json.Required.Default)]
        public string Note { get; set; }
    
    }
}
