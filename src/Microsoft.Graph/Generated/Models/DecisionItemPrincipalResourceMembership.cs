using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DecisionItemPrincipalResourceMembership : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The membershipType property</summary>
        public DecisionItemPrincipalResourceMembershipType? MembershipType { get; set; }
        /// <summary>
        /// Instantiates a new decisionItemPrincipalResourceMembership and sets the default values.
        /// </summary>
        public DecisionItemPrincipalResourceMembership() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DecisionItemPrincipalResourceMembership CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DecisionItemPrincipalResourceMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"membershipType", n => { MembershipType = n.GetEnumValue<DecisionItemPrincipalResourceMembershipType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DecisionItemPrincipalResourceMembershipType>("membershipType", MembershipType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
