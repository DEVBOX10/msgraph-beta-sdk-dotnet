using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceManagement.Intents.Item.MigrateToTemplate {
    /// <summary>Provides operations to call the migrateToTemplate method.</summary>
    public class MigrateToTemplateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The newTemplateId property</summary>
        public string NewTemplateId { get; set; }
        /// <summary>The preserveCustomValues property</summary>
        public bool? PreserveCustomValues { get; set; }
        /// <summary>
        /// Instantiates a new migrateToTemplateRequestBody and sets the default values.
        /// </summary>
        public MigrateToTemplateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MigrateToTemplateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MigrateToTemplateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newTemplateId", (o,n) => { (o as MigrateToTemplateRequestBody).NewTemplateId = n.GetStringValue(); } },
                {"preserveCustomValues", (o,n) => { (o as MigrateToTemplateRequestBody).PreserveCustomValues = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("newTemplateId", NewTemplateId);
            writer.WriteBoolValue("preserveCustomValues", PreserveCustomValues);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
