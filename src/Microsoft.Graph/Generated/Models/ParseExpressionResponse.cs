using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ParseExpressionResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Error details, if expression evaluation resulted in an error.</summary>
        public PublicError Error {
            get { return BackingStore?.Get<PublicError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>A collection of values produced by the evaluation of the expression.</summary>
        public List<string> EvaluationResult {
            get { return BackingStore?.Get<List<string>>("evaluationResult"); }
            set { BackingStore?.Set("evaluationResult", value); }
        }
        /// <summary>true if the evaluation was successful.</summary>
        public bool? EvaluationSucceeded {
            get { return BackingStore?.Get<bool?>("evaluationSucceeded"); }
            set { BackingStore?.Set("evaluationSucceeded", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>An attributeMappingSource object representing the parsed expression.</summary>
        public AttributeMappingSource ParsedExpression {
            get { return BackingStore?.Get<AttributeMappingSource>("parsedExpression"); }
            set { BackingStore?.Set("parsedExpression", value); }
        }
        /// <summary>true if the expression was parsed successfully.</summary>
        public bool? ParsingSucceeded {
            get { return BackingStore?.Get<bool?>("parsingSucceeded"); }
            set { BackingStore?.Set("parsingSucceeded", value); }
        }
        /// <summary>
        /// Instantiates a new parseExpressionResponse and sets the default values.
        /// </summary>
        public ParseExpressionResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.parseExpressionResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ParseExpressionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParseExpressionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"error", n => { Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                {"evaluationResult", n => { EvaluationResult = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"evaluationSucceeded", n => { EvaluationSucceeded = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parsedExpression", n => { ParsedExpression = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                {"parsingSucceeded", n => { ParsingSucceeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("evaluationResult", EvaluationResult);
            writer.WriteBoolValue("evaluationSucceeded", EvaluationSucceeded);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AttributeMappingSource>("parsedExpression", ParsedExpression);
            writer.WriteBoolValue("parsingSucceeded", ParsingSucceeded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
