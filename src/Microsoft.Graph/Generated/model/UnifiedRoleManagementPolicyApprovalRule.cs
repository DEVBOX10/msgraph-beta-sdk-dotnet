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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Unified Role Management Policy Approval Rule.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UnifiedRoleManagementPolicyApprovalRule : UnifiedRoleManagementPolicyRule
    {
    
		///<summary>
		/// The UnifiedRoleManagementPolicyApprovalRule constructor
		///</summary>
        public UnifiedRoleManagementPolicyApprovalRule()
        {
            this.ODataType = "microsoft.graph.unifiedRoleManagementPolicyApprovalRule";
        }
	
        /// <summary>
        /// Gets or sets setting.
        /// The approval setting for the rule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "setting", Required = Newtonsoft.Json.Required.Default)]
        public ApprovalSettings Setting { get; set; }
    
    }
}

