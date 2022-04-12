using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DlpPoliciesJobResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The auditCorrelationId property</summary>
        public string AuditCorrelationId { get; set; }
        /// <summary>The evaluationDateTime property</summary>
        public DateTimeOffset? EvaluationDateTime { get; set; }
        /// <summary>The matchingRules property</summary>
        public List<MatchingDlpRule> MatchingRules { get; set; }
        /// <summary>
        /// Instantiates a new dlpPoliciesJobResult and sets the default values.
        /// </summary>
        public DlpPoliciesJobResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DlpPoliciesJobResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DlpPoliciesJobResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"auditCorrelationId", n => { AuditCorrelationId = n.GetStringValue(); } },
                {"evaluationDateTime", n => { EvaluationDateTime = n.GetDateTimeOffsetValue(); } },
                {"matchingRules", n => { MatchingRules = n.GetCollectionOfObjectValues<MatchingDlpRule>(MatchingDlpRule.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("auditCorrelationId", AuditCorrelationId);
            writer.WriteDateTimeOffsetValue("evaluationDateTime", EvaluationDateTime);
            writer.WriteCollectionOfObjectValues<MatchingDlpRule>("matchingRules", MatchingRules);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
