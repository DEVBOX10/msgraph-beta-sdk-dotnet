using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Admin.Windows.Updates.Deployments.Item.Audience.UpdateAudienceById {
    /// <summary>Provides operations to call the updateAudienceById method.</summary>
    public class UpdateAudienceByIdRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The addExclusions property</summary>
        public List<string> AddExclusions { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The addMembers property</summary>
        public List<string> AddMembers { get; set; }
        /// <summary>The memberEntityType property</summary>
        public string MemberEntityType { get; set; }
        /// <summary>The removeExclusions property</summary>
        public List<string> RemoveExclusions { get; set; }
        /// <summary>The removeMembers property</summary>
        public List<string> RemoveMembers { get; set; }
        /// <summary>
        /// Instantiates a new updateAudienceByIdRequestBody and sets the default values.
        /// </summary>
        public UpdateAudienceByIdRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateAudienceByIdRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAudienceByIdRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"addExclusions", (o,n) => { (o as UpdateAudienceByIdRequestBody).AddExclusions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"addMembers", (o,n) => { (o as UpdateAudienceByIdRequestBody).AddMembers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"memberEntityType", (o,n) => { (o as UpdateAudienceByIdRequestBody).MemberEntityType = n.GetStringValue(); } },
                {"removeExclusions", (o,n) => { (o as UpdateAudienceByIdRequestBody).RemoveExclusions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"removeMembers", (o,n) => { (o as UpdateAudienceByIdRequestBody).RemoveMembers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("addExclusions", AddExclusions);
            writer.WriteCollectionOfPrimitiveValues<string>("addMembers", AddMembers);
            writer.WriteStringValue("memberEntityType", MemberEntityType);
            writer.WriteCollectionOfPrimitiveValues<string>("removeExclusions", RemoveExclusions);
            writer.WriteCollectionOfPrimitiveValues<string>("removeMembers", RemoveMembers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
