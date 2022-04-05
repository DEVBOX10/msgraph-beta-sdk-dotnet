using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.BookingBusinesses.Item.GetStaffAvailability {
    /// <summary>Provides operations to call the getStaffAvailability method.</summary>
    public class GetStaffAvailabilityRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The endDateTime property</summary>
        public DateTimeTimeZone EndDateTime { get; set; }
        /// <summary>The staffIds property</summary>
        public List<string> StaffIds { get; set; }
        /// <summary>The startDateTime property</summary>
        public DateTimeTimeZone StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new getStaffAvailabilityRequestBody and sets the default values.
        /// </summary>
        public GetStaffAvailabilityRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetStaffAvailabilityRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetStaffAvailabilityRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"endDateTime", (o,n) => { (o as GetStaffAvailabilityRequestBody).EndDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"staffIds", (o,n) => { (o as GetStaffAvailabilityRequestBody).StaffIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"startDateTime", (o,n) => { (o as GetStaffAvailabilityRequestBody).StartDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DateTimeTimeZone>("endDateTime", EndDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("staffIds", StaffIds);
            writer.WriteObjectValue<DateTimeTimeZone>("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
