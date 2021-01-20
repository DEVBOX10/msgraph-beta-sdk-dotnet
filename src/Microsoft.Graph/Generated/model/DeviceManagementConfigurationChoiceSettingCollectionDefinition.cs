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
    /// The type Device Management Configuration Choice Setting Collection Definition.
    /// </summary>
    public partial class DeviceManagementConfigurationChoiceSettingCollectionDefinition : DeviceManagementConfigurationChoiceSettingDefinition
    {
    
		///<summary>
		/// The DeviceManagementConfigurationChoiceSettingCollectionDefinition constructor
		///</summary>
        public DeviceManagementConfigurationChoiceSettingCollectionDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationChoiceSettingCollectionDefinition";
        }
	
        /// <summary>
        /// Gets or sets maximum count.
        /// Maximum number of choices in the collection. Valid values 1 to 100
        /// </summary>
        [JsonPropertyName("maximumCount")]
        public Int32? MaximumCount { get; set; }
    
        /// <summary>
        /// Gets or sets minimum count.
        /// Minimum number of choices in the collection. Valid values 1 to 100
        /// </summary>
        [JsonPropertyName("minimumCount")]
        public Int32? MinimumCount { get; set; }
    
    }
}

