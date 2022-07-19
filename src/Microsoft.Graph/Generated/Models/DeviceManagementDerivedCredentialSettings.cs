using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementDerivedCredentialSettings : Entity, IParsable {
        /// <summary>The display name for the profile.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The URL that will be accessible to end users as they retrieve a derived credential using the Company Portal.</summary>
        public string HelpUrl {
            get { return BackingStore?.Get<string>("helpUrl"); }
            set { BackingStore?.Set("helpUrl", value); }
        }
        /// <summary>Supported values for the derived credential issuer.</summary>
        public DeviceManagementDerivedCredentialIssuer? Issuer {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialIssuer?>("issuer"); }
            set { BackingStore?.Set("issuer", value); }
        }
        /// <summary>Supported values for the notification type to use.</summary>
        public DeviceManagementDerivedCredentialNotificationType? NotificationType {
            get { return BackingStore?.Get<DeviceManagementDerivedCredentialNotificationType?>("notificationType"); }
            set { BackingStore?.Set("notificationType", value); }
        }
        /// <summary>The nominal percentage of time before certificate renewal is initiated by the client.</summary>
        public int? RenewalThresholdPercentage {
            get { return BackingStore?.Get<int?>("renewalThresholdPercentage"); }
            set { BackingStore?.Set("renewalThresholdPercentage", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementDerivedCredentialSettings and sets the default values.
        /// </summary>
        public DeviceManagementDerivedCredentialSettings() : base() {
            OdataType = "#microsoft.graph.deviceManagementDerivedCredentialSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementDerivedCredentialSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementDerivedCredentialSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpUrl", n => { HelpUrl = n.GetStringValue(); } },
                {"issuer", n => { Issuer = n.GetEnumValue<DeviceManagementDerivedCredentialIssuer>(); } },
                {"notificationType", n => { NotificationType = n.GetEnumValue<DeviceManagementDerivedCredentialNotificationType>(); } },
                {"renewalThresholdPercentage", n => { RenewalThresholdPercentage = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpUrl", HelpUrl);
            writer.WriteEnumValue<DeviceManagementDerivedCredentialIssuer>("issuer", Issuer);
            writer.WriteEnumValue<DeviceManagementDerivedCredentialNotificationType>("notificationType", NotificationType);
            writer.WriteIntValue("renewalThresholdPercentage", RenewalThresholdPercentage);
        }
    }
}
