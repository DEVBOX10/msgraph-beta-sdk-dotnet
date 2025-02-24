// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkActivePeripherals : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The communicationSpeaker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheral? CommunicationSpeaker {
            get { return BackingStore?.Get<TeamworkPeripheral?>("communicationSpeaker"); }
            set { BackingStore?.Set("communicationSpeaker", value); }
        }
#nullable restore
#else
        public TeamworkPeripheral CommunicationSpeaker {
            get { return BackingStore?.Get<TeamworkPeripheral>("communicationSpeaker"); }
            set { BackingStore?.Set("communicationSpeaker", value); }
        }
#endif
        /// <summary>The contentCamera property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheral? ContentCamera {
            get { return BackingStore?.Get<TeamworkPeripheral?>("contentCamera"); }
            set { BackingStore?.Set("contentCamera", value); }
        }
#nullable restore
#else
        public TeamworkPeripheral ContentCamera {
            get { return BackingStore?.Get<TeamworkPeripheral>("contentCamera"); }
            set { BackingStore?.Set("contentCamera", value); }
        }
#endif
        /// <summary>The microphone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheral? Microphone {
            get { return BackingStore?.Get<TeamworkPeripheral?>("microphone"); }
            set { BackingStore?.Set("microphone", value); }
        }
#nullable restore
#else
        public TeamworkPeripheral Microphone {
            get { return BackingStore?.Get<TeamworkPeripheral>("microphone"); }
            set { BackingStore?.Set("microphone", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The roomCamera property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheral? RoomCamera {
            get { return BackingStore?.Get<TeamworkPeripheral?>("roomCamera"); }
            set { BackingStore?.Set("roomCamera", value); }
        }
#nullable restore
#else
        public TeamworkPeripheral RoomCamera {
            get { return BackingStore?.Get<TeamworkPeripheral>("roomCamera"); }
            set { BackingStore?.Set("roomCamera", value); }
        }
#endif
        /// <summary>The speaker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheral? Speaker {
            get { return BackingStore?.Get<TeamworkPeripheral?>("speaker"); }
            set { BackingStore?.Set("speaker", value); }
        }
#nullable restore
#else
        public TeamworkPeripheral Speaker {
            get { return BackingStore?.Get<TeamworkPeripheral>("speaker"); }
            set { BackingStore?.Set("speaker", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkActivePeripherals and sets the default values.
        /// </summary>
        public TeamworkActivePeripherals() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkActivePeripherals CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkActivePeripherals();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"communicationSpeaker", n => { CommunicationSpeaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"contentCamera", n => { ContentCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"microphone", n => { Microphone = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"roomCamera", n => { RoomCamera = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"speaker", n => { Speaker = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("communicationSpeaker", CommunicationSpeaker);
            writer.WriteObjectValue<TeamworkPeripheral>("contentCamera", ContentCamera);
            writer.WriteObjectValue<TeamworkPeripheral>("microphone", Microphone);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkPeripheral>("roomCamera", RoomCamera);
            writer.WriteObjectValue<TeamworkPeripheral>("speaker", Speaker);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
