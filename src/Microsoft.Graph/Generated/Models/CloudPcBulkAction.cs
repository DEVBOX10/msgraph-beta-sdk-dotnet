using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcBulkAction : Entity, IParsable {
        /// <summary>The actionSummary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcBulkActionSummary? ActionSummary {
            get { return BackingStore?.Get<CloudPcBulkActionSummary?>("actionSummary"); }
            set { BackingStore?.Set("actionSummary", value); }
        }
#nullable restore
#else
        public CloudPcBulkActionSummary ActionSummary {
            get { return BackingStore?.Get<CloudPcBulkActionSummary>("actionSummary"); }
            set { BackingStore?.Set("actionSummary", value); }
        }
#endif
        /// <summary>The cloudPcIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CloudPcIds {
            get { return BackingStore?.Get<List<string>?>("cloudPcIds"); }
            set { BackingStore?.Set("cloudPcIds", value); }
        }
#nullable restore
#else
        public List<string> CloudPcIds {
            get { return BackingStore?.Get<List<string>>("cloudPcIds"); }
            set { BackingStore?.Set("cloudPcIds", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The displayName property</summary>
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcBulkAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.cloudPcBulkPowerOff" => new CloudPcBulkPowerOff(),
                "#microsoft.graph.cloudPcBulkPowerOn" => new CloudPcBulkPowerOn(),
                _ => new CloudPcBulkAction(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionSummary", n => { ActionSummary = n.GetObjectValue<CloudPcBulkActionSummary>(CloudPcBulkActionSummary.CreateFromDiscriminatorValue); } },
                {"cloudPcIds", n => { CloudPcIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CloudPcBulkActionSummary>("actionSummary", ActionSummary);
            writer.WriteCollectionOfPrimitiveValues<string>("cloudPcIds", CloudPcIds);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
