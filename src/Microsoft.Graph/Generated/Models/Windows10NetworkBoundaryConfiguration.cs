using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Windows10NetworkBoundaryConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Windows Network Isolation Policy</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy? WindowsNetworkIsolationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy?>("windowsNetworkIsolationPolicy"); }
            set { BackingStore?.Set("windowsNetworkIsolationPolicy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy WindowsNetworkIsolationPolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy>("windowsNetworkIsolationPolicy"); }
            set { BackingStore?.Set("windowsNetworkIsolationPolicy", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Windows10NetworkBoundaryConfiguration and sets the default values.
        /// </summary>
        public Windows10NetworkBoundaryConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10NetworkBoundaryConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10NetworkBoundaryConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10NetworkBoundaryConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"windowsNetworkIsolationPolicy", n => { WindowsNetworkIsolationPolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy>(Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsNetworkIsolationPolicy>("windowsNetworkIsolationPolicy", WindowsNetworkIsolationPolicy);
        }
    }
}
