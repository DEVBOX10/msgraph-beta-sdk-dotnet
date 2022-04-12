using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TrustFramework : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keySets property</summary>
        public List<TrustFrameworkKeySet> KeySets { get; set; }
        /// <summary>The policies property</summary>
        public List<TrustFrameworkPolicy> Policies { get; set; }
        /// <summary>
        /// Instantiates a new TrustFramework and sets the default values.
        /// </summary>
        public TrustFramework() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TrustFramework CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrustFramework();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keySets", n => { KeySets = n.GetCollectionOfObjectValues<TrustFrameworkKeySet>(TrustFrameworkKeySet.CreateFromDiscriminatorValue).ToList(); } },
                {"policies", n => { Policies = n.GetCollectionOfObjectValues<TrustFrameworkPolicy>(TrustFrameworkPolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<TrustFrameworkKeySet>("keySets", KeySets);
            writer.WriteCollectionOfObjectValues<TrustFrameworkPolicy>("policies", Policies);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
