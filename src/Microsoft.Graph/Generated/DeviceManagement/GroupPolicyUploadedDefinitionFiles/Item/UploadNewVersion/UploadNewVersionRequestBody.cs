using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.GroupPolicyUploadedDefinitionFiles.Item.UploadNewVersion {
    /// <summary>Provides operations to call the uploadNewVersion method.</summary>
    public class UploadNewVersionRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The content property</summary>
        public byte[] Content { get; set; }
        /// <summary>The groupPolicyUploadedLanguageFiles property</summary>
        public List<GroupPolicyUploadedLanguageFile> GroupPolicyUploadedLanguageFiles { get; set; }
        /// <summary>
        /// Instantiates a new uploadNewVersionRequestBody and sets the default values.
        /// </summary>
        public UploadNewVersionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UploadNewVersionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UploadNewVersionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"groupPolicyUploadedLanguageFiles", n => { GroupPolicyUploadedLanguageFiles = n.GetCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>(GroupPolicyUploadedLanguageFile.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("content", Content);
            writer.WriteCollectionOfObjectValues<GroupPolicyUploadedLanguageFile>("groupPolicyUploadedLanguageFiles", GroupPolicyUploadedLanguageFiles);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
