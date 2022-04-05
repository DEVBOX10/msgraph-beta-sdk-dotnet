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
    /// The type Windows Autopilot Device Identity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsAutopilotDeviceIdentity>))]
    public partial class WindowsAutopilotDeviceIdentity : Entity
    {
    
        /// <summary>
        /// Gets or sets addressable user name.
        /// Addressable user name.
        /// </summary>
        [JsonPropertyName("addressableUserName")]
        public string AddressableUserName { get; set; }
    
        /// <summary>
        /// Gets or sets azure active directory device id.
        /// AAD Device ID - to be deprecated
        /// </summary>
        [JsonPropertyName("azureActiveDirectoryDeviceId")]
        public string AzureActiveDirectoryDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure ad device id.
        /// AAD Device ID
        /// </summary>
        [JsonPropertyName("azureAdDeviceId")]
        public string AzureAdDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile assigned date time.
        /// Profile set time of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("deploymentProfileAssignedDateTime")]
        public DateTimeOffset? DeploymentProfileAssignedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile assignment detailed status.
        /// Profile assignment detailed status of the Windows autopilot device. Possible values are: none, hardwareRequirementsNotMet, surfaceHubProfileNotSupported, holoLensProfileNotSupported, windowsPcProfileNotSupported, surfaceHub2SProfileNotSupported, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("deploymentProfileAssignmentDetailedStatus")]
        public WindowsAutopilotProfileAssignmentDetailedStatus? DeploymentProfileAssignmentDetailedStatus { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile assignment status.
        /// Profile assignment status of the Windows autopilot device. Possible values are: unknown, assignedInSync, assignedOutOfSync, assignedUnkownSyncState, notAssigned, pending, failed.
        /// </summary>
        [JsonPropertyName("deploymentProfileAssignmentStatus")]
        public WindowsAutopilotProfileAssignmentStatus? DeploymentProfileAssignmentStatus { get; set; }
    
        /// <summary>
        /// Gets or sets device account password.
        /// Surface Hub Device Account Password
        /// </summary>
        [JsonPropertyName("deviceAccountPassword")]
        public string DeviceAccountPassword { get; set; }
    
        /// <summary>
        /// Gets or sets device account upn.
        /// Surface Hub Device Account Upn
        /// </summary>
        [JsonPropertyName("deviceAccountUpn")]
        public string DeviceAccountUpn { get; set; }
    
        /// <summary>
        /// Gets or sets device friendly name.
        /// Surface Hub Device Friendly Name
        /// </summary>
        [JsonPropertyName("deviceFriendlyName")]
        public string DeviceFriendlyName { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display Name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// Intune enrollment state of the Windows autopilot device. Possible values are: unknown, enrolled, pendingReset, failed, notContacted.
        /// </summary>
        [JsonPropertyName("enrollmentState")]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets group tag.
        /// Group Tag of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("groupTag")]
        public string GroupTag { get; set; }
    
        /// <summary>
        /// Gets or sets last contacted date time.
        /// Intune Last Contacted Date Time of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("lastContactedDateTime")]
        public DateTimeOffset? LastContactedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device id.
        /// Managed Device ID
        /// </summary>
        [JsonPropertyName("managedDeviceId")]
        public string ManagedDeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// Oem manufacturer of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// Model name of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets product key.
        /// Product Key of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("productKey")]
        public string ProductKey { get; set; }
    
        /// <summary>
        /// Gets or sets purchase order identifier.
        /// Purchase Order Identifier of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("purchaseOrderIdentifier")]
        public string PurchaseOrderIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets resource name.
        /// Resource Name.
        /// </summary>
        [JsonPropertyName("resourceName")]
        public string ResourceName { get; set; }
    
        /// <summary>
        /// Gets or sets serial number.
        /// Serial number of the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("serialNumber")]
        public string SerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets sku number.
        /// SKU Number
        /// </summary>
        [JsonPropertyName("skuNumber")]
        public string SkuNumber { get; set; }
    
        /// <summary>
        /// Gets or sets system family.
        /// System Family
        /// </summary>
        [JsonPropertyName("systemFamily")]
        public string SystemFamily { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets deployment profile.
        /// Deployment profile currently assigned to the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("deploymentProfile")]
        public WindowsAutopilotDeploymentProfile DeploymentProfile { get; set; }
    
        /// <summary>
        /// Gets or sets intended deployment profile.
        /// Deployment profile intended to be assigned to the Windows autopilot device.
        /// </summary>
        [JsonPropertyName("intendedDeploymentProfile")]
        public WindowsAutopilotDeploymentProfile IntendedDeploymentProfile { get; set; }
    
    }
}

