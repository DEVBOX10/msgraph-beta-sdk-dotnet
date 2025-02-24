// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class BaseSitePage : BaseItem, IParsable {
        /// <summary>The name of the page layout of the page. The possible values are: microsoftReserved, article, home, unknownFutureValue.</summary>
        public PageLayoutType? PageLayout {
            get { return BackingStore?.Get<PageLayoutType?>("pageLayout"); }
            set { BackingStore?.Set("pageLayout", value); }
        }
        /// <summary>The publishing status and the MM.mm version of the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicationFacet? PublishingState {
            get { return BackingStore?.Get<PublicationFacet?>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
#nullable restore
#else
        public PublicationFacet PublishingState {
            get { return BackingStore?.Get<PublicationFacet>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
#endif
        /// <summary>Title of the sitePage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new baseSitePage and sets the default values.
        /// </summary>
        public BaseSitePage() : base() {
            OdataType = "#microsoft.graph.baseSitePage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BaseSitePage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.sitePage" => new SitePage(),
                _ => new BaseSitePage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"pageLayout", n => { PageLayout = n.GetEnumValue<PageLayoutType>(); } },
                {"publishingState", n => { PublishingState = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PageLayoutType>("pageLayout", PageLayout);
            writer.WriteObjectValue<PublicationFacet>("publishingState", PublishingState);
            writer.WriteStringValue("title", Title);
        }
    }
}
