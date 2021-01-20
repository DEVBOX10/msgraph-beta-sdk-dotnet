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
    /// The type Device Management Configuration Category.
    /// </summary>
    public partial class DeviceManagementConfigurationCategory : Entity
    {
    
		///<summary>
		/// The DeviceManagementConfigurationCategory constructor
		///</summary>
        public DeviceManagementConfigurationCategory()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationCategory";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// Description of the item
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the item
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets help text.
        /// Help text of the item
        /// </summary>
        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the item
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets platforms.
        /// Platforms types, which settings in the category have. Possible values are: none, macOS, windows10X, windows10.
        /// </summary>
        [JsonPropertyName("platforms")]
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
    
        /// <summary>
        /// Gets or sets technologies.
        /// Technologies types, which settings in the category have. Possible values are: none, mdm, windows10XManagement, configManager.
        /// </summary>
        [JsonPropertyName("technologies")]
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
    
    }
}

