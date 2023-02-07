using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Sites.Item.Lists.Item.ContentTypes.Item.MicrosoftGraphAssociateWithHubSites {
    public class AssociateWithHubSitesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The hubSiteUrls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? HubSiteUrls {
            get { return BackingStore?.Get<List<string>?>("hubSiteUrls"); }
            set { BackingStore?.Set("hubSiteUrls", value); }
        }
#nullable restore
#else
        public List<string> HubSiteUrls {
            get { return BackingStore?.Get<List<string>>("hubSiteUrls"); }
            set { BackingStore?.Set("hubSiteUrls", value); }
        }
#endif
        /// <summary>The propagateToExistingLists property</summary>
        public bool? PropagateToExistingLists {
            get { return BackingStore?.Get<bool?>("propagateToExistingLists"); }
            set { BackingStore?.Set("propagateToExistingLists", value); }
        }
        /// <summary>
        /// Instantiates a new associateWithHubSitesPostRequestBody and sets the default values.
        /// </summary>
        public AssociateWithHubSitesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssociateWithHubSitesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssociateWithHubSitesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hubSiteUrls", n => { HubSiteUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"propagateToExistingLists", n => { PropagateToExistingLists = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("hubSiteUrls", HubSiteUrls);
            writer.WriteBoolValue("propagateToExistingLists", PropagateToExistingLists);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
