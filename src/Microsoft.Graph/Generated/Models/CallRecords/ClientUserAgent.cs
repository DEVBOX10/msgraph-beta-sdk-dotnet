using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    public class ClientUserAgent : UserAgent, IParsable {
        /// <summary>The unique identifier of the Azure AD application used by this endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureADAppId {
            get { return BackingStore?.Get<string?>("azureADAppId"); }
            set { BackingStore?.Set("azureADAppId", value); }
        }
#nullable restore
#else
        public string AzureADAppId {
            get { return BackingStore?.Get<string>("azureADAppId"); }
            set { BackingStore?.Set("azureADAppId", value); }
        }
#endif
        /// <summary>Immutable resource identifier of the Azure Communication Service associated with this endpoint based on Communication Services APIs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommunicationServiceId {
            get { return BackingStore?.Get<string?>("communicationServiceId"); }
            set { BackingStore?.Set("communicationServiceId", value); }
        }
#nullable restore
#else
        public string CommunicationServiceId {
            get { return BackingStore?.Get<string>("communicationServiceId"); }
            set { BackingStore?.Set("communicationServiceId", value); }
        }
#endif
        /// <summary>The platform property</summary>
        public ClientPlatform? Platform {
            get { return BackingStore?.Get<ClientPlatform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>The productFamily property</summary>
        public Microsoft.Graph.Beta.Models.CallRecords.ProductFamily? ProductFamily {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecords.ProductFamily?>("productFamily"); }
            set { BackingStore?.Set("productFamily", value); }
        }
        /// <summary>
        /// Instantiates a new ClientUserAgent and sets the default values.
        /// </summary>
        public ClientUserAgent() : base() {
            OdataType = "#microsoft.graph.callRecords.clientUserAgent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ClientUserAgent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClientUserAgent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureADAppId", n => { AzureADAppId = n.GetStringValue(); } },
                {"communicationServiceId", n => { CommunicationServiceId = n.GetStringValue(); } },
                {"platform", n => { Platform = n.GetEnumValue<ClientPlatform>(); } },
                {"productFamily", n => { ProductFamily = n.GetEnumValue<ProductFamily>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureADAppId", AzureADAppId);
            writer.WriteStringValue("communicationServiceId", CommunicationServiceId);
            writer.WriteEnumValue<ClientPlatform>("platform", Platform);
            writer.WriteEnumValue<ProductFamily>("productFamily", ProductFamily);
        }
    }
}
