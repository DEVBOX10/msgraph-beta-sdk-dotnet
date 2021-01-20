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
    /// The type Group Policy Presentation Dropdown List.
    /// </summary>
    public partial class GroupPolicyPresentationDropdownList : GroupPolicyPresentation
    {
    
		///<summary>
		/// The GroupPolicyPresentationDropdownList constructor
		///</summary>
        public GroupPolicyPresentationDropdownList()
        {
            this.ODataType = "microsoft.graph.groupPolicyPresentationDropdownList";
        }
	
        /// <summary>
        /// Gets or sets default item.
        /// Localized string value identifying the default choice of the list of items.
        /// </summary>
        [JsonPropertyName("defaultItem")]
        public GroupPolicyPresentationDropdownListItem DefaultItem { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// Represents a set of localized display names and their associated values.
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<GroupPolicyPresentationDropdownListItem> Items { get; set; }
    
        /// <summary>
        /// Gets or sets required.
        /// Requirement to enter a value in the parameter box. The default value is false.
        /// </summary>
        [JsonPropertyName("required")]
        public bool? Required { get; set; }
    
    }
}

