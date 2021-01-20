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
    /// The type Swap Shifts Change Request.
    /// </summary>
    public partial class SwapShiftsChangeRequestObject : OfferShiftRequestObject
    {
    
		///<summary>
		/// The SwapShiftsChangeRequest constructor
		///</summary>
        public SwapShiftsChangeRequestObject()
        {
            this.ODataType = "microsoft.graph.swapShiftsChangeRequest";
        }
	
        /// <summary>
        /// Gets or sets recipient shift id.
        /// Shift ID for the recipient user with whom the request is to swap.
        /// </summary>
        [JsonPropertyName("recipientShiftId")]
        public string RecipientShiftId { get; set; }
    
    }
}

