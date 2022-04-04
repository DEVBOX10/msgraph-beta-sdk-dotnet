using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.App.OnlineMeetings.CreateOrGet {
    /// <summary>Provides operations to call the createOrGet method.</summary>
    public class CreateOrGetRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The chatInfo property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo ChatInfo { get; set; }
        /// <summary>The endDateTime property</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The externalId property</summary>
        public string ExternalId { get; set; }
        /// <summary>The participants property</summary>
        public MeetingParticipants Participants { get; set; }
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The subject property</summary>
        public string Subject { get; set; }
        /// <summary>
        /// Instantiates a new createOrGetRequestBody and sets the default values.
        /// </summary>
        public CreateOrGetRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateOrGetRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateOrGetRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"chatInfo", (o,n) => { (o as CreateOrGetRequestBody).ChatInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo.CreateFromDiscriminatorValue); } },
                {"endDateTime", (o,n) => { (o as CreateOrGetRequestBody).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", (o,n) => { (o as CreateOrGetRequestBody).ExternalId = n.GetStringValue(); } },
                {"participants", (o,n) => { (o as CreateOrGetRequestBody).Participants = n.GetObjectValue<MeetingParticipants>(MeetingParticipants.CreateFromDiscriminatorValue); } },
                {"startDateTime", (o,n) => { (o as CreateOrGetRequestBody).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", (o,n) => { (o as CreateOrGetRequestBody).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
