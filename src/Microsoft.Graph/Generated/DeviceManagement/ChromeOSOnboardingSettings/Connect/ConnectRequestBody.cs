using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ChromeOSOnboardingSettings.Connect {
    /// <summary>Provides operations to call the connect method.</summary>
    public class ConnectRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ownerAccessToken property</summary>
        public string OwnerAccessToken { get; set; }
        /// <summary>The ownerUserPrincipalName property</summary>
        public string OwnerUserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new connectRequestBody and sets the default values.
        /// </summary>
        public ConnectRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConnectRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ownerAccessToken", n => { OwnerAccessToken = n.GetStringValue(); } },
                {"ownerUserPrincipalName", n => { OwnerUserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ownerAccessToken", OwnerAccessToken);
            writer.WriteStringValue("ownerUserPrincipalName", OwnerUserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
