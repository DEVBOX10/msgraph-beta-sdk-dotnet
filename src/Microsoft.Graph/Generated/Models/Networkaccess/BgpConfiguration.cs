// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class BgpConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Specifies the ASN of the BGP.</summary>
        public int? Asn {
            get { return BackingStore?.Get<int?>("asn"); }
            set { BackingStore?.Set("asn", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ipAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>Specifies the BGP IP address of peer (Microsoft, in this case).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalIpAddress {
            get { return BackingStore?.Get<string?>("localIpAddress"); }
            set { BackingStore?.Set("localIpAddress", value); }
        }
#nullable restore
#else
        public string LocalIpAddress {
            get { return BackingStore?.Get<string>("localIpAddress"); }
            set { BackingStore?.Set("localIpAddress", value); }
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
        /// <summary>Specifies the BGP IP address of customer&apos;s on-premise VPN router configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PeerIpAddress {
            get { return BackingStore?.Get<string?>("peerIpAddress"); }
            set { BackingStore?.Set("peerIpAddress", value); }
        }
#nullable restore
#else
        public string PeerIpAddress {
            get { return BackingStore?.Get<string>("peerIpAddress"); }
            set { BackingStore?.Set("peerIpAddress", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new bgpConfiguration and sets the default values.
        /// </summary>
        public BgpConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BgpConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BgpConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"asn", n => { Asn = n.GetIntValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"localIpAddress", n => { LocalIpAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"peerIpAddress", n => { PeerIpAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("asn", Asn);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("localIpAddress", LocalIpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("peerIpAddress", PeerIpAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
