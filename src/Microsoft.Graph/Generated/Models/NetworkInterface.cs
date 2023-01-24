using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class NetworkInterface : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Description of the NIC (e.g. Ethernet adapter, Wireless LAN adapter Local Area Connection, and so on).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Last IPv4 address associated with this NIC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpV4Address {
            get { return BackingStore?.Get<string?>("ipV4Address"); }
            set { BackingStore?.Set("ipV4Address", value); }
        }
#nullable restore
#else
        public string IpV4Address {
            get { return BackingStore?.Get<string>("ipV4Address"); }
            set { BackingStore?.Set("ipV4Address", value); }
        }
#endif
        /// <summary>Last Public (aka global) IPv6 address associated with this NIC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpV6Address {
            get { return BackingStore?.Get<string?>("ipV6Address"); }
            set { BackingStore?.Set("ipV6Address", value); }
        }
#nullable restore
#else
        public string IpV6Address {
            get { return BackingStore?.Get<string>("ipV6Address"); }
            set { BackingStore?.Set("ipV6Address", value); }
        }
#endif
        /// <summary>Last local (link-local or site-local) IPv6 address associated with this NIC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalIpV6Address {
            get { return BackingStore?.Get<string?>("localIpV6Address"); }
            set { BackingStore?.Set("localIpV6Address", value); }
        }
#nullable restore
#else
        public string LocalIpV6Address {
            get { return BackingStore?.Get<string>("localIpV6Address"); }
            set { BackingStore?.Set("localIpV6Address", value); }
        }
#endif
        /// <summary>MAC address of the NIC on this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MacAddress {
            get { return BackingStore?.Get<string?>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
        }
#nullable restore
#else
        public string MacAddress {
            get { return BackingStore?.Get<string>("macAddress"); }
            set { BackingStore?.Set("macAddress", value); }
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
        /// <summary>
        /// Instantiates a new networkInterface and sets the default values.
        /// </summary>
        public NetworkInterface() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NetworkInterface CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkInterface();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"ipV4Address", n => { IpV4Address = n.GetStringValue(); } },
                {"ipV6Address", n => { IpV6Address = n.GetStringValue(); } },
                {"localIpV6Address", n => { LocalIpV6Address = n.GetStringValue(); } },
                {"macAddress", n => { MacAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("ipV4Address", IpV4Address);
            writer.WriteStringValue("ipV6Address", IpV6Address);
            writer.WriteStringValue("localIpV6Address", LocalIpV6Address);
            writer.WriteStringValue("macAddress", MacAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
