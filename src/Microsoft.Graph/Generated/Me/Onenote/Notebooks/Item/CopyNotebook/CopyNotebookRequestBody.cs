using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.Onenote.Notebooks.Item.CopyNotebook {
    /// <summary>Provides operations to call the copyNotebook method.</summary>
    public class CopyNotebookRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The groupId property</summary>
        public string GroupId { get; set; }
        /// <summary>The notebookFolder property</summary>
        public string NotebookFolder { get; set; }
        /// <summary>The renameAs property</summary>
        public string RenameAs { get; set; }
        /// <summary>The siteCollectionId property</summary>
        public string SiteCollectionId { get; set; }
        /// <summary>The siteId property</summary>
        public string SiteId { get; set; }
        /// <summary>
        /// Instantiates a new copyNotebookRequestBody and sets the default values.
        /// </summary>
        public CopyNotebookRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyNotebookRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyNotebookRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupId", (o,n) => { (o as CopyNotebookRequestBody).GroupId = n.GetStringValue(); } },
                {"notebookFolder", (o,n) => { (o as CopyNotebookRequestBody).NotebookFolder = n.GetStringValue(); } },
                {"renameAs", (o,n) => { (o as CopyNotebookRequestBody).RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", (o,n) => { (o as CopyNotebookRequestBody).SiteCollectionId = n.GetStringValue(); } },
                {"siteId", (o,n) => { (o as CopyNotebookRequestBody).SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("notebookFolder", NotebookFolder);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
