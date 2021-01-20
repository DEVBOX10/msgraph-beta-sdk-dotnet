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
    /// The type Education Submission Resource.
    /// </summary>
    public partial class EducationSubmissionResource : Entity
    {
    
		///<summary>
		/// The EducationSubmissionResource constructor
		///</summary>
        public EducationSubmissionResource()
        {
            this.ODataType = "microsoft.graph.educationSubmissionResource";
        }
	
        /// <summary>
        /// Gets or sets assignment resource url.
        /// Pointer to the assignment from which this resource was copied. If this is null, the student uploaded the resource.
        /// </summary>
        [JsonPropertyName("assignmentResourceUrl")]
        public string AssignmentResourceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Resource object.
        /// </summary>
        [JsonPropertyName("resource")]
        public EducationResource Resource { get; set; }
    
    }
}

