// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// This entity provides descriptions of the declared methods, properties and relationships exposed by Windows Hello for Business.
    /// </summary>
    public class WindowsIdentityProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Boolean value used to enable enhanced anti-spoofing for facial feature recognition on Windows Hello face authentication.</summary>
        public bool? EnhancedAntiSpoofingForFacialFeaturesEnabled {
            get { return BackingStore?.Get<bool?>("enhancedAntiSpoofingForFacialFeaturesEnabled"); }
            set { BackingStore?.Set("enhancedAntiSpoofingForFacialFeaturesEnabled", value); }
        }
        /// <summary>Integer value specifies the period (in days) that a PIN can be used before the system requires the user to change it. Valid values are 0 to 730 inclusive. Valid values 0 to 730</summary>
        public int? PinExpirationInDays {
            get { return BackingStore?.Get<int?>("pinExpirationInDays"); }
            set { BackingStore?.Set("pinExpirationInDays", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? PinLowercaseCharactersUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("pinLowercaseCharactersUsage"); }
            set { BackingStore?.Set("pinLowercaseCharactersUsage", value); }
        }
        /// <summary>Integer value that sets the maximum number of characters allowed for the work PIN. Valid values are 4 to 127 inclusive and greater than or equal to the value set for the minimum PIN. Valid values 4 to 127</summary>
        public int? PinMaximumLength {
            get { return BackingStore?.Get<int?>("pinMaximumLength"); }
            set { BackingStore?.Set("pinMaximumLength", value); }
        }
        /// <summary>Integer value that sets the minimum number of characters required for the Windows Hello for Business PIN. Valid values are 4 to 127 inclusive and less than or equal to the value set for the maximum PIN. Valid values 4 to 127</summary>
        public int? PinMinimumLength {
            get { return BackingStore?.Get<int?>("pinMinimumLength"); }
            set { BackingStore?.Set("pinMinimumLength", value); }
        }
        /// <summary>Controls the ability to prevent users from using past PINs. This must be set between 0 and 50, inclusive, and the current PIN of the user is included in that count. If set to 0, previous PINs are not stored. PIN history is not preserved through a PIN reset. Valid values 0 to 50</summary>
        public int? PinPreviousBlockCount {
            get { return BackingStore?.Get<int?>("pinPreviousBlockCount"); }
            set { BackingStore?.Set("pinPreviousBlockCount", value); }
        }
        /// <summary>Boolean value that enables a user to change their PIN by using the Windows Hello for Business PIN recovery service.</summary>
        public bool? PinRecoveryEnabled {
            get { return BackingStore?.Get<bool?>("pinRecoveryEnabled"); }
            set { BackingStore?.Set("pinRecoveryEnabled", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? PinSpecialCharactersUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("pinSpecialCharactersUsage"); }
            set { BackingStore?.Set("pinSpecialCharactersUsage", value); }
        }
        /// <summary>Possible values of the ConfigurationUsage list.</summary>
        public ConfigurationUsage? PinUppercaseCharactersUsage {
            get { return BackingStore?.Get<ConfigurationUsage?>("pinUppercaseCharactersUsage"); }
            set { BackingStore?.Set("pinUppercaseCharactersUsage", value); }
        }
        /// <summary>Controls whether to require a Trusted Platform Module (TPM) for provisioning Windows Hello for Business. A TPM provides an additional security benefit in that data stored on it cannot be used on other devices. If set to False, all devices can provision Windows Hello for Business even if there is not a usable TPM.</summary>
        public bool? SecurityDeviceRequired {
            get { return BackingStore?.Get<bool?>("securityDeviceRequired"); }
            set { BackingStore?.Set("securityDeviceRequired", value); }
        }
        /// <summary>Controls the use of biometric gestures, such as face and fingerprint, as an alternative to the Windows Hello for Business PIN.  If set to False, biometric gestures are not allowed. Users must still configure a PIN as a backup in case of failures.</summary>
        public bool? UnlockWithBiometricsEnabled {
            get { return BackingStore?.Get<bool?>("unlockWithBiometricsEnabled"); }
            set { BackingStore?.Set("unlockWithBiometricsEnabled", value); }
        }
        /// <summary>Boolean value that enables Windows Hello for Business to use certificates to authenticate on-premise resources.</summary>
        public bool? UseCertificatesForOnPremisesAuthEnabled {
            get { return BackingStore?.Get<bool?>("useCertificatesForOnPremisesAuthEnabled"); }
            set { BackingStore?.Set("useCertificatesForOnPremisesAuthEnabled", value); }
        }
        /// <summary>Boolean value used to enable the Windows Hello security key as a logon credential.</summary>
        public bool? UseSecurityKeyForSignin {
            get { return BackingStore?.Get<bool?>("useSecurityKeyForSignin"); }
            set { BackingStore?.Set("useSecurityKeyForSignin", value); }
        }
        /// <summary>Boolean value that blocks Windows Hello for Business as a method for signing into Windows.</summary>
        public bool? WindowsHelloForBusinessBlocked {
            get { return BackingStore?.Get<bool?>("windowsHelloForBusinessBlocked"); }
            set { BackingStore?.Set("windowsHelloForBusinessBlocked", value); }
        }
        /// <summary>
        /// Instantiates a new windowsIdentityProtectionConfiguration and sets the default values.
        /// </summary>
        public WindowsIdentityProtectionConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsIdentityProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsIdentityProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsIdentityProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enhancedAntiSpoofingForFacialFeaturesEnabled", n => { EnhancedAntiSpoofingForFacialFeaturesEnabled = n.GetBoolValue(); } },
                {"pinExpirationInDays", n => { PinExpirationInDays = n.GetIntValue(); } },
                {"pinLowercaseCharactersUsage", n => { PinLowercaseCharactersUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"pinMaximumLength", n => { PinMaximumLength = n.GetIntValue(); } },
                {"pinMinimumLength", n => { PinMinimumLength = n.GetIntValue(); } },
                {"pinPreviousBlockCount", n => { PinPreviousBlockCount = n.GetIntValue(); } },
                {"pinRecoveryEnabled", n => { PinRecoveryEnabled = n.GetBoolValue(); } },
                {"pinSpecialCharactersUsage", n => { PinSpecialCharactersUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"pinUppercaseCharactersUsage", n => { PinUppercaseCharactersUsage = n.GetEnumValue<ConfigurationUsage>(); } },
                {"securityDeviceRequired", n => { SecurityDeviceRequired = n.GetBoolValue(); } },
                {"unlockWithBiometricsEnabled", n => { UnlockWithBiometricsEnabled = n.GetBoolValue(); } },
                {"useCertificatesForOnPremisesAuthEnabled", n => { UseCertificatesForOnPremisesAuthEnabled = n.GetBoolValue(); } },
                {"useSecurityKeyForSignin", n => { UseSecurityKeyForSignin = n.GetBoolValue(); } },
                {"windowsHelloForBusinessBlocked", n => { WindowsHelloForBusinessBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enhancedAntiSpoofingForFacialFeaturesEnabled", EnhancedAntiSpoofingForFacialFeaturesEnabled);
            writer.WriteIntValue("pinExpirationInDays", PinExpirationInDays);
            writer.WriteEnumValue<ConfigurationUsage>("pinLowercaseCharactersUsage", PinLowercaseCharactersUsage);
            writer.WriteIntValue("pinMaximumLength", PinMaximumLength);
            writer.WriteIntValue("pinMinimumLength", PinMinimumLength);
            writer.WriteIntValue("pinPreviousBlockCount", PinPreviousBlockCount);
            writer.WriteBoolValue("pinRecoveryEnabled", PinRecoveryEnabled);
            writer.WriteEnumValue<ConfigurationUsage>("pinSpecialCharactersUsage", PinSpecialCharactersUsage);
            writer.WriteEnumValue<ConfigurationUsage>("pinUppercaseCharactersUsage", PinUppercaseCharactersUsage);
            writer.WriteBoolValue("securityDeviceRequired", SecurityDeviceRequired);
            writer.WriteBoolValue("unlockWithBiometricsEnabled", UnlockWithBiometricsEnabled);
            writer.WriteBoolValue("useCertificatesForOnPremisesAuthEnabled", UseCertificatesForOnPremisesAuthEnabled);
            writer.WriteBoolValue("useSecurityKeyForSignin", UseSecurityKeyForSignin);
            writer.WriteBoolValue("windowsHelloForBusinessBlocked", WindowsHelloForBusinessBlocked);
        }
    }
}
