using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcAuditResource : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The resource entity display name.</summary>
        public string DisplayName { get; set; }
        /// <summary>A list of modified properties.</summary>
        public List<CloudPcAuditProperty> ModifiedProperties { get; set; }
        /// <summary>The ID of the audit resource.</summary>
        public string ResourceId { get; set; }
        /// <summary>The type of the audit resource.</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new cloudPcAuditResource and sets the default values.
        /// </summary>
        public CloudPcAuditResource() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CloudPcAuditResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcAuditResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<CloudPcAuditProperty>(CloudPcAuditProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<CloudPcAuditProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
