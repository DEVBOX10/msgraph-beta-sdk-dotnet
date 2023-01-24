using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class EdiscoveryFile : FileObject, IParsable {
        /// <summary>Custodians associated with the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoveryCustodian? Custodian {
            get { return BackingStore?.Get<EdiscoveryCustodian?>("custodian"); }
            set { BackingStore?.Set("custodian", value); }
        }
#nullable restore
#else
        public EdiscoveryCustodian Custodian {
            get { return BackingStore?.Get<EdiscoveryCustodian>("custodian"); }
            set { BackingStore?.Set("custodian", value); }
        }
#endif
        /// <summary>Tags associated with the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewTag>? Tags {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<EdiscoveryReviewTag> Tags {
            get { return BackingStore?.Get<List<EdiscoveryReviewTag>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"custodian", n => { Custodian = n.GetObjectValue<EdiscoveryCustodian>(EdiscoveryCustodian.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EdiscoveryCustodian>("custodian", Custodian);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("tags", Tags);
        }
    }
}
