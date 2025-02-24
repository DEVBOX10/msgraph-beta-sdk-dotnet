// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class IsolateDeviceResponseAction : ResponseAction, IParsable {
        /// <summary>The identifier property</summary>
        public DeviceIdEntityIdentifier? Identifier {
            get { return BackingStore?.Get<DeviceIdEntityIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>The isolationType property</summary>
        public Microsoft.Graph.Beta.Models.Security.IsolationType? IsolationType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.IsolationType?>("isolationType"); }
            set { BackingStore?.Set("isolationType", value); }
        }
        /// <summary>
        /// Instantiates a new isolateDeviceResponseAction and sets the default values.
        /// </summary>
        public IsolateDeviceResponseAction() : base() {
            OdataType = "#microsoft.graph.security.isolateDeviceResponseAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IsolateDeviceResponseAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IsolateDeviceResponseAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identifier", n => { Identifier = n.GetEnumValue<DeviceIdEntityIdentifier>(); } },
                {"isolationType", n => { IsolationType = n.GetEnumValue<IsolationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceIdEntityIdentifier>("identifier", Identifier);
            writer.WriteEnumValue<IsolationType>("isolationType", IsolationType);
        }
    }
}
