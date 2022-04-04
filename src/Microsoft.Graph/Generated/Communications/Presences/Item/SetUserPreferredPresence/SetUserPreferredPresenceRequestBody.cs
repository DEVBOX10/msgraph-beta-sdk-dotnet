using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Communications.Presences.Item.SetUserPreferredPresence {
    /// <summary>Provides operations to call the setUserPreferredPresence method.</summary>
    public class SetUserPreferredPresenceRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The activity property</summary>
        public string Activity { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The availability property</summary>
        public string Availability { get; set; }
        /// <summary>The expirationDuration property</summary>
        public TimeSpan? ExpirationDuration { get; set; }
        /// <summary>
        /// Instantiates a new setUserPreferredPresenceRequestBody and sets the default values.
        /// </summary>
        public SetUserPreferredPresenceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SetUserPreferredPresenceRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetUserPreferredPresenceRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"activity", (o,n) => { (o as SetUserPreferredPresenceRequestBody).Activity = n.GetStringValue(); } },
                {"availability", (o,n) => { (o as SetUserPreferredPresenceRequestBody).Availability = n.GetStringValue(); } },
                {"expirationDuration", (o,n) => { (o as SetUserPreferredPresenceRequestBody).ExpirationDuration = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activity", Activity);
            writer.WriteStringValue("availability", Availability);
            writer.WriteTimeSpanValue("expirationDuration", ExpirationDuration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
