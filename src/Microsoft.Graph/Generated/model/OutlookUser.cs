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
    /// The type Outlook User.
    /// </summary>
    public partial class OutlookUser : Entity
    {
    
		///<summary>
		/// The OutlookUser constructor
		///</summary>
        public OutlookUser()
        {
            this.ODataType = "microsoft.graph.outlookUser";
        }
	
        /// <summary>
        /// Gets or sets master categories.
        /// A list of categories defined for the user.
        /// </summary>
        [JsonPropertyName("masterCategories")]
        public IOutlookUserMasterCategoriesCollectionPage MasterCategories { get; set; }
    
        /// <summary>
        /// Gets or sets task folders.
        /// </summary>
        [JsonPropertyName("taskFolders")]
        public IOutlookUserTaskFoldersCollectionPage TaskFolders { get; set; }
    
        /// <summary>
        /// Gets or sets task groups.
        /// </summary>
        [JsonPropertyName("taskGroups")]
        public IOutlookUserTaskGroupsCollectionPage TaskGroups { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// </summary>
        [JsonPropertyName("tasks")]
        public IOutlookUserTasksCollectionPage Tasks { get; set; }
    
    }
}

