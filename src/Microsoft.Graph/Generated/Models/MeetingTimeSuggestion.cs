// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingTimeSuggestion : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>An array that shows the availability status of each attendee for this meeting suggestion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AttendeeAvailability>? AttendeeAvailability {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AttendeeAvailability>?>("attendeeAvailability"); }
            set { BackingStore?.Set("attendeeAvailability", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AttendeeAvailability> AttendeeAvailability {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AttendeeAvailability>>("attendeeAvailability"); }
            set { BackingStore?.Set("attendeeAvailability", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A percentage that represents the likelhood of all the attendees attending.</summary>
        public double? Confidence {
            get { return BackingStore?.Get<double?>("confidence"); }
            set { BackingStore?.Set("confidence", value); }
        }
        /// <summary>An array that specifies the name and geographic location of each meeting location for this meeting suggestion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Location>? Locations {
            get { return BackingStore?.Get<List<Location>?>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#nullable restore
#else
        public List<Location> Locations {
            get { return BackingStore?.Get<List<Location>>("locations"); }
            set { BackingStore?.Set("locations", value); }
        }
#endif
        /// <summary>A time period suggested for the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeSlot? MeetingTimeSlot {
            get { return BackingStore?.Get<TimeSlot?>("meetingTimeSlot"); }
            set { BackingStore?.Set("meetingTimeSlot", value); }
        }
#nullable restore
#else
        public TimeSlot MeetingTimeSlot {
            get { return BackingStore?.Get<TimeSlot>("meetingTimeSlot"); }
            set { BackingStore?.Set("meetingTimeSlot", value); }
        }
#endif
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
        /// <summary>Order of meeting time suggestions sorted by their computed confidence value from high to low, then by chronology if there are suggestions with the same confidence.</summary>
        public int? Order {
            get { return BackingStore?.Get<int?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
        /// <summary>Availability of the meeting organizer for this meeting suggestion. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? OrganizerAvailability {
            get { return BackingStore?.Get<FreeBusyStatus?>("organizerAvailability"); }
            set { BackingStore?.Set("organizerAvailability", value); }
        }
        /// <summary>Reason for suggesting the meeting time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SuggestionReason {
            get { return BackingStore?.Get<string?>("suggestionReason"); }
            set { BackingStore?.Set("suggestionReason", value); }
        }
#nullable restore
#else
        public string SuggestionReason {
            get { return BackingStore?.Get<string>("suggestionReason"); }
            set { BackingStore?.Set("suggestionReason", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new meetingTimeSuggestion and sets the default values.
        /// </summary>
        public MeetingTimeSuggestion() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MeetingTimeSuggestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingTimeSuggestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attendeeAvailability", n => { AttendeeAvailability = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AttendeeAvailability>(Microsoft.Graph.Beta.Models.AttendeeAvailability.CreateFromDiscriminatorValue)?.ToList(); } },
                {"confidence", n => { Confidence = n.GetDoubleValue(); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<Location>(Location.CreateFromDiscriminatorValue)?.ToList(); } },
                {"meetingTimeSlot", n => { MeetingTimeSlot = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"order", n => { Order = n.GetIntValue(); } },
                {"organizerAvailability", n => { OrganizerAvailability = n.GetEnumValue<FreeBusyStatus>(); } },
                {"suggestionReason", n => { SuggestionReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AttendeeAvailability>("attendeeAvailability", AttendeeAvailability);
            writer.WriteDoubleValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<Location>("locations", Locations);
            writer.WriteObjectValue<TimeSlot>("meetingTimeSlot", MeetingTimeSlot);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("order", Order);
            writer.WriteEnumValue<FreeBusyStatus>("organizerAvailability", OrganizerAvailability);
            writer.WriteStringValue("suggestionReason", SuggestionReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
