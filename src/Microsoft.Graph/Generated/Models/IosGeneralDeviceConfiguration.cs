using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to allow account modification when the device is in supervised mode.</summary>
        public bool? AccountBlockModification {
            get { return BackingStore?.Get<bool?>("accountBlockModification"); }
            set { BackingStore?.Set("accountBlockModification", value); }
        }
        /// <summary>Indicates whether or not to allow activation lock when the device is in the supervised mode.</summary>
        public bool? ActivationLockAllowWhenSupervised {
            get { return BackingStore?.Get<bool?>("activationLockAllowWhenSupervised"); }
            set { BackingStore?.Set("activationLockAllowWhenSupervised", value); }
        }
        /// <summary>Indicates whether or not to allow AirDrop when the device is in supervised mode.</summary>
        public bool? AirDropBlocked {
            get { return BackingStore?.Get<bool?>("airDropBlocked"); }
            set { BackingStore?.Set("airDropBlocked", value); }
        }
        /// <summary>Indicates whether or not to cause AirDrop to be considered an unmanaged drop target (iOS 9.0 and later).</summary>
        public bool? AirDropForceUnmanagedDropTarget {
            get { return BackingStore?.Get<bool?>("airDropForceUnmanagedDropTarget"); }
            set { BackingStore?.Set("airDropForceUnmanagedDropTarget", value); }
        }
        /// <summary>Indicates whether or not to enforce all devices receiving AirPlay requests from this device to use a pairing password.</summary>
        public bool? AirPlayForcePairingPasswordForOutgoingRequests {
            get { return BackingStore?.Get<bool?>("airPlayForcePairingPasswordForOutgoingRequests"); }
            set { BackingStore?.Set("airPlayForcePairingPasswordForOutgoingRequests", value); }
        }
        /// <summary>Indicates whether or not keychain storage of username and password for Airprint is blocked (iOS 11.0 and later).</summary>
        public bool? AirPrintBlockCredentialsStorage {
            get { return BackingStore?.Get<bool?>("airPrintBlockCredentialsStorage"); }
            set { BackingStore?.Set("airPrintBlockCredentialsStorage", value); }
        }
        /// <summary>Indicates whether or not AirPrint is blocked (iOS 11.0 and later).</summary>
        public bool? AirPrintBlocked {
            get { return BackingStore?.Get<bool?>("airPrintBlocked"); }
            set { BackingStore?.Set("airPrintBlocked", value); }
        }
        /// <summary>Indicates whether or not iBeacon discovery of AirPrint printers is blocked. This prevents spurious AirPrint Bluetooth beacons from phishing for network traffic (iOS 11.0 and later).</summary>
        public bool? AirPrintBlockiBeaconDiscovery {
            get { return BackingStore?.Get<bool?>("airPrintBlockiBeaconDiscovery"); }
            set { BackingStore?.Set("airPrintBlockiBeaconDiscovery", value); }
        }
        /// <summary>Indicates if trusted certificates are required for TLS printing communication (iOS 11.0 and later).</summary>
        public bool? AirPrintForceTrustedTLS {
            get { return BackingStore?.Get<bool?>("airPrintForceTrustedTLS"); }
            set { BackingStore?.Set("airPrintForceTrustedTLS", value); }
        }
        /// <summary>Prevents a user from adding any App Clips and removes any existing App Clips on the device.</summary>
        public bool? AppClipsBlocked {
            get { return BackingStore?.Get<bool?>("appClipsBlocked"); }
            set { BackingStore?.Set("appClipsBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from using News when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? AppleNewsBlocked {
            get { return BackingStore?.Get<bool?>("appleNewsBlocked"); }
            set { BackingStore?.Set("appleNewsBlocked", value); }
        }
        /// <summary>Limits Apple personalized advertising when true. Available in iOS 14 and later.</summary>
        public bool? ApplePersonalizedAdsBlocked {
            get { return BackingStore?.Get<bool?>("applePersonalizedAdsBlocked"); }
            set { BackingStore?.Set("applePersonalizedAdsBlocked", value); }
        }
        /// <summary>Indicates whether or not to allow Apple Watch pairing when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? AppleWatchBlockPairing {
            get { return BackingStore?.Get<bool?>("appleWatchBlockPairing"); }
            set { BackingStore?.Set("appleWatchBlockPairing", value); }
        }
        /// <summary>Indicates whether or not to force a paired Apple Watch to use Wrist Detection (iOS 8.2 and later).</summary>
        public bool? AppleWatchForceWristDetection {
            get { return BackingStore?.Get<bool?>("appleWatchForceWristDetection"); }
            set { BackingStore?.Set("appleWatchForceWristDetection", value); }
        }
        /// <summary>Indicates if the removal of apps is allowed.</summary>
        public bool? AppRemovalBlocked {
            get { return BackingStore?.Get<bool?>("appRemovalBlocked"); }
            set { BackingStore?.Set("appRemovalBlocked", value); }
        }
        /// <summary>Gets or sets the list of iOS apps allowed to autonomously enter Single App Mode. Supervised only. iOS 7.0 and later. This collection can contain a maximum of 500 elements.</summary>
        public List<AppListItem> AppsSingleAppModeList {
            get { return BackingStore?.Get<List<AppListItem>>("appsSingleAppModeList"); }
            set { BackingStore?.Set("appsSingleAppModeList", value); }
        }
        /// <summary>Indicates whether or not to block the automatic downloading of apps purchased on other devices when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? AppStoreBlockAutomaticDownloads {
            get { return BackingStore?.Get<bool?>("appStoreBlockAutomaticDownloads"); }
            set { BackingStore?.Set("appStoreBlockAutomaticDownloads", value); }
        }
        /// <summary>Indicates whether or not to block the user from using the App Store. Requires a supervised device for iOS 13 and later.</summary>
        public bool? AppStoreBlocked {
            get { return BackingStore?.Get<bool?>("appStoreBlocked"); }
            set { BackingStore?.Set("appStoreBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from making in app purchases.</summary>
        public bool? AppStoreBlockInAppPurchases {
            get { return BackingStore?.Get<bool?>("appStoreBlockInAppPurchases"); }
            set { BackingStore?.Set("appStoreBlockInAppPurchases", value); }
        }
        /// <summary>Indicates whether or not to block the App Store app, not restricting installation through Host apps. Applies to supervised mode only (iOS 9.0 and later).</summary>
        public bool? AppStoreBlockUIAppInstallation {
            get { return BackingStore?.Get<bool?>("appStoreBlockUIAppInstallation"); }
            set { BackingStore?.Set("appStoreBlockUIAppInstallation", value); }
        }
        /// <summary>Indicates whether or not to require a password when using the app store.</summary>
        public bool? AppStoreRequirePassword {
            get { return BackingStore?.Get<bool?>("appStoreRequirePassword"); }
            set { BackingStore?.Set("appStoreRequirePassword", value); }
        }
        /// <summary>List of apps in the visibility list (either visible/launchable apps list or hidden/unlaunchable apps list, controlled by AppsVisibilityListType) (iOS 9.3 and later). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> AppsVisibilityList {
            get { return BackingStore?.Get<List<AppListItem>>("appsVisibilityList"); }
            set { BackingStore?.Set("appsVisibilityList", value); }
        }
        /// <summary>Possible values of the compliance app list.</summary>
        public AppListType? AppsVisibilityListType {
            get { return BackingStore?.Get<AppListType?>("appsVisibilityListType"); }
            set { BackingStore?.Set("appsVisibilityListType", value); }
        }
        /// <summary>Indicates whether or not to force user authentication before autofilling passwords and credit card information in Safari and other apps on supervised devices.</summary>
        public bool? AutoFillForceAuthentication {
            get { return BackingStore?.Get<bool?>("autoFillForceAuthentication"); }
            set { BackingStore?.Set("autoFillForceAuthentication", value); }
        }
        /// <summary>Blocks users from unlocking their device with Apple Watch. Available for devices running iOS and iPadOS versions 14.5 and later.</summary>
        public bool? AutoUnlockBlocked {
            get { return BackingStore?.Get<bool?>("autoUnlockBlocked"); }
            set { BackingStore?.Set("autoUnlockBlocked", value); }
        }
        /// <summary>Indicates whether or not the removal of system apps from the device is blocked on a supervised device (iOS 11.0 and later).</summary>
        public bool? BlockSystemAppRemoval {
            get { return BackingStore?.Get<bool?>("blockSystemAppRemoval"); }
            set { BackingStore?.Set("blockSystemAppRemoval", value); }
        }
        /// <summary>Indicates whether or not to allow modification of Bluetooth settings when the device is in supervised mode (iOS 10.0 and later).</summary>
        public bool? BluetoothBlockModification {
            get { return BackingStore?.Get<bool?>("bluetoothBlockModification"); }
            set { BackingStore?.Set("bluetoothBlockModification", value); }
        }
        /// <summary>Indicates whether or not to block the user from accessing the camera of the device. Requires a supervised device for iOS 13 and later.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>("cameraBlocked"); }
            set { BackingStore?.Set("cameraBlocked", value); }
        }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockDataRoaming"); }
            set { BackingStore?.Set("cellularBlockDataRoaming", value); }
        }
        /// <summary>Indicates whether or not to block global background fetch while roaming.</summary>
        public bool? CellularBlockGlobalBackgroundFetchWhileRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockGlobalBackgroundFetchWhileRoaming"); }
            set { BackingStore?.Set("cellularBlockGlobalBackgroundFetchWhileRoaming", value); }
        }
        /// <summary>Indicates whether or not to allow changes to cellular app data usage settings when the device is in supervised mode.</summary>
        public bool? CellularBlockPerAppDataModification {
            get { return BackingStore?.Get<bool?>("cellularBlockPerAppDataModification"); }
            set { BackingStore?.Set("cellularBlockPerAppDataModification", value); }
        }
        /// <summary>Indicates whether or not to block Personal Hotspot.</summary>
        public bool? CellularBlockPersonalHotspot {
            get { return BackingStore?.Get<bool?>("cellularBlockPersonalHotspot"); }
            set { BackingStore?.Set("cellularBlockPersonalHotspot", value); }
        }
        /// <summary>Indicates whether or not to block the user from modifying the personal hotspot setting (iOS 12.2 or later).</summary>
        public bool? CellularBlockPersonalHotspotModification {
            get { return BackingStore?.Get<bool?>("cellularBlockPersonalHotspotModification"); }
            set { BackingStore?.Set("cellularBlockPersonalHotspotModification", value); }
        }
        /// <summary>Indicates whether or not to allow users to change the settings of the cellular plan on a supervised device.</summary>
        public bool? CellularBlockPlanModification {
            get { return BackingStore?.Get<bool?>("cellularBlockPlanModification"); }
            set { BackingStore?.Set("cellularBlockPlanModification", value); }
        }
        /// <summary>Indicates whether or not to block voice roaming.</summary>
        public bool? CellularBlockVoiceRoaming {
            get { return BackingStore?.Get<bool?>("cellularBlockVoiceRoaming"); }
            set { BackingStore?.Set("cellularBlockVoiceRoaming", value); }
        }
        /// <summary>Indicates whether or not to block untrusted TLS certificates.</summary>
        public bool? CertificatesBlockUntrustedTlsCertificates {
            get { return BackingStore?.Get<bool?>("certificatesBlockUntrustedTlsCertificates"); }
            set { BackingStore?.Set("certificatesBlockUntrustedTlsCertificates", value); }
        }
        /// <summary>Indicates whether or not to allow remote screen observation by Classroom app when the device is in supervised mode (iOS 9.3 and later).</summary>
        public bool? ClassroomAppBlockRemoteScreenObservation {
            get { return BackingStore?.Get<bool?>("classroomAppBlockRemoteScreenObservation"); }
            set { BackingStore?.Set("classroomAppBlockRemoteScreenObservation", value); }
        }
        /// <summary>Indicates whether or not to automatically give permission to the teacher of a managed course on the Classroom app to view a student&apos;s screen without prompting when the device is in supervised mode.</summary>
        public bool? ClassroomAppForceUnpromptedScreenObservation {
            get { return BackingStore?.Get<bool?>("classroomAppForceUnpromptedScreenObservation"); }
            set { BackingStore?.Set("classroomAppForceUnpromptedScreenObservation", value); }
        }
        /// <summary>Indicates whether or not to automatically give permission to the teacher&apos;s requests, without prompting the student, when the device is in supervised mode.</summary>
        public bool? ClassroomForceAutomaticallyJoinClasses {
            get { return BackingStore?.Get<bool?>("classroomForceAutomaticallyJoinClasses"); }
            set { BackingStore?.Set("classroomForceAutomaticallyJoinClasses", value); }
        }
        /// <summary>Indicates whether a student enrolled in an unmanaged course via Classroom will request permission from the teacher when attempting to leave the course (iOS 11.3 and later).</summary>
        public bool? ClassroomForceRequestPermissionToLeaveClasses {
            get { return BackingStore?.Get<bool?>("classroomForceRequestPermissionToLeaveClasses"); }
            set { BackingStore?.Set("classroomForceRequestPermissionToLeaveClasses", value); }
        }
        /// <summary>Indicates whether or not to allow the teacher to lock apps or the device without prompting the student. Supervised only.</summary>
        public bool? ClassroomForceUnpromptedAppAndDeviceLock {
            get { return BackingStore?.Get<bool?>("classroomForceUnpromptedAppAndDeviceLock"); }
            set { BackingStore?.Set("classroomForceUnpromptedAppAndDeviceLock", value); }
        }
        /// <summary>Possible values of the compliance app list.</summary>
        public AppListType? CompliantAppListType {
            get { return BackingStore?.Get<AppListType?>("compliantAppListType"); }
            set { BackingStore?.Set("compliantAppListType", value); }
        }
        /// <summary>List of apps in the compliance (either allow list or block list, controlled by CompliantAppListType). This collection can contain a maximum of 10000 elements.</summary>
        public List<AppListItem> CompliantAppsList {
            get { return BackingStore?.Get<List<AppListItem>>("compliantAppsList"); }
            set { BackingStore?.Set("compliantAppsList", value); }
        }
        /// <summary>Indicates whether or not to block the user from installing configuration profiles and certificates interactively when the device is in supervised mode.</summary>
        public bool? ConfigurationProfileBlockChanges {
            get { return BackingStore?.Get<bool?>("configurationProfileBlockChanges"); }
            set { BackingStore?.Set("configurationProfileBlockChanges", value); }
        }
        /// <summary>Indicates whether or not managed apps can write contacts to unmanaged contacts accounts (iOS 12.0 and later).</summary>
        public bool? ContactsAllowManagedToUnmanagedWrite {
            get { return BackingStore?.Get<bool?>("contactsAllowManagedToUnmanagedWrite"); }
            set { BackingStore?.Set("contactsAllowManagedToUnmanagedWrite", value); }
        }
        /// <summary>Indicates whether or not unmanaged apps can read from managed contacts accounts (iOS 12.0 or later).</summary>
        public bool? ContactsAllowUnmanagedToManagedRead {
            get { return BackingStore?.Get<bool?>("contactsAllowUnmanagedToManagedRead"); }
            set { BackingStore?.Set("contactsAllowUnmanagedToManagedRead", value); }
        }
        /// <summary>Indicates whether or not to block the continuous path keyboard when the device is supervised (iOS 13 or later).</summary>
        public bool? ContinuousPathKeyboardBlocked {
            get { return BackingStore?.Get<bool?>("continuousPathKeyboardBlocked"); }
            set { BackingStore?.Set("continuousPathKeyboardBlocked", value); }
        }
        /// <summary>Indicates whether or not the Date and Time &apos;Set Automatically&apos; feature is enabled and cannot be turned off by the user (iOS 12.0 and later).</summary>
        public bool? DateAndTimeForceSetAutomatically {
            get { return BackingStore?.Get<bool?>("dateAndTimeForceSetAutomatically"); }
            set { BackingStore?.Set("dateAndTimeForceSetAutomatically", value); }
        }
        /// <summary>Indicates whether or not to block definition lookup when the device is in supervised mode (iOS 8.1.3 and later ).</summary>
        public bool? DefinitionLookupBlocked {
            get { return BackingStore?.Get<bool?>("definitionLookupBlocked"); }
            set { BackingStore?.Set("definitionLookupBlocked", value); }
        }
        /// <summary>Indicates whether or not to allow the user to enables restrictions in the device settings when the device is in supervised mode.</summary>
        public bool? DeviceBlockEnableRestrictions {
            get { return BackingStore?.Get<bool?>("deviceBlockEnableRestrictions"); }
            set { BackingStore?.Set("deviceBlockEnableRestrictions", value); }
        }
        /// <summary>Indicates whether or not to allow the use of the &apos;Erase all content and settings&apos; option on the device when the device is in supervised mode.</summary>
        public bool? DeviceBlockEraseContentAndSettings {
            get { return BackingStore?.Get<bool?>("deviceBlockEraseContentAndSettings"); }
            set { BackingStore?.Set("deviceBlockEraseContentAndSettings", value); }
        }
        /// <summary>Indicates whether or not to allow device name modification when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? DeviceBlockNameModification {
            get { return BackingStore?.Get<bool?>("deviceBlockNameModification"); }
            set { BackingStore?.Set("deviceBlockNameModification", value); }
        }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticDataBlockSubmission {
            get { return BackingStore?.Get<bool?>("diagnosticDataBlockSubmission"); }
            set { BackingStore?.Set("diagnosticDataBlockSubmission", value); }
        }
        /// <summary>Indicates whether or not to allow diagnostics submission settings modification when the device is in supervised mode (iOS 9.3.2 and later).</summary>
        public bool? DiagnosticDataBlockSubmissionModification {
            get { return BackingStore?.Get<bool?>("diagnosticDataBlockSubmissionModification"); }
            set { BackingStore?.Set("diagnosticDataBlockSubmissionModification", value); }
        }
        /// <summary>Indicates whether or not to block the user from viewing managed documents in unmanaged apps.</summary>
        public bool? DocumentsBlockManagedDocumentsInUnmanagedApps {
            get { return BackingStore?.Get<bool?>("documentsBlockManagedDocumentsInUnmanagedApps"); }
            set { BackingStore?.Set("documentsBlockManagedDocumentsInUnmanagedApps", value); }
        }
        /// <summary>Indicates whether or not to block the user from viewing unmanaged documents in managed apps.</summary>
        public bool? DocumentsBlockUnmanagedDocumentsInManagedApps {
            get { return BackingStore?.Get<bool?>("documentsBlockUnmanagedDocumentsInManagedApps"); }
            set { BackingStore?.Set("documentsBlockUnmanagedDocumentsInManagedApps", value); }
        }
        /// <summary>An email address lacking a suffix that matches any of these strings will be considered out-of-domain.</summary>
        public List<string> EmailInDomainSuffixes {
            get { return BackingStore?.Get<List<string>>("emailInDomainSuffixes"); }
            set { BackingStore?.Set("emailInDomainSuffixes", value); }
        }
        /// <summary>Indicates whether or not to block the user from trusting an enterprise app.</summary>
        public bool? EnterpriseAppBlockTrust {
            get { return BackingStore?.Get<bool?>("enterpriseAppBlockTrust"); }
            set { BackingStore?.Set("enterpriseAppBlockTrust", value); }
        }
        /// <summary>[Deprecated] Configuring this setting and setting the value to &apos;true&apos; has no effect on the device.</summary>
        public bool? EnterpriseAppBlockTrustModification {
            get { return BackingStore?.Get<bool?>("enterpriseAppBlockTrustModification"); }
            set { BackingStore?.Set("enterpriseAppBlockTrustModification", value); }
        }
        /// <summary>Indicates whether or not Enterprise book back up is blocked.</summary>
        public bool? EnterpriseBookBlockBackup {
            get { return BackingStore?.Get<bool?>("enterpriseBookBlockBackup"); }
            set { BackingStore?.Set("enterpriseBookBlockBackup", value); }
        }
        /// <summary>Indicates whether or not Enterprise book notes and highlights sync is blocked.</summary>
        public bool? EnterpriseBookBlockMetadataSync {
            get { return BackingStore?.Get<bool?>("enterpriseBookBlockMetadataSync"); }
            set { BackingStore?.Set("enterpriseBookBlockMetadataSync", value); }
        }
        /// <summary>Indicates whether or not to allow the addition or removal of cellular plans on the eSIM of a supervised device.</summary>
        public bool? EsimBlockModification {
            get { return BackingStore?.Get<bool?>("esimBlockModification"); }
            set { BackingStore?.Set("esimBlockModification", value); }
        }
        /// <summary>Indicates whether or not to block the user from using FaceTime. Requires a supervised device for iOS 13 and later.</summary>
        public bool? FaceTimeBlocked {
            get { return BackingStore?.Get<bool?>("faceTimeBlocked"); }
            set { BackingStore?.Set("faceTimeBlocked", value); }
        }
        /// <summary>Indicates if devices can access files or other resources on a network server using the Server Message Block (SMB) protocol. Available for devices running iOS and iPadOS, versions 13.0 and later.</summary>
        public bool? FilesNetworkDriveAccessBlocked {
            get { return BackingStore?.Get<bool?>("filesNetworkDriveAccessBlocked"); }
            set { BackingStore?.Set("filesNetworkDriveAccessBlocked", value); }
        }
        /// <summary>Indicates if sevices with access can connect to and open files on a USB drive. Available for devices running iOS and iPadOS, versions 13.0 and later.</summary>
        public bool? FilesUsbDriveAccessBlocked {
            get { return BackingStore?.Get<bool?>("filesUsbDriveAccessBlocked"); }
            set { BackingStore?.Set("filesUsbDriveAccessBlocked", value); }
        }
        /// <summary>Indicates whether or not to block Find My Device when the device is supervised (iOS 13 or later).</summary>
        public bool? FindMyDeviceInFindMyAppBlocked {
            get { return BackingStore?.Get<bool?>("findMyDeviceInFindMyAppBlocked"); }
            set { BackingStore?.Set("findMyDeviceInFindMyAppBlocked", value); }
        }
        /// <summary>Indicates whether or not to block changes to Find My Friends when the device is in supervised mode.</summary>
        public bool? FindMyFriendsBlocked {
            get { return BackingStore?.Get<bool?>("findMyFriendsBlocked"); }
            set { BackingStore?.Set("findMyFriendsBlocked", value); }
        }
        /// <summary>Indicates whether or not to block Find My Friends when the device is supervised (iOS 13 or later).</summary>
        public bool? FindMyFriendsInFindMyAppBlocked {
            get { return BackingStore?.Get<bool?>("findMyFriendsInFindMyAppBlocked"); }
            set { BackingStore?.Set("findMyFriendsInFindMyAppBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from using Game Center when the device is in supervised mode.</summary>
        public bool? GameCenterBlocked {
            get { return BackingStore?.Get<bool?>("gameCenterBlocked"); }
            set { BackingStore?.Set("gameCenterBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from having friends in Game Center. Requires a supervised device for iOS 13 and later.</summary>
        public bool? GamingBlockGameCenterFriends {
            get { return BackingStore?.Get<bool?>("gamingBlockGameCenterFriends"); }
            set { BackingStore?.Set("gamingBlockGameCenterFriends", value); }
        }
        /// <summary>Indicates whether or not to block the user from using multiplayer gaming. Requires a supervised device for iOS 13 and later.</summary>
        public bool? GamingBlockMultiplayer {
            get { return BackingStore?.Get<bool?>("gamingBlockMultiplayer"); }
            set { BackingStore?.Set("gamingBlockMultiplayer", value); }
        }
        /// <summary>indicates whether or not to allow host pairing to control the devices an iOS device can pair with when the iOS device is in supervised mode.</summary>
        public bool? HostPairingBlocked {
            get { return BackingStore?.Get<bool?>("hostPairingBlocked"); }
            set { BackingStore?.Set("hostPairingBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from using the iBooks Store when the device is in supervised mode.</summary>
        public bool? IBooksStoreBlocked {
            get { return BackingStore?.Get<bool?>("iBooksStoreBlocked"); }
            set { BackingStore?.Set("iBooksStoreBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from downloading media from the iBookstore that has been tagged as erotica.</summary>
        public bool? IBooksStoreBlockErotica {
            get { return BackingStore?.Get<bool?>("iBooksStoreBlockErotica"); }
            set { BackingStore?.Set("iBooksStoreBlockErotica", value); }
        }
        /// <summary>Indicates whether or not to block the user from continuing work they started on iOS device to another iOS or macOS device.</summary>
        public bool? ICloudBlockActivityContinuation {
            get { return BackingStore?.Get<bool?>("iCloudBlockActivityContinuation"); }
            set { BackingStore?.Set("iCloudBlockActivityContinuation", value); }
        }
        /// <summary>Indicates whether or not to block iCloud backup. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ICloudBlockBackup {
            get { return BackingStore?.Get<bool?>("iCloudBlockBackup"); }
            set { BackingStore?.Set("iCloudBlockBackup", value); }
        }
        /// <summary>Indicates whether or not to block iCloud document sync. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ICloudBlockDocumentSync {
            get { return BackingStore?.Get<bool?>("iCloudBlockDocumentSync"); }
            set { BackingStore?.Set("iCloudBlockDocumentSync", value); }
        }
        /// <summary>Indicates whether or not to block Managed Apps Cloud Sync.</summary>
        public bool? ICloudBlockManagedAppsSync {
            get { return BackingStore?.Get<bool?>("iCloudBlockManagedAppsSync"); }
            set { BackingStore?.Set("iCloudBlockManagedAppsSync", value); }
        }
        /// <summary>Indicates whether or not to block iCloud Photo Library.</summary>
        public bool? ICloudBlockPhotoLibrary {
            get { return BackingStore?.Get<bool?>("iCloudBlockPhotoLibrary"); }
            set { BackingStore?.Set("iCloudBlockPhotoLibrary", value); }
        }
        /// <summary>Indicates whether or not to block iCloud Photo Stream Sync.</summary>
        public bool? ICloudBlockPhotoStreamSync {
            get { return BackingStore?.Get<bool?>("iCloudBlockPhotoStreamSync"); }
            set { BackingStore?.Set("iCloudBlockPhotoStreamSync", value); }
        }
        /// <summary>Indicates whether or not to block Shared Photo Stream.</summary>
        public bool? ICloudBlockSharedPhotoStream {
            get { return BackingStore?.Get<bool?>("iCloudBlockSharedPhotoStream"); }
            set { BackingStore?.Set("iCloudBlockSharedPhotoStream", value); }
        }
        /// <summary>iCloud private relay is an iCloud+ service that prevents networks and servers from monitoring a person&apos;s activity across the internet. By blocking iCloud private relay, Apple will not encrypt the traffic leaving the device. Available for devices running iOS 15 and later.</summary>
        public bool? ICloudPrivateRelayBlocked {
            get { return BackingStore?.Get<bool?>("iCloudPrivateRelayBlocked"); }
            set { BackingStore?.Set("iCloudPrivateRelayBlocked", value); }
        }
        /// <summary>Indicates whether or not to require backups to iCloud be encrypted.</summary>
        public bool? ICloudRequireEncryptedBackup {
            get { return BackingStore?.Get<bool?>("iCloudRequireEncryptedBackup"); }
            set { BackingStore?.Set("iCloudRequireEncryptedBackup", value); }
        }
        /// <summary>Indicates whether or not to block the iTunes app. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ITunesBlocked {
            get { return BackingStore?.Get<bool?>("iTunesBlocked"); }
            set { BackingStore?.Set("iTunesBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from accessing explicit content in iTunes and the App Store. Requires a supervised device for iOS 13 and later.</summary>
        public bool? ITunesBlockExplicitContent {
            get { return BackingStore?.Get<bool?>("iTunesBlockExplicitContent"); }
            set { BackingStore?.Set("iTunesBlockExplicitContent", value); }
        }
        /// <summary>Indicates whether or not to block Music service and revert Music app to classic mode when the device is in supervised mode (iOS 9.3 and later and macOS 10.12 and later).</summary>
        public bool? ITunesBlockMusicService {
            get { return BackingStore?.Get<bool?>("iTunesBlockMusicService"); }
            set { BackingStore?.Set("iTunesBlockMusicService", value); }
        }
        /// <summary>Indicates whether or not to block the user from using iTunes Radio when the device is in supervised mode (iOS 9.3 and later).</summary>
        public bool? ITunesBlockRadio {
            get { return BackingStore?.Get<bool?>("iTunesBlockRadio"); }
            set { BackingStore?.Set("iTunesBlockRadio", value); }
        }
        /// <summary>Indicates whether or not to block keyboard auto-correction when the device is in supervised mode (iOS 8.1.3 and later).</summary>
        public bool? KeyboardBlockAutoCorrect {
            get { return BackingStore?.Get<bool?>("keyboardBlockAutoCorrect"); }
            set { BackingStore?.Set("keyboardBlockAutoCorrect", value); }
        }
        /// <summary>Indicates whether or not to block the user from using dictation input when the device is in supervised mode.</summary>
        public bool? KeyboardBlockDictation {
            get { return BackingStore?.Get<bool?>("keyboardBlockDictation"); }
            set { BackingStore?.Set("keyboardBlockDictation", value); }
        }
        /// <summary>Indicates whether or not to block predictive keyboards when device is in supervised mode (iOS 8.1.3 and later).</summary>
        public bool? KeyboardBlockPredictive {
            get { return BackingStore?.Get<bool?>("keyboardBlockPredictive"); }
            set { BackingStore?.Set("keyboardBlockPredictive", value); }
        }
        /// <summary>Indicates whether or not to block keyboard shortcuts when the device is in supervised mode (iOS 9.0 and later).</summary>
        public bool? KeyboardBlockShortcuts {
            get { return BackingStore?.Get<bool?>("keyboardBlockShortcuts"); }
            set { BackingStore?.Set("keyboardBlockShortcuts", value); }
        }
        /// <summary>Indicates whether or not to block keyboard spell-checking when the device is in supervised mode (iOS 8.1.3 and later).</summary>
        public bool? KeyboardBlockSpellCheck {
            get { return BackingStore?.Get<bool?>("keyboardBlockSpellCheck"); }
            set { BackingStore?.Set("keyboardBlockSpellCheck", value); }
        }
        /// <summary>Indicates whether or not iCloud keychain synchronization is blocked. Requires a supervised device for iOS 13 and later.</summary>
        public bool? KeychainBlockCloudSync {
            get { return BackingStore?.Get<bool?>("keychainBlockCloudSync"); }
            set { BackingStore?.Set("keychainBlockCloudSync", value); }
        }
        /// <summary>Indicates whether or not to allow assistive speak while in kiosk mode.</summary>
        public bool? KioskModeAllowAssistiveSpeak {
            get { return BackingStore?.Get<bool?>("kioskModeAllowAssistiveSpeak"); }
            set { BackingStore?.Set("kioskModeAllowAssistiveSpeak", value); }
        }
        /// <summary>Indicates whether or not to allow access to the Assistive Touch Settings while in kiosk mode.</summary>
        public bool? KioskModeAllowAssistiveTouchSettings {
            get { return BackingStore?.Get<bool?>("kioskModeAllowAssistiveTouchSettings"); }
            set { BackingStore?.Set("kioskModeAllowAssistiveTouchSettings", value); }
        }
        /// <summary>Indicates whether or not to allow device auto lock while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockAutoLock instead.</summary>
        public bool? KioskModeAllowAutoLock {
            get { return BackingStore?.Get<bool?>("kioskModeAllowAutoLock"); }
            set { BackingStore?.Set("kioskModeAllowAutoLock", value); }
        }
        /// <summary>Indicates whether or not to allow access to the Color Inversion Settings while in kiosk mode.</summary>
        public bool? KioskModeAllowColorInversionSettings {
            get { return BackingStore?.Get<bool?>("kioskModeAllowColorInversionSettings"); }
            set { BackingStore?.Set("kioskModeAllowColorInversionSettings", value); }
        }
        /// <summary>Indicates whether or not to allow use of the ringer switch while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockRingerSwitch instead.</summary>
        public bool? KioskModeAllowRingerSwitch {
            get { return BackingStore?.Get<bool?>("kioskModeAllowRingerSwitch"); }
            set { BackingStore?.Set("kioskModeAllowRingerSwitch", value); }
        }
        /// <summary>Indicates whether or not to allow screen rotation while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockScreenRotation instead.</summary>
        public bool? KioskModeAllowScreenRotation {
            get { return BackingStore?.Get<bool?>("kioskModeAllowScreenRotation"); }
            set { BackingStore?.Set("kioskModeAllowScreenRotation", value); }
        }
        /// <summary>Indicates whether or not to allow use of the sleep button while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockSleepButton instead.</summary>
        public bool? KioskModeAllowSleepButton {
            get { return BackingStore?.Get<bool?>("kioskModeAllowSleepButton"); }
            set { BackingStore?.Set("kioskModeAllowSleepButton", value); }
        }
        /// <summary>Indicates whether or not to allow use of the touchscreen while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockTouchscreen instead.</summary>
        public bool? KioskModeAllowTouchscreen {
            get { return BackingStore?.Get<bool?>("kioskModeAllowTouchscreen"); }
            set { BackingStore?.Set("kioskModeAllowTouchscreen", value); }
        }
        /// <summary>Indicates whether or not to allow the user to toggle voice control in kiosk mode.</summary>
        public bool? KioskModeAllowVoiceControlModification {
            get { return BackingStore?.Get<bool?>("kioskModeAllowVoiceControlModification"); }
            set { BackingStore?.Set("kioskModeAllowVoiceControlModification", value); }
        }
        /// <summary>Indicates whether or not to allow access to the voice over settings while in kiosk mode.</summary>
        public bool? KioskModeAllowVoiceOverSettings {
            get { return BackingStore?.Get<bool?>("kioskModeAllowVoiceOverSettings"); }
            set { BackingStore?.Set("kioskModeAllowVoiceOverSettings", value); }
        }
        /// <summary>Indicates whether or not to allow use of the volume buttons while in kiosk mode. This property&apos;s functionality is redundant with the OS default and is deprecated. Use KioskModeBlockVolumeButtons instead.</summary>
        public bool? KioskModeAllowVolumeButtons {
            get { return BackingStore?.Get<bool?>("kioskModeAllowVolumeButtons"); }
            set { BackingStore?.Set("kioskModeAllowVolumeButtons", value); }
        }
        /// <summary>Indicates whether or not to allow access to the zoom settings while in kiosk mode.</summary>
        public bool? KioskModeAllowZoomSettings {
            get { return BackingStore?.Get<bool?>("kioskModeAllowZoomSettings"); }
            set { BackingStore?.Set("kioskModeAllowZoomSettings", value); }
        }
        /// <summary>URL in the app store to the app to use for kiosk mode. Use if KioskModeManagedAppId is not known.</summary>
        public string KioskModeAppStoreUrl {
            get { return BackingStore?.Get<string>("kioskModeAppStoreUrl"); }
            set { BackingStore?.Set("kioskModeAppStoreUrl", value); }
        }
        /// <summary>App source options for iOS kiosk mode.</summary>
        public IosKioskModeAppType? KioskModeAppType {
            get { return BackingStore?.Get<IosKioskModeAppType?>("kioskModeAppType"); }
            set { BackingStore?.Set("kioskModeAppType", value); }
        }
        /// <summary>Indicates whether or not to block device auto lock while in kiosk mode.</summary>
        public bool? KioskModeBlockAutoLock {
            get { return BackingStore?.Get<bool?>("kioskModeBlockAutoLock"); }
            set { BackingStore?.Set("kioskModeBlockAutoLock", value); }
        }
        /// <summary>Indicates whether or not to block use of the ringer switch while in kiosk mode.</summary>
        public bool? KioskModeBlockRingerSwitch {
            get { return BackingStore?.Get<bool?>("kioskModeBlockRingerSwitch"); }
            set { BackingStore?.Set("kioskModeBlockRingerSwitch", value); }
        }
        /// <summary>Indicates whether or not to block screen rotation while in kiosk mode.</summary>
        public bool? KioskModeBlockScreenRotation {
            get { return BackingStore?.Get<bool?>("kioskModeBlockScreenRotation"); }
            set { BackingStore?.Set("kioskModeBlockScreenRotation", value); }
        }
        /// <summary>Indicates whether or not to block use of the sleep button while in kiosk mode.</summary>
        public bool? KioskModeBlockSleepButton {
            get { return BackingStore?.Get<bool?>("kioskModeBlockSleepButton"); }
            set { BackingStore?.Set("kioskModeBlockSleepButton", value); }
        }
        /// <summary>Indicates whether or not to block use of the touchscreen while in kiosk mode.</summary>
        public bool? KioskModeBlockTouchscreen {
            get { return BackingStore?.Get<bool?>("kioskModeBlockTouchscreen"); }
            set { BackingStore?.Set("kioskModeBlockTouchscreen", value); }
        }
        /// <summary>Indicates whether or not to block the volume buttons while in Kiosk Mode.</summary>
        public bool? KioskModeBlockVolumeButtons {
            get { return BackingStore?.Get<bool?>("kioskModeBlockVolumeButtons"); }
            set { BackingStore?.Set("kioskModeBlockVolumeButtons", value); }
        }
        /// <summary>ID for built-in apps to use for kiosk mode. Used when KioskModeManagedAppId and KioskModeAppStoreUrl are not set.</summary>
        public string KioskModeBuiltInAppId {
            get { return BackingStore?.Get<string>("kioskModeBuiltInAppId"); }
            set { BackingStore?.Set("kioskModeBuiltInAppId", value); }
        }
        /// <summary>Indicates whether or not to enable voice control in kiosk mode.</summary>
        public bool? KioskModeEnableVoiceControl {
            get { return BackingStore?.Get<bool?>("kioskModeEnableVoiceControl"); }
            set { BackingStore?.Set("kioskModeEnableVoiceControl", value); }
        }
        /// <summary>Managed app id of the app to use for kiosk mode. If KioskModeManagedAppId is specified then KioskModeAppStoreUrl will be ignored.</summary>
        public string KioskModeManagedAppId {
            get { return BackingStore?.Get<string>("kioskModeManagedAppId"); }
            set { BackingStore?.Set("kioskModeManagedAppId", value); }
        }
        /// <summary>Indicates whether or not to require assistive touch while in kiosk mode.</summary>
        public bool? KioskModeRequireAssistiveTouch {
            get { return BackingStore?.Get<bool?>("kioskModeRequireAssistiveTouch"); }
            set { BackingStore?.Set("kioskModeRequireAssistiveTouch", value); }
        }
        /// <summary>Indicates whether or not to require color inversion while in kiosk mode.</summary>
        public bool? KioskModeRequireColorInversion {
            get { return BackingStore?.Get<bool?>("kioskModeRequireColorInversion"); }
            set { BackingStore?.Set("kioskModeRequireColorInversion", value); }
        }
        /// <summary>Indicates whether or not to require mono audio while in kiosk mode.</summary>
        public bool? KioskModeRequireMonoAudio {
            get { return BackingStore?.Get<bool?>("kioskModeRequireMonoAudio"); }
            set { BackingStore?.Set("kioskModeRequireMonoAudio", value); }
        }
        /// <summary>Indicates whether or not to require voice over while in kiosk mode.</summary>
        public bool? KioskModeRequireVoiceOver {
            get { return BackingStore?.Get<bool?>("kioskModeRequireVoiceOver"); }
            set { BackingStore?.Set("kioskModeRequireVoiceOver", value); }
        }
        /// <summary>Indicates whether or not to require zoom while in kiosk mode.</summary>
        public bool? KioskModeRequireZoom {
            get { return BackingStore?.Get<bool?>("kioskModeRequireZoom"); }
            set { BackingStore?.Set("kioskModeRequireZoom", value); }
        }
        /// <summary>Indicates whether or not to block the user from using control center on the lock screen.</summary>
        public bool? LockScreenBlockControlCenter {
            get { return BackingStore?.Get<bool?>("lockScreenBlockControlCenter"); }
            set { BackingStore?.Set("lockScreenBlockControlCenter", value); }
        }
        /// <summary>Indicates whether or not to block the user from using the notification view on the lock screen.</summary>
        public bool? LockScreenBlockNotificationView {
            get { return BackingStore?.Get<bool?>("lockScreenBlockNotificationView"); }
            set { BackingStore?.Set("lockScreenBlockNotificationView", value); }
        }
        /// <summary>Indicates whether or not to block the user from using passbook when the device is locked.</summary>
        public bool? LockScreenBlockPassbook {
            get { return BackingStore?.Get<bool?>("lockScreenBlockPassbook"); }
            set { BackingStore?.Set("lockScreenBlockPassbook", value); }
        }
        /// <summary>Indicates whether or not to block the user from using the Today View on the lock screen.</summary>
        public bool? LockScreenBlockTodayView {
            get { return BackingStore?.Get<bool?>("lockScreenBlockTodayView"); }
            set { BackingStore?.Set("lockScreenBlockTodayView", value); }
        }
        /// <summary>Open-in management controls how people share data between unmanaged and managed apps. Setting this to true enforces copy/paste restrictions based on how you configured Block viewing corporate documents in unmanaged apps  and  Block viewing non-corporate documents in corporate apps.</summary>
        public bool? ManagedPasteboardRequired {
            get { return BackingStore?.Get<bool?>("managedPasteboardRequired"); }
            set { BackingStore?.Set("managedPasteboardRequired", value); }
        }
        /// <summary>Apps rating as in media content</summary>
        public RatingAppsType? MediaContentRatingApps {
            get { return BackingStore?.Get<RatingAppsType?>("mediaContentRatingApps"); }
            set { BackingStore?.Set("mediaContentRatingApps", value); }
        }
        /// <summary>Media content rating settings for Australia</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingAustralia MediaContentRatingAustralia {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingAustralia>("mediaContentRatingAustralia"); }
            set { BackingStore?.Set("mediaContentRatingAustralia", value); }
        }
        /// <summary>Media content rating settings for Canada</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingCanada MediaContentRatingCanada {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingCanada>("mediaContentRatingCanada"); }
            set { BackingStore?.Set("mediaContentRatingCanada", value); }
        }
        /// <summary>Media content rating settings for France</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingFrance MediaContentRatingFrance {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingFrance>("mediaContentRatingFrance"); }
            set { BackingStore?.Set("mediaContentRatingFrance", value); }
        }
        /// <summary>Media content rating settings for Germany</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingGermany MediaContentRatingGermany {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingGermany>("mediaContentRatingGermany"); }
            set { BackingStore?.Set("mediaContentRatingGermany", value); }
        }
        /// <summary>Media content rating settings for Ireland</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingIreland MediaContentRatingIreland {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingIreland>("mediaContentRatingIreland"); }
            set { BackingStore?.Set("mediaContentRatingIreland", value); }
        }
        /// <summary>Media content rating settings for Japan</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingJapan MediaContentRatingJapan {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingJapan>("mediaContentRatingJapan"); }
            set { BackingStore?.Set("mediaContentRatingJapan", value); }
        }
        /// <summary>Media content rating settings for New Zealand</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingNewZealand MediaContentRatingNewZealand {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingNewZealand>("mediaContentRatingNewZealand"); }
            set { BackingStore?.Set("mediaContentRatingNewZealand", value); }
        }
        /// <summary>Media content rating settings for United Kingdom</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingUnitedKingdom MediaContentRatingUnitedKingdom {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingUnitedKingdom>("mediaContentRatingUnitedKingdom"); }
            set { BackingStore?.Set("mediaContentRatingUnitedKingdom", value); }
        }
        /// <summary>Media content rating settings for United States</summary>
        public Microsoft.Graph.Beta.Models.MediaContentRatingUnitedStates MediaContentRatingUnitedStates {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MediaContentRatingUnitedStates>("mediaContentRatingUnitedStates"); }
            set { BackingStore?.Set("mediaContentRatingUnitedStates", value); }
        }
        /// <summary>Indicates whether or not to block the user from using the Messages app on the supervised device.</summary>
        public bool? MessagesBlocked {
            get { return BackingStore?.Get<bool?>("messagesBlocked"); }
            set { BackingStore?.Set("messagesBlocked", value); }
        }
        /// <summary>List of managed apps and the network rules that applies to them. This collection can contain a maximum of 1000 elements.</summary>
        public List<IosNetworkUsageRule> NetworkUsageRules {
            get { return BackingStore?.Get<List<IosNetworkUsageRule>>("networkUsageRules"); }
            set { BackingStore?.Set("networkUsageRules", value); }
        }
        /// <summary>Disable NFC to prevent devices from pairing with other NFC-enabled devices. Available for iOS/iPadOS devices running 14.2 and later.</summary>
        public bool? NfcBlocked {
            get { return BackingStore?.Get<bool?>("nfcBlocked"); }
            set { BackingStore?.Set("nfcBlocked", value); }
        }
        /// <summary>Indicates whether or not to allow notifications settings modification (iOS 9.3 and later).</summary>
        public bool? NotificationsBlockSettingsModification {
            get { return BackingStore?.Get<bool?>("notificationsBlockSettingsModification"); }
            set { BackingStore?.Set("notificationsBlockSettingsModification", value); }
        }
        /// <summary>Disables connections to Siri servers so that users can’t use Siri to dictate text. Available for devices running iOS and iPadOS versions 14.5 and later.</summary>
        public bool? OnDeviceOnlyDictationForced {
            get { return BackingStore?.Get<bool?>("onDeviceOnlyDictationForced"); }
            set { BackingStore?.Set("onDeviceOnlyDictationForced", value); }
        }
        /// <summary>When set to TRUE, the setting disables connections to Siri servers so that users can’t use Siri to translate text. When set to FALSE, the setting allows connections to to Siri servers to users can use Siri to translate text. Available for devices running iOS and iPadOS versions 15.0 and later.</summary>
        public bool? OnDeviceOnlyTranslationForced {
            get { return BackingStore?.Get<bool?>("onDeviceOnlyTranslationForced"); }
            set { BackingStore?.Set("onDeviceOnlyTranslationForced", value); }
        }
        /// <summary>Block modification of registered Touch ID fingerprints when in supervised mode.</summary>
        public bool? PasscodeBlockFingerprintModification {
            get { return BackingStore?.Get<bool?>("passcodeBlockFingerprintModification"); }
            set { BackingStore?.Set("passcodeBlockFingerprintModification", value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasscodeBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>("passcodeBlockFingerprintUnlock"); }
            set { BackingStore?.Set("passcodeBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to allow passcode modification on the supervised device (iOS 9.0 and later).</summary>
        public bool? PasscodeBlockModification {
            get { return BackingStore?.Get<bool?>("passcodeBlockModification"); }
            set { BackingStore?.Set("passcodeBlockModification", value); }
        }
        /// <summary>Indicates whether or not to block simple passcodes.</summary>
        public bool? PasscodeBlockSimple {
            get { return BackingStore?.Get<bool?>("passcodeBlockSimple"); }
            set { BackingStore?.Set("passcodeBlockSimple", value); }
        }
        /// <summary>Number of days before the passcode expires. Valid values 1 to 65535</summary>
        public int? PasscodeExpirationDays {
            get { return BackingStore?.Get<int?>("passcodeExpirationDays"); }
            set { BackingStore?.Set("passcodeExpirationDays", value); }
        }
        /// <summary>Number of character sets a passcode must contain. Valid values 0 to 4</summary>
        public int? PasscodeMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passcodeMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passcodeMinimumCharacterSetCount", value); }
        }
        /// <summary>Minimum length of passcode. Valid values 4 to 14</summary>
        public int? PasscodeMinimumLength {
            get { return BackingStore?.Get<int?>("passcodeMinimumLength"); }
            set { BackingStore?.Set("passcodeMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before a passcode is required.</summary>
        public int? PasscodeMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>("passcodeMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passcodeMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasscodeMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passcodeMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passcodeMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Number of previous passcodes to block. Valid values 1 to 24</summary>
        public int? PasscodePreviousPasscodeBlockCount {
            get { return BackingStore?.Get<int?>("passcodePreviousPasscodeBlockCount"); }
            set { BackingStore?.Set("passcodePreviousPasscodeBlockCount", value); }
        }
        /// <summary>Indicates whether or not to require a passcode.</summary>
        public bool? PasscodeRequired {
            get { return BackingStore?.Get<bool?>("passcodeRequired"); }
            set { BackingStore?.Set("passcodeRequired", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasscodeRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passcodeRequiredType"); }
            set { BackingStore?.Set("passcodeRequiredType", value); }
        }
        /// <summary>Number of sign in failures allowed before wiping the device. Valid values 2 to 11</summary>
        public int? PasscodeSignInFailureCountBeforeWipe {
            get { return BackingStore?.Get<int?>("passcodeSignInFailureCountBeforeWipe"); }
            set { BackingStore?.Set("passcodeSignInFailureCountBeforeWipe", value); }
        }
        /// <summary>Indicates whether or not to block sharing passwords with the AirDrop passwords feature iOS 12.0 and later).</summary>
        public bool? PasswordBlockAirDropSharing {
            get { return BackingStore?.Get<bool?>("passwordBlockAirDropSharing"); }
            set { BackingStore?.Set("passwordBlockAirDropSharing", value); }
        }
        /// <summary>Indicates if the AutoFill passwords feature is allowed (iOS 12.0 and later).</summary>
        public bool? PasswordBlockAutoFill {
            get { return BackingStore?.Get<bool?>("passwordBlockAutoFill"); }
            set { BackingStore?.Set("passwordBlockAutoFill", value); }
        }
        /// <summary>Indicates whether or not to block requesting passwords from nearby devices (iOS 12.0 and later).</summary>
        public bool? PasswordBlockProximityRequests {
            get { return BackingStore?.Get<bool?>("passwordBlockProximityRequests"); }
            set { BackingStore?.Set("passwordBlockProximityRequests", value); }
        }
        /// <summary>Indicates whether or not over-the-air PKI updates are blocked. Setting this restriction to false does not disable CRL and OCSP checks (iOS 7.0 and later).</summary>
        public bool? PkiBlockOTAUpdates {
            get { return BackingStore?.Get<bool?>("pkiBlockOTAUpdates"); }
            set { BackingStore?.Set("pkiBlockOTAUpdates", value); }
        }
        /// <summary>Indicates whether or not to block the user from using podcasts on the supervised device (iOS 8.0 and later).</summary>
        public bool? PodcastsBlocked {
            get { return BackingStore?.Get<bool?>("podcastsBlocked"); }
            set { BackingStore?.Set("podcastsBlocked", value); }
        }
        /// <summary>Indicates if ad tracking is limited.(iOS 7.0 and later).</summary>
        public bool? PrivacyForceLimitAdTracking {
            get { return BackingStore?.Get<bool?>("privacyForceLimitAdTracking"); }
            set { BackingStore?.Set("privacyForceLimitAdTracking", value); }
        }
        /// <summary>Indicates whether or not to enable the prompt to setup nearby devices with a supervised device.</summary>
        public bool? ProximityBlockSetupToNewDevice {
            get { return BackingStore?.Get<bool?>("proximityBlockSetupToNewDevice"); }
            set { BackingStore?.Set("proximityBlockSetupToNewDevice", value); }
        }
        /// <summary>Indicates whether or not to block the user from using Auto fill in Safari. Requires a supervised device for iOS 13 and later.</summary>
        public bool? SafariBlockAutofill {
            get { return BackingStore?.Get<bool?>("safariBlockAutofill"); }
            set { BackingStore?.Set("safariBlockAutofill", value); }
        }
        /// <summary>Indicates whether or not to block the user from using Safari. Requires a supervised device for iOS 13 and later.</summary>
        public bool? SafariBlocked {
            get { return BackingStore?.Get<bool?>("safariBlocked"); }
            set { BackingStore?.Set("safariBlocked", value); }
        }
        /// <summary>Indicates whether or not to block JavaScript in Safari.</summary>
        public bool? SafariBlockJavaScript {
            get { return BackingStore?.Get<bool?>("safariBlockJavaScript"); }
            set { BackingStore?.Set("safariBlockJavaScript", value); }
        }
        /// <summary>Indicates whether or not to block popups in Safari.</summary>
        public bool? SafariBlockPopups {
            get { return BackingStore?.Get<bool?>("safariBlockPopups"); }
            set { BackingStore?.Set("safariBlockPopups", value); }
        }
        /// <summary>Web Browser Cookie Settings.</summary>
        public WebBrowserCookieSettings? SafariCookieSettings {
            get { return BackingStore?.Get<WebBrowserCookieSettings?>("safariCookieSettings"); }
            set { BackingStore?.Set("safariCookieSettings", value); }
        }
        /// <summary>URLs matching the patterns listed here will be considered managed.</summary>
        public List<string> SafariManagedDomains {
            get { return BackingStore?.Get<List<string>>("safariManagedDomains"); }
            set { BackingStore?.Set("safariManagedDomains", value); }
        }
        /// <summary>Users can save passwords in Safari only from URLs matching the patterns listed here. Applies to devices in supervised mode (iOS 9.3 and later).</summary>
        public List<string> SafariPasswordAutoFillDomains {
            get { return BackingStore?.Get<List<string>>("safariPasswordAutoFillDomains"); }
            set { BackingStore?.Set("safariPasswordAutoFillDomains", value); }
        }
        /// <summary>Indicates whether or not to require fraud warning in Safari.</summary>
        public bool? SafariRequireFraudWarning {
            get { return BackingStore?.Get<bool?>("safariRequireFraudWarning"); }
            set { BackingStore?.Set("safariRequireFraudWarning", value); }
        }
        /// <summary>Indicates whether or not to block the user from taking Screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Indicates whether or not to block temporary sessions on Shared iPads (iOS 13.4 or later).</summary>
        public bool? SharedDeviceBlockTemporarySessions {
            get { return BackingStore?.Get<bool?>("sharedDeviceBlockTemporarySessions"); }
            set { BackingStore?.Set("sharedDeviceBlockTemporarySessions", value); }
        }
        /// <summary>Indicates whether or not to block the user from using Siri.</summary>
        public bool? SiriBlocked {
            get { return BackingStore?.Get<bool?>("siriBlocked"); }
            set { BackingStore?.Set("siriBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from using Siri when locked.</summary>
        public bool? SiriBlockedWhenLocked {
            get { return BackingStore?.Get<bool?>("siriBlockedWhenLocked"); }
            set { BackingStore?.Set("siriBlockedWhenLocked", value); }
        }
        /// <summary>Indicates whether or not to block Siri from querying user-generated content when used on a supervised device.</summary>
        public bool? SiriBlockUserGeneratedContent {
            get { return BackingStore?.Get<bool?>("siriBlockUserGeneratedContent"); }
            set { BackingStore?.Set("siriBlockUserGeneratedContent", value); }
        }
        /// <summary>Indicates whether or not to prevent Siri from dictating, or speaking profane language on supervised device.</summary>
        public bool? SiriRequireProfanityFilter {
            get { return BackingStore?.Get<bool?>("siriRequireProfanityFilter"); }
            set { BackingStore?.Set("siriRequireProfanityFilter", value); }
        }
        /// <summary>Sets how many days a software update will be delyed for a supervised device. Valid values 0 to 90</summary>
        public int? SoftwareUpdatesEnforcedDelayInDays {
            get { return BackingStore?.Get<int?>("softwareUpdatesEnforcedDelayInDays"); }
            set { BackingStore?.Set("softwareUpdatesEnforcedDelayInDays", value); }
        }
        /// <summary>Indicates whether or not to delay user visibility of software updates when the device is in supervised mode.</summary>
        public bool? SoftwareUpdatesForceDelayed {
            get { return BackingStore?.Get<bool?>("softwareUpdatesForceDelayed"); }
            set { BackingStore?.Set("softwareUpdatesForceDelayed", value); }
        }
        /// <summary>Indicates whether or not to block Spotlight search from returning internet results on supervised device.</summary>
        public bool? SpotlightBlockInternetResults {
            get { return BackingStore?.Get<bool?>("spotlightBlockInternetResults"); }
            set { BackingStore?.Set("spotlightBlockInternetResults", value); }
        }
        /// <summary>Allow users to boot devices into recovery mode with unpaired devices. Available for devices running iOS and iPadOS versions 14.5 and later.</summary>
        public bool? UnpairedExternalBootToRecoveryAllowed {
            get { return BackingStore?.Get<bool?>("unpairedExternalBootToRecoveryAllowed"); }
            set { BackingStore?.Set("unpairedExternalBootToRecoveryAllowed", value); }
        }
        /// <summary>Indicates if connecting to USB accessories while the device is locked is allowed (iOS 11.4.1 and later).</summary>
        public bool? UsbRestrictedModeBlocked {
            get { return BackingStore?.Get<bool?>("usbRestrictedModeBlocked"); }
            set { BackingStore?.Set("usbRestrictedModeBlocked", value); }
        }
        /// <summary>Indicates whether or not to block voice dialing.</summary>
        public bool? VoiceDialingBlocked {
            get { return BackingStore?.Get<bool?>("voiceDialingBlocked"); }
            set { BackingStore?.Set("voiceDialingBlocked", value); }
        }
        /// <summary>Indicates whether or not the creation of VPN configurations is blocked (iOS 11.0 and later).</summary>
        public bool? VpnBlockCreation {
            get { return BackingStore?.Get<bool?>("vpnBlockCreation"); }
            set { BackingStore?.Set("vpnBlockCreation", value); }
        }
        /// <summary>Indicates whether or not to allow wallpaper modification on supervised device (iOS 9.0 and later) .</summary>
        public bool? WallpaperBlockModification {
            get { return BackingStore?.Get<bool?>("wallpaperBlockModification"); }
            set { BackingStore?.Set("wallpaperBlockModification", value); }
        }
        /// <summary>Indicates whether or not to force the device to use only Wi-Fi networks from configuration profiles when the device is in supervised mode. Available for devices running iOS and iPadOS versions 14.4 and earlier. Devices running 14.5+ should use the setting, &apos;WiFiConnectToAllowedNetworksOnlyForced.</summary>
        public bool? WiFiConnectOnlyToConfiguredNetworks {
            get { return BackingStore?.Get<bool?>("wiFiConnectOnlyToConfiguredNetworks"); }
            set { BackingStore?.Set("wiFiConnectOnlyToConfiguredNetworks", value); }
        }
        /// <summary>Require devices to use Wi-Fi networks set up via configuration profiles. Available for devices running iOS and iPadOS versions 14.5 and later.</summary>
        public bool? WiFiConnectToAllowedNetworksOnlyForced {
            get { return BackingStore?.Get<bool?>("wiFiConnectToAllowedNetworksOnlyForced"); }
            set { BackingStore?.Set("wiFiConnectToAllowedNetworksOnlyForced", value); }
        }
        /// <summary>Indicates whether or not Wi-Fi remains on, even when device is in airplane mode. Available for devices running iOS and iPadOS, versions 13.0 and later.</summary>
        public bool? WifiPowerOnForced {
            get { return BackingStore?.Get<bool?>("wifiPowerOnForced"); }
            set { BackingStore?.Set("wifiPowerOnForced", value); }
        }
        /// <summary>
        /// Instantiates a new IosGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public IosGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.iosGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountBlockModification", n => { AccountBlockModification = n.GetBoolValue(); } },
                {"activationLockAllowWhenSupervised", n => { ActivationLockAllowWhenSupervised = n.GetBoolValue(); } },
                {"airDropBlocked", n => { AirDropBlocked = n.GetBoolValue(); } },
                {"airDropForceUnmanagedDropTarget", n => { AirDropForceUnmanagedDropTarget = n.GetBoolValue(); } },
                {"airPlayForcePairingPasswordForOutgoingRequests", n => { AirPlayForcePairingPasswordForOutgoingRequests = n.GetBoolValue(); } },
                {"airPrintBlockCredentialsStorage", n => { AirPrintBlockCredentialsStorage = n.GetBoolValue(); } },
                {"airPrintBlocked", n => { AirPrintBlocked = n.GetBoolValue(); } },
                {"airPrintBlockiBeaconDiscovery", n => { AirPrintBlockiBeaconDiscovery = n.GetBoolValue(); } },
                {"airPrintForceTrustedTLS", n => { AirPrintForceTrustedTLS = n.GetBoolValue(); } },
                {"appClipsBlocked", n => { AppClipsBlocked = n.GetBoolValue(); } },
                {"appleNewsBlocked", n => { AppleNewsBlocked = n.GetBoolValue(); } },
                {"applePersonalizedAdsBlocked", n => { ApplePersonalizedAdsBlocked = n.GetBoolValue(); } },
                {"appleWatchBlockPairing", n => { AppleWatchBlockPairing = n.GetBoolValue(); } },
                {"appleWatchForceWristDetection", n => { AppleWatchForceWristDetection = n.GetBoolValue(); } },
                {"appRemovalBlocked", n => { AppRemovalBlocked = n.GetBoolValue(); } },
                {"appsSingleAppModeList", n => { AppsSingleAppModeList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"appStoreBlockAutomaticDownloads", n => { AppStoreBlockAutomaticDownloads = n.GetBoolValue(); } },
                {"appStoreBlocked", n => { AppStoreBlocked = n.GetBoolValue(); } },
                {"appStoreBlockInAppPurchases", n => { AppStoreBlockInAppPurchases = n.GetBoolValue(); } },
                {"appStoreBlockUIAppInstallation", n => { AppStoreBlockUIAppInstallation = n.GetBoolValue(); } },
                {"appStoreRequirePassword", n => { AppStoreRequirePassword = n.GetBoolValue(); } },
                {"appsVisibilityList", n => { AppsVisibilityList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"appsVisibilityListType", n => { AppsVisibilityListType = n.GetEnumValue<AppListType>(); } },
                {"autoFillForceAuthentication", n => { AutoFillForceAuthentication = n.GetBoolValue(); } },
                {"autoUnlockBlocked", n => { AutoUnlockBlocked = n.GetBoolValue(); } },
                {"blockSystemAppRemoval", n => { BlockSystemAppRemoval = n.GetBoolValue(); } },
                {"bluetoothBlockModification", n => { BluetoothBlockModification = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"cellularBlockGlobalBackgroundFetchWhileRoaming", n => { CellularBlockGlobalBackgroundFetchWhileRoaming = n.GetBoolValue(); } },
                {"cellularBlockPerAppDataModification", n => { CellularBlockPerAppDataModification = n.GetBoolValue(); } },
                {"cellularBlockPersonalHotspot", n => { CellularBlockPersonalHotspot = n.GetBoolValue(); } },
                {"cellularBlockPersonalHotspotModification", n => { CellularBlockPersonalHotspotModification = n.GetBoolValue(); } },
                {"cellularBlockPlanModification", n => { CellularBlockPlanModification = n.GetBoolValue(); } },
                {"cellularBlockVoiceRoaming", n => { CellularBlockVoiceRoaming = n.GetBoolValue(); } },
                {"certificatesBlockUntrustedTlsCertificates", n => { CertificatesBlockUntrustedTlsCertificates = n.GetBoolValue(); } },
                {"classroomAppBlockRemoteScreenObservation", n => { ClassroomAppBlockRemoteScreenObservation = n.GetBoolValue(); } },
                {"classroomAppForceUnpromptedScreenObservation", n => { ClassroomAppForceUnpromptedScreenObservation = n.GetBoolValue(); } },
                {"classroomForceAutomaticallyJoinClasses", n => { ClassroomForceAutomaticallyJoinClasses = n.GetBoolValue(); } },
                {"classroomForceRequestPermissionToLeaveClasses", n => { ClassroomForceRequestPermissionToLeaveClasses = n.GetBoolValue(); } },
                {"classroomForceUnpromptedAppAndDeviceLock", n => { ClassroomForceUnpromptedAppAndDeviceLock = n.GetBoolValue(); } },
                {"compliantAppListType", n => { CompliantAppListType = n.GetEnumValue<AppListType>(); } },
                {"compliantAppsList", n => { CompliantAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"configurationProfileBlockChanges", n => { ConfigurationProfileBlockChanges = n.GetBoolValue(); } },
                {"contactsAllowManagedToUnmanagedWrite", n => { ContactsAllowManagedToUnmanagedWrite = n.GetBoolValue(); } },
                {"contactsAllowUnmanagedToManagedRead", n => { ContactsAllowUnmanagedToManagedRead = n.GetBoolValue(); } },
                {"continuousPathKeyboardBlocked", n => { ContinuousPathKeyboardBlocked = n.GetBoolValue(); } },
                {"dateAndTimeForceSetAutomatically", n => { DateAndTimeForceSetAutomatically = n.GetBoolValue(); } },
                {"definitionLookupBlocked", n => { DefinitionLookupBlocked = n.GetBoolValue(); } },
                {"deviceBlockEnableRestrictions", n => { DeviceBlockEnableRestrictions = n.GetBoolValue(); } },
                {"deviceBlockEraseContentAndSettings", n => { DeviceBlockEraseContentAndSettings = n.GetBoolValue(); } },
                {"deviceBlockNameModification", n => { DeviceBlockNameModification = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmission", n => { DiagnosticDataBlockSubmission = n.GetBoolValue(); } },
                {"diagnosticDataBlockSubmissionModification", n => { DiagnosticDataBlockSubmissionModification = n.GetBoolValue(); } },
                {"documentsBlockManagedDocumentsInUnmanagedApps", n => { DocumentsBlockManagedDocumentsInUnmanagedApps = n.GetBoolValue(); } },
                {"documentsBlockUnmanagedDocumentsInManagedApps", n => { DocumentsBlockUnmanagedDocumentsInManagedApps = n.GetBoolValue(); } },
                {"emailInDomainSuffixes", n => { EmailInDomainSuffixes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"enterpriseAppBlockTrust", n => { EnterpriseAppBlockTrust = n.GetBoolValue(); } },
                {"enterpriseAppBlockTrustModification", n => { EnterpriseAppBlockTrustModification = n.GetBoolValue(); } },
                {"enterpriseBookBlockBackup", n => { EnterpriseBookBlockBackup = n.GetBoolValue(); } },
                {"enterpriseBookBlockMetadataSync", n => { EnterpriseBookBlockMetadataSync = n.GetBoolValue(); } },
                {"esimBlockModification", n => { EsimBlockModification = n.GetBoolValue(); } },
                {"faceTimeBlocked", n => { FaceTimeBlocked = n.GetBoolValue(); } },
                {"filesNetworkDriveAccessBlocked", n => { FilesNetworkDriveAccessBlocked = n.GetBoolValue(); } },
                {"filesUsbDriveAccessBlocked", n => { FilesUsbDriveAccessBlocked = n.GetBoolValue(); } },
                {"findMyDeviceInFindMyAppBlocked", n => { FindMyDeviceInFindMyAppBlocked = n.GetBoolValue(); } },
                {"findMyFriendsBlocked", n => { FindMyFriendsBlocked = n.GetBoolValue(); } },
                {"findMyFriendsInFindMyAppBlocked", n => { FindMyFriendsInFindMyAppBlocked = n.GetBoolValue(); } },
                {"gameCenterBlocked", n => { GameCenterBlocked = n.GetBoolValue(); } },
                {"gamingBlockGameCenterFriends", n => { GamingBlockGameCenterFriends = n.GetBoolValue(); } },
                {"gamingBlockMultiplayer", n => { GamingBlockMultiplayer = n.GetBoolValue(); } },
                {"hostPairingBlocked", n => { HostPairingBlocked = n.GetBoolValue(); } },
                {"iBooksStoreBlocked", n => { IBooksStoreBlocked = n.GetBoolValue(); } },
                {"iBooksStoreBlockErotica", n => { IBooksStoreBlockErotica = n.GetBoolValue(); } },
                {"iCloudBlockActivityContinuation", n => { ICloudBlockActivityContinuation = n.GetBoolValue(); } },
                {"iCloudBlockBackup", n => { ICloudBlockBackup = n.GetBoolValue(); } },
                {"iCloudBlockDocumentSync", n => { ICloudBlockDocumentSync = n.GetBoolValue(); } },
                {"iCloudBlockManagedAppsSync", n => { ICloudBlockManagedAppsSync = n.GetBoolValue(); } },
                {"iCloudBlockPhotoLibrary", n => { ICloudBlockPhotoLibrary = n.GetBoolValue(); } },
                {"iCloudBlockPhotoStreamSync", n => { ICloudBlockPhotoStreamSync = n.GetBoolValue(); } },
                {"iCloudBlockSharedPhotoStream", n => { ICloudBlockSharedPhotoStream = n.GetBoolValue(); } },
                {"iCloudPrivateRelayBlocked", n => { ICloudPrivateRelayBlocked = n.GetBoolValue(); } },
                {"iCloudRequireEncryptedBackup", n => { ICloudRequireEncryptedBackup = n.GetBoolValue(); } },
                {"iTunesBlocked", n => { ITunesBlocked = n.GetBoolValue(); } },
                {"iTunesBlockExplicitContent", n => { ITunesBlockExplicitContent = n.GetBoolValue(); } },
                {"iTunesBlockMusicService", n => { ITunesBlockMusicService = n.GetBoolValue(); } },
                {"iTunesBlockRadio", n => { ITunesBlockRadio = n.GetBoolValue(); } },
                {"keyboardBlockAutoCorrect", n => { KeyboardBlockAutoCorrect = n.GetBoolValue(); } },
                {"keyboardBlockDictation", n => { KeyboardBlockDictation = n.GetBoolValue(); } },
                {"keyboardBlockPredictive", n => { KeyboardBlockPredictive = n.GetBoolValue(); } },
                {"keyboardBlockShortcuts", n => { KeyboardBlockShortcuts = n.GetBoolValue(); } },
                {"keyboardBlockSpellCheck", n => { KeyboardBlockSpellCheck = n.GetBoolValue(); } },
                {"keychainBlockCloudSync", n => { KeychainBlockCloudSync = n.GetBoolValue(); } },
                {"kioskModeAllowAssistiveSpeak", n => { KioskModeAllowAssistiveSpeak = n.GetBoolValue(); } },
                {"kioskModeAllowAssistiveTouchSettings", n => { KioskModeAllowAssistiveTouchSettings = n.GetBoolValue(); } },
                {"kioskModeAllowAutoLock", n => { KioskModeAllowAutoLock = n.GetBoolValue(); } },
                {"kioskModeAllowColorInversionSettings", n => { KioskModeAllowColorInversionSettings = n.GetBoolValue(); } },
                {"kioskModeAllowRingerSwitch", n => { KioskModeAllowRingerSwitch = n.GetBoolValue(); } },
                {"kioskModeAllowScreenRotation", n => { KioskModeAllowScreenRotation = n.GetBoolValue(); } },
                {"kioskModeAllowSleepButton", n => { KioskModeAllowSleepButton = n.GetBoolValue(); } },
                {"kioskModeAllowTouchscreen", n => { KioskModeAllowTouchscreen = n.GetBoolValue(); } },
                {"kioskModeAllowVoiceControlModification", n => { KioskModeAllowVoiceControlModification = n.GetBoolValue(); } },
                {"kioskModeAllowVoiceOverSettings", n => { KioskModeAllowVoiceOverSettings = n.GetBoolValue(); } },
                {"kioskModeAllowVolumeButtons", n => { KioskModeAllowVolumeButtons = n.GetBoolValue(); } },
                {"kioskModeAllowZoomSettings", n => { KioskModeAllowZoomSettings = n.GetBoolValue(); } },
                {"kioskModeAppStoreUrl", n => { KioskModeAppStoreUrl = n.GetStringValue(); } },
                {"kioskModeAppType", n => { KioskModeAppType = n.GetEnumValue<IosKioskModeAppType>(); } },
                {"kioskModeBlockAutoLock", n => { KioskModeBlockAutoLock = n.GetBoolValue(); } },
                {"kioskModeBlockRingerSwitch", n => { KioskModeBlockRingerSwitch = n.GetBoolValue(); } },
                {"kioskModeBlockScreenRotation", n => { KioskModeBlockScreenRotation = n.GetBoolValue(); } },
                {"kioskModeBlockSleepButton", n => { KioskModeBlockSleepButton = n.GetBoolValue(); } },
                {"kioskModeBlockTouchscreen", n => { KioskModeBlockTouchscreen = n.GetBoolValue(); } },
                {"kioskModeBlockVolumeButtons", n => { KioskModeBlockVolumeButtons = n.GetBoolValue(); } },
                {"kioskModeBuiltInAppId", n => { KioskModeBuiltInAppId = n.GetStringValue(); } },
                {"kioskModeEnableVoiceControl", n => { KioskModeEnableVoiceControl = n.GetBoolValue(); } },
                {"kioskModeManagedAppId", n => { KioskModeManagedAppId = n.GetStringValue(); } },
                {"kioskModeRequireAssistiveTouch", n => { KioskModeRequireAssistiveTouch = n.GetBoolValue(); } },
                {"kioskModeRequireColorInversion", n => { KioskModeRequireColorInversion = n.GetBoolValue(); } },
                {"kioskModeRequireMonoAudio", n => { KioskModeRequireMonoAudio = n.GetBoolValue(); } },
                {"kioskModeRequireVoiceOver", n => { KioskModeRequireVoiceOver = n.GetBoolValue(); } },
                {"kioskModeRequireZoom", n => { KioskModeRequireZoom = n.GetBoolValue(); } },
                {"lockScreenBlockControlCenter", n => { LockScreenBlockControlCenter = n.GetBoolValue(); } },
                {"lockScreenBlockNotificationView", n => { LockScreenBlockNotificationView = n.GetBoolValue(); } },
                {"lockScreenBlockPassbook", n => { LockScreenBlockPassbook = n.GetBoolValue(); } },
                {"lockScreenBlockTodayView", n => { LockScreenBlockTodayView = n.GetBoolValue(); } },
                {"managedPasteboardRequired", n => { ManagedPasteboardRequired = n.GetBoolValue(); } },
                {"mediaContentRatingApps", n => { MediaContentRatingApps = n.GetEnumValue<RatingAppsType>(); } },
                {"mediaContentRatingAustralia", n => { MediaContentRatingAustralia = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingAustralia>(Microsoft.Graph.Beta.Models.MediaContentRatingAustralia.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingCanada", n => { MediaContentRatingCanada = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingCanada>(Microsoft.Graph.Beta.Models.MediaContentRatingCanada.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingFrance", n => { MediaContentRatingFrance = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingFrance>(Microsoft.Graph.Beta.Models.MediaContentRatingFrance.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingGermany", n => { MediaContentRatingGermany = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingGermany>(Microsoft.Graph.Beta.Models.MediaContentRatingGermany.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingIreland", n => { MediaContentRatingIreland = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingIreland>(Microsoft.Graph.Beta.Models.MediaContentRatingIreland.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingJapan", n => { MediaContentRatingJapan = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingJapan>(Microsoft.Graph.Beta.Models.MediaContentRatingJapan.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingNewZealand", n => { MediaContentRatingNewZealand = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingNewZealand>(Microsoft.Graph.Beta.Models.MediaContentRatingNewZealand.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingUnitedKingdom", n => { MediaContentRatingUnitedKingdom = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingUnitedKingdom>(Microsoft.Graph.Beta.Models.MediaContentRatingUnitedKingdom.CreateFromDiscriminatorValue); } },
                {"mediaContentRatingUnitedStates", n => { MediaContentRatingUnitedStates = n.GetObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingUnitedStates>(Microsoft.Graph.Beta.Models.MediaContentRatingUnitedStates.CreateFromDiscriminatorValue); } },
                {"messagesBlocked", n => { MessagesBlocked = n.GetBoolValue(); } },
                {"networkUsageRules", n => { NetworkUsageRules = n.GetCollectionOfObjectValues<IosNetworkUsageRule>(IosNetworkUsageRule.CreateFromDiscriminatorValue).ToList(); } },
                {"nfcBlocked", n => { NfcBlocked = n.GetBoolValue(); } },
                {"notificationsBlockSettingsModification", n => { NotificationsBlockSettingsModification = n.GetBoolValue(); } },
                {"onDeviceOnlyDictationForced", n => { OnDeviceOnlyDictationForced = n.GetBoolValue(); } },
                {"onDeviceOnlyTranslationForced", n => { OnDeviceOnlyTranslationForced = n.GetBoolValue(); } },
                {"passcodeBlockFingerprintModification", n => { PasscodeBlockFingerprintModification = n.GetBoolValue(); } },
                {"passcodeBlockFingerprintUnlock", n => { PasscodeBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passcodeBlockModification", n => { PasscodeBlockModification = n.GetBoolValue(); } },
                {"passcodeBlockSimple", n => { PasscodeBlockSimple = n.GetBoolValue(); } },
                {"passcodeExpirationDays", n => { PasscodeExpirationDays = n.GetIntValue(); } },
                {"passcodeMinimumCharacterSetCount", n => { PasscodeMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passcodeMinimumLength", n => { PasscodeMinimumLength = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeLock", n => { PasscodeMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeScreenTimeout", n => { PasscodeMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passcodePreviousPasscodeBlockCount", n => { PasscodePreviousPasscodeBlockCount = n.GetIntValue(); } },
                {"passcodeRequired", n => { PasscodeRequired = n.GetBoolValue(); } },
                {"passcodeRequiredType", n => { PasscodeRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passcodeSignInFailureCountBeforeWipe", n => { PasscodeSignInFailureCountBeforeWipe = n.GetIntValue(); } },
                {"passwordBlockAirDropSharing", n => { PasswordBlockAirDropSharing = n.GetBoolValue(); } },
                {"passwordBlockAutoFill", n => { PasswordBlockAutoFill = n.GetBoolValue(); } },
                {"passwordBlockProximityRequests", n => { PasswordBlockProximityRequests = n.GetBoolValue(); } },
                {"pkiBlockOTAUpdates", n => { PkiBlockOTAUpdates = n.GetBoolValue(); } },
                {"podcastsBlocked", n => { PodcastsBlocked = n.GetBoolValue(); } },
                {"privacyForceLimitAdTracking", n => { PrivacyForceLimitAdTracking = n.GetBoolValue(); } },
                {"proximityBlockSetupToNewDevice", n => { ProximityBlockSetupToNewDevice = n.GetBoolValue(); } },
                {"safariBlockAutofill", n => { SafariBlockAutofill = n.GetBoolValue(); } },
                {"safariBlocked", n => { SafariBlocked = n.GetBoolValue(); } },
                {"safariBlockJavaScript", n => { SafariBlockJavaScript = n.GetBoolValue(); } },
                {"safariBlockPopups", n => { SafariBlockPopups = n.GetBoolValue(); } },
                {"safariCookieSettings", n => { SafariCookieSettings = n.GetEnumValue<WebBrowserCookieSettings>(); } },
                {"safariManagedDomains", n => { SafariManagedDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"safariPasswordAutoFillDomains", n => { SafariPasswordAutoFillDomains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"safariRequireFraudWarning", n => { SafariRequireFraudWarning = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"sharedDeviceBlockTemporarySessions", n => { SharedDeviceBlockTemporarySessions = n.GetBoolValue(); } },
                {"siriBlocked", n => { SiriBlocked = n.GetBoolValue(); } },
                {"siriBlockedWhenLocked", n => { SiriBlockedWhenLocked = n.GetBoolValue(); } },
                {"siriBlockUserGeneratedContent", n => { SiriBlockUserGeneratedContent = n.GetBoolValue(); } },
                {"siriRequireProfanityFilter", n => { SiriRequireProfanityFilter = n.GetBoolValue(); } },
                {"softwareUpdatesEnforcedDelayInDays", n => { SoftwareUpdatesEnforcedDelayInDays = n.GetIntValue(); } },
                {"softwareUpdatesForceDelayed", n => { SoftwareUpdatesForceDelayed = n.GetBoolValue(); } },
                {"spotlightBlockInternetResults", n => { SpotlightBlockInternetResults = n.GetBoolValue(); } },
                {"unpairedExternalBootToRecoveryAllowed", n => { UnpairedExternalBootToRecoveryAllowed = n.GetBoolValue(); } },
                {"usbRestrictedModeBlocked", n => { UsbRestrictedModeBlocked = n.GetBoolValue(); } },
                {"voiceDialingBlocked", n => { VoiceDialingBlocked = n.GetBoolValue(); } },
                {"vpnBlockCreation", n => { VpnBlockCreation = n.GetBoolValue(); } },
                {"wallpaperBlockModification", n => { WallpaperBlockModification = n.GetBoolValue(); } },
                {"wiFiConnectOnlyToConfiguredNetworks", n => { WiFiConnectOnlyToConfiguredNetworks = n.GetBoolValue(); } },
                {"wiFiConnectToAllowedNetworksOnlyForced", n => { WiFiConnectToAllowedNetworksOnlyForced = n.GetBoolValue(); } },
                {"wifiPowerOnForced", n => { WifiPowerOnForced = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountBlockModification", AccountBlockModification);
            writer.WriteBoolValue("activationLockAllowWhenSupervised", ActivationLockAllowWhenSupervised);
            writer.WriteBoolValue("airDropBlocked", AirDropBlocked);
            writer.WriteBoolValue("airDropForceUnmanagedDropTarget", AirDropForceUnmanagedDropTarget);
            writer.WriteBoolValue("airPlayForcePairingPasswordForOutgoingRequests", AirPlayForcePairingPasswordForOutgoingRequests);
            writer.WriteBoolValue("airPrintBlockCredentialsStorage", AirPrintBlockCredentialsStorage);
            writer.WriteBoolValue("airPrintBlocked", AirPrintBlocked);
            writer.WriteBoolValue("airPrintBlockiBeaconDiscovery", AirPrintBlockiBeaconDiscovery);
            writer.WriteBoolValue("airPrintForceTrustedTLS", AirPrintForceTrustedTLS);
            writer.WriteBoolValue("appClipsBlocked", AppClipsBlocked);
            writer.WriteBoolValue("appleNewsBlocked", AppleNewsBlocked);
            writer.WriteBoolValue("applePersonalizedAdsBlocked", ApplePersonalizedAdsBlocked);
            writer.WriteBoolValue("appleWatchBlockPairing", AppleWatchBlockPairing);
            writer.WriteBoolValue("appleWatchForceWristDetection", AppleWatchForceWristDetection);
            writer.WriteBoolValue("appRemovalBlocked", AppRemovalBlocked);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsSingleAppModeList", AppsSingleAppModeList);
            writer.WriteBoolValue("appStoreBlockAutomaticDownloads", AppStoreBlockAutomaticDownloads);
            writer.WriteBoolValue("appStoreBlocked", AppStoreBlocked);
            writer.WriteBoolValue("appStoreBlockInAppPurchases", AppStoreBlockInAppPurchases);
            writer.WriteBoolValue("appStoreBlockUIAppInstallation", AppStoreBlockUIAppInstallation);
            writer.WriteBoolValue("appStoreRequirePassword", AppStoreRequirePassword);
            writer.WriteCollectionOfObjectValues<AppListItem>("appsVisibilityList", AppsVisibilityList);
            writer.WriteEnumValue<AppListType>("appsVisibilityListType", AppsVisibilityListType);
            writer.WriteBoolValue("autoFillForceAuthentication", AutoFillForceAuthentication);
            writer.WriteBoolValue("autoUnlockBlocked", AutoUnlockBlocked);
            writer.WriteBoolValue("blockSystemAppRemoval", BlockSystemAppRemoval);
            writer.WriteBoolValue("bluetoothBlockModification", BluetoothBlockModification);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("cellularBlockGlobalBackgroundFetchWhileRoaming", CellularBlockGlobalBackgroundFetchWhileRoaming);
            writer.WriteBoolValue("cellularBlockPerAppDataModification", CellularBlockPerAppDataModification);
            writer.WriteBoolValue("cellularBlockPersonalHotspot", CellularBlockPersonalHotspot);
            writer.WriteBoolValue("cellularBlockPersonalHotspotModification", CellularBlockPersonalHotspotModification);
            writer.WriteBoolValue("cellularBlockPlanModification", CellularBlockPlanModification);
            writer.WriteBoolValue("cellularBlockVoiceRoaming", CellularBlockVoiceRoaming);
            writer.WriteBoolValue("certificatesBlockUntrustedTlsCertificates", CertificatesBlockUntrustedTlsCertificates);
            writer.WriteBoolValue("classroomAppBlockRemoteScreenObservation", ClassroomAppBlockRemoteScreenObservation);
            writer.WriteBoolValue("classroomAppForceUnpromptedScreenObservation", ClassroomAppForceUnpromptedScreenObservation);
            writer.WriteBoolValue("classroomForceAutomaticallyJoinClasses", ClassroomForceAutomaticallyJoinClasses);
            writer.WriteBoolValue("classroomForceRequestPermissionToLeaveClasses", ClassroomForceRequestPermissionToLeaveClasses);
            writer.WriteBoolValue("classroomForceUnpromptedAppAndDeviceLock", ClassroomForceUnpromptedAppAndDeviceLock);
            writer.WriteEnumValue<AppListType>("compliantAppListType", CompliantAppListType);
            writer.WriteCollectionOfObjectValues<AppListItem>("compliantAppsList", CompliantAppsList);
            writer.WriteBoolValue("configurationProfileBlockChanges", ConfigurationProfileBlockChanges);
            writer.WriteBoolValue("contactsAllowManagedToUnmanagedWrite", ContactsAllowManagedToUnmanagedWrite);
            writer.WriteBoolValue("contactsAllowUnmanagedToManagedRead", ContactsAllowUnmanagedToManagedRead);
            writer.WriteBoolValue("continuousPathKeyboardBlocked", ContinuousPathKeyboardBlocked);
            writer.WriteBoolValue("dateAndTimeForceSetAutomatically", DateAndTimeForceSetAutomatically);
            writer.WriteBoolValue("definitionLookupBlocked", DefinitionLookupBlocked);
            writer.WriteBoolValue("deviceBlockEnableRestrictions", DeviceBlockEnableRestrictions);
            writer.WriteBoolValue("deviceBlockEraseContentAndSettings", DeviceBlockEraseContentAndSettings);
            writer.WriteBoolValue("deviceBlockNameModification", DeviceBlockNameModification);
            writer.WriteBoolValue("diagnosticDataBlockSubmission", DiagnosticDataBlockSubmission);
            writer.WriteBoolValue("diagnosticDataBlockSubmissionModification", DiagnosticDataBlockSubmissionModification);
            writer.WriteBoolValue("documentsBlockManagedDocumentsInUnmanagedApps", DocumentsBlockManagedDocumentsInUnmanagedApps);
            writer.WriteBoolValue("documentsBlockUnmanagedDocumentsInManagedApps", DocumentsBlockUnmanagedDocumentsInManagedApps);
            writer.WriteCollectionOfPrimitiveValues<string>("emailInDomainSuffixes", EmailInDomainSuffixes);
            writer.WriteBoolValue("enterpriseAppBlockTrust", EnterpriseAppBlockTrust);
            writer.WriteBoolValue("enterpriseAppBlockTrustModification", EnterpriseAppBlockTrustModification);
            writer.WriteBoolValue("enterpriseBookBlockBackup", EnterpriseBookBlockBackup);
            writer.WriteBoolValue("enterpriseBookBlockMetadataSync", EnterpriseBookBlockMetadataSync);
            writer.WriteBoolValue("esimBlockModification", EsimBlockModification);
            writer.WriteBoolValue("faceTimeBlocked", FaceTimeBlocked);
            writer.WriteBoolValue("filesNetworkDriveAccessBlocked", FilesNetworkDriveAccessBlocked);
            writer.WriteBoolValue("filesUsbDriveAccessBlocked", FilesUsbDriveAccessBlocked);
            writer.WriteBoolValue("findMyDeviceInFindMyAppBlocked", FindMyDeviceInFindMyAppBlocked);
            writer.WriteBoolValue("findMyFriendsBlocked", FindMyFriendsBlocked);
            writer.WriteBoolValue("findMyFriendsInFindMyAppBlocked", FindMyFriendsInFindMyAppBlocked);
            writer.WriteBoolValue("gameCenterBlocked", GameCenterBlocked);
            writer.WriteBoolValue("gamingBlockGameCenterFriends", GamingBlockGameCenterFriends);
            writer.WriteBoolValue("gamingBlockMultiplayer", GamingBlockMultiplayer);
            writer.WriteBoolValue("hostPairingBlocked", HostPairingBlocked);
            writer.WriteBoolValue("iBooksStoreBlocked", IBooksStoreBlocked);
            writer.WriteBoolValue("iBooksStoreBlockErotica", IBooksStoreBlockErotica);
            writer.WriteBoolValue("iCloudBlockActivityContinuation", ICloudBlockActivityContinuation);
            writer.WriteBoolValue("iCloudBlockBackup", ICloudBlockBackup);
            writer.WriteBoolValue("iCloudBlockDocumentSync", ICloudBlockDocumentSync);
            writer.WriteBoolValue("iCloudBlockManagedAppsSync", ICloudBlockManagedAppsSync);
            writer.WriteBoolValue("iCloudBlockPhotoLibrary", ICloudBlockPhotoLibrary);
            writer.WriteBoolValue("iCloudBlockPhotoStreamSync", ICloudBlockPhotoStreamSync);
            writer.WriteBoolValue("iCloudBlockSharedPhotoStream", ICloudBlockSharedPhotoStream);
            writer.WriteBoolValue("iCloudPrivateRelayBlocked", ICloudPrivateRelayBlocked);
            writer.WriteBoolValue("iCloudRequireEncryptedBackup", ICloudRequireEncryptedBackup);
            writer.WriteBoolValue("iTunesBlocked", ITunesBlocked);
            writer.WriteBoolValue("iTunesBlockExplicitContent", ITunesBlockExplicitContent);
            writer.WriteBoolValue("iTunesBlockMusicService", ITunesBlockMusicService);
            writer.WriteBoolValue("iTunesBlockRadio", ITunesBlockRadio);
            writer.WriteBoolValue("keyboardBlockAutoCorrect", KeyboardBlockAutoCorrect);
            writer.WriteBoolValue("keyboardBlockDictation", KeyboardBlockDictation);
            writer.WriteBoolValue("keyboardBlockPredictive", KeyboardBlockPredictive);
            writer.WriteBoolValue("keyboardBlockShortcuts", KeyboardBlockShortcuts);
            writer.WriteBoolValue("keyboardBlockSpellCheck", KeyboardBlockSpellCheck);
            writer.WriteBoolValue("keychainBlockCloudSync", KeychainBlockCloudSync);
            writer.WriteBoolValue("kioskModeAllowAssistiveSpeak", KioskModeAllowAssistiveSpeak);
            writer.WriteBoolValue("kioskModeAllowAssistiveTouchSettings", KioskModeAllowAssistiveTouchSettings);
            writer.WriteBoolValue("kioskModeAllowAutoLock", KioskModeAllowAutoLock);
            writer.WriteBoolValue("kioskModeAllowColorInversionSettings", KioskModeAllowColorInversionSettings);
            writer.WriteBoolValue("kioskModeAllowRingerSwitch", KioskModeAllowRingerSwitch);
            writer.WriteBoolValue("kioskModeAllowScreenRotation", KioskModeAllowScreenRotation);
            writer.WriteBoolValue("kioskModeAllowSleepButton", KioskModeAllowSleepButton);
            writer.WriteBoolValue("kioskModeAllowTouchscreen", KioskModeAllowTouchscreen);
            writer.WriteBoolValue("kioskModeAllowVoiceControlModification", KioskModeAllowVoiceControlModification);
            writer.WriteBoolValue("kioskModeAllowVoiceOverSettings", KioskModeAllowVoiceOverSettings);
            writer.WriteBoolValue("kioskModeAllowVolumeButtons", KioskModeAllowVolumeButtons);
            writer.WriteBoolValue("kioskModeAllowZoomSettings", KioskModeAllowZoomSettings);
            writer.WriteStringValue("kioskModeAppStoreUrl", KioskModeAppStoreUrl);
            writer.WriteEnumValue<IosKioskModeAppType>("kioskModeAppType", KioskModeAppType);
            writer.WriteBoolValue("kioskModeBlockAutoLock", KioskModeBlockAutoLock);
            writer.WriteBoolValue("kioskModeBlockRingerSwitch", KioskModeBlockRingerSwitch);
            writer.WriteBoolValue("kioskModeBlockScreenRotation", KioskModeBlockScreenRotation);
            writer.WriteBoolValue("kioskModeBlockSleepButton", KioskModeBlockSleepButton);
            writer.WriteBoolValue("kioskModeBlockTouchscreen", KioskModeBlockTouchscreen);
            writer.WriteBoolValue("kioskModeBlockVolumeButtons", KioskModeBlockVolumeButtons);
            writer.WriteStringValue("kioskModeBuiltInAppId", KioskModeBuiltInAppId);
            writer.WriteBoolValue("kioskModeEnableVoiceControl", KioskModeEnableVoiceControl);
            writer.WriteStringValue("kioskModeManagedAppId", KioskModeManagedAppId);
            writer.WriteBoolValue("kioskModeRequireAssistiveTouch", KioskModeRequireAssistiveTouch);
            writer.WriteBoolValue("kioskModeRequireColorInversion", KioskModeRequireColorInversion);
            writer.WriteBoolValue("kioskModeRequireMonoAudio", KioskModeRequireMonoAudio);
            writer.WriteBoolValue("kioskModeRequireVoiceOver", KioskModeRequireVoiceOver);
            writer.WriteBoolValue("kioskModeRequireZoom", KioskModeRequireZoom);
            writer.WriteBoolValue("lockScreenBlockControlCenter", LockScreenBlockControlCenter);
            writer.WriteBoolValue("lockScreenBlockNotificationView", LockScreenBlockNotificationView);
            writer.WriteBoolValue("lockScreenBlockPassbook", LockScreenBlockPassbook);
            writer.WriteBoolValue("lockScreenBlockTodayView", LockScreenBlockTodayView);
            writer.WriteBoolValue("managedPasteboardRequired", ManagedPasteboardRequired);
            writer.WriteEnumValue<RatingAppsType>("mediaContentRatingApps", MediaContentRatingApps);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingAustralia>("mediaContentRatingAustralia", MediaContentRatingAustralia);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingCanada>("mediaContentRatingCanada", MediaContentRatingCanada);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingFrance>("mediaContentRatingFrance", MediaContentRatingFrance);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingGermany>("mediaContentRatingGermany", MediaContentRatingGermany);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingIreland>("mediaContentRatingIreland", MediaContentRatingIreland);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingJapan>("mediaContentRatingJapan", MediaContentRatingJapan);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingNewZealand>("mediaContentRatingNewZealand", MediaContentRatingNewZealand);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingUnitedKingdom>("mediaContentRatingUnitedKingdom", MediaContentRatingUnitedKingdom);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MediaContentRatingUnitedStates>("mediaContentRatingUnitedStates", MediaContentRatingUnitedStates);
            writer.WriteBoolValue("messagesBlocked", MessagesBlocked);
            writer.WriteCollectionOfObjectValues<IosNetworkUsageRule>("networkUsageRules", NetworkUsageRules);
            writer.WriteBoolValue("nfcBlocked", NfcBlocked);
            writer.WriteBoolValue("notificationsBlockSettingsModification", NotificationsBlockSettingsModification);
            writer.WriteBoolValue("onDeviceOnlyDictationForced", OnDeviceOnlyDictationForced);
            writer.WriteBoolValue("onDeviceOnlyTranslationForced", OnDeviceOnlyTranslationForced);
            writer.WriteBoolValue("passcodeBlockFingerprintModification", PasscodeBlockFingerprintModification);
            writer.WriteBoolValue("passcodeBlockFingerprintUnlock", PasscodeBlockFingerprintUnlock);
            writer.WriteBoolValue("passcodeBlockModification", PasscodeBlockModification);
            writer.WriteBoolValue("passcodeBlockSimple", PasscodeBlockSimple);
            writer.WriteIntValue("passcodeExpirationDays", PasscodeExpirationDays);
            writer.WriteIntValue("passcodeMinimumCharacterSetCount", PasscodeMinimumCharacterSetCount);
            writer.WriteIntValue("passcodeMinimumLength", PasscodeMinimumLength);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeLock", PasscodeMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeScreenTimeout", PasscodeMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passcodePreviousPasscodeBlockCount", PasscodePreviousPasscodeBlockCount);
            writer.WriteBoolValue("passcodeRequired", PasscodeRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passcodeRequiredType", PasscodeRequiredType);
            writer.WriteIntValue("passcodeSignInFailureCountBeforeWipe", PasscodeSignInFailureCountBeforeWipe);
            writer.WriteBoolValue("passwordBlockAirDropSharing", PasswordBlockAirDropSharing);
            writer.WriteBoolValue("passwordBlockAutoFill", PasswordBlockAutoFill);
            writer.WriteBoolValue("passwordBlockProximityRequests", PasswordBlockProximityRequests);
            writer.WriteBoolValue("pkiBlockOTAUpdates", PkiBlockOTAUpdates);
            writer.WriteBoolValue("podcastsBlocked", PodcastsBlocked);
            writer.WriteBoolValue("privacyForceLimitAdTracking", PrivacyForceLimitAdTracking);
            writer.WriteBoolValue("proximityBlockSetupToNewDevice", ProximityBlockSetupToNewDevice);
            writer.WriteBoolValue("safariBlockAutofill", SafariBlockAutofill);
            writer.WriteBoolValue("safariBlocked", SafariBlocked);
            writer.WriteBoolValue("safariBlockJavaScript", SafariBlockJavaScript);
            writer.WriteBoolValue("safariBlockPopups", SafariBlockPopups);
            writer.WriteEnumValue<WebBrowserCookieSettings>("safariCookieSettings", SafariCookieSettings);
            writer.WriteCollectionOfPrimitiveValues<string>("safariManagedDomains", SafariManagedDomains);
            writer.WriteCollectionOfPrimitiveValues<string>("safariPasswordAutoFillDomains", SafariPasswordAutoFillDomains);
            writer.WriteBoolValue("safariRequireFraudWarning", SafariRequireFraudWarning);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteBoolValue("sharedDeviceBlockTemporarySessions", SharedDeviceBlockTemporarySessions);
            writer.WriteBoolValue("siriBlocked", SiriBlocked);
            writer.WriteBoolValue("siriBlockedWhenLocked", SiriBlockedWhenLocked);
            writer.WriteBoolValue("siriBlockUserGeneratedContent", SiriBlockUserGeneratedContent);
            writer.WriteBoolValue("siriRequireProfanityFilter", SiriRequireProfanityFilter);
            writer.WriteIntValue("softwareUpdatesEnforcedDelayInDays", SoftwareUpdatesEnforcedDelayInDays);
            writer.WriteBoolValue("softwareUpdatesForceDelayed", SoftwareUpdatesForceDelayed);
            writer.WriteBoolValue("spotlightBlockInternetResults", SpotlightBlockInternetResults);
            writer.WriteBoolValue("unpairedExternalBootToRecoveryAllowed", UnpairedExternalBootToRecoveryAllowed);
            writer.WriteBoolValue("usbRestrictedModeBlocked", UsbRestrictedModeBlocked);
            writer.WriteBoolValue("voiceDialingBlocked", VoiceDialingBlocked);
            writer.WriteBoolValue("vpnBlockCreation", VpnBlockCreation);
            writer.WriteBoolValue("wallpaperBlockModification", WallpaperBlockModification);
            writer.WriteBoolValue("wiFiConnectOnlyToConfiguredNetworks", WiFiConnectOnlyToConfiguredNetworks);
            writer.WriteBoolValue("wiFiConnectToAllowedNetworksOnlyForced", WiFiConnectToAllowedNetworksOnlyForced);
            writer.WriteBoolValue("wifiPowerOnForced", WifiPowerOnForced);
        }
    }
}
