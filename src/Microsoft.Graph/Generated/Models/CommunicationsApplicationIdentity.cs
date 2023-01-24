using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CommunicationsApplicationIdentity : Identity, IParsable {
        /// <summary>First party Microsoft application presenting this identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationType {
            get { return BackingStore?.Get<string?>("applicationType"); }
            set { BackingStore?.Set("applicationType", value); }
        }
#nullable restore
#else
        public string ApplicationType {
            get { return BackingStore?.Get<string>("applicationType"); }
            set { BackingStore?.Set("applicationType", value); }
        }
#endif
        /// <summary>True if the participant would not like to be shown in other participants&apos; rosters.</summary>
        public bool? Hidden {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>
        /// Instantiates a new CommunicationsApplicationIdentity and sets the default values.
        /// </summary>
        public CommunicationsApplicationIdentity() : base() {
            OdataType = "#microsoft.graph.communicationsApplicationIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CommunicationsApplicationIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommunicationsApplicationIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationType", n => { ApplicationType = n.GetStringValue(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationType", ApplicationType);
            writer.WriteBoolValue("hidden", Hidden);
        }
    }
}
