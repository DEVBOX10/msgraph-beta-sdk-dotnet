using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.InformationProtection.SensitivityLabels.Item.Sublabels.Evaluate {
    /// <summary>Provides operations to call the evaluate method.</summary>
    public class EvaluateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The currentLabel property</summary>
        public Microsoft.Graph.Beta.Models.CurrentLabel CurrentLabel { get; set; }
        /// <summary>The discoveredSensitiveTypes property</summary>
        public List<DiscoveredSensitiveType> DiscoveredSensitiveTypes { get; set; }
        /// <summary>
        /// Instantiates a new evaluateRequestBody and sets the default values.
        /// </summary>
        public EvaluateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"currentLabel", n => { CurrentLabel = n.GetObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>(Microsoft.Graph.Beta.Models.CurrentLabel.CreateFromDiscriminatorValue); } },
                {"discoveredSensitiveTypes", n => { DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<DiscoveredSensitiveType>(DiscoveredSensitiveType.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
