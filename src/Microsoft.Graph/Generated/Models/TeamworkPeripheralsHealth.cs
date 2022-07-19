using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkPeripheralsHealth : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The health details about the communication speaker.</summary>
        public TeamworkPeripheralHealth CommunicationSpeakerHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>("communicationSpeakerHealth"); }
            set { BackingStore?.Set("communicationSpeakerHealth", value); }
        }
        /// <summary>The health details about the content camera.</summary>
        public TeamworkPeripheralHealth ContentCameraHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>("contentCameraHealth"); }
            set { BackingStore?.Set("contentCameraHealth", value); }
        }
        /// <summary>The health details about displays.</summary>
        public List<TeamworkPeripheralHealth> DisplayHealthCollection {
            get { return BackingStore?.Get<List<TeamworkPeripheralHealth>>("displayHealthCollection"); }
            set { BackingStore?.Set("displayHealthCollection", value); }
        }
        /// <summary>The health details about the microphone.</summary>
        public TeamworkPeripheralHealth MicrophoneHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>("microphoneHealth"); }
            set { BackingStore?.Set("microphoneHealth", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The health details about the room camera.</summary>
        public TeamworkPeripheralHealth RoomCameraHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>("roomCameraHealth"); }
            set { BackingStore?.Set("roomCameraHealth", value); }
        }
        /// <summary>The health details about the speaker.</summary>
        public TeamworkPeripheralHealth SpeakerHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>("speakerHealth"); }
            set { BackingStore?.Set("speakerHealth", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkPeripheralsHealth and sets the default values.
        /// </summary>
        public TeamworkPeripheralsHealth() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkPeripheralsHealth";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkPeripheralsHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkPeripheralsHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"communicationSpeakerHealth", n => { CommunicationSpeakerHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                {"contentCameraHealth", n => { ContentCameraHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                {"displayHealthCollection", n => { DisplayHealthCollection = n.GetCollectionOfObjectValues<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue).ToList(); } },
                {"microphoneHealth", n => { MicrophoneHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"roomCameraHealth", n => { RoomCameraHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                {"speakerHealth", n => { SpeakerHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheralHealth>("communicationSpeakerHealth", CommunicationSpeakerHealth);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("contentCameraHealth", ContentCameraHealth);
            writer.WriteCollectionOfObjectValues<TeamworkPeripheralHealth>("displayHealthCollection", DisplayHealthCollection);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("microphoneHealth", MicrophoneHealth);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("roomCameraHealth", RoomCameraHealth);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("speakerHealth", SpeakerHealth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
