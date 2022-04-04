using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TermsAndConditionsGroupAssignment : Entity, IParsable {
        /// <summary>Unique identifier of a group that the T&amp;C policy is assigned to.</summary>
        public string TargetGroupId { get; set; }
        /// <summary>Navigation link to the terms and conditions that are assigned.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TermsAndConditions TermsAndConditions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TermsAndConditionsGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsAndConditionsGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"targetGroupId", (o,n) => { (o as TermsAndConditionsGroupAssignment).TargetGroupId = n.GetStringValue(); } },
                {"termsAndConditions", (o,n) => { (o as TermsAndConditionsGroupAssignment).TermsAndConditions = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TermsAndConditions>(MicrosoftGraphSdk.Models.Microsoft.Graph.TermsAndConditions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.TermsAndConditions>("termsAndConditions", TermsAndConditions);
        }
    }
}
