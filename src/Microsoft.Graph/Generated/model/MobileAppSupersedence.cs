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
    /// The type Mobile App Supersedence.
    /// </summary>
    public partial class MobileAppSupersedence : MobileAppRelationship
    {
    
		///<summary>
		/// The MobileAppSupersedence constructor
		///</summary>
        public MobileAppSupersedence()
        {
            this.ODataType = "microsoft.graph.mobileAppSupersedence";
        }
	
        /// <summary>
        /// Gets or sets superseded app count.
        /// The total number of apps directly or indirectly superseded by the child app.
        /// </summary>
        [JsonPropertyName("supersededAppCount")]
        public Int32? SupersededAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets supersedence type.
        /// The supersedence relationship type between the parent and child apps. Possible values are: update, replace.
        /// </summary>
        [JsonPropertyName("supersedenceType")]
        public MobileAppSupersedenceType? SupersedenceType { get; set; }
    
        /// <summary>
        /// Gets or sets superseding app count.
        /// The total number of apps directly or indirectly superseding the parent app.
        /// </summary>
        [JsonPropertyName("supersedingAppCount")]
        public Int32? SupersedingAppCount { get; set; }
    
    }
}

