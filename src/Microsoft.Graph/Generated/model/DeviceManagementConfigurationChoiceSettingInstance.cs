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
    /// The type DeviceManagementConfigurationChoiceSettingInstance.
    /// </summary>
    public partial class DeviceManagementConfigurationChoiceSettingInstance : DeviceManagementConfigurationSettingInstance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationChoiceSettingInstance"/> class.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingInstance()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationChoiceSettingInstance";
        }

        /// <summary>
        /// Gets or sets choiceSettingValue.
        /// Choice setting value
        /// </summary>
        [JsonPropertyName("choiceSettingValue")]
        public DeviceManagementConfigurationChoiceSettingValue ChoiceSettingValue { get; set; }
    
    }
}
