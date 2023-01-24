using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OnTokenIssuanceStartCustomExtension : CustomAuthenticationExtension, IParsable {
        /// <summary>The claimsForTokenConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnTokenIssuanceStartReturnClaim>? ClaimsForTokenConfiguration {
            get { return BackingStore?.Get<List<OnTokenIssuanceStartReturnClaim>?>("claimsForTokenConfiguration"); }
            set { BackingStore?.Set("claimsForTokenConfiguration", value); }
        }
#nullable restore
#else
        public List<OnTokenIssuanceStartReturnClaim> ClaimsForTokenConfiguration {
            get { return BackingStore?.Get<List<OnTokenIssuanceStartReturnClaim>>("claimsForTokenConfiguration"); }
            set { BackingStore?.Set("claimsForTokenConfiguration", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new OnTokenIssuanceStartCustomExtension and sets the default values.
        /// </summary>
        public OnTokenIssuanceStartCustomExtension() : base() {
            OdataType = "#microsoft.graph.onTokenIssuanceStartCustomExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnTokenIssuanceStartCustomExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnTokenIssuanceStartCustomExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"claimsForTokenConfiguration", n => { ClaimsForTokenConfiguration = n.GetCollectionOfObjectValues<OnTokenIssuanceStartReturnClaim>(OnTokenIssuanceStartReturnClaim.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<OnTokenIssuanceStartReturnClaim>("claimsForTokenConfiguration", ClaimsForTokenConfiguration);
        }
    }
}
