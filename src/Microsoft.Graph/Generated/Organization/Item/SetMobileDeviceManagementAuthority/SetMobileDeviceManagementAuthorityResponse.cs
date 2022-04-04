using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Organization.Item.SetMobileDeviceManagementAuthority {
    /// <summary>Provides operations to call the setMobileDeviceManagementAuthority method.</summary>
    public class SetMobileDeviceManagementAuthorityResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value property</summary>
        public int? Value { get; set; }
        /// <summary>
        /// Instantiates a new setMobileDeviceManagementAuthorityResponse and sets the default values.
        /// </summary>
        public SetMobileDeviceManagementAuthorityResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SetMobileDeviceManagementAuthorityResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetMobileDeviceManagementAuthorityResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"value", (o,n) => { (o as SetMobileDeviceManagementAuthorityResponse).Value = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
