// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.Snapshots.GetSubscriptions {
    public class GetSubscriptionsGetResponse : BaseCollectionPaginationCountResponse, IParsable {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSubscription>? Value {
            get { return BackingStore?.Get<List<CloudPcSubscription>?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public List<CloudPcSubscription> Value {
            get { return BackingStore?.Get<List<CloudPcSubscription>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetSubscriptionsGetResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetSubscriptionsGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"value", n => { Value = n.GetCollectionOfObjectValues<CloudPcSubscription>(CloudPcSubscription.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CloudPcSubscription>("value", Value);
        }
    }
}
