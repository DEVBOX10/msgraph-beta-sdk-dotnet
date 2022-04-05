// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum WindowsDriverUpdateProfileInventorySyncState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsDriverUpdateProfileInventorySyncState
    {
    
        /// <summary>
        /// Pending
        /// </summary>
        Pending = 0,
	
        /// <summary>
        /// Success
        /// </summary>
        Success = 1,
	
        /// <summary>
        /// Failure
        /// </summary>
        Failure = 2,
	
    }
}
