using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Enrollment Profile used to enroll COSU devices using Google&apos;s Cloud Management.
    /// </summary>
    public class AndroidForWorkEnrollmentProfile : Entity, IParsable {
        /// <summary>Tenant GUID the enrollment profile belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId {
            get { return BackingStore?.Get<string?>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
#nullable restore
#else
        public string AccountId {
            get { return BackingStore?.Get<string>("accountId"); }
            set { BackingStore?.Set("accountId", value); }
        }
#endif
        /// <summary>Date time the enrollment profile was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description for the enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Display name for the enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Total number of Android devices that have enrolled using this enrollment profile.</summary>
        public int? EnrolledDeviceCount {
            get { return BackingStore?.Get<int?>("enrolledDeviceCount"); }
            set { BackingStore?.Set("enrolledDeviceCount", value); }
        }
        /// <summary>Date time the enrollment profile was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QrCodeContent {
            get { return BackingStore?.Get<string?>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
#nullable restore
#else
        public string QrCodeContent {
            get { return BackingStore?.Get<string>("qrCodeContent"); }
            set { BackingStore?.Set("qrCodeContent", value); }
        }
#endif
        /// <summary>String used to generate a QR code for the token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? QrCodeImage {
            get { return BackingStore?.Get<MimeContent?>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
#nullable restore
#else
        public MimeContent QrCodeImage {
            get { return BackingStore?.Get<MimeContent>("qrCodeImage"); }
            set { BackingStore?.Set("qrCodeImage", value); }
        }
#endif
        /// <summary>Date time the most recently created token will expire.</summary>
        public DateTimeOffset? TokenExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("tokenExpirationDateTime"); }
            set { BackingStore?.Set("tokenExpirationDateTime", value); }
        }
        /// <summary>Value of the most recently created token for this enrollment profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TokenValue {
            get { return BackingStore?.Get<string?>("tokenValue"); }
            set { BackingStore?.Set("tokenValue", value); }
        }
#nullable restore
#else
        public string TokenValue {
            get { return BackingStore?.Get<string>("tokenValue"); }
            set { BackingStore?.Set("tokenValue", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidForWorkEnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidForWorkEnrollmentProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrolledDeviceCount", n => { EnrolledDeviceCount = n.GetIntValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"qrCodeContent", n => { QrCodeContent = n.GetStringValue(); } },
                {"qrCodeImage", n => { QrCodeImage = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"tokenExpirationDateTime", n => { TokenExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"tokenValue", n => { TokenValue = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("enrolledDeviceCount", EnrolledDeviceCount);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("qrCodeContent", QrCodeContent);
            writer.WriteObjectValue<MimeContent>("qrCodeImage", QrCodeImage);
            writer.WriteDateTimeOffsetValue("tokenExpirationDateTime", TokenExpirationDateTime);
            writer.WriteStringValue("tokenValue", TokenValue);
        }
    }
}
