using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Yes prevents users from adding friends to Game Center. Available for devices running macOS versions 10.13 and later.</summary>
        public bool? AddingGameCenterFriendsBlocked {
            get { return BackingStore?.Get<bool?>("addingGameCenterFriendsBlocked"); }
            set { BackingStore?.Set("addingGameCenterFriendsBlocked", value); }
        }
        /// <summary>Indicates whether or not to allow AirDrop.</summary>
        public bool? AirDropBlocked {
            get { return BackingStore?.Get<bool?>("airDropBlocked"); }
            set { BackingStore?.Set("airDropBlocked", value); }
        }
        /// <summary>Indicates whether or to block users from unlocking their Mac with Apple Watch.</summary>
        public bool? AppleWatchBlockAutoUnlock {
            get { return BackingStore?.Get<bool?>("appleWatchBlockAutoUnlock"); }
            set { BackingStore?.Set("appleWatchBlockAutoUnlock", value); }
        }
        /// <summary>Indicates whether or not to block the user from accessing the camera of the device.</summary>
        public bool? CameraBlocked {
            get { return BackingStore?.Get<bool?>("cameraBlocked"); }
            set { BackingStore?.Set("cameraBlocked", value); }
        }
        /// <summary>Indicates whether or not to allow remote screen observation by Classroom app. Requires MDM enrollment via Apple School Manager or Apple Business Manager.</summary>
        public bool? ClassroomAppBlockRemoteScreenObservation {
            get { return BackingStore?.Get<bool?>("classroomAppBlockRemoteScreenObservation"); }
            set { BackingStore?.Set("classroomAppBlockRemoteScreenObservation", value); }
        }
        /// <summary>Indicates whether or not to automatically give permission to the teacher of a managed course on the Classroom app to view a student&apos;s screen without prompting. Requires MDM enrollment via Apple School Manager or Apple Business Manager.</summary>
        public bool? ClassroomAppForceUnpromptedScreenObservation {
            get { return BackingStore?.Get<bool?>("classroomAppForceUnpromptedScreenObservation"); }
            set { BackingStore?.Set("classroomAppForceUnpromptedScreenObservation", value); }
        }
        /// <summary>Indicates whether or not to automatically give permission to the teacher&apos;s requests, without prompting the student. Requires MDM enrollment via Apple School Manager or Apple Business Manager.</summary>
        public bool? ClassroomForceAutomaticallyJoinClasses {
            get { return BackingStore?.Get<bool?>("classroomForceAutomaticallyJoinClasses"); }
            set { BackingStore?.Set("classroomForceAutomaticallyJoinClasses", value); }
        }
        /// <summary>Indicates whether a student enrolled in an unmanaged course via Classroom will be required to request permission from the teacher when attempting to leave the course. Requires MDM enrollment via Apple School Manager or Apple Business Manager.</summary>
        public bool? ClassroomForceRequestPermissionToLeaveClasses {
            get { return BackingStore?.Get<bool?>("classroomForceRequestPermissionToLeaveClasses"); }
            set { BackingStore?.Set("classroomForceRequestPermissionToLeaveClasses", value); }
        }
        /// <summary>Indicates whether or not to allow the teacher to lock apps or the device without prompting the student. Requires MDM enrollment via Apple School Manager or Apple Business Manager.</summary>
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppListItem>? CompliantAppsList {
            get { return BackingStore?.Get<List<AppListItem>?>("compliantAppsList"); }
            set { BackingStore?.Set("compliantAppsList", value); }
        }
#nullable restore
#else
        public List<AppListItem> CompliantAppsList {
            get { return BackingStore?.Get<List<AppListItem>>("compliantAppsList"); }
            set { BackingStore?.Set("compliantAppsList", value); }
        }
#endif
        /// <summary>Indicates whether or not to allow content caching.</summary>
        public bool? ContentCachingBlocked {
            get { return BackingStore?.Get<bool?>("contentCachingBlocked"); }
            set { BackingStore?.Set("contentCachingBlocked", value); }
        }
        /// <summary>Indicates whether or not to block definition lookup.</summary>
        public bool? DefinitionLookupBlocked {
            get { return BackingStore?.Get<bool?>("definitionLookupBlocked"); }
            set { BackingStore?.Set("definitionLookupBlocked", value); }
        }
        /// <summary>An email address lacking a suffix that matches any of these strings will be considered out-of-domain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EmailInDomainSuffixes {
            get { return BackingStore?.Get<List<string>?>("emailInDomainSuffixes"); }
            set { BackingStore?.Set("emailInDomainSuffixes", value); }
        }
#nullable restore
#else
        public List<string> EmailInDomainSuffixes {
            get { return BackingStore?.Get<List<string>>("emailInDomainSuffixes"); }
            set { BackingStore?.Set("emailInDomainSuffixes", value); }
        }
#endif
        /// <summary>TRUE disables the reset option on supervised devices. FALSE enables the reset option on supervised devices. Available for devices running macOS versions 12.0 and later.</summary>
        public bool? EraseContentAndSettingsBlocked {
            get { return BackingStore?.Get<bool?>("eraseContentAndSettingsBlocked"); }
            set { BackingStore?.Set("eraseContentAndSettingsBlocked", value); }
        }
        /// <summary>Yes disables Game Center, and the Game Center icon is removed from the Home screen. Available for devices running macOS versions 10.13 and later.</summary>
        public bool? GameCenterBlocked {
            get { return BackingStore?.Get<bool?>("gameCenterBlocked"); }
            set { BackingStore?.Set("gameCenterBlocked", value); }
        }
        /// <summary>Indicates whether or not to block the user from continuing work that they started on a MacOS device on another iOS or MacOS device (MacOS 10.15 or later).</summary>
        public bool? ICloudBlockActivityContinuation {
            get { return BackingStore?.Get<bool?>("iCloudBlockActivityContinuation"); }
            set { BackingStore?.Set("iCloudBlockActivityContinuation", value); }
        }
        /// <summary>Indicates whether or not to block iCloud from syncing contacts.</summary>
        public bool? ICloudBlockAddressBook {
            get { return BackingStore?.Get<bool?>("iCloudBlockAddressBook"); }
            set { BackingStore?.Set("iCloudBlockAddressBook", value); }
        }
        /// <summary>Indicates whether or not to block iCloud from syncing bookmarks.</summary>
        public bool? ICloudBlockBookmarks {
            get { return BackingStore?.Get<bool?>("iCloudBlockBookmarks"); }
            set { BackingStore?.Set("iCloudBlockBookmarks", value); }
        }
        /// <summary>Indicates whether or not to block iCloud from syncing calendars.</summary>
        public bool? ICloudBlockCalendar {
            get { return BackingStore?.Get<bool?>("iCloudBlockCalendar"); }
            set { BackingStore?.Set("iCloudBlockCalendar", value); }
        }
        /// <summary>Indicates whether or not to block iCloud document sync.</summary>
        public bool? ICloudBlockDocumentSync {
            get { return BackingStore?.Get<bool?>("iCloudBlockDocumentSync"); }
            set { BackingStore?.Set("iCloudBlockDocumentSync", value); }
        }
        /// <summary>Indicates whether or not to block iCloud from syncing mail.</summary>
        public bool? ICloudBlockMail {
            get { return BackingStore?.Get<bool?>("iCloudBlockMail"); }
            set { BackingStore?.Set("iCloudBlockMail", value); }
        }
        /// <summary>Indicates whether or not to block iCloud from syncing notes.</summary>
        public bool? ICloudBlockNotes {
            get { return BackingStore?.Get<bool?>("iCloudBlockNotes"); }
            set { BackingStore?.Set("iCloudBlockNotes", value); }
        }
        /// <summary>Indicates whether or not to block iCloud Photo Library.</summary>
        public bool? ICloudBlockPhotoLibrary {
            get { return BackingStore?.Get<bool?>("iCloudBlockPhotoLibrary"); }
            set { BackingStore?.Set("iCloudBlockPhotoLibrary", value); }
        }
        /// <summary>Indicates whether or not to block iCloud from syncing reminders.</summary>
        public bool? ICloudBlockReminders {
            get { return BackingStore?.Get<bool?>("iCloudBlockReminders"); }
            set { BackingStore?.Set("iCloudBlockReminders", value); }
        }
        /// <summary>When TRUE the synchronization of cloud desktop and documents is blocked. When FALSE, synchronization of the cloud desktop and documents are allowed. Available for devices running macOS 10.12.4 and later.</summary>
        public bool? ICloudDesktopAndDocumentsBlocked {
            get { return BackingStore?.Get<bool?>("iCloudDesktopAndDocumentsBlocked"); }
            set { BackingStore?.Set("iCloudDesktopAndDocumentsBlocked", value); }
        }
        /// <summary>iCloud private relay is an iCloud+ service that prevents networks and servers from monitoring a person&apos;s activity across the internet. By blocking iCloud private relay, Apple will not encrypt the traffic leaving the device. Available for devices running macOS 12 and later.</summary>
        public bool? ICloudPrivateRelayBlocked {
            get { return BackingStore?.Get<bool?>("iCloudPrivateRelayBlocked"); }
            set { BackingStore?.Set("iCloudPrivateRelayBlocked", value); }
        }
        /// <summary>Indicates whether or not to block files from being transferred using iTunes.</summary>
        public bool? ITunesBlockFileSharing {
            get { return BackingStore?.Get<bool?>("iTunesBlockFileSharing"); }
            set { BackingStore?.Set("iTunesBlockFileSharing", value); }
        }
        /// <summary>Indicates whether or not to block Music service and revert Music app to classic mode.</summary>
        public bool? ITunesBlockMusicService {
            get { return BackingStore?.Get<bool?>("iTunesBlockMusicService"); }
            set { BackingStore?.Set("iTunesBlockMusicService", value); }
        }
        /// <summary>Indicates whether or not to block the user from using dictation input.</summary>
        public bool? KeyboardBlockDictation {
            get { return BackingStore?.Get<bool?>("keyboardBlockDictation"); }
            set { BackingStore?.Set("keyboardBlockDictation", value); }
        }
        /// <summary>Indicates whether or not iCloud keychain synchronization is blocked (macOS 10.12 and later).</summary>
        public bool? KeychainBlockCloudSync {
            get { return BackingStore?.Get<bool?>("keychainBlockCloudSync"); }
            set { BackingStore?.Set("keychainBlockCloudSync", value); }
        }
        /// <summary>TRUE prevents multiplayer gaming when using Game Center. FALSE allows multiplayer gaming when using Game Center. Available for devices running macOS versions 10.13 and later.</summary>
        public bool? MultiplayerGamingBlocked {
            get { return BackingStore?.Get<bool?>("multiplayerGamingBlocked"); }
            set { BackingStore?.Set("multiplayerGamingBlocked", value); }
        }
        /// <summary>Indicates whether or not to block sharing passwords with the AirDrop passwords feature.</summary>
        public bool? PasswordBlockAirDropSharing {
            get { return BackingStore?.Get<bool?>("passwordBlockAirDropSharing"); }
            set { BackingStore?.Set("passwordBlockAirDropSharing", value); }
        }
        /// <summary>Indicates whether or not to block the AutoFill Passwords feature.</summary>
        public bool? PasswordBlockAutoFill {
            get { return BackingStore?.Get<bool?>("passwordBlockAutoFill"); }
            set { BackingStore?.Set("passwordBlockAutoFill", value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>("passwordBlockFingerprintUnlock"); }
            set { BackingStore?.Set("passwordBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to allow passcode modification.</summary>
        public bool? PasswordBlockModification {
            get { return BackingStore?.Get<bool?>("passwordBlockModification"); }
            set { BackingStore?.Set("passwordBlockModification", value); }
        }
        /// <summary>Indicates whether or not to block requesting passwords from nearby devices.</summary>
        public bool? PasswordBlockProximityRequests {
            get { return BackingStore?.Get<bool?>("passwordBlockProximityRequests"); }
            set { BackingStore?.Set("passwordBlockProximityRequests", value); }
        }
        /// <summary>Block simple passwords.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>("passwordBlockSimple"); }
            set { BackingStore?.Set("passwordBlockSimple", value); }
        }
        /// <summary>Number of days before the password expires.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>The number of allowed failed attempts to enter the passcode at the device&apos;s lock screen. Valid values 2 to 11</summary>
        public int? PasswordMaximumAttemptCount {
            get { return BackingStore?.Get<int?>("passwordMaximumAttemptCount"); }
            set { BackingStore?.Set("passwordMaximumAttemptCount", value); }
        }
        /// <summary>Number of character sets a password must contain. Valid values 0 to 4</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>Minimum length of passwords.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity required before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>Minutes of inactivity required before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>The number of minutes before the login is reset after the maximum number of unsuccessful login attempts is reached.</summary>
        public int? PasswordMinutesUntilFailedLoginReset {
            get { return BackingStore?.Get<int?>("passwordMinutesUntilFailedLoginReset"); }
            set { BackingStore?.Set("passwordMinutesUntilFailedLoginReset", value); }
        }
        /// <summary>Number of previous passwords to block.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Whether or not to require a password.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>List of privacy preference policy controls. This collection can contain a maximum of 10000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSPrivacyAccessControlItem>? PrivacyAccessControls {
            get { return BackingStore?.Get<List<MacOSPrivacyAccessControlItem>?>("privacyAccessControls"); }
            set { BackingStore?.Set("privacyAccessControls", value); }
        }
#nullable restore
#else
        public List<MacOSPrivacyAccessControlItem> PrivacyAccessControls {
            get { return BackingStore?.Get<List<MacOSPrivacyAccessControlItem>>("privacyAccessControls"); }
            set { BackingStore?.Set("privacyAccessControls", value); }
        }
#endif
        /// <summary>Indicates whether or not to block the user from using Auto fill in Safari.</summary>
        public bool? SafariBlockAutofill {
            get { return BackingStore?.Get<bool?>("safariBlockAutofill"); }
            set { BackingStore?.Set("safariBlockAutofill", value); }
        }
        /// <summary>Indicates whether or not to block the user from taking Screenshots.</summary>
        public bool? ScreenCaptureBlocked {
            get { return BackingStore?.Get<bool?>("screenCaptureBlocked"); }
            set { BackingStore?.Set("screenCaptureBlocked", value); }
        }
        /// <summary>Specify the number of days (1-90) to delay visibility of major OS software updates. Available for devices running macOS versions 11.3 and later. Valid values 0 to 90</summary>
        public int? SoftwareUpdateMajorOSDeferredInstallDelayInDays {
            get { return BackingStore?.Get<int?>("softwareUpdateMajorOSDeferredInstallDelayInDays"); }
            set { BackingStore?.Set("softwareUpdateMajorOSDeferredInstallDelayInDays", value); }
        }
        /// <summary>Specify the number of days (1-90) to delay visibility of minor OS software updates. Available for devices running macOS versions 11.3 and later. Valid values 0 to 90</summary>
        public int? SoftwareUpdateMinorOSDeferredInstallDelayInDays {
            get { return BackingStore?.Get<int?>("softwareUpdateMinorOSDeferredInstallDelayInDays"); }
            set { BackingStore?.Set("softwareUpdateMinorOSDeferredInstallDelayInDays", value); }
        }
        /// <summary>Specify the number of days (1-90) to delay visibility of non-OS software updates. Available for devices running macOS versions 11.3 and later. Valid values 0 to 90</summary>
        public int? SoftwareUpdateNonOSDeferredInstallDelayInDays {
            get { return BackingStore?.Get<int?>("softwareUpdateNonOSDeferredInstallDelayInDays"); }
            set { BackingStore?.Set("softwareUpdateNonOSDeferredInstallDelayInDays", value); }
        }
        /// <summary>Sets how many days a software update will be delyed for a supervised device. Valid values 0 to 90</summary>
        public int? SoftwareUpdatesEnforcedDelayInDays {
            get { return BackingStore?.Get<int?>("softwareUpdatesEnforcedDelayInDays"); }
            set { BackingStore?.Set("softwareUpdatesEnforcedDelayInDays", value); }
        }
        /// <summary>Indicates whether or not to block Spotlight from returning any results from an Internet search.</summary>
        public bool? SpotlightBlockInternetResults {
            get { return BackingStore?.Get<bool?>("spotlightBlockInternetResults"); }
            set { BackingStore?.Set("spotlightBlockInternetResults", value); }
        }
        /// <summary>Maximum hours after which the user must enter their password to unlock the device instead of using Touch ID. Available for devices running macOS 12 and later. Valid values 0 to 2147483647</summary>
        public int? TouchIdTimeoutInHours {
            get { return BackingStore?.Get<int?>("touchIdTimeoutInHours"); }
            set { BackingStore?.Set("touchIdTimeoutInHours", value); }
        }
        /// <summary>Determines whether to delay OS and/or app updates for macOS. Possible values are: none, delayOSUpdateVisibility, delayAppUpdateVisibility, unknownFutureValue, delayMajorOsUpdateVisibility.</summary>
        public MacOSSoftwareUpdateDelayPolicy? UpdateDelayPolicy {
            get { return BackingStore?.Get<MacOSSoftwareUpdateDelayPolicy?>("updateDelayPolicy"); }
            set { BackingStore?.Set("updateDelayPolicy", value); }
        }
        /// <summary>TRUE prevents the wallpaper from being changed. FALSE allows the wallpaper to be changed. Available for devices running macOS versions 10.13 and later.</summary>
        public bool? WallpaperModificationBlocked {
            get { return BackingStore?.Get<bool?>("wallpaperModificationBlocked"); }
            set { BackingStore?.Set("wallpaperModificationBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public MacOSGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addingGameCenterFriendsBlocked", n => { AddingGameCenterFriendsBlocked = n.GetBoolValue(); } },
                {"airDropBlocked", n => { AirDropBlocked = n.GetBoolValue(); } },
                {"appleWatchBlockAutoUnlock", n => { AppleWatchBlockAutoUnlock = n.GetBoolValue(); } },
                {"cameraBlocked", n => { CameraBlocked = n.GetBoolValue(); } },
                {"classroomAppBlockRemoteScreenObservation", n => { ClassroomAppBlockRemoteScreenObservation = n.GetBoolValue(); } },
                {"classroomAppForceUnpromptedScreenObservation", n => { ClassroomAppForceUnpromptedScreenObservation = n.GetBoolValue(); } },
                {"classroomForceAutomaticallyJoinClasses", n => { ClassroomForceAutomaticallyJoinClasses = n.GetBoolValue(); } },
                {"classroomForceRequestPermissionToLeaveClasses", n => { ClassroomForceRequestPermissionToLeaveClasses = n.GetBoolValue(); } },
                {"classroomForceUnpromptedAppAndDeviceLock", n => { ClassroomForceUnpromptedAppAndDeviceLock = n.GetBoolValue(); } },
                {"compliantAppListType", n => { CompliantAppListType = n.GetEnumValue<AppListType>(); } },
                {"compliantAppsList", n => { CompliantAppsList = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentCachingBlocked", n => { ContentCachingBlocked = n.GetBoolValue(); } },
                {"definitionLookupBlocked", n => { DefinitionLookupBlocked = n.GetBoolValue(); } },
                {"emailInDomainSuffixes", n => { EmailInDomainSuffixes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"eraseContentAndSettingsBlocked", n => { EraseContentAndSettingsBlocked = n.GetBoolValue(); } },
                {"gameCenterBlocked", n => { GameCenterBlocked = n.GetBoolValue(); } },
                {"iCloudBlockActivityContinuation", n => { ICloudBlockActivityContinuation = n.GetBoolValue(); } },
                {"iCloudBlockAddressBook", n => { ICloudBlockAddressBook = n.GetBoolValue(); } },
                {"iCloudBlockBookmarks", n => { ICloudBlockBookmarks = n.GetBoolValue(); } },
                {"iCloudBlockCalendar", n => { ICloudBlockCalendar = n.GetBoolValue(); } },
                {"iCloudBlockDocumentSync", n => { ICloudBlockDocumentSync = n.GetBoolValue(); } },
                {"iCloudBlockMail", n => { ICloudBlockMail = n.GetBoolValue(); } },
                {"iCloudBlockNotes", n => { ICloudBlockNotes = n.GetBoolValue(); } },
                {"iCloudBlockPhotoLibrary", n => { ICloudBlockPhotoLibrary = n.GetBoolValue(); } },
                {"iCloudBlockReminders", n => { ICloudBlockReminders = n.GetBoolValue(); } },
                {"iCloudDesktopAndDocumentsBlocked", n => { ICloudDesktopAndDocumentsBlocked = n.GetBoolValue(); } },
                {"iCloudPrivateRelayBlocked", n => { ICloudPrivateRelayBlocked = n.GetBoolValue(); } },
                {"iTunesBlockFileSharing", n => { ITunesBlockFileSharing = n.GetBoolValue(); } },
                {"iTunesBlockMusicService", n => { ITunesBlockMusicService = n.GetBoolValue(); } },
                {"keyboardBlockDictation", n => { KeyboardBlockDictation = n.GetBoolValue(); } },
                {"keychainBlockCloudSync", n => { KeychainBlockCloudSync = n.GetBoolValue(); } },
                {"multiplayerGamingBlocked", n => { MultiplayerGamingBlocked = n.GetBoolValue(); } },
                {"passwordBlockAirDropSharing", n => { PasswordBlockAirDropSharing = n.GetBoolValue(); } },
                {"passwordBlockAutoFill", n => { PasswordBlockAutoFill = n.GetBoolValue(); } },
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockModification", n => { PasswordBlockModification = n.GetBoolValue(); } },
                {"passwordBlockProximityRequests", n => { PasswordBlockProximityRequests = n.GetBoolValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMaximumAttemptCount", n => { PasswordMaximumAttemptCount = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordMinutesUntilFailedLoginReset", n => { PasswordMinutesUntilFailedLoginReset = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"privacyAccessControls", n => { PrivacyAccessControls = n.GetCollectionOfObjectValues<MacOSPrivacyAccessControlItem>(MacOSPrivacyAccessControlItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"safariBlockAutofill", n => { SafariBlockAutofill = n.GetBoolValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
                {"softwareUpdateMajorOSDeferredInstallDelayInDays", n => { SoftwareUpdateMajorOSDeferredInstallDelayInDays = n.GetIntValue(); } },
                {"softwareUpdateMinorOSDeferredInstallDelayInDays", n => { SoftwareUpdateMinorOSDeferredInstallDelayInDays = n.GetIntValue(); } },
                {"softwareUpdateNonOSDeferredInstallDelayInDays", n => { SoftwareUpdateNonOSDeferredInstallDelayInDays = n.GetIntValue(); } },
                {"softwareUpdatesEnforcedDelayInDays", n => { SoftwareUpdatesEnforcedDelayInDays = n.GetIntValue(); } },
                {"spotlightBlockInternetResults", n => { SpotlightBlockInternetResults = n.GetBoolValue(); } },
                {"touchIdTimeoutInHours", n => { TouchIdTimeoutInHours = n.GetIntValue(); } },
                {"updateDelayPolicy", n => { UpdateDelayPolicy = n.GetEnumValue<MacOSSoftwareUpdateDelayPolicy>(); } },
                {"wallpaperModificationBlocked", n => { WallpaperModificationBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("addingGameCenterFriendsBlocked", AddingGameCenterFriendsBlocked);
            writer.WriteBoolValue("airDropBlocked", AirDropBlocked);
            writer.WriteBoolValue("appleWatchBlockAutoUnlock", AppleWatchBlockAutoUnlock);
            writer.WriteBoolValue("cameraBlocked", CameraBlocked);
            writer.WriteBoolValue("classroomAppBlockRemoteScreenObservation", ClassroomAppBlockRemoteScreenObservation);
            writer.WriteBoolValue("classroomAppForceUnpromptedScreenObservation", ClassroomAppForceUnpromptedScreenObservation);
            writer.WriteBoolValue("classroomForceAutomaticallyJoinClasses", ClassroomForceAutomaticallyJoinClasses);
            writer.WriteBoolValue("classroomForceRequestPermissionToLeaveClasses", ClassroomForceRequestPermissionToLeaveClasses);
            writer.WriteBoolValue("classroomForceUnpromptedAppAndDeviceLock", ClassroomForceUnpromptedAppAndDeviceLock);
            writer.WriteEnumValue<AppListType>("compliantAppListType", CompliantAppListType);
            writer.WriteCollectionOfObjectValues<AppListItem>("compliantAppsList", CompliantAppsList);
            writer.WriteBoolValue("contentCachingBlocked", ContentCachingBlocked);
            writer.WriteBoolValue("definitionLookupBlocked", DefinitionLookupBlocked);
            writer.WriteCollectionOfPrimitiveValues<string>("emailInDomainSuffixes", EmailInDomainSuffixes);
            writer.WriteBoolValue("eraseContentAndSettingsBlocked", EraseContentAndSettingsBlocked);
            writer.WriteBoolValue("gameCenterBlocked", GameCenterBlocked);
            writer.WriteBoolValue("iCloudBlockActivityContinuation", ICloudBlockActivityContinuation);
            writer.WriteBoolValue("iCloudBlockAddressBook", ICloudBlockAddressBook);
            writer.WriteBoolValue("iCloudBlockBookmarks", ICloudBlockBookmarks);
            writer.WriteBoolValue("iCloudBlockCalendar", ICloudBlockCalendar);
            writer.WriteBoolValue("iCloudBlockDocumentSync", ICloudBlockDocumentSync);
            writer.WriteBoolValue("iCloudBlockMail", ICloudBlockMail);
            writer.WriteBoolValue("iCloudBlockNotes", ICloudBlockNotes);
            writer.WriteBoolValue("iCloudBlockPhotoLibrary", ICloudBlockPhotoLibrary);
            writer.WriteBoolValue("iCloudBlockReminders", ICloudBlockReminders);
            writer.WriteBoolValue("iCloudDesktopAndDocumentsBlocked", ICloudDesktopAndDocumentsBlocked);
            writer.WriteBoolValue("iCloudPrivateRelayBlocked", ICloudPrivateRelayBlocked);
            writer.WriteBoolValue("iTunesBlockFileSharing", ITunesBlockFileSharing);
            writer.WriteBoolValue("iTunesBlockMusicService", ITunesBlockMusicService);
            writer.WriteBoolValue("keyboardBlockDictation", KeyboardBlockDictation);
            writer.WriteBoolValue("keychainBlockCloudSync", KeychainBlockCloudSync);
            writer.WriteBoolValue("multiplayerGamingBlocked", MultiplayerGamingBlocked);
            writer.WriteBoolValue("passwordBlockAirDropSharing", PasswordBlockAirDropSharing);
            writer.WriteBoolValue("passwordBlockAutoFill", PasswordBlockAutoFill);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockModification", PasswordBlockModification);
            writer.WriteBoolValue("passwordBlockProximityRequests", PasswordBlockProximityRequests);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMaximumAttemptCount", PasswordMaximumAttemptCount);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordMinutesUntilFailedLoginReset", PasswordMinutesUntilFailedLoginReset);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteCollectionOfObjectValues<MacOSPrivacyAccessControlItem>("privacyAccessControls", PrivacyAccessControls);
            writer.WriteBoolValue("safariBlockAutofill", SafariBlockAutofill);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
            writer.WriteIntValue("softwareUpdateMajorOSDeferredInstallDelayInDays", SoftwareUpdateMajorOSDeferredInstallDelayInDays);
            writer.WriteIntValue("softwareUpdateMinorOSDeferredInstallDelayInDays", SoftwareUpdateMinorOSDeferredInstallDelayInDays);
            writer.WriteIntValue("softwareUpdateNonOSDeferredInstallDelayInDays", SoftwareUpdateNonOSDeferredInstallDelayInDays);
            writer.WriteIntValue("softwareUpdatesEnforcedDelayInDays", SoftwareUpdatesEnforcedDelayInDays);
            writer.WriteBoolValue("spotlightBlockInternetResults", SpotlightBlockInternetResults);
            writer.WriteIntValue("touchIdTimeoutInHours", TouchIdTimeoutInHours);
            writer.WriteEnumValue<MacOSSoftwareUpdateDelayPolicy>("updateDelayPolicy", UpdateDelayPolicy);
            writer.WriteBoolValue("wallpaperModificationBlocked", WallpaperModificationBlocked);
        }
    }
}
