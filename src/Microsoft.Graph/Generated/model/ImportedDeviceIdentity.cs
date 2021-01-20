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
    /// The type Imported Device Identity.
    /// </summary>
    public partial class ImportedDeviceIdentity : Entity
    {
    
		///<summary>
		/// The ImportedDeviceIdentity constructor
		///</summary>
        public ImportedDeviceIdentity()
        {
            this.ODataType = "microsoft.graph.importedDeviceIdentity";
        }
	
        /// <summary>
        /// Gets or sets created date time.
        /// Created Date Time of the device
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the device
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// The state of the device in Intune. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.
        /// </summary>
        [JsonPropertyName("enrollmentState")]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets imported device identifier.
        /// Imported Device Identifier
        /// </summary>
        [JsonPropertyName("importedDeviceIdentifier")]
        public string ImportedDeviceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets imported device identity type.
        /// Type of Imported Device Identity. Possible values are: unknown, imei, serialNumber.
        /// </summary>
        [JsonPropertyName("importedDeviceIdentityType")]
        public ImportedDeviceIdentityType? ImportedDeviceIdentityType { get; set; }
    
        /// <summary>
        /// Gets or sets last contacted date time.
        /// Last Contacted Date Time of the device
        /// </summary>
        [JsonPropertyName("lastContactedDateTime")]
        public DateTimeOffset? LastContactedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Last Modified DateTime of the description
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// The platform of the Device. Possible values are: unknown, ios, android, windows, windowsMobile, macOS.
        /// </summary>
        [JsonPropertyName("platform")]
        public Platform? Platform { get; set; }
    
    }
}

