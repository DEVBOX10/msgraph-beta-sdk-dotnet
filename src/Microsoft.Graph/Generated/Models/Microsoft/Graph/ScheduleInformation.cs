using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getSchedule method.</summary>
    public class ScheduleInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free, 1= tentative, 2= busy, 3= out of office, 4= working elsewhere.</summary>
        public string AvailabilityView { get; set; }
        /// <summary>Error information from attempting to get the availability of the user, distribution list, or resource.</summary>
        public FreeBusyError Error { get; set; }
        /// <summary>An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.</summary>
        public string ScheduleId { get; set; }
        /// <summary>Contains the items that describe the availability of the user or resource.</summary>
        public List<ScheduleItem> ScheduleItems { get; set; }
        /// <summary>The days of the week and hours in a specific time zone that the user works. These are set as part of the user's mailboxSettings.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.WorkingHours WorkingHours { get; set; }
        /// <summary>
        /// Instantiates a new scheduleInformation and sets the default values.
        /// </summary>
        public ScheduleInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ScheduleInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"availabilityView", (o,n) => { (o as ScheduleInformation).AvailabilityView = n.GetStringValue(); } },
                {"error", (o,n) => { (o as ScheduleInformation).Error = n.GetObjectValue<FreeBusyError>(FreeBusyError.CreateFromDiscriminatorValue); } },
                {"scheduleId", (o,n) => { (o as ScheduleInformation).ScheduleId = n.GetStringValue(); } },
                {"scheduleItems", (o,n) => { (o as ScheduleInformation).ScheduleItems = n.GetCollectionOfObjectValues<ScheduleItem>(ScheduleItem.CreateFromDiscriminatorValue).ToList(); } },
                {"workingHours", (o,n) => { (o as ScheduleInformation).WorkingHours = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WorkingHours>(MicrosoftGraphSdk.Models.Microsoft.Graph.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availabilityView", AvailabilityView);
            writer.WriteObjectValue<FreeBusyError>("error", Error);
            writer.WriteStringValue("scheduleId", ScheduleId);
            writer.WriteCollectionOfObjectValues<ScheduleItem>("scheduleItems", ScheduleItems);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
