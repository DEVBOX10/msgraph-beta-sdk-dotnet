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
    /// The type DeliveryOptimizationGroupIdCustom.
    /// </summary>
    public partial class DeliveryOptimizationGroupIdCustom : DeliveryOptimizationGroupIdSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOptimizationGroupIdCustom"/> class.
        /// </summary>
        public DeliveryOptimizationGroupIdCustom()
        {
            this.ODataType = "microsoft.graph.deliveryOptimizationGroupIdCustom";
        }

        /// <summary>
        /// Gets or sets groupIdCustom.
        /// Specifies an arbitrary group ID that the device belongs to
        /// </summary>
        [JsonPropertyName("groupIdCustom")]
        public string GroupIdCustom { get; set; }
    
    }
}
