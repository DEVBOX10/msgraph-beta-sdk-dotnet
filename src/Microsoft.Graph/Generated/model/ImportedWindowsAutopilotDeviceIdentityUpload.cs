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
    /// The type Imported Windows Autopilot Device Identity Upload.
    /// </summary>
    public partial class ImportedWindowsAutopilotDeviceIdentityUpload : Entity
    {
    
		///<summary>
		/// The ImportedWindowsAutopilotDeviceIdentityUpload constructor
		///</summary>
        public ImportedWindowsAutopilotDeviceIdentityUpload()
        {
            this.ODataType = "microsoft.graph.importedWindowsAutopilotDeviceIdentityUpload";
        }
	
        /// <summary>
        /// Gets or sets created date time utc.
        /// DateTime when the entity is created.
        /// </summary>
        [JsonPropertyName("createdDateTimeUtc")]
        public DateTimeOffset? CreatedDateTimeUtc { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Upload status. Possible values are: noUpload, pending, complete, error.
        /// </summary>
        [JsonPropertyName("status")]
        public ImportedWindowsAutopilotDeviceIdentityUploadStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets device identities.
        /// Collection of all Autopilot devices as a part of this upload.
        /// </summary>
        [JsonPropertyName("deviceIdentities")]
        public IImportedWindowsAutopilotDeviceIdentityUploadDeviceIdentitiesCollectionPage DeviceIdentities { get; set; }
    
    }
}

