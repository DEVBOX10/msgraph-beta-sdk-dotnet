using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class Windows : Entity, IParsable {
        /// <summary>Entity that acts as a container for the functionality of the Windows Update for Business deployment service. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Updates? Updates {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Updates?>("updates"); }
            set { BackingStore?.Set("updates", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Updates Updates {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Updates>("updates"); }
            set { BackingStore?.Set("updates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"updates", n => { Updates = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Updates>(Microsoft.Graph.Beta.Models.WindowsUpdates.Updates.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Updates>("updates", Updates);
        }
    }
}
