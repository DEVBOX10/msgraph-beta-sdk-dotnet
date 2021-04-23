// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedDeviceRequestBuilder.
    /// </summary>
    public partial class ManagedDeviceRequestBuilder : EntityRequestBuilder, IManagedDeviceRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedDeviceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ManagedDeviceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagedDeviceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagedDeviceRequest Request(IEnumerable<Option> options)
        {
            return new ManagedDeviceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder DeviceCompliancePolicyStates
        {
            get
            {
                return new ManagedDeviceDeviceCompliancePolicyStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceCompliancePolicyStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AssignmentFilterEvaluationStatusDetails.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceAssignmentFilterEvaluationStatusDetailsCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceAssignmentFilterEvaluationStatusDetailsCollectionRequestBuilder AssignmentFilterEvaluationStatusDetails
        {
            get
            {
                return new ManagedDeviceAssignmentFilterEvaluationStatusDetailsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("assignmentFilterEvaluationStatusDetails"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceConfigurationStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder DeviceConfigurationStates
        {
            get
            {
                return new ManagedDeviceDeviceConfigurationStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deviceConfigurationStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceMobileAppConfigurationStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder ManagedDeviceMobileAppConfigurationStates
        {
            get
            {
                return new ManagedDeviceManagedDeviceMobileAppConfigurationStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("managedDeviceMobileAppConfigurationStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SecurityBaselineStates.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSecurityBaselineStatesCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceSecurityBaselineStatesCollectionRequestBuilder SecurityBaselineStates
        {
            get
            {
                return new ManagedDeviceSecurityBaselineStatesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("securityBaselineStates"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DetectedApps.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder"/>.</returns>
        public IManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder DetectedApps
        {
            get
            {
                return new ManagedDeviceDetectedAppsCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("detectedApps"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeviceCategory.
        /// </summary>
        /// <returns>The <see cref="IDeviceCategoryRequestBuilder"/>.</returns>
        public IDeviceCategoryRequestBuilder DeviceCategory
        {
            get
            {
                return new DeviceCategoryRequestBuilder(this.AppendSegmentToRequestUrl("deviceCategory"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LogCollectionRequests.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLogCollectionRequestsCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceLogCollectionRequestsCollectionRequestBuilder LogCollectionRequests
        {
            get
            {
                return new ManagedDeviceLogCollectionRequestsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("logCollectionRequests"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Users.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceUsersCollectionRequestBuilder"/>.</returns>
        public IManagedDeviceUsersCollectionRequestBuilder Users
        {
            get
            {
                return new ManagedDeviceUsersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("users"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WindowsProtectionState.
        /// </summary>
        /// <returns>The <see cref="IWindowsProtectionStateRequestBuilder"/>.</returns>
        public IWindowsProtectionStateRequestBuilder WindowsProtectionState
        {
            get
            {
                return new WindowsProtectionStateRequestBuilder(this.AppendSegmentToRequestUrl("windowsProtectionState"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for ManagedDeviceSendCustomNotificationToCompanyPortal.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder"/>.</returns>
        public IManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder SendCustomNotificationToCompanyPortal(
            string notificationTitle,
            string notificationBody)
        {
            return new ManagedDeviceSendCustomNotificationToCompanyPortalRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.sendCustomNotificationToCompanyPortal"),
                this.Client,
                notificationTitle,
                notificationBody);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceOverrideComplianceState.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceOverrideComplianceStateRequestBuilder"/>.</returns>
        public IManagedDeviceOverrideComplianceStateRequestBuilder OverrideComplianceState(
            AdministratorConfiguredDeviceComplianceState complianceState,
            string remediationUrl = null)
        {
            return new ManagedDeviceOverrideComplianceStateRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.overrideComplianceState"),
                this.Client,
                complianceState,
                remediationUrl);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceActivateDeviceEsim.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceActivateDeviceEsimRequestBuilder"/>.</returns>
        public IManagedDeviceActivateDeviceEsimRequestBuilder ActivateDeviceEsim(
            string carrierUrl = null)
        {
            return new ManagedDeviceActivateDeviceEsimRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.activateDeviceEsim"),
                this.Client,
                carrierUrl);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceBypassActivationLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBypassActivationLockRequestBuilder"/>.</returns>
        public IManagedDeviceBypassActivationLockRequestBuilder BypassActivationLock()
        {
            return new ManagedDeviceBypassActivationLockRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.bypassActivationLock"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceCleanWindowsDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceCleanWindowsDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceCleanWindowsDeviceRequestBuilder CleanWindowsDevice(
            bool keepUserData)
        {
            return new ManagedDeviceCleanWindowsDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.cleanWindowsDevice"),
                this.Client,
                keepUserData);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceCreateDeviceLogCollectionRequest.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceCreateDeviceLogCollectionRequestRequestBuilder"/>.</returns>
        public IManagedDeviceCreateDeviceLogCollectionRequestRequestBuilder CreateDeviceLogCollectionRequest(
            DeviceLogCollectionRequestObject templateType = null)
        {
            return new ManagedDeviceCreateDeviceLogCollectionRequestRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.createDeviceLogCollectionRequest"),
                this.Client,
                templateType);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceDeleteUserFromSharedAppleDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder DeleteUserFromSharedAppleDevice(
            string userPrincipalName = null)
        {
            return new ManagedDeviceDeleteUserFromSharedAppleDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.deleteUserFromSharedAppleDevice"),
                this.Client,
                userPrincipalName);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceDisableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDisableLostModeRequestBuilder"/>.</returns>
        public IManagedDeviceDisableLostModeRequestBuilder DisableLostMode()
        {
            return new ManagedDeviceDisableLostModeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.disableLostMode"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceEnableLostMode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceEnableLostModeRequestBuilder"/>.</returns>
        public IManagedDeviceEnableLostModeRequestBuilder EnableLostMode(
            string message = null,
            string phoneNumber = null,
            string footer = null)
        {
            return new ManagedDeviceEnableLostModeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.enableLostMode"),
                this.Client,
                message,
                phoneNumber,
                footer);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceLocateDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLocateDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceLocateDeviceRequestBuilder LocateDevice()
        {
            return new ManagedDeviceLocateDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.locateDevice"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceLogoutSharedAppleDeviceActiveUser.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder"/>.</returns>
        public IManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder LogoutSharedAppleDeviceActiveUser()
        {
            return new ManagedDeviceLogoutSharedAppleDeviceActiveUserRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.logoutSharedAppleDeviceActiveUser"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDevicePlayLostModeSound.
        /// </summary>
        /// <returns>The <see cref="IManagedDevicePlayLostModeSoundRequestBuilder"/>.</returns>
        public IManagedDevicePlayLostModeSoundRequestBuilder PlayLostModeSound()
        {
            return new ManagedDevicePlayLostModeSoundRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.playLostModeSound"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRebootNow.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRebootNowRequestBuilder"/>.</returns>
        public IManagedDeviceRebootNowRequestBuilder RebootNow()
        {
            return new ManagedDeviceRebootNowRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.rebootNow"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRecoverPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRecoverPasscodeRequestBuilder"/>.</returns>
        public IManagedDeviceRecoverPasscodeRequestBuilder RecoverPasscode()
        {
            return new ManagedDeviceRecoverPasscodeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.recoverPasscode"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRemoteLock.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRemoteLockRequestBuilder"/>.</returns>
        public IManagedDeviceRemoteLockRequestBuilder RemoteLock()
        {
            return new ManagedDeviceRemoteLockRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.remoteLock"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRequestRemoteAssistance.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRequestRemoteAssistanceRequestBuilder"/>.</returns>
        public IManagedDeviceRequestRemoteAssistanceRequestBuilder RequestRemoteAssistance()
        {
            return new ManagedDeviceRequestRemoteAssistanceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.requestRemoteAssistance"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceResetPasscode.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceResetPasscodeRequestBuilder"/>.</returns>
        public IManagedDeviceResetPasscodeRequestBuilder ResetPasscode()
        {
            return new ManagedDeviceResetPasscodeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.resetPasscode"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRetire.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRetireRequestBuilder"/>.</returns>
        public IManagedDeviceRetireRequestBuilder Retire()
        {
            return new ManagedDeviceRetireRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.retire"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRevokeAppleVppLicenses.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRevokeAppleVppLicensesRequestBuilder"/>.</returns>
        public IManagedDeviceRevokeAppleVppLicensesRequestBuilder RevokeAppleVppLicenses()
        {
            return new ManagedDeviceRevokeAppleVppLicensesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.revokeAppleVppLicenses"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRotateBitLockerKeys.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRotateBitLockerKeysRequestBuilder"/>.</returns>
        public IManagedDeviceRotateBitLockerKeysRequestBuilder RotateBitLockerKeys()
        {
            return new ManagedDeviceRotateBitLockerKeysRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.rotateBitLockerKeys"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceRotateFileVaultKey.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceRotateFileVaultKeyRequestBuilder"/>.</returns>
        public IManagedDeviceRotateFileVaultKeyRequestBuilder RotateFileVaultKey()
        {
            return new ManagedDeviceRotateFileVaultKeyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.rotateFileVaultKey"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceSetDeviceName.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSetDeviceNameRequestBuilder"/>.</returns>
        public IManagedDeviceSetDeviceNameRequestBuilder SetDeviceName(
            string deviceName = null)
        {
            return new ManagedDeviceSetDeviceNameRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setDeviceName"),
                this.Client,
                deviceName);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceShutDown.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceShutDownRequestBuilder"/>.</returns>
        public IManagedDeviceShutDownRequestBuilder ShutDown()
        {
            return new ManagedDeviceShutDownRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.shutDown"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceSyncDevice.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceSyncDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceSyncDeviceRequestBuilder SyncDevice()
        {
            return new ManagedDeviceSyncDeviceRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.syncDevice"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceTriggerConfigurationManagerAction.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceTriggerConfigurationManagerActionRequestBuilder"/>.</returns>
        public IManagedDeviceTriggerConfigurationManagerActionRequestBuilder TriggerConfigurationManagerAction(
            ConfigurationManagerAction configurationManagerAction)
        {
            return new ManagedDeviceTriggerConfigurationManagerActionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.triggerConfigurationManagerAction"),
                this.Client,
                configurationManagerAction);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceUpdateWindowsDeviceAccount.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceUpdateWindowsDeviceAccountRequestBuilder"/>.</returns>
        public IManagedDeviceUpdateWindowsDeviceAccountRequestBuilder UpdateWindowsDeviceAccount(
            UpdateWindowsDeviceAccountActionParameter updateWindowsDeviceAccountActionParameter = null)
        {
            return new ManagedDeviceUpdateWindowsDeviceAccountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.updateWindowsDeviceAccount"),
                this.Client,
                updateWindowsDeviceAccountActionParameter);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceWindowsDefenderScan.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWindowsDefenderScanRequestBuilder"/>.</returns>
        public IManagedDeviceWindowsDefenderScanRequestBuilder WindowsDefenderScan(
            bool quickScan)
        {
            return new ManagedDeviceWindowsDefenderScanRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.windowsDefenderScan"),
                this.Client,
                quickScan);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceWindowsDefenderUpdateSignatures.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder"/>.</returns>
        public IManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder WindowsDefenderUpdateSignatures()
        {
            return new ManagedDeviceWindowsDefenderUpdateSignaturesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.windowsDefenderUpdateSignatures"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceWipe.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceWipeRequestBuilder"/>.</returns>
        public IManagedDeviceWipeRequestBuilder Wipe(
            bool? keepEnrollmentData = null,
            bool? keepUserData = null,
            string macOsUnlockCode = null,
            bool? persistEsimDataPlan = null,
            bool? useProtectedWipe = null)
        {
            return new ManagedDeviceWipeRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.wipe"),
                this.Client,
                keepEnrollmentData,
                keepUserData,
                macOsUnlockCode,
                persistEsimDataPlan,
                useProtectedWipe);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceGetNonCompliantSettings.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceGetNonCompliantSettingsRequestBuilder"/>.</returns>
        public IManagedDeviceGetNonCompliantSettingsRequestBuilder GetNonCompliantSettings()
        {
            return new ManagedDeviceGetNonCompliantSettingsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getNonCompliantSettings"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceGetFileVaultKey.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceGetFileVaultKeyRequestBuilder"/>.</returns>
        public IManagedDeviceGetFileVaultKeyRequestBuilder GetFileVaultKey()
        {
            return new ManagedDeviceGetFileVaultKeyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getFileVaultKey"),
                this.Client);
        }
    
    }
}
