using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcExternalPartnerSetting : Entity, IParsable {
        /// <summary>Enable or disable the connection to an external partner. If true, an external partner API will accept incoming calls from external partners. Required. Supports $filter (eq).</summary>
        public bool? EnableConnection {
            get { return BackingStore?.Get<bool?>("enableConnection"); }
            set { BackingStore?.Set("enableConnection", value); }
        }
        /// <summary>Last data sync time for this external partner. The Timestamp type represents the date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: &apos;2014-01-01T00:00:00Z&apos;.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The external partner ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PartnerId {
            get { return BackingStore?.Get<string?>("partnerId"); }
            set { BackingStore?.Set("partnerId", value); }
        }
#nullable restore
#else
        public string PartnerId {
            get { return BackingStore?.Get<string>("partnerId"); }
            set { BackingStore?.Set("partnerId", value); }
        }
#endif
        /// <summary>The status property</summary>
        public CloudPcExternalPartnerStatus? Status {
            get { return BackingStore?.Get<CloudPcExternalPartnerStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Status details message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusDetails {
            get { return BackingStore?.Get<string?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#nullable restore
#else
        public string StatusDetails {
            get { return BackingStore?.Get<string>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcExternalPartnerSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcExternalPartnerSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enableConnection", n => { EnableConnection = n.GetBoolValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"partnerId", n => { PartnerId = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<CloudPcExternalPartnerStatus>(); } },
                {"statusDetails", n => { StatusDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enableConnection", EnableConnection);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("partnerId", PartnerId);
            writer.WriteEnumValue<CloudPcExternalPartnerStatus>("status", Status);
            writer.WriteStringValue("statusDetails", StatusDetails);
        }
    }
}
