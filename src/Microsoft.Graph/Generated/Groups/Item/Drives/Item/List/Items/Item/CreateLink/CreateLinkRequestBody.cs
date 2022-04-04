using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Groups.Item.Drives.Item.List.Items.Item.CreateLink {
    /// <summary>Provides operations to call the createLink method.</summary>
    public class CreateLinkRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The password property</summary>
        public string Password { get; set; }
        /// <summary>The recipients property</summary>
        public List<DriveRecipient> Recipients { get; set; }
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions { get; set; }
        /// <summary>The scope property</summary>
        public string Scope { get; set; }
        /// <summary>The type property</summary>
        public string Type { get; set; }
        /// <summary>
        /// Instantiates a new createLinkRequestBody and sets the default values.
        /// </summary>
        public CreateLinkRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateLinkRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateLinkRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"expirationDateTime", (o,n) => { (o as CreateLinkRequestBody).ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"password", (o,n) => { (o as CreateLinkRequestBody).Password = n.GetStringValue(); } },
                {"recipients", (o,n) => { (o as CreateLinkRequestBody).Recipients = n.GetCollectionOfObjectValues<DriveRecipient>(DriveRecipient.CreateFromDiscriminatorValue).ToList(); } },
                {"retainInheritedPermissions", (o,n) => { (o as CreateLinkRequestBody).RetainInheritedPermissions = n.GetBoolValue(); } },
                {"scope", (o,n) => { (o as CreateLinkRequestBody).Scope = n.GetStringValue(); } },
                {"type", (o,n) => { (o as CreateLinkRequestBody).Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("password", Password);
            writer.WriteCollectionOfObjectValues<DriveRecipient>("recipients", Recipients);
            writer.WriteBoolValue("retainInheritedPermissions", RetainInheritedPermissions);
            writer.WriteStringValue("scope", Scope);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
