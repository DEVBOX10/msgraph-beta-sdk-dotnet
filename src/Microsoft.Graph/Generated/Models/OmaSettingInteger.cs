using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class OmaSettingInteger : OmaSetting, IParsable {
        /// <summary>By setting to true, the CSP (configuration service provider) specified in the OMA-URI will perform a get, instead of set</summary>
        public bool? IsReadOnly {
            get { return BackingStore?.Get<bool?>("isReadOnly"); }
            set { BackingStore?.Set("isReadOnly", value); }
        }
        /// <summary>Value.</summary>
        public int? Value {
            get { return BackingStore?.Get<int?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new OmaSettingInteger and sets the default values.
        /// </summary>
        public OmaSettingInteger() : base() {
            OdataType = "#microsoft.graph.omaSettingInteger";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OmaSettingInteger CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OmaSettingInteger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isReadOnly", n => { IsReadOnly = n.GetBoolValue(); } },
                {"value", n => { Value = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isReadOnly", IsReadOnly);
            writer.WriteIntValue("value", Value);
        }
    }
}
