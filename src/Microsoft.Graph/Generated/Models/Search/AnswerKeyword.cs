using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Search {
    public class AnswerKeyword : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A collection of keywords used to trigger the search answer.</summary>
        public List<string> Keywords {
            get { return BackingStore?.Get<List<string>>("keywords"); }
            set { BackingStore?.Set("keywords", value); }
        }
        /// <summary>If true, indicates that the search term contains similar words to the keywords that should trigger the search answer.</summary>
        public bool? MatchSimilarKeywords {
            get { return BackingStore?.Get<bool?>("matchSimilarKeywords"); }
            set { BackingStore?.Set("matchSimilarKeywords", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Unique keywords that will guarantee the search answer is triggered.</summary>
        public List<string> ReservedKeywords {
            get { return BackingStore?.Get<List<string>>("reservedKeywords"); }
            set { BackingStore?.Set("reservedKeywords", value); }
        }
        /// <summary>
        /// Instantiates a new answerKeyword and sets the default values.
        /// </summary>
        public AnswerKeyword() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.search.answerKeyword";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AnswerKeyword CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerKeyword();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keywords", n => { Keywords = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"matchSimilarKeywords", n => { MatchSimilarKeywords = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reservedKeywords", n => { ReservedKeywords = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("keywords", Keywords);
            writer.WriteBoolValue("matchSimilarKeywords", MatchSimilarKeywords);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("reservedKeywords", ReservedKeywords);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
