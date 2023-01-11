namespace Microsoft.Graph.Beta.Models {
    /// <summary>This enum represents associated assignment payload type</summary>
    public enum AssociatedAssignmentPayloadType {
        /// <summary>Invalid payload type</summary>
        Unknown,
        /// <summary>Indicates that this filter is associated with a configuration or compliance policy payload type</summary>
        DeviceConfigurationAndCompliance,
        /// <summary>Indicates that this assignment filter is associated with an application payload type</summary>
        Application,
        /// <summary>Indicates that this filter is associated with a Android Enterprise application payload type</summary>
        AndroidEnterpriseApp,
        /// <summary>Indicates that this filter is associated with an enrollment restriction or enrollment status page policy payload type</summary>
        EnrollmentConfiguration,
        /// <summary>Indicates that this filter is associated with an Administrative Template policy payload type</summary>
        GroupPolicyConfiguration,
        /// <summary>Indicates that this assignment filter is associated with Zero touch deployment Device Configuration Profile payload type</summary>
        ZeroTouchDeploymentDeviceConfigProfile,
        /// <summary>Indicates that this filter is associated with an Android Enterprise Configuration policy payload type</summary>
        AndroidEnterpriseConfiguration,
        /// <summary>Indicates that this assignment filter is associated with Device Firmware Configuration Interface(DCFI) payload type</summary>
        DeviceFirmwareConfigurationInterfacePolicy,
        /// <summary>Indicates that this filter is associated with a resource access policy (Wifi, VPN, Certificate) payload type</summary>
        ResourceAccessPolicy,
        /// <summary>Indicates that this filter is associated with a Win32 app payload type</summary>
        Win32app,
        /// <summary>Indicates that this filter is associated with a configuration or compliance policy on Device Configuration v2 Infrastructure payload type</summary>
        DeviceManagmentConfigurationAndCompliancePolicy,
    }
}
