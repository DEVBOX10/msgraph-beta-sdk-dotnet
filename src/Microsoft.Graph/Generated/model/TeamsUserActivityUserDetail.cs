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
    /// The type Teams User Activity User Detail.
    /// </summary>
    public partial class TeamsUserActivityUserDetail : Entity
    {
    
		///<summary>
		/// The TeamsUserActivityUserDetail constructor
		///</summary>
        public TeamsUserActivityUserDetail()
        {
            this.ODataType = "microsoft.graph.teamsUserActivityUserDetail";
        }
	
        /// <summary>
        /// Gets or sets assigned products.
        /// </summary>
        [JsonPropertyName("assignedProducts")]
        public IEnumerable<string> AssignedProducts { get; set; }
    
        /// <summary>
        /// Gets or sets call count.
        /// </summary>
        [JsonPropertyName("callCount")]
        public Int64? CallCount { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date.
        /// </summary>
        [JsonPropertyName("deletedDate")]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets has other action.
        /// </summary>
        [JsonPropertyName("hasOtherAction")]
        public bool? HasOtherAction { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets last activity date.
        /// </summary>
        [JsonPropertyName("lastActivityDate")]
        public Date LastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets meeting count.
        /// </summary>
        [JsonPropertyName("meetingCount")]
        public Int64? MeetingCount { get; set; }
    
        /// <summary>
        /// Gets or sets private chat message count.
        /// </summary>
        [JsonPropertyName("privateChatMessageCount")]
        public Int64? PrivateChatMessageCount { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonPropertyName("reportPeriod")]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonPropertyName("reportRefreshDate")]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets team chat message count.
        /// </summary>
        [JsonPropertyName("teamChatMessageCount")]
        public Int64? TeamChatMessageCount { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

