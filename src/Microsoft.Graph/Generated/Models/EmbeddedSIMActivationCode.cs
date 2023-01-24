using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The embedded SIM activation code as provided by the mobile operator.
    /// </summary>
    public class EmbeddedSIMActivationCode : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The Integrated Circuit Card Identifier (ICCID) for this embedded SIM activation code as provided by the mobile operator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IntegratedCircuitCardIdentifier {
            get { return BackingStore?.Get<string?>("integratedCircuitCardIdentifier"); }
            set { BackingStore?.Set("integratedCircuitCardIdentifier", value); }
        }
#nullable restore
#else
        public string IntegratedCircuitCardIdentifier {
            get { return BackingStore?.Get<string>("integratedCircuitCardIdentifier"); }
            set { BackingStore?.Set("integratedCircuitCardIdentifier", value); }
        }
#endif
        /// <summary>The MatchingIdentifier (MatchingID) as specified in the GSMA Association SGP.22 RSP Technical Specification section 4.1.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MatchingIdentifier {
            get { return BackingStore?.Get<string?>("matchingIdentifier"); }
            set { BackingStore?.Set("matchingIdentifier", value); }
        }
#nullable restore
#else
        public string MatchingIdentifier {
            get { return BackingStore?.Get<string>("matchingIdentifier"); }
            set { BackingStore?.Set("matchingIdentifier", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The fully qualified domain name of the SM-DP+ server as specified in the GSM Association SPG .22 RSP Technical Specification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SmdpPlusServerAddress {
            get { return BackingStore?.Get<string?>("smdpPlusServerAddress"); }
            set { BackingStore?.Set("smdpPlusServerAddress", value); }
        }
#nullable restore
#else
        public string SmdpPlusServerAddress {
            get { return BackingStore?.Get<string>("smdpPlusServerAddress"); }
            set { BackingStore?.Set("smdpPlusServerAddress", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new embeddedSIMActivationCode and sets the default values.
        /// </summary>
        public EmbeddedSIMActivationCode() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EmbeddedSIMActivationCode CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmbeddedSIMActivationCode();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"integratedCircuitCardIdentifier", n => { IntegratedCircuitCardIdentifier = n.GetStringValue(); } },
                {"matchingIdentifier", n => { MatchingIdentifier = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"smdpPlusServerAddress", n => { SmdpPlusServerAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("integratedCircuitCardIdentifier", IntegratedCircuitCardIdentifier);
            writer.WriteStringValue("matchingIdentifier", MatchingIdentifier);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("smdpPlusServerAddress", SmdpPlusServerAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
