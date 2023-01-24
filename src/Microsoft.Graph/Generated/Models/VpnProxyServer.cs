using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// VPN Proxy Server.
    /// </summary>
    public class VpnProxyServer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Address {
            get { return BackingStore?.Get<string?>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#nullable restore
#else
        public string Address {
            get { return BackingStore?.Get<string>("address"); }
            set { BackingStore?.Set("address", value); }
        }
#endif
        /// <summary>Proxy&apos;s automatic configuration script url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AutomaticConfigurationScriptUrl {
            get { return BackingStore?.Get<string?>("automaticConfigurationScriptUrl"); }
            set { BackingStore?.Set("automaticConfigurationScriptUrl", value); }
        }
#nullable restore
#else
        public string AutomaticConfigurationScriptUrl {
            get { return BackingStore?.Get<string>("automaticConfigurationScriptUrl"); }
            set { BackingStore?.Set("automaticConfigurationScriptUrl", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Port. Valid values 0 to 65535</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>
        /// Instantiates a new vpnProxyServer and sets the default values.
        /// </summary>
        public VpnProxyServer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VpnProxyServer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windows10VpnProxyServer" => new Windows10VpnProxyServer(),
                "#microsoft.graph.windows81VpnProxyServer" => new Windows81VpnProxyServer(),
                _ => new VpnProxyServer(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetStringValue(); } },
                {"automaticConfigurationScriptUrl", n => { AutomaticConfigurationScriptUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("automaticConfigurationScriptUrl", AutomaticConfigurationScriptUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
