using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DepMacOSEnrollmentProfile : DepEnrollmentBaseProfile, IParsable {
        /// <summary>Indicates if Accessibility screen is disabled</summary>
        public bool? AccessibilityScreenDisabled {
            get { return BackingStore?.Get<bool?>("accessibilityScreenDisabled"); }
            set { BackingStore?.Set("accessibilityScreenDisabled", value); }
        }
        /// <summary>Indicates if UnlockWithWatch screen is disabled</summary>
        public bool? AutoUnlockWithWatchDisabled {
            get { return BackingStore?.Get<bool?>("autoUnlockWithWatchDisabled"); }
            set { BackingStore?.Set("autoUnlockWithWatchDisabled", value); }
        }
        /// <summary>Indicates if iCloud Documents and Desktop screen is disabled</summary>
        public bool? ChooseYourLockScreenDisabled {
            get { return BackingStore?.Get<bool?>("chooseYourLockScreenDisabled"); }
            set { BackingStore?.Set("chooseYourLockScreenDisabled", value); }
        }
        /// <summary>Indicates whether Setup Assistant will auto populate the primary account information</summary>
        public bool? DontAutoPopulatePrimaryAccountInfo {
            get { return BackingStore?.Get<bool?>("dontAutoPopulatePrimaryAccountInfo"); }
            set { BackingStore?.Set("dontAutoPopulatePrimaryAccountInfo", value); }
        }
        /// <summary>Indicates whether the user will enable blockediting</summary>
        public bool? EnableRestrictEditing {
            get { return BackingStore?.Get<bool?>("enableRestrictEditing"); }
            set { BackingStore?.Set("enableRestrictEditing", value); }
        }
        /// <summary>Indicates if file vault is disabled</summary>
        public bool? FileVaultDisabled {
            get { return BackingStore?.Get<bool?>("fileVaultDisabled"); }
            set { BackingStore?.Set("fileVaultDisabled", value); }
        }
        /// <summary>Indicates if iCloud Analytics screen is disabled</summary>
        public bool? ICloudDiagnosticsDisabled {
            get { return BackingStore?.Get<bool?>("iCloudDiagnosticsDisabled"); }
            set { BackingStore?.Set("iCloudDiagnosticsDisabled", value); }
        }
        /// <summary>Indicates if iCloud Documents and Desktop screen is disabled</summary>
        public bool? ICloudStorageDisabled {
            get { return BackingStore?.Get<bool?>("iCloudStorageDisabled"); }
            set { BackingStore?.Set("iCloudStorageDisabled", value); }
        }
        /// <summary>Indicates if Passcode setup pane is disabled</summary>
        public bool? PassCodeDisabled {
            get { return BackingStore?.Get<bool?>("passCodeDisabled"); }
            set { BackingStore?.Set("passCodeDisabled", value); }
        }
        /// <summary>Indicates what the full name for the primary account is</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryAccountFullName {
            get { return BackingStore?.Get<string?>("primaryAccountFullName"); }
            set { BackingStore?.Set("primaryAccountFullName", value); }
        }
#nullable restore
#else
        public string PrimaryAccountFullName {
            get { return BackingStore?.Get<string>("primaryAccountFullName"); }
            set { BackingStore?.Set("primaryAccountFullName", value); }
        }
#endif
        /// <summary>Indicates what the account name for the primary account is</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryAccountUserName {
            get { return BackingStore?.Get<string?>("primaryAccountUserName"); }
            set { BackingStore?.Set("primaryAccountUserName", value); }
        }
#nullable restore
#else
        public string PrimaryAccountUserName {
            get { return BackingStore?.Get<string>("primaryAccountUserName"); }
            set { BackingStore?.Set("primaryAccountUserName", value); }
        }
#endif
        /// <summary>Indicates if registration is disabled</summary>
        public bool? RegistrationDisabled {
            get { return BackingStore?.Get<bool?>("registrationDisabled"); }
            set { BackingStore?.Set("registrationDisabled", value); }
        }
        /// <summary>Indicates whether Setup Assistant will set the account as a regular user</summary>
        public bool? SetPrimarySetupAccountAsRegularUser {
            get { return BackingStore?.Get<bool?>("setPrimarySetupAccountAsRegularUser"); }
            set { BackingStore?.Set("setPrimarySetupAccountAsRegularUser", value); }
        }
        /// <summary>Indicates whether Setup Assistant will skip the user interface for primary account setup</summary>
        public bool? SkipPrimarySetupAccountCreation {
            get { return BackingStore?.Get<bool?>("skipPrimarySetupAccountCreation"); }
            set { BackingStore?.Set("skipPrimarySetupAccountCreation", value); }
        }
        /// <summary>Indicates if zoom setup pane is disabled</summary>
        public bool? ZoomDisabled {
            get { return BackingStore?.Get<bool?>("zoomDisabled"); }
            set { BackingStore?.Set("zoomDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new DepMacOSEnrollmentProfile and sets the default values.
        /// </summary>
        public DepMacOSEnrollmentProfile() : base() {
            OdataType = "#microsoft.graph.depMacOSEnrollmentProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DepMacOSEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DepMacOSEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessibilityScreenDisabled", n => { AccessibilityScreenDisabled = n.GetBoolValue(); } },
                {"autoUnlockWithWatchDisabled", n => { AutoUnlockWithWatchDisabled = n.GetBoolValue(); } },
                {"chooseYourLockScreenDisabled", n => { ChooseYourLockScreenDisabled = n.GetBoolValue(); } },
                {"dontAutoPopulatePrimaryAccountInfo", n => { DontAutoPopulatePrimaryAccountInfo = n.GetBoolValue(); } },
                {"enableRestrictEditing", n => { EnableRestrictEditing = n.GetBoolValue(); } },
                {"fileVaultDisabled", n => { FileVaultDisabled = n.GetBoolValue(); } },
                {"iCloudDiagnosticsDisabled", n => { ICloudDiagnosticsDisabled = n.GetBoolValue(); } },
                {"iCloudStorageDisabled", n => { ICloudStorageDisabled = n.GetBoolValue(); } },
                {"passCodeDisabled", n => { PassCodeDisabled = n.GetBoolValue(); } },
                {"primaryAccountFullName", n => { PrimaryAccountFullName = n.GetStringValue(); } },
                {"primaryAccountUserName", n => { PrimaryAccountUserName = n.GetStringValue(); } },
                {"registrationDisabled", n => { RegistrationDisabled = n.GetBoolValue(); } },
                {"setPrimarySetupAccountAsRegularUser", n => { SetPrimarySetupAccountAsRegularUser = n.GetBoolValue(); } },
                {"skipPrimarySetupAccountCreation", n => { SkipPrimarySetupAccountCreation = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("accessibilityScreenDisabled", AccessibilityScreenDisabled);
            writer.WriteBoolValue("autoUnlockWithWatchDisabled", AutoUnlockWithWatchDisabled);
            writer.WriteBoolValue("chooseYourLockScreenDisabled", ChooseYourLockScreenDisabled);
            writer.WriteBoolValue("dontAutoPopulatePrimaryAccountInfo", DontAutoPopulatePrimaryAccountInfo);
            writer.WriteBoolValue("enableRestrictEditing", EnableRestrictEditing);
            writer.WriteBoolValue("fileVaultDisabled", FileVaultDisabled);
            writer.WriteBoolValue("iCloudDiagnosticsDisabled", ICloudDiagnosticsDisabled);
            writer.WriteBoolValue("iCloudStorageDisabled", ICloudStorageDisabled);
            writer.WriteBoolValue("passCodeDisabled", PassCodeDisabled);
            writer.WriteStringValue("primaryAccountFullName", PrimaryAccountFullName);
            writer.WriteStringValue("primaryAccountUserName", PrimaryAccountUserName);
            writer.WriteBoolValue("registrationDisabled", RegistrationDisabled);
            writer.WriteBoolValue("setPrimarySetupAccountAsRegularUser", SetPrimarySetupAccountAsRegularUser);
            writer.WriteBoolValue("skipPrimarySetupAccountCreation", SkipPrimarySetupAccountCreation);
            writer.WriteBoolValue("zoomDisabled", ZoomDisabled);
        }
    }
}
