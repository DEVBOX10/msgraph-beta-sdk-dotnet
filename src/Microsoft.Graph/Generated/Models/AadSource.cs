// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AadSource : AuthorizationSystemIdentitySource, IParsable {
        /// <summary>The domain property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Domain {
            get { return BackingStore?.Get<string?>("domain"); }
            set { BackingStore?.Set("domain", value); }
        }
#nullable restore
#else
        public string Domain {
            get { return BackingStore?.Get<string>("domain"); }
            set { BackingStore?.Set("domain", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new aadSource and sets the default values.
        /// </summary>
        public AadSource() : base() {
            OdataType = "#microsoft.graph.aadSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AadSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AadSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"domain", n => { Domain = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("domain", Domain);
        }
    }
}
