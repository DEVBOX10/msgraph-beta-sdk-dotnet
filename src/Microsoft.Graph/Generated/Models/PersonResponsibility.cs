using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PersonResponsibility : ItemFacet, IParsable {
        /// <summary>Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.</summary>
        public List<string> CollaborationTags {
            get { return BackingStore?.Get<List<string>>("collaborationTags"); }
            set { BackingStore?.Set("collaborationTags", value); }
        }
        /// <summary>Description of the responsibility.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>Contains a friendly name for the responsibility.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The thumbnailUrl property</summary>
        public string ThumbnailUrl {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
        /// <summary>Contains a link to a web page or resource about the responsibility.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
        /// <summary>
        /// Instantiates a new PersonResponsibility and sets the default values.
        /// </summary>
        public PersonResponsibility() : base() {
            OdataType = "#microsoft.graph.personResponsibility";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PersonResponsibility CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonResponsibility();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"collaborationTags", n => { CollaborationTags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("collaborationTags", CollaborationTags);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
