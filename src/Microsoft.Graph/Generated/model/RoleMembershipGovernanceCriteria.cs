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
    /// The type RoleMembershipGovernanceCriteria.
    /// </summary>
    public partial class RoleMembershipGovernanceCriteria : GovernanceCriteria
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMembershipGovernanceCriteria"/> class.
        /// </summary>
        public RoleMembershipGovernanceCriteria()
        {
            this.ODataType = "microsoft.graph.roleMembershipGovernanceCriteria";
        }

        /// <summary>
        /// Gets or sets roleId.
        /// </summary>
        [JsonPropertyName("roleId")]
        public string RoleId { get; set; }
    
        /// <summary>
        /// Gets or sets roleTemplateId.
        /// </summary>
        [JsonPropertyName("roleTemplateId")]
        public string RoleTemplateId { get; set; }
    
    }
}
