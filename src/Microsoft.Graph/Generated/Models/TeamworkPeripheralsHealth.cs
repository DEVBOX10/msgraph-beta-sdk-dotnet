using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkPeripheralsHealth : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The health details about the communication speaker.</summary>
        public TeamworkPeripheralHealth CommunicationSpeakerHealth { get; set; }
        /// <summary>The health details about the content camera.</summary>
        public TeamworkPeripheralHealth ContentCameraHealth { get; set; }
        /// <summary>The health details about displays.</summary>
        public List<TeamworkPeripheralHealth> DisplayHealthCollection { get; set; }
        /// <summary>The health details about the microphone.</summary>
        public TeamworkPeripheralHealth MicrophoneHealth { get; set; }
        /// <summary>The health details about the room camera.</summary>
        public TeamworkPeripheralHealth RoomCameraHealth { get; set; }
        /// <summary>The health details about the speaker.</summary>
        public TeamworkPeripheralHealth SpeakerHealth { get; set; }
        /// <summary>
        /// Instantiates a new teamworkPeripheralsHealth and sets the default values.
        /// </summary>
        public TeamworkPeripheralsHealth() {
            AdditionalData = new Dictionary<string, object>();
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
            writer.WriteObjectValue<TeamworkPeripheralHealth>("roomCameraHealth", RoomCameraHealth);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("speakerHealth", SpeakerHealth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
