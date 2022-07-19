using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Device threat protection levels for the Device Threat Protection API.</summary>
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>("advancedThreatProtectionRequiredSecurityLevel"); }
            set { BackingStore?.Set("advancedThreatProtectionRequiredSecurityLevel", value); }
        }
        /// <summary>Require that devices have enabled device threat protection .</summary>
        public bool? DeviceThreatProtectionEnabled {
            get { return BackingStore?.Get<bool?>("deviceThreatProtectionEnabled"); }
            set { BackingStore?.Set("deviceThreatProtectionEnabled", value); }
        }
        /// <summary>Device threat protection levels for the Device Threat Protection API.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel {
            get { return BackingStore?.Get<DeviceThreatProtectionLevel?>("deviceThreatProtectionRequiredSecurityLevel"); }
            set { BackingStore?.Set("deviceThreatProtectionRequiredSecurityLevel", value); }
        }
        /// <summary>Indicates whether or not to require a managed email profile.</summary>
        public bool? ManagedEmailProfileRequired {
            get { return BackingStore?.Get<bool?>("managedEmailProfileRequired"); }
            set { BackingStore?.Set("managedEmailProfileRequired", value); }
        }
        /// <summary>Maximum IOS build version.</summary>
        public string OsMaximumBuildVersion {
            get { return BackingStore?.Get<string>("osMaximumBuildVersion"); }
            set { BackingStore?.Set("osMaximumBuildVersion", value); }
        }
        /// <summary>Maximum IOS version.</summary>
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
        /// <summary>Minimum IOS build version.</summary>
        public string OsMinimumBuildVersion {
            get { return BackingStore?.Get<string>("osMinimumBuildVersion"); }
            set { BackingStore?.Set("osMinimumBuildVersion", value); }
        }
        /// <summary>Minimum IOS version.</summary>
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
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
        /// <summary>The number of character sets required in the password.</summary>
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
        /// <summary>Require the device to not have the specified apps installed. This collection can contain a maximum of 100 elements.</summary>
        public List<AppListItem> RestrictedApps {
            get { return BackingStore?.Get<List<AppListItem>>("restrictedApps"); }
            set { BackingStore?.Set("restrictedApps", value); }
        }
        /// <summary>Devices must not be jailbroken or rooted.</summary>
        public bool? SecurityBlockJailbrokenDevices {
            get { return BackingStore?.Get<bool?>("securityBlockJailbrokenDevices"); }
            set { BackingStore?.Set("securityBlockJailbrokenDevices", value); }
        }
        /// <summary>
        /// Instantiates a new IosCompliancePolicy and sets the default values.
        /// </summary>
        public IosCompliancePolicy() : base() {
            OdataType = "#microsoft.graph.iosCompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"advancedThreatProtectionRequiredSecurityLevel", n => { AdvancedThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"managedEmailProfileRequired", n => { ManagedEmailProfileRequired = n.GetBoolValue(); } },
                {"osMaximumBuildVersion", n => { OsMaximumBuildVersion = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumBuildVersion", n => { OsMinimumBuildVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passcodeBlockSimple", n => { PasscodeBlockSimple = n.GetBoolValue(); } },
                {"passcodeExpirationDays", n => { PasscodeExpirationDays = n.GetIntValue(); } },
                {"passcodeMinimumCharacterSetCount", n => { PasscodeMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passcodeMinimumLength", n => { PasscodeMinimumLength = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeLock", n => { PasscodeMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passcodeMinutesOfInactivityBeforeScreenTimeout", n => { PasscodeMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passcodePreviousPasscodeBlockCount", n => { PasscodePreviousPasscodeBlockCount = n.GetIntValue(); } },
                {"passcodeRequired", n => { PasscodeRequired = n.GetBoolValue(); } },
                {"passcodeRequiredType", n => { PasscodeRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"restrictedApps", n => { RestrictedApps = n.GetCollectionOfObjectValues<AppListItem>(AppListItem.CreateFromDiscriminatorValue).ToList(); } },
                {"securityBlockJailbrokenDevices", n => { SecurityBlockJailbrokenDevices = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("advancedThreatProtectionRequiredSecurityLevel", AdvancedThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteBoolValue("managedEmailProfileRequired", ManagedEmailProfileRequired);
            writer.WriteStringValue("osMaximumBuildVersion", OsMaximumBuildVersion);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumBuildVersion", OsMinimumBuildVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passcodeBlockSimple", PasscodeBlockSimple);
            writer.WriteIntValue("passcodeExpirationDays", PasscodeExpirationDays);
            writer.WriteIntValue("passcodeMinimumCharacterSetCount", PasscodeMinimumCharacterSetCount);
            writer.WriteIntValue("passcodeMinimumLength", PasscodeMinimumLength);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeLock", PasscodeMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passcodeMinutesOfInactivityBeforeScreenTimeout", PasscodeMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passcodePreviousPasscodeBlockCount", PasscodePreviousPasscodeBlockCount);
            writer.WriteBoolValue("passcodeRequired", PasscodeRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passcodeRequiredType", PasscodeRequiredType);
            writer.WriteCollectionOfObjectValues<AppListItem>("restrictedApps", RestrictedApps);
            writer.WriteBoolValue("securityBlockJailbrokenDevices", SecurityBlockJailbrokenDevices);
        }
    }
}
