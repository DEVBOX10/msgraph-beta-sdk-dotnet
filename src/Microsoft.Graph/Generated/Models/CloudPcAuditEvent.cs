using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcAuditEvent : Entity, IParsable {
        /// <summary>Friendly name of the activity. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Activity {
            get { return BackingStore?.Get<string?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public string Activity {
            get { return BackingStore?.Get<string>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The date time in UTC when the activity was performed. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>The activityOperationType property</summary>
        public CloudPcAuditActivityOperationType? ActivityOperationType {
            get { return BackingStore?.Get<CloudPcAuditActivityOperationType?>("activityOperationType"); }
            set { BackingStore?.Set("activityOperationType", value); }
        }
        /// <summary>The activityResult property</summary>
        public CloudPcAuditActivityResult? ActivityResult {
            get { return BackingStore?.Get<CloudPcAuditActivityResult?>("activityResult"); }
            set { BackingStore?.Set("activityResult", value); }
        }
        /// <summary>The type of activity that was performed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityType {
            get { return BackingStore?.Get<string?>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#nullable restore
#else
        public string ActivityType {
            get { return BackingStore?.Get<string>("activityType"); }
            set { BackingStore?.Set("activityType", value); }
        }
#endif
        /// <summary>The actor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcAuditActor? Actor {
            get { return BackingStore?.Get<CloudPcAuditActor?>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#nullable restore
#else
        public CloudPcAuditActor Actor {
            get { return BackingStore?.Get<CloudPcAuditActor>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
#endif
        /// <summary>The category property</summary>
        public CloudPcAuditCategory? Category {
            get { return BackingStore?.Get<CloudPcAuditCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>Component name. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ComponentName {
            get { return BackingStore?.Get<string?>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
#nullable restore
#else
        public string ComponentName {
            get { return BackingStore?.Get<string>("componentName"); }
            set { BackingStore?.Set("componentName", value); }
        }
#endif
        /// <summary>The client request identifier, used to correlate activity within the system. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>Event display name. Read-only.</summary>
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
        /// <summary>List of cloudPcAuditResource objects. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcAuditResource>? Resources {
            get { return BackingStore?.Get<List<CloudPcAuditResource>?>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#nullable restore
#else
        public List<CloudPcAuditResource> Resources {
            get { return BackingStore?.Get<List<CloudPcAuditResource>>("resources"); }
            set { BackingStore?.Set("resources", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcAuditEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcAuditEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityOperationType", n => { ActivityOperationType = n.GetEnumValue<CloudPcAuditActivityOperationType>(); } },
                {"activityResult", n => { ActivityResult = n.GetEnumValue<CloudPcAuditActivityResult>(); } },
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"actor", n => { Actor = n.GetObjectValue<CloudPcAuditActor>(CloudPcAuditActor.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetEnumValue<CloudPcAuditCategory>(); } },
                {"componentName", n => { ComponentName = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resources", n => { Resources = n.GetCollectionOfObjectValues<CloudPcAuditResource>(CloudPcAuditResource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteEnumValue<CloudPcAuditActivityOperationType>("activityOperationType", ActivityOperationType);
            writer.WriteEnumValue<CloudPcAuditActivityResult>("activityResult", ActivityResult);
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteObjectValue<CloudPcAuditActor>("actor", Actor);
            writer.WriteEnumValue<CloudPcAuditCategory>("category", Category);
            writer.WriteStringValue("componentName", ComponentName);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<CloudPcAuditResource>("resources", Resources);
        }
    }
}
