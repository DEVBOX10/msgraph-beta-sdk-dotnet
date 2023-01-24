using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BuiltInIdentityProvider : IdentityProviderBase, IParsable {
        /// <summary>The identity provider type. For a B2B scenario, possible values: AADSignup, MicrosoftAccount, EmailOTP. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProviderType {
            get { return BackingStore?.Get<string?>("identityProviderType"); }
            set { BackingStore?.Set("identityProviderType", value); }
        }
#nullable restore
#else
        public string IdentityProviderType {
            get { return BackingStore?.Get<string>("identityProviderType"); }
            set { BackingStore?.Set("identityProviderType", value); }
        }
#endif
        /// <summary>The state property</summary>
        public IdentityProviderState? State {
            get { return BackingStore?.Get<IdentityProviderState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Instantiates a new BuiltInIdentityProvider and sets the default values.
        /// </summary>
        public BuiltInIdentityProvider() : base() {
            OdataType = "#microsoft.graph.builtInIdentityProvider";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BuiltInIdentityProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BuiltInIdentityProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identityProviderType", n => { IdentityProviderType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<IdentityProviderState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("identityProviderType", IdentityProviderType);
            writer.WriteEnumValue<IdentityProviderState>("state", State);
        }
    }
}
