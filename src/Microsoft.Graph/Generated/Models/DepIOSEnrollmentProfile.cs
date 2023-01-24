using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DepIOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable {
        /// <summary>Indicates if Apperance screen is disabled</summary>
        public bool? AppearanceScreenDisabled {
            get { return BackingStore?.Get<bool?>("appearanceScreenDisabled"); }
            set { BackingStore?.Set("appearanceScreenDisabled", value); }
        }
        /// <summary>Indicates if the device will need to wait for configured confirmation</summary>
        public bool? AwaitDeviceConfiguredConfirmation {
            get { return BackingStore?.Get<bool?>("awaitDeviceConfiguredConfirmation"); }
            set { BackingStore?.Set("awaitDeviceConfiguredConfirmation", value); }
        }
        /// <summary>Carrier URL for activating device eSIM.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CarrierActivationUrl {
            get { return BackingStore?.Get<string?>("carrierActivationUrl"); }
            set { BackingStore?.Set("carrierActivationUrl", value); }
        }
#nullable restore
#else
        public string CarrierActivationUrl {
            get { return BackingStore?.Get<string>("carrierActivationUrl"); }
            set { BackingStore?.Set("carrierActivationUrl", value); }
        }
#endif
        /// <summary>If set, indicates which Vpp token should be used to deploy the Company Portal w/ device licensing. &apos;enableAuthenticationViaCompanyPortal&apos; must be set in order for this property to be set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyPortalVppTokenId {
            get { return BackingStore?.Get<string?>("companyPortalVppTokenId"); }
            set { BackingStore?.Set("companyPortalVppTokenId", value); }
        }
#nullable restore
#else
        public string CompanyPortalVppTokenId {
            get { return BackingStore?.Get<string>("companyPortalVppTokenId"); }
            set { BackingStore?.Set("companyPortalVppTokenId", value); }
        }
#endif
        /// <summary>Indicates if Device To Device Migration is disabled</summary>
        public bool? DeviceToDeviceMigrationDisabled {
            get { return BackingStore?.Get<bool?>("deviceToDeviceMigrationDisabled"); }
            set { BackingStore?.Set("deviceToDeviceMigrationDisabled", value); }
        }
        /// <summary>This indicates whether the device is to be enrolled in a mode which enables multi user scenarios. Only applicable in shared iPads.</summary>
        public bool? EnableSharedIPad {
            get { return BackingStore?.Get<bool?>("enableSharedIPad"); }
            set { BackingStore?.Set("enableSharedIPad", value); }
        }
        /// <summary>Tells the device to enable single app mode and apply app-lock during enrollment. Default is false. &apos;enableAuthenticationViaCompanyPortal&apos; and &apos;companyPortalVppTokenId&apos; must be set for this property to be set.</summary>
        public bool? EnableSingleAppEnrollmentMode {
            get { return BackingStore?.Get<bool?>("enableSingleAppEnrollmentMode"); }
            set { BackingStore?.Set("enableSingleAppEnrollmentMode", value); }
        }
        /// <summary>Indicates if Express Language screen is disabled</summary>
        public bool? ExpressLanguageScreenDisabled {
            get { return BackingStore?.Get<bool?>("expressLanguageScreenDisabled"); }
            set { BackingStore?.Set("expressLanguageScreenDisabled", value); }
        }
        /// <summary>Indicates if temporary sessions is enabled</summary>
        public bool? ForceTemporarySession {
            get { return BackingStore?.Get<bool?>("forceTemporarySession"); }
            set { BackingStore?.Set("forceTemporarySession", value); }
        }
        /// <summary>Indicates if home button sensitivity screen is disabled</summary>
        public bool? HomeButtonScreenDisabled {
            get { return BackingStore?.Get<bool?>("homeButtonScreenDisabled"); }
            set { BackingStore?.Set("homeButtonScreenDisabled", value); }
        }
        /// <summary>Indicates if iMessage and FaceTime screen is disabled</summary>
        public bool? IMessageAndFaceTimeScreenDisabled {
            get { return BackingStore?.Get<bool?>("iMessageAndFaceTimeScreenDisabled"); }
            set { BackingStore?.Set("iMessageAndFaceTimeScreenDisabled", value); }
        }
        /// <summary>The iTunesPairingMode property</summary>
        public Microsoft.Graph.Beta.Models.ITunesPairingMode? ITunesPairingMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ITunesPairingMode?>("iTunesPairingMode"); }
            set { BackingStore?.Set("iTunesPairingMode", value); }
        }
        /// <summary>Management certificates for Apple Configurator</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementCertificateWithThumbprint>? ManagementCertificates {
            get { return BackingStore?.Get<List<ManagementCertificateWithThumbprint>?>("managementCertificates"); }
            set { BackingStore?.Set("managementCertificates", value); }
        }
#nullable restore
#else
        public List<ManagementCertificateWithThumbprint> ManagementCertificates {
            get { return BackingStore?.Get<List<ManagementCertificateWithThumbprint>>("managementCertificates"); }
            set { BackingStore?.Set("managementCertificates", value); }
        }
#endif
        /// <summary>Indicates if onboarding setup screen is disabled</summary>
        public bool? OnBoardingScreenDisabled {
            get { return BackingStore?.Get<bool?>("onBoardingScreenDisabled"); }
            set { BackingStore?.Set("onBoardingScreenDisabled", value); }
        }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled {
            get { return BackingStore?.Get<bool?>("passCodeDisabled"); }
            set { BackingStore?.Set("passCodeDisabled", value); }
        }
        /// <summary>Indicates timeout before locked screen requires the user to enter the device passocde to unlock it</summary>
        public int? PasscodeLockGracePeriodInSeconds {
            get { return BackingStore?.Get<int?>("passcodeLockGracePeriodInSeconds"); }
            set { BackingStore?.Set("passcodeLockGracePeriodInSeconds", value); }
        }
        /// <summary>Indicates if Preferred language screen is disabled</summary>
        public bool? PreferredLanguageScreenDisabled {
            get { return BackingStore?.Get<bool?>("preferredLanguageScreenDisabled"); }
            set { BackingStore?.Set("preferredLanguageScreenDisabled", value); }
        }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? RestoreCompletedScreenDisabled {
            get { return BackingStore?.Get<bool?>("restoreCompletedScreenDisabled"); }
            set { BackingStore?.Set("restoreCompletedScreenDisabled", value); }
        }
        /// <summary>Indicates if Restore from Android is disabled</summary>
        public bool? RestoreFromAndroidDisabled {
            get { return BackingStore?.Get<bool?>("restoreFromAndroidDisabled"); }
            set { BackingStore?.Set("restoreFromAndroidDisabled", value); }
        }
        /// <summary>This specifies the maximum number of users that can use a shared iPad. Only applicable in shared iPad mode.</summary>
        public int? SharedIPadMaximumUserCount {
            get { return BackingStore?.Get<int?>("sharedIPadMaximumUserCount"); }
            set { BackingStore?.Set("sharedIPadMaximumUserCount", value); }
        }
        /// <summary>Indicates if the SIMSetup screen is disabled</summary>
        public bool? SimSetupScreenDisabled {
            get { return BackingStore?.Get<bool?>("simSetupScreenDisabled"); }
            set { BackingStore?.Set("simSetupScreenDisabled", value); }
        }
        /// <summary>Indicates if the mandatory sofware update screen is disabled</summary>
        public bool? SoftwareUpdateScreenDisabled {
            get { return BackingStore?.Get<bool?>("softwareUpdateScreenDisabled"); }
            set { BackingStore?.Set("softwareUpdateScreenDisabled", value); }
        }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? TemporarySessionTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("temporarySessionTimeoutInSeconds"); }
            set { BackingStore?.Set("temporarySessionTimeoutInSeconds", value); }
        }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? UpdateCompleteScreenDisabled {
            get { return BackingStore?.Get<bool?>("updateCompleteScreenDisabled"); }
            set { BackingStore?.Set("updateCompleteScreenDisabled", value); }
        }
        /// <summary>Indicates that this apple device is designated to support &apos;shared device mode&apos; scenarios. This is distinct from the &apos;shared iPad&apos; scenario. See https://learn.microsoft.com/en-us/mem/intune/enrollment/device-enrollment-shared-ios</summary>
        public bool? UserlessSharedAadModeEnabled {
            get { return BackingStore?.Get<bool?>("userlessSharedAadModeEnabled"); }
            set { BackingStore?.Set("userlessSharedAadModeEnabled", value); }
        }
        /// <summary>Indicates timeout of temporary session</summary>
        public int? UserSessionTimeoutInSeconds {
            get { return BackingStore?.Get<int?>("userSessionTimeoutInSeconds"); }
            set { BackingStore?.Set("userSessionTimeoutInSeconds", value); }
        }
        /// <summary>Indicates if the watch migration screen is disabled</summary>
        public bool? WatchMigrationScreenDisabled {
            get { return BackingStore?.Get<bool?>("watchMigrationScreenDisabled"); }
            set { BackingStore?.Set("watchMigrationScreenDisabled", value); }
        }
        /// <summary>Indicates if Weclome screen is disabled</summary>
        public bool? WelcomeScreenDisabled {
            get { return BackingStore?.Get<bool?>("welcomeScreenDisabled"); }
            set { BackingStore?.Set("welcomeScreenDisabled", value); }
        }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled {
            get { return BackingStore?.Get<bool?>("zoomDisabled"); }
            set { BackingStore?.Set("zoomDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new DepIOSEnrollmentProfile and sets the default values.
        /// </summary>
        public DepIOSEnrollmentProfile() : base() {
            OdataType = "#microsoft.graph.depIOSEnrollmentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DepIOSEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepIOSEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appearanceScreenDisabled", n => { AppearanceScreenDisabled = n.GetBoolValue(); } },
                {"awaitDeviceConfiguredConfirmation", n => { AwaitDeviceConfiguredConfirmation = n.GetBoolValue(); } },
                {"carrierActivationUrl", n => { CarrierActivationUrl = n.GetStringValue(); } },
                {"companyPortalVppTokenId", n => { CompanyPortalVppTokenId = n.GetStringValue(); } },
                {"deviceToDeviceMigrationDisabled", n => { DeviceToDeviceMigrationDisabled = n.GetBoolValue(); } },
                {"enableSharedIPad", n => { EnableSharedIPad = n.GetBoolValue(); } },
                {"enableSingleAppEnrollmentMode", n => { EnableSingleAppEnrollmentMode = n.GetBoolValue(); } },
                {"expressLanguageScreenDisabled", n => { ExpressLanguageScreenDisabled = n.GetBoolValue(); } },
                {"forceTemporarySession", n => { ForceTemporarySession = n.GetBoolValue(); } },
                {"homeButtonScreenDisabled", n => { HomeButtonScreenDisabled = n.GetBoolValue(); } },
                {"iMessageAndFaceTimeScreenDisabled", n => { IMessageAndFaceTimeScreenDisabled = n.GetBoolValue(); } },
                {"iTunesPairingMode", n => { ITunesPairingMode = n.GetEnumValue<ITunesPairingMode>(); } },
                {"managementCertificates", n => { ManagementCertificates = n.GetCollectionOfObjectValues<ManagementCertificateWithThumbprint>(ManagementCertificateWithThumbprint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onBoardingScreenDisabled", n => { OnBoardingScreenDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"passcodeLockGracePeriodInSeconds", n => { PasscodeLockGracePeriodInSeconds = n.GetIntValue(); } },
                {"preferredLanguageScreenDisabled", n => { PreferredLanguageScreenDisabled = n.GetBoolValue(); } },
                {"restoreCompletedScreenDisabled", n => { RestoreCompletedScreenDisabled = n.GetBoolValue(); } },
                {"restoreFromAndroidDisabled", n => { RestoreFromAndroidDisabled = n.GetBoolValue(); } },
                {"sharedIPadMaximumUserCount", n => { SharedIPadMaximumUserCount = n.GetIntValue(); } },
                {"simSetupScreenDisabled", n => { SimSetupScreenDisabled = n.GetBoolValue(); } },
                {"softwareUpdateScreenDisabled", n => { SoftwareUpdateScreenDisabled = n.GetBoolValue(); } },
                {"temporarySessionTimeoutInSeconds", n => { TemporarySessionTimeoutInSeconds = n.GetIntValue(); } },
                {"updateCompleteScreenDisabled", n => { UpdateCompleteScreenDisabled = n.GetBoolValue(); } },
                {"userlessSharedAadModeEnabled", n => { UserlessSharedAadModeEnabled = n.GetBoolValue(); } },
                {"userSessionTimeoutInSeconds", n => { UserSessionTimeoutInSeconds = n.GetIntValue(); } },
                {"watchMigrationScreenDisabled", n => { WatchMigrationScreenDisabled = n.GetBoolValue(); } },
                {"welcomeScreenDisabled", n => { WelcomeScreenDisabled = n.GetBoolValue(); } },
                {"zoomDisabled", n => { ZoomDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("appearanceScreenDisabled", AppearanceScreenDisabled);
            writer.WriteBoolValue("awaitDeviceConfiguredConfirmation", AwaitDeviceConfiguredConfirmation);
            writer.WriteStringValue("carrierActivationUrl", CarrierActivationUrl);
            writer.WriteStringValue("companyPortalVppTokenId", CompanyPortalVppTokenId);
            writer.WriteBoolValue("deviceToDeviceMigrationDisabled", DeviceToDeviceMigrationDisabled);
            writer.WriteBoolValue("enableSharedIPad", EnableSharedIPad);
            writer.WriteBoolValue("enableSingleAppEnrollmentMode", EnableSingleAppEnrollmentMode);
            writer.WriteBoolValue("expressLanguageScreenDisabled", ExpressLanguageScreenDisabled);
            writer.WriteBoolValue("forceTemporarySession", ForceTemporarySession);
            writer.WriteBoolValue("homeButtonScreenDisabled", HomeButtonScreenDisabled);
            writer.WriteBoolValue("iMessageAndFaceTimeScreenDisabled", IMessageAndFaceTimeScreenDisabled);
            writer.WriteEnumValue<ITunesPairingMode>("iTunesPairingMode", ITunesPairingMode);
            writer.WriteCollectionOfObjectValues<ManagementCertificateWithThumbprint>("managementCertificates", ManagementCertificates);
            writer.WriteBoolValue("onBoardingScreenDisabled", OnBoardingScreenDisabled);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteIntValue("passcodeLockGracePeriodInSeconds", PasscodeLockGracePeriodInSeconds);
            writer.WriteBoolValue("preferredLanguageScreenDisabled", PreferredLanguageScreenDisabled);
            writer.WriteBoolValue("restoreCompletedScreenDisabled", RestoreCompletedScreenDisabled);
            writer.WriteBoolValue("restoreFromAndroidDisabled", RestoreFromAndroidDisabled);
            writer.WriteIntValue("sharedIPadMaximumUserCount", SharedIPadMaximumUserCount);
            writer.WriteBoolValue("simSetupScreenDisabled", SimSetupScreenDisabled);
            writer.WriteBoolValue("softwareUpdateScreenDisabled", SoftwareUpdateScreenDisabled);
            writer.WriteIntValue("temporarySessionTimeoutInSeconds", TemporarySessionTimeoutInSeconds);
            writer.WriteBoolValue("updateCompleteScreenDisabled", UpdateCompleteScreenDisabled);
            writer.WriteBoolValue("userlessSharedAadModeEnabled", UserlessSharedAadModeEnabled);
            writer.WriteIntValue("userSessionTimeoutInSeconds", UserSessionTimeoutInSeconds);
            writer.WriteBoolValue("watchMigrationScreenDisabled", WatchMigrationScreenDisabled);
            writer.WriteBoolValue("welcomeScreenDisabled", WelcomeScreenDisabled);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}
