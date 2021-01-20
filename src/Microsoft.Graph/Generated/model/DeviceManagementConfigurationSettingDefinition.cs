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
    /// The type Device Management Configuration Setting Definition.
    /// </summary>
    public partial class DeviceManagementConfigurationSettingDefinition : Entity
    {
    
		///<summary>
		/// The DeviceManagementConfigurationSettingDefinition constructor
		///</summary>
        public DeviceManagementConfigurationSettingDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationSettingDefinition";
        }
	
        /// <summary>
        /// Gets or sets access types.
        /// Read/write access mode of the setting. Possible values are: none, add, copy, delete, get, replace, execute.
        /// </summary>
        [JsonPropertyName("accessTypes")]
        public DeviceManagementConfigurationSettingAccessTypes? AccessTypes { get; set; }
    
        /// <summary>
        /// Gets or sets applicability.
        /// Details which device setting is applicable on
        /// </summary>
        [JsonPropertyName("applicability")]
        public DeviceManagementConfigurationSettingApplicability Applicability { get; set; }
    
        /// <summary>
        /// Gets or sets base uri.
        /// Base CSP Path
        /// </summary>
        [JsonPropertyName("baseUri")]
        public string BaseUri { get; set; }
    
        /// <summary>
        /// Gets or sets category id.
        /// Specifies the area group under which the setting is configured in a specified configuration service provider (CSP)
        /// </summary>
        [JsonPropertyName("categoryId")]
        public string CategoryId { get; set; }
    
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
        /// Gets or sets info urls.
        /// List of links more info for the setting can be found at
        /// </summary>
        [JsonPropertyName("infoUrls")]
        public IEnumerable<string> InfoUrls { get; set; }
    
        /// <summary>
        /// Gets or sets keywords.
        /// Tokens which to search settings on
        /// </summary>
        [JsonPropertyName("keywords")]
        public IEnumerable<string> Keywords { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the item
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets occurrence.
        /// Indicates whether the setting is required or not
        /// </summary>
        [JsonPropertyName("occurrence")]
        public DeviceManagementConfigurationSettingOccurrence Occurrence { get; set; }
    
        /// <summary>
        /// Gets or sets offset uri.
        /// Offset CSP Path from Base
        /// </summary>
        [JsonPropertyName("offsetUri")]
        public string OffsetUri { get; set; }
    
        /// <summary>
        /// Gets or sets root definition id.
        /// Root setting definition if the setting is a child setting.
        /// </summary>
        [JsonPropertyName("rootDefinitionId")]
        public string RootDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets setting usage.
        /// Setting type, for example, configuration and compliance. Possible values are: none, configuration.
        /// </summary>
        [JsonPropertyName("settingUsage")]
        public DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Item Version
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    
    }
}

