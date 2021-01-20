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
    /// The type Group Policy Definition.
    /// </summary>
    public partial class GroupPolicyDefinition : Entity
    {
    
		///<summary>
		/// The GroupPolicyDefinition constructor
		///</summary>
        public GroupPolicyDefinition()
        {
            this.ODataType = "microsoft.graph.groupPolicyDefinition";
        }
	
        /// <summary>
        /// Gets or sets category path.
        /// The localized full category path for the policy.
        /// </summary>
        [JsonPropertyName("categoryPath")]
        public string CategoryPath { get; set; }
    
        /// <summary>
        /// Gets or sets class type.
        /// Identifies the type of groups the policy can be applied to. Possible values are: user, machine.
        /// </summary>
        [JsonPropertyName("classType")]
        public GroupPolicyDefinitionClassType? ClassType { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The localized policy name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets explain text.
        /// The localized explanation or help text associated with the policy. The default value is empty.
        /// </summary>
        [JsonPropertyName("explainText")]
        public string ExplainText { get; set; }
    
        /// <summary>
        /// Gets or sets group policy category id.
        /// The category id of the parent category
        /// </summary>
        [JsonPropertyName("groupPolicyCategoryId")]
        public Guid? GroupPolicyCategoryId { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the entity was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets policy type.
        /// Specifies the type of group policy. Possible values are: admxBacked, admxIngested.
        /// </summary>
        [JsonPropertyName("policyType")]
        public GroupPolicyType? PolicyType { get; set; }
    
        /// <summary>
        /// Gets or sets supported on.
        /// Localized string used to specify what operating system or application version is affected by the policy.
        /// </summary>
        [JsonPropertyName("supportedOn")]
        public string SupportedOn { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// The group policy category associated with the definition.
        /// </summary>
        [JsonPropertyName("category")]
        public GroupPolicyCategory Category { get; set; }
    
        /// <summary>
        /// Gets or sets definition file.
        /// The group policy file associated with the definition.
        /// </summary>
        [JsonPropertyName("definitionFile")]
        public GroupPolicyDefinitionFile DefinitionFile { get; set; }
    
        /// <summary>
        /// Gets or sets presentations.
        /// The group policy presentations associated with the definition.
        /// </summary>
        [JsonPropertyName("presentations")]
        public IGroupPolicyDefinitionPresentationsCollectionPage Presentations { get; set; }
    
    }
}

