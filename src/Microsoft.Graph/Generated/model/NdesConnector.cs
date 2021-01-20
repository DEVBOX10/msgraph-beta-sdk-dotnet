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
    /// The type Ndes Connector.
    /// </summary>
    public partial class NdesConnector : Entity
    {
    
		///<summary>
		/// The NdesConnector constructor
		///</summary>
        public NdesConnector()
        {
            this.ODataType = "microsoft.graph.ndesConnector";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The friendly name of the Ndes Connector.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last connection date time.
        /// Last connection time for the Ndes Connector
        /// </summary>
        [JsonPropertyName("lastConnectionDateTime")]
        public DateTimeOffset? LastConnectionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Ndes Connector Status. Possible values are: none, active, inactive.
        /// </summary>
        [JsonPropertyName("state")]
        public NdesConnectorState? State { get; set; }
    
    }
}

