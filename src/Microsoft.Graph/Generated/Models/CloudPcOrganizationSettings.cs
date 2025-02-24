// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcOrganizationSettings : Entity, IParsable {
        /// <summary>Specifies whether new Cloud PCs will be automatically enrolled in Microsoft Endpoint Manager (MEM). The default value is false.</summary>
        public bool? EnableMEMAutoEnroll {
            get { return BackingStore?.Get<bool?>("enableMEMAutoEnroll"); }
            set { BackingStore?.Set("enableMEMAutoEnroll", value); }
        }
        /// <summary>True if the provisioned Cloud PC can be accessed by single sign-on. False indicates that the provisioned Cloud PC doesn&apos;t support this feature. Default value is false. Windows 365 users can use single sign-on to authenticate to Microsoft Entra ID with passwordless options (for example, FIDO keys) to access their Cloud PC. Optional.</summary>
        public bool? EnableSingleSignOn {
            get { return BackingStore?.Get<bool?>("enableSingleSignOn"); }
            set { BackingStore?.Set("enableSingleSignOn", value); }
        }
        /// <summary>The version of the operating system (OS) to provision on Cloud PCs. The possible values are: windows10, windows11, unknownFutureValue.</summary>
        public CloudPcOperatingSystem? OsVersion {
            get { return BackingStore?.Get<CloudPcOperatingSystem?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
        /// <summary>The account type of the user on provisioned Cloud PCs. The possible values are: standardUser, administrator, unknownFutureValue.</summary>
        public CloudPcUserAccountType? UserAccountType {
            get { return BackingStore?.Get<CloudPcUserAccountType?>("userAccountType"); }
            set { BackingStore?.Set("userAccountType", value); }
        }
        /// <summary>Represents the Cloud PC organization settings for a tenant. A tenant has only one cloudPcOrganizationSettings object. The default language value en-US.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcWindowsSettings? WindowsSettings {
            get { return BackingStore?.Get<CloudPcWindowsSettings?>("windowsSettings"); }
            set { BackingStore?.Set("windowsSettings", value); }
        }
#nullable restore
#else
        public CloudPcWindowsSettings WindowsSettings {
            get { return BackingStore?.Get<CloudPcWindowsSettings>("windowsSettings"); }
            set { BackingStore?.Set("windowsSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcOrganizationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOrganizationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enableMEMAutoEnroll", n => { EnableMEMAutoEnroll = n.GetBoolValue(); } },
                {"enableSingleSignOn", n => { EnableSingleSignOn = n.GetBoolValue(); } },
                {"osVersion", n => { OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
                {"windowsSettings", n => { WindowsSettings = n.GetObjectValue<CloudPcWindowsSettings>(CloudPcWindowsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enableMEMAutoEnroll", EnableMEMAutoEnroll);
            writer.WriteBoolValue("enableSingleSignOn", EnableSingleSignOn);
            writer.WriteEnumValue<CloudPcOperatingSystem>("osVersion", OsVersion);
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteObjectValue<CloudPcWindowsSettings>("windowsSettings", WindowsSettings);
        }
    }
}
