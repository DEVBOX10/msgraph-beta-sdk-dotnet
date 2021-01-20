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
    /// The type Unsupported Group Policy Extension.
    /// </summary>
    public partial class UnsupportedGroupPolicyExtension : Entity
    {
    
		///<summary>
		/// The UnsupportedGroupPolicyExtension constructor
		///</summary>
        public UnsupportedGroupPolicyExtension()
        {
            this.ODataType = "microsoft.graph.unsupportedGroupPolicyExtension";
        }
	
        /// <summary>
        /// Gets or sets extension type.
        /// ExtensionType of the unsupported extension.
        /// </summary>
        [JsonPropertyName("extensionType")]
        public string ExtensionType { get; set; }
    
        /// <summary>
        /// Gets or sets namespace url.
        /// Namespace Url of the unsupported extension.
        /// </summary>
        [JsonPropertyName("namespaceUrl")]
        public string NamespaceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets node name.
        /// Node name of the unsupported extension.
        /// </summary>
        [JsonPropertyName("nodeName")]
        public string NodeName { get; set; }
    
        /// <summary>
        /// Gets or sets setting scope.
        /// Setting Scope of the unsupported extension. Possible values are: unknown, device, user.
        /// </summary>
        [JsonPropertyName("settingScope")]
        public GroupPolicySettingScope? SettingScope { get; set; }
    
    }
}

