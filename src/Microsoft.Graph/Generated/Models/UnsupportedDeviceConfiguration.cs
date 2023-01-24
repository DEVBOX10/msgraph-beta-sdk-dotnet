using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnsupportedDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Details describing why the entity is unsupported. This collection can contain a maximum of 1000 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnsupportedDeviceConfigurationDetail>? Details {
            get { return BackingStore?.Get<List<UnsupportedDeviceConfigurationDetail>?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public List<UnsupportedDeviceConfigurationDetail> Details {
            get { return BackingStore?.Get<List<UnsupportedDeviceConfigurationDetail>>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The type of entity that would be returned otherwise.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalEntityTypeName {
            get { return BackingStore?.Get<string?>("originalEntityTypeName"); }
            set { BackingStore?.Set("originalEntityTypeName", value); }
        }
#nullable restore
#else
        public string OriginalEntityTypeName {
            get { return BackingStore?.Get<string>("originalEntityTypeName"); }
            set { BackingStore?.Set("originalEntityTypeName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new UnsupportedDeviceConfiguration and sets the default values.
        /// </summary>
        public UnsupportedDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.unsupportedDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnsupportedDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnsupportedDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"details", n => { Details = n.GetCollectionOfObjectValues<UnsupportedDeviceConfigurationDetail>(UnsupportedDeviceConfigurationDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"originalEntityTypeName", n => { OriginalEntityTypeName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnsupportedDeviceConfigurationDetail>("details", Details);
            writer.WriteStringValue("originalEntityTypeName", OriginalEntityTypeName);
        }
    }
}
