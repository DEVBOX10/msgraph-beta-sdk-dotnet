// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ResponseStatus : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The response type. Possible values are: none, organizer, tentativelyAccepted, accepted, declined, notResponded.To differentiate between none and notResponded:  none – from organizer&apos;s perspective. This value is used when the status of an attendee/participant is reported to the organizer of a meeting.  notResponded – from attendee&apos;s perspective. Indicates the attendee has not responded to the meeting request.  Clients can treat notResponded == none.  As an example, if attendee Alex hasn&apos;t responded to a meeting request, getting Alex&apos; response status for that event in Alex&apos; calendar returns notResponded. Getting Alex&apos; response from the calendar of any other attendee or the organizer&apos;s returns none. Getting the organizer&apos;s response for the event in anybody&apos;s calendar also returns none.</summary>
        public ResponseType? Response {
            get { return BackingStore?.Get<ResponseType?>("response"); }
            set { BackingStore?.Set("response", value); }
        }
        /// <summary>The date and time that the response was returned. It uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? Time {
            get { return BackingStore?.Get<DateTimeOffset?>("time"); }
            set { BackingStore?.Set("time", value); }
        }
        /// <summary>
        /// Instantiates a new responseStatus and sets the default values.
        /// </summary>
        public ResponseStatus() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ResponseStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResponseStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"response", n => { Response = n.GetEnumValue<ResponseType>(); } },
                {"time", n => { Time = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<ResponseType>("response", Response);
            writer.WriteDateTimeOffsetValue("time", Time);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
