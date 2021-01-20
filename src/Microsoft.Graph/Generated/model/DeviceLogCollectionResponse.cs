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
    /// The type Device Log Collection Response.
    /// </summary>
    public partial class DeviceLogCollectionResponse : Entity
    {
    
		///<summary>
		/// The DeviceLogCollectionResponse constructor
		///</summary>
        public DeviceLogCollectionResponse()
        {
            this.ODataType = "microsoft.graph.deviceLogCollectionResponse";
        }
	
        /// <summary>
        /// Gets or sets error code.
        /// The error code, if any. Valid values -9.22337203685478E+18 to 9.22337203685478E+18
        /// </summary>
        [JsonPropertyName("errorCode")]
        public Int64? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time utc.
        /// The DateTime of the expiration of the logs
        /// </summary>
        [JsonPropertyName("expirationDateTimeUTC")]
        public DateTimeOffset? ExpirationDateTimeUTC { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by user principal name.
        /// The UPN for who initiated the request
        /// </summary>
        [JsonPropertyName("initiatedByUserPrincipalName")]
        public string InitiatedByUserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// The device Id
        /// </summary>
        [JsonPropertyName("managedDeviceId")]
        public Guid? ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets received date time utc.
        /// The DateTime the request was received
        /// </summary>
        [JsonPropertyName("receivedDateTimeUTC")]
        public DateTimeOffset? ReceivedDateTimeUTC { get; set; }
    
        /// <summary>
        /// Gets or sets requested date time utc.
        /// The DateTime of the request
        /// </summary>
        [JsonPropertyName("requestedDateTimeUTC")]
        public DateTimeOffset? RequestedDateTimeUTC { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// The size of the logs. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("size")]
        public double? Size { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the log collection request
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
    }
}

