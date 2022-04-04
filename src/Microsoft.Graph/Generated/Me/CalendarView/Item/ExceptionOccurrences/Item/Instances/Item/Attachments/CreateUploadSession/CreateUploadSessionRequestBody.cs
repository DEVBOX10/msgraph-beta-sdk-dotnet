using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.CalendarView.Item.ExceptionOccurrences.Item.Instances.Item.Attachments.CreateUploadSession {
    /// <summary>Provides operations to call the createUploadSession method.</summary>
    public class CreateUploadSessionRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AttachmentItem property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AttachmentItem AttachmentItem { get; set; }
        /// <summary>
        /// Instantiates a new createUploadSessionRequestBody and sets the default values.
        /// </summary>
        public CreateUploadSessionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateUploadSessionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateUploadSessionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attachmentItem", (o,n) => { (o as CreateUploadSessionRequestBody).AttachmentItem = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttachmentItem>(MicrosoftGraphSdk.Models.Microsoft.Graph.AttachmentItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.AttachmentItem>("attachmentItem", AttachmentItem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
