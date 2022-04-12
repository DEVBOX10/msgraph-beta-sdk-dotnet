using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ActionStep : IAdditionalDataHolder, IParsable {
        /// <summary>The actionUrl property</summary>
        public Microsoft.Graph.Beta.Models.ActionUrl ActionUrl { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The stepNumber property</summary>
        public long? StepNumber { get; set; }
        /// <summary>The text property</summary>
        public string Text { get; set; }
        /// <summary>
        /// Instantiates a new actionStep and sets the default values.
        /// </summary>
        public ActionStep() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ActionStep CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionUrl", n => { ActionUrl = n.GetObjectValue<Microsoft.Graph.Beta.Models.ActionUrl>(Microsoft.Graph.Beta.Models.ActionUrl.CreateFromDiscriminatorValue); } },
                {"stepNumber", n => { StepNumber = n.GetLongValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ActionUrl>("actionUrl", ActionUrl);
            writer.WriteLongValue("stepNumber", StepNumber);
            writer.WriteStringValue("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
