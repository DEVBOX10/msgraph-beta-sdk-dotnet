using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceEnrollmentNotificationConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
        public EnrollmentNotificationBrandingOptions? BrandingOptions {
            get { return BackingStore?.Get<EnrollmentNotificationBrandingOptions?>("brandingOptions"); }
            set { BackingStore?.Set("brandingOptions", value); }
        }
        /// <summary>DefaultLocale for the Enrollment Notification</summary>
        public string DefaultLocale {
            get { return BackingStore?.Get<string>("defaultLocale"); }
            set { BackingStore?.Set("defaultLocale", value); }
        }
        /// <summary>Notification Message Template Id</summary>
        public string NotificationMessageTemplateId {
            get { return BackingStore?.Get<string>("notificationMessageTemplateId"); }
            set { BackingStore?.Set("notificationMessageTemplateId", value); }
        }
        /// <summary>This enum indicates the platform type for which the enrollment restriction applies.</summary>
        public EnrollmentRestrictionPlatformType? PlatformType {
            get { return BackingStore?.Get<EnrollmentRestrictionPlatformType?>("platformType"); }
            set { BackingStore?.Set("platformType", value); }
        }
        /// <summary>This enum indicates the Template type for which the enrollment notification applies.</summary>
        public EnrollmentNotificationTemplateType? TemplateType {
            get { return BackingStore?.Get<EnrollmentNotificationTemplateType?>("templateType"); }
            set { BackingStore?.Set("templateType", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceEnrollmentNotificationConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentNotificationConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceEnrollmentNotificationConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceEnrollmentNotificationConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentNotificationConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"brandingOptions", n => { BrandingOptions = n.GetEnumValue<EnrollmentNotificationBrandingOptions>(); } },
                {"defaultLocale", n => { DefaultLocale = n.GetStringValue(); } },
                {"notificationMessageTemplateId", n => { NotificationMessageTemplateId = n.GetStringValue(); } },
                {"platformType", n => { PlatformType = n.GetEnumValue<EnrollmentRestrictionPlatformType>(); } },
                {"templateType", n => { TemplateType = n.GetEnumValue<EnrollmentNotificationTemplateType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EnrollmentNotificationBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteStringValue("notificationMessageTemplateId", NotificationMessageTemplateId);
            writer.WriteEnumValue<EnrollmentRestrictionPlatformType>("platformType", PlatformType);
            writer.WriteEnumValue<EnrollmentNotificationTemplateType>("templateType", TemplateType);
        }
    }
}
