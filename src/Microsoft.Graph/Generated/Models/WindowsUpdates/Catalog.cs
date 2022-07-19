using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class Catalog : Entity, IParsable {
        /// <summary>Lists the content that you can approve for deployment. Read-only.</summary>
        public List<CatalogEntry> Entries {
            get { return BackingStore?.Get<List<CatalogEntry>>("entries"); }
            set { BackingStore?.Set("entries", value); }
        }
        /// <summary>
        /// Instantiates a new catalog and sets the default values.
        /// </summary>
        public Catalog() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.catalog";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Catalog CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Catalog();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"entries", n => { Entries = n.GetCollectionOfObjectValues<CatalogEntry>(CatalogEntry.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CatalogEntry>("entries", Entries);
        }
    }
}
