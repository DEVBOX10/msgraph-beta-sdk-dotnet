using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementEnumConstraint : DeviceManagementConstraint, IParsable {
        /// <summary>List of valid values for this string</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementEnumValue>? Values {
            get { return BackingStore?.Get<List<DeviceManagementEnumValue>?>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#nullable restore
#else
        public List<DeviceManagementEnumValue> Values {
            get { return BackingStore?.Get<List<DeviceManagementEnumValue>>("values"); }
            set { BackingStore?.Set("values", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceManagementEnumConstraint and sets the default values.
        /// </summary>
        public DeviceManagementEnumConstraint() : base() {
            OdataType = "#microsoft.graph.deviceManagementEnumConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementEnumConstraint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementEnumConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"values", n => { Values = n.GetCollectionOfObjectValues<DeviceManagementEnumValue>(DeviceManagementEnumValue.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceManagementEnumValue>("values", Values);
        }
    }
}
