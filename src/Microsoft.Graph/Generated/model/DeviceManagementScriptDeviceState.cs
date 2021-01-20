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
    /// The type Device Management Script Device State.
    /// </summary>
    public partial class DeviceManagementScriptDeviceState : Entity
    {
    
		///<summary>
		/// The DeviceManagementScriptDeviceState constructor
		///</summary>
        public DeviceManagementScriptDeviceState()
        {
            this.ODataType = "microsoft.graph.deviceManagementScriptDeviceState";
        }
	
        /// <summary>
        /// Gets or sets error code.
        /// Error code corresponding to erroneous execution of the device management script.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public Int32? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets error description.
        /// Error description corresponding to erroneous execution of the device management script.
        /// </summary>
        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }
    
        /// <summary>
        /// Gets or sets last state update date time.
        /// Latest time the device management script executes.
        /// </summary>
        [JsonPropertyName("lastStateUpdateDateTime")]
        public DateTimeOffset? LastStateUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets result message.
        /// Details of execution output.
        /// </summary>
        [JsonPropertyName("resultMessage")]
        public string ResultMessage { get; set; }
    
        /// <summary>
        /// Gets or sets run state.
        /// State of latest run of the device management script. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.
        /// </summary>
        [JsonPropertyName("runState")]
        public RunState? RunState { get; set; }
    
        /// <summary>
        /// Gets or sets managed device.
        /// The managed devices that executes the device management script.
        /// </summary>
        [JsonPropertyName("managedDevice")]
        public ManagedDevice ManagedDevice { get; set; }
    
    }
}

