using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Communications.Calls.Item.MicrosoftGraphTransfer {
    public class TransferPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The transferee property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ParticipantInfo? Transferee {
            get { return BackingStore?.Get<ParticipantInfo?>("transferee"); }
            set { BackingStore?.Set("transferee", value); }
        }
#nullable restore
#else
        public ParticipantInfo Transferee {
            get { return BackingStore?.Get<ParticipantInfo>("transferee"); }
            set { BackingStore?.Set("transferee", value); }
        }
#endif
        /// <summary>The transferTarget property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InvitationParticipantInfo? TransferTarget {
            get { return BackingStore?.Get<InvitationParticipantInfo?>("transferTarget"); }
            set { BackingStore?.Set("transferTarget", value); }
        }
#nullable restore
#else
        public InvitationParticipantInfo TransferTarget {
            get { return BackingStore?.Get<InvitationParticipantInfo>("transferTarget"); }
            set { BackingStore?.Set("transferTarget", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new transferPostRequestBody and sets the default values.
        /// </summary>
        public TransferPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TransferPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TransferPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"transferee", n => { Transferee = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"transferTarget", n => { TransferTarget = n.GetObjectValue<InvitationParticipantInfo>(InvitationParticipantInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ParticipantInfo>("transferee", Transferee);
            writer.WriteObjectValue<InvitationParticipantInfo>("transferTarget", TransferTarget);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
