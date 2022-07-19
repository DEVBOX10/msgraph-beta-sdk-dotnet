using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10CompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require active firewall on Windows devices.</summary>
        public bool? ActiveFirewallRequired {
            get { return BackingStore?.Get<bool?>("activeFirewallRequired"); }
            set { BackingStore?.Set("activeFirewallRequired", value); }
        }
        /// <summary>Require any AntiSpyware solution registered with Windows Decurity Center to be on and monitoring (e.g. Symantec, Windows Defender).</summary>
        public bool? AntiSpywareRequired {
            get { return BackingStore?.Get<bool?>("antiSpywareRequired"); }
            set { BackingStore?.Set("antiSpywareRequired", value); }
        }
        /// <summary>Require any Antivirus solution registered with Windows Decurity Center to be on and monitoring (e.g. Symantec, Windows Defender).</summary>
        public bool? AntivirusRequired {
            get { return BackingStore?.Get<bool?>("antivirusRequired"); }
            set { BackingStore?.Set("antivirusRequired", value); }
        }
        /// <summary>Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</summary>
        public bool? BitLockerEnabled {
            get { return BackingStore?.Get<bool?>("bitLockerEnabled"); }
            set { BackingStore?.Set("bitLockerEnabled", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? CodeIntegrityEnabled {
            get { return BackingStore?.Get<bool?>("codeIntegrityEnabled"); }
            set { BackingStore?.Set("codeIntegrityEnabled", value); }
        }
        /// <summary>Require to consider SCCM Compliance state into consideration for Intune Compliance State.</summary>
        public bool? ConfigurationManagerComplianceRequired {
            get { return BackingStore?.Get<bool?>("configurationManagerComplianceRequired"); }
            set { BackingStore?.Set("configurationManagerComplianceRequired", value); }
        }
        /// <summary>Require Windows Defender Antimalware on Windows devices.</summary>
        public bool? DefenderEnabled {
            get { return BackingStore?.Get<bool?>("defenderEnabled"); }
            set { BackingStore?.Set("defenderEnabled", value); }
        }
        /// <summary>Require Windows Defender Antimalware minimum version on Windows devices.</summary>
        public string DefenderVersion {
            get { return BackingStore?.Get<string>("defenderVersion"); }
            set { BackingStore?.Set("defenderVersion", value); }
        }
        /// <summary>Not yet documented</summary>
        public Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript DeviceCompliancePolicyScript {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>("deviceCompliancePolicyScript"); }
            set { BackingStore?.Set("deviceCompliancePolicyScript", value); }
        }
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>("deviceThreatProtectionEnabled"); }
            set { BackingStore?.Set("deviceThreatProtectionEnabled", value); }
        }
        /// <summary>Device threat protection levels for the Device Threat Protection API.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>("deviceThreatProtectionRequiredSecurityLevel"); }
            set { BackingStore?.Set("deviceThreatProtectionRequiredSecurityLevel", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</summary>
        public bool? EarlyLaunchAntiMalwareDriverEnabled {
            get { return BackingStore?.Get<bool?>("earlyLaunchAntiMalwareDriverEnabled"); }
            set { BackingStore?.Set("earlyLaunchAntiMalwareDriverEnabled", value); }
        }
        /// <summary>Maximum Windows Phone version.</summary>
        public string MobileOsMaximumVersion {
            get { return BackingStore?.Get<string>("mobileOsMaximumVersion"); }
            set { BackingStore?.Set("mobileOsMaximumVersion", value); }
        }
        /// <summary>Minimum Windows Phone version.</summary>
        public string MobileOsMinimumVersion {
            get { return BackingStore?.Get<string>("mobileOsMinimumVersion"); }
            set { BackingStore?.Set("mobileOsMinimumVersion", value); }
        }
        /// <summary>Maximum Windows 10 version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
        /// <summary>Minimum Windows 10 version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
        /// <summary>Indicates whether or not to block simple password.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>("passwordBlockSimple"); }
            set { BackingStore?.Set("passwordBlockSimple", value); }
        }
        /// <summary>The password expiration in days.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Require a password to unlock Windows device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Require a password to unlock an idle device.</summary>
        public bool? PasswordRequiredToUnlockFromIdle {
            get { return BackingStore?.Get<bool?>("passwordRequiredToUnlockFromIdle"); }
            set { BackingStore?.Set("passwordRequiredToUnlockFromIdle", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? RequireHealthyDeviceReport {
            get { return BackingStore?.Get<bool?>("requireHealthyDeviceReport"); }
            set { BackingStore?.Set("requireHealthyDeviceReport", value); }
        }
        /// <summary>Require Windows Defender Antimalware Real-Time Protection on Windows devices.</summary>
        public bool? RtpEnabled {
            get { return BackingStore?.Get<bool?>("rtpEnabled"); }
            set { BackingStore?.Set("rtpEnabled", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</summary>
        public bool? SecureBootEnabled {
            get { return BackingStore?.Get<bool?>("secureBootEnabled"); }
            set { BackingStore?.Set("secureBootEnabled", value); }
        }
        /// <summary>Require Windows Defender Antimalware Signature to be up to date on Windows devices.</summary>
        public bool? SignatureOutOfDate {
            get { return BackingStore?.Get<bool?>("signatureOutOfDate"); }
            set { BackingStore?.Set("signatureOutOfDate", value); }
        }
        /// <summary>Require encryption on windows devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireEncryption"); }
            set { BackingStore?.Set("storageRequireEncryption", value); }
        }
        /// <summary>Require Trusted Platform Module(TPM) to be present.</summary>
        public bool? TpmRequired {
            get { return BackingStore?.Get<bool?>("tpmRequired"); }
            set { BackingStore?.Set("tpmRequired", value); }
        }
        /// <summary>The valid operating system build ranges on Windows devices. This collection can contain a maximum of 10000 elements.</summary>
        public List<OperatingSystemVersionRange> ValidOperatingSystemBuildRanges {
            get { return BackingStore?.Get<List<OperatingSystemVersionRange>>("validOperatingSystemBuildRanges"); }
            set { BackingStore?.Set("validOperatingSystemBuildRanges", value); }
        }
        /// <summary>
        /// Instantiates a new Windows10CompliancePolicy and sets the default values.
        /// </summary>
        public Windows10CompliancePolicy() : base() {
            OdataType = "#microsoft.graph.windows10CompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Windows10CompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10CompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeFirewallRequired", n => { ActiveFirewallRequired = n.GetBoolValue(); } },
                {"antiSpywareRequired", n => { AntiSpywareRequired = n.GetBoolValue(); } },
                {"antivirusRequired", n => { AntivirusRequired = n.GetBoolValue(); } },
                {"bitLockerEnabled", n => { BitLockerEnabled = n.GetBoolValue(); } },
                {"codeIntegrityEnabled", n => { CodeIntegrityEnabled = n.GetBoolValue(); } },
                {"configurationManagerComplianceRequired", n => { ConfigurationManagerComplianceRequired = n.GetBoolValue(); } },
                {"defenderEnabled", n => { DefenderEnabled = n.GetBoolValue(); } },
                {"defenderVersion", n => { DefenderVersion = n.GetStringValue(); } },
                {"deviceCompliancePolicyScript", n => { DeviceCompliancePolicyScript = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript.CreateFromDiscriminatorValue); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"earlyLaunchAntiMalwareDriverEnabled", n => { EarlyLaunchAntiMalwareDriverEnabled = n.GetBoolValue(); } },
                {"mobileOsMaximumVersion", n => { MobileOsMaximumVersion = n.GetStringValue(); } },
                {"mobileOsMinimumVersion", n => { MobileOsMinimumVersion = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredToUnlockFromIdle", n => { PasswordRequiredToUnlockFromIdle = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"requireHealthyDeviceReport", n => { RequireHealthyDeviceReport = n.GetBoolValue(); } },
                {"rtpEnabled", n => { RtpEnabled = n.GetBoolValue(); } },
                {"secureBootEnabled", n => { SecureBootEnabled = n.GetBoolValue(); } },
                {"signatureOutOfDate", n => { SignatureOutOfDate = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
                {"tpmRequired", n => { TpmRequired = n.GetBoolValue(); } },
                {"validOperatingSystemBuildRanges", n => { ValidOperatingSystemBuildRanges = n.GetCollectionOfObjectValues<OperatingSystemVersionRange>(OperatingSystemVersionRange.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("activeFirewallRequired", ActiveFirewallRequired);
            writer.WriteBoolValue("antiSpywareRequired", AntiSpywareRequired);
            writer.WriteBoolValue("antivirusRequired", AntivirusRequired);
            writer.WriteBoolValue("bitLockerEnabled", BitLockerEnabled);
            writer.WriteBoolValue("codeIntegrityEnabled", CodeIntegrityEnabled);
            writer.WriteBoolValue("configurationManagerComplianceRequired", ConfigurationManagerComplianceRequired);
            writer.WriteBoolValue("defenderEnabled", DefenderEnabled);
            writer.WriteStringValue("defenderVersion", DefenderVersion);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicyScript>("deviceCompliancePolicyScript", DeviceCompliancePolicyScript);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("earlyLaunchAntiMalwareDriverEnabled", EarlyLaunchAntiMalwareDriverEnabled);
            writer.WriteStringValue("mobileOsMaximumVersion", MobileOsMaximumVersion);
            writer.WriteStringValue("mobileOsMinimumVersion", MobileOsMinimumVersion);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteBoolValue("passwordRequiredToUnlockFromIdle", PasswordRequiredToUnlockFromIdle);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("requireHealthyDeviceReport", RequireHealthyDeviceReport);
            writer.WriteBoolValue("rtpEnabled", RtpEnabled);
            writer.WriteBoolValue("secureBootEnabled", SecureBootEnabled);
            writer.WriteBoolValue("signatureOutOfDate", SignatureOutOfDate);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
            writer.WriteBoolValue("tpmRequired", TpmRequired);
            writer.WriteCollectionOfObjectValues<OperatingSystemVersionRange>("validOperatingSystemBuildRanges", ValidOperatingSystemBuildRanges);
        }
    }
}
