// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.InformationProtection.Policy.Labels.EvaluateClassificationResults {
    public class EvaluateClassificationResultsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The classificationResults property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ClassificationResult>? ClassificationResults {
            get { return BackingStore?.Get<List<ClassificationResult>?>("classificationResults"); }
            set { BackingStore?.Set("classificationResults", value); }
        }
#nullable restore
#else
        public List<ClassificationResult> ClassificationResults {
            get { return BackingStore?.Get<List<ClassificationResult>>("classificationResults"); }
            set { BackingStore?.Set("classificationResults", value); }
        }
#endif
        /// <summary>The contentInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ContentInfo? ContentInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContentInfo?>("contentInfo"); }
            set { BackingStore?.Set("contentInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ContentInfo ContentInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ContentInfo>("contentInfo"); }
            set { BackingStore?.Set("contentInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new evaluateClassificationResultsPostRequestBody and sets the default values.
        /// </summary>
        public EvaluateClassificationResultsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EvaluateClassificationResultsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateClassificationResultsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"classificationResults", n => { ClassificationResults = n.GetCollectionOfObjectValues<ClassificationResult>(ClassificationResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>(Microsoft.Graph.Beta.Models.ContentInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationResult>("classificationResults", ClassificationResults);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
