using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkContentCameraConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>True if the content camera is inverted.</summary>
        public bool? IsContentCameraInverted { get; set; }
        /// <summary>True if the content camera is optional.</summary>
        public bool? IsContentCameraOptional { get; set; }
        /// <summary>True if the content enhancement is enabled.</summary>
        public bool? IsContentEnhancementEnabled { get; set; }
        /// <summary>
        /// Instantiates a new teamworkContentCameraConfiguration and sets the default values.
        /// </summary>
        public TeamworkContentCameraConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkContentCameraConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkContentCameraConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isContentCameraInverted", n => { IsContentCameraInverted = n.GetBoolValue(); } },
                {"isContentCameraOptional", n => { IsContentCameraOptional = n.GetBoolValue(); } },
                {"isContentEnhancementEnabled", n => { IsContentEnhancementEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isContentCameraInverted", IsContentCameraInverted);
            writer.WriteBoolValue("isContentCameraOptional", IsContentCameraOptional);
            writer.WriteBoolValue("isContentEnhancementEnabled", IsContentEnhancementEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
