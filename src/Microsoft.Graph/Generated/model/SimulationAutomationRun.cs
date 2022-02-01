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
    /// The type Simulation Automation Run.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SimulationAutomationRun>))]
    public partial class SimulationAutomationRun : Entity
    {
    
        /// <summary>
        /// Gets or sets end date time.
        /// </summary>
        [JsonPropertyName("endDateTime")]
        public DateTimeOffset? EndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets simulation id.
        /// </summary>
        [JsonPropertyName("simulationId")]
        public string SimulationId { get; set; }
    
        /// <summary>
        /// Gets or sets start date time.
        /// </summary>
        [JsonPropertyName("startDateTime")]
        public DateTimeOffset? StartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public SimulationAutomationRunStatus? Status { get; set; }
    
    }
}

