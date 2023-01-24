using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ExternalConnectors {
    public class ItemIdResolver : UrlToItemResolverBase, IParsable {
        /// <summary>Pattern that specifies how to form the ID of the external item that the URL represents. The named groups from the regular expression in urlPattern within the urlMatchInfo can be referenced by inserting the group name inside curly brackets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ItemId {
            get { return BackingStore?.Get<string?>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
#nullable restore
#else
        public string ItemId {
            get { return BackingStore?.Get<string>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
#endif
        /// <summary>Configurations to match and resolve URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo? UrlMatchInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo?>("urlMatchInfo"); }
            set { BackingStore?.Set("urlMatchInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo UrlMatchInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo>("urlMatchInfo"); }
            set { BackingStore?.Set("urlMatchInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new ItemIdResolver and sets the default values.
        /// </summary>
        public ItemIdResolver() : base() {
            OdataType = "#microsoft.graph.externalConnectors.itemIdResolver";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemIdResolver CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemIdResolver();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"urlMatchInfo", n => { UrlMatchInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo>(Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ExternalConnectors.UrlMatchInfo>("urlMatchInfo", UrlMatchInfo);
        }
    }
}
