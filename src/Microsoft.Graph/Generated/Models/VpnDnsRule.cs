using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// VPN DNS Rule definition.
    /// </summary>
    public class VpnDnsRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Automatically connect to the VPN when the device connects to this domain: Default False.</summary>
        public bool? AutoTrigger {
            get { return BackingStore?.Get<bool?>("autoTrigger"); }
            set { BackingStore?.Set("autoTrigger", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
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
        /// <summary>Keep this rule active even when the VPN is not connected: Default False</summary>
        public bool? Persistent {
            get { return BackingStore?.Get<bool?>("persistent"); }
            set { BackingStore?.Set("persistent", value); }
        }
        /// <summary>Proxy Server Uri.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProxyServerUri {
            get { return BackingStore?.Get<string?>("proxyServerUri"); }
            set { BackingStore?.Set("proxyServerUri", value); }
        }
#nullable restore
#else
        public string ProxyServerUri {
            get { return BackingStore?.Get<string>("proxyServerUri"); }
            set { BackingStore?.Set("proxyServerUri", value); }
        }
#endif
        /// <summary>Servers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Servers {
            get { return BackingStore?.Get<List<string>?>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#nullable restore
#else
        public List<string> Servers {
            get { return BackingStore?.Get<List<string>>("servers"); }
            set { BackingStore?.Set("servers", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new vpnDnsRule and sets the default values.
        /// </summary>
        public VpnDnsRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VpnDnsRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VpnDnsRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"autoTrigger", n => { AutoTrigger = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"persistent", n => { Persistent = n.GetBoolValue(); } },
                {"proxyServerUri", n => { ProxyServerUri = n.GetStringValue(); } },
                {"servers", n => { Servers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("autoTrigger", AutoTrigger);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("persistent", Persistent);
            writer.WriteStringValue("proxyServerUri", ProxyServerUri);
            writer.WriteCollectionOfPrimitiveValues<string>("servers", Servers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
