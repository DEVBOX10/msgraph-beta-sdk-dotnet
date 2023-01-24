using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BookingAppointment : Entity, IParsable {
        /// <summary>Additional information that is sent to the customer when an appointment is confirmed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation {
            get { return BackingStore?.Get<string?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public string AdditionalInformation {
            get { return BackingStore?.Get<string>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>The URL of the meeting to join anonymously.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnonymousJoinWebUrl {
            get { return BackingStore?.Get<string?>("anonymousJoinWebUrl"); }
            set { BackingStore?.Set("anonymousJoinWebUrl", value); }
        }
#nullable restore
#else
        public string AnonymousJoinWebUrl {
            get { return BackingStore?.Get<string>("anonymousJoinWebUrl"); }
            set { BackingStore?.Set("anonymousJoinWebUrl", value); }
        }
#endif
        /// <summary>The SMTP address of the bookingCustomer who is booking the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerEmailAddress {
            get { return BackingStore?.Get<string?>("customerEmailAddress"); }
            set { BackingStore?.Set("customerEmailAddress", value); }
        }
#nullable restore
#else
        public string CustomerEmailAddress {
            get { return BackingStore?.Get<string>("customerEmailAddress"); }
            set { BackingStore?.Set("customerEmailAddress", value); }
        }
#endif
        /// <summary>The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId {
            get { return BackingStore?.Get<string?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
#nullable restore
#else
        public string CustomerId {
            get { return BackingStore?.Get<string>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
#endif
        /// <summary>Represents location information for the bookingCustomer who is booking the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Location? CustomerLocation {
            get { return BackingStore?.Get<Location?>("customerLocation"); }
            set { BackingStore?.Set("customerLocation", value); }
        }
#nullable restore
#else
        public Location CustomerLocation {
            get { return BackingStore?.Get<Location>("customerLocation"); }
            set { BackingStore?.Set("customerLocation", value); }
        }
#endif
        /// <summary>The customer&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerName {
            get { return BackingStore?.Get<string?>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#nullable restore
#else
        public string CustomerName {
            get { return BackingStore?.Get<string>("customerName"); }
            set { BackingStore?.Set("customerName", value); }
        }
#endif
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID.  You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by customerId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerNotes {
            get { return BackingStore?.Get<string?>("customerNotes"); }
            set { BackingStore?.Set("customerNotes", value); }
        }
#nullable restore
#else
        public string CustomerNotes {
            get { return BackingStore?.Get<string>("customerNotes"); }
            set { BackingStore?.Set("customerNotes", value); }
        }
#endif
        /// <summary>The customer&apos;s phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerPhone {
            get { return BackingStore?.Get<string?>("customerPhone"); }
            set { BackingStore?.Set("customerPhone", value); }
        }
#nullable restore
#else
        public string CustomerPhone {
            get { return BackingStore?.Get<string>("customerPhone"); }
            set { BackingStore?.Set("customerPhone", value); }
        }
#endif
        /// <summary>A collection of the customer properties for an appointment. An appointment will contain a list of customer information and each unit will indicate the properties of a customer who is part of that appointment. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomerInformationBase>? Customers {
            get { return BackingStore?.Get<List<BookingCustomerInformationBase>?>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#nullable restore
#else
        public List<BookingCustomerInformationBase> Customers {
            get { return BackingStore?.Get<List<BookingCustomerInformationBase>>("customers"); }
            set { BackingStore?.Set("customers", value); }
        }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerTimeZone {
            get { return BackingStore?.Get<string?>("customerTimeZone"); }
            set { BackingStore?.Set("customerTimeZone", value); }
        }
#nullable restore
#else
        public string CustomerTimeZone {
            get { return BackingStore?.Get<string>("customerTimeZone"); }
            set { BackingStore?.Set("customerTimeZone", value); }
        }
#endif
        /// <summary>The length of the appointment, denoted in ISO8601 format.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>The end property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? End {
            get { return BackingStore?.Get<DateTimeTimeZone?>("end"); }
            set { BackingStore?.Set("end", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone End {
            get { return BackingStore?.Get<DateTimeTimeZone>("end"); }
            set { BackingStore?.Set("end", value); }
        }
#endif
        /// <summary>The current number of customers in the appointment.</summary>
        public int? FilledAttendeesCount {
            get { return BackingStore?.Get<int?>("filledAttendeesCount"); }
            set { BackingStore?.Set("filledAttendeesCount", value); }
        }
        /// <summary>The billed amount on the invoice.</summary>
        public double? InvoiceAmount {
            get { return BackingStore?.Get<double?>("invoiceAmount"); }
            set { BackingStore?.Set("invoiceAmount", value); }
        }
        /// <summary>The date, time, and time zone of the invoice for this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? InvoiceDate {
            get { return BackingStore?.Get<DateTimeTimeZone?>("invoiceDate"); }
            set { BackingStore?.Set("invoiceDate", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone InvoiceDate {
            get { return BackingStore?.Get<DateTimeTimeZone>("invoiceDate"); }
            set { BackingStore?.Set("invoiceDate", value); }
        }
#endif
        /// <summary>The ID of the invoice.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceId {
            get { return BackingStore?.Get<string?>("invoiceId"); }
            set { BackingStore?.Set("invoiceId", value); }
        }
#nullable restore
#else
        public string InvoiceId {
            get { return BackingStore?.Get<string>("invoiceId"); }
            set { BackingStore?.Set("invoiceId", value); }
        }
#endif
        /// <summary>The invoiceStatus property</summary>
        public BookingInvoiceStatus? InvoiceStatus {
            get { return BackingStore?.Get<BookingInvoiceStatus?>("invoiceStatus"); }
            set { BackingStore?.Set("invoiceStatus", value); }
        }
        /// <summary>The URL of the invoice in Microsoft Bookings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InvoiceUrl {
            get { return BackingStore?.Get<string?>("invoiceUrl"); }
            set { BackingStore?.Set("invoiceUrl", value); }
        }
#nullable restore
#else
        public string InvoiceUrl {
            get { return BackingStore?.Get<string>("invoiceUrl"); }
            set { BackingStore?.Set("invoiceUrl", value); }
        }
#endif
        /// <summary>True indicates that the appointment will be held online. Default value is false.</summary>
        public bool? IsLocationOnline {
            get { return BackingStore?.Get<bool?>("isLocationOnline"); }
            set { BackingStore?.Set("isLocationOnline", value); }
        }
        /// <summary>The URL of the online meeting for the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl {
            get { return BackingStore?.Get<string?>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#nullable restore
#else
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#endif
        /// <summary>The maximum number of customers allowed in an appointment. If maximumAttendeesCount of the service is greater than 1, pass valid customer IDs while creating or updating an appointment. To create a customer, use the Create bookingCustomer operation.</summary>
        public int? MaximumAttendeesCount {
            get { return BackingStore?.Get<int?>("maximumAttendeesCount"); }
            set { BackingStore?.Set("maximumAttendeesCount", value); }
        }
        /// <summary>The onlineMeetingUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineMeetingUrl {
            get { return BackingStore?.Get<string?>("onlineMeetingUrl"); }
            set { BackingStore?.Set("onlineMeetingUrl", value); }
        }
#nullable restore
#else
        public string OnlineMeetingUrl {
            get { return BackingStore?.Get<string>("onlineMeetingUrl"); }
            set { BackingStore?.Set("onlineMeetingUrl", value); }
        }
#endif
        /// <summary>True indicates that the bookingCustomer for this appointment does not wish to receive a confirmation for this appointment.</summary>
        public bool? OptOutOfCustomerEmail {
            get { return BackingStore?.Get<bool?>("optOutOfCustomerEmail"); }
            set { BackingStore?.Set("optOutOfCustomerEmail", value); }
        }
        /// <summary>The amount of time to reserve after the appointment ends, for cleaning up, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PostBuffer {
            get { return BackingStore?.Get<TimeSpan?>("postBuffer"); }
            set { BackingStore?.Set("postBuffer", value); }
        }
        /// <summary>The amount of time to reserve before the appointment begins, for preparation, as an example. The value is expressed in ISO8601 format.</summary>
        public TimeSpan? PreBuffer {
            get { return BackingStore?.Get<TimeSpan?>("preBuffer"); }
            set { BackingStore?.Set("preBuffer", value); }
        }
        /// <summary>The regular price for an appointment for the specified bookingService.</summary>
        public double? Price {
            get { return BackingStore?.Get<double?>("price"); }
            set { BackingStore?.Set("price", value); }
        }
        /// <summary>Represents the type of pricing of a booking service.</summary>
        public BookingPriceType? PriceType {
            get { return BackingStore?.Get<BookingPriceType?>("priceType"); }
            set { BackingStore?.Set("priceType", value); }
        }
        /// <summary>The collection of customer reminders sent for this appointment. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingReminder>? Reminders {
            get { return BackingStore?.Get<List<BookingReminder>?>("reminders"); }
            set { BackingStore?.Set("reminders", value); }
        }
#nullable restore
#else
        public List<BookingReminder> Reminders {
            get { return BackingStore?.Get<List<BookingReminder>>("reminders"); }
            set { BackingStore?.Set("reminders", value); }
        }
#endif
        /// <summary>An additional tracking ID for the appointment, if the appointment has been created directly by the customer on the scheduling page, as opposed to by a staff member on the behalf of the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SelfServiceAppointmentId {
            get { return BackingStore?.Get<string?>("selfServiceAppointmentId"); }
            set { BackingStore?.Set("selfServiceAppointmentId", value); }
        }
#nullable restore
#else
        public string SelfServiceAppointmentId {
            get { return BackingStore?.Get<string>("selfServiceAppointmentId"); }
            set { BackingStore?.Set("selfServiceAppointmentId", value); }
        }
#endif
        /// <summary>The ID of the bookingService associated with this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceId {
            get { return BackingStore?.Get<string?>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
#nullable restore
#else
        public string ServiceId {
            get { return BackingStore?.Get<string>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
#endif
        /// <summary>The location where the service is delivered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Location? ServiceLocation {
            get { return BackingStore?.Get<Location?>("serviceLocation"); }
            set { BackingStore?.Set("serviceLocation", value); }
        }
#nullable restore
#else
        public Location ServiceLocation {
            get { return BackingStore?.Get<Location>("serviceLocation"); }
            set { BackingStore?.Set("serviceLocation", value); }
        }
#endif
        /// <summary>The name of the bookingService associated with this appointment.This property is optional when creating a new appointment. If not specified, it is computed from the service associated with the appointment by the serviceId property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceName {
            get { return BackingStore?.Get<string?>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#nullable restore
#else
        public string ServiceName {
            get { return BackingStore?.Get<string>("serviceName"); }
            set { BackingStore?.Set("serviceName", value); }
        }
#endif
        /// <summary>Notes from a bookingStaffMember. The value of this property is available only when reading this bookingAppointment by its ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceNotes {
            get { return BackingStore?.Get<string?>("serviceNotes"); }
            set { BackingStore?.Set("serviceNotes", value); }
        }
#nullable restore
#else
        public string ServiceNotes {
            get { return BackingStore?.Get<string>("serviceNotes"); }
            set { BackingStore?.Set("serviceNotes", value); }
        }
#endif
        /// <summary>True indicates SMS notifications will be sent to the customers for the appointment. Default value is false.</summary>
        public bool? SmsNotificationsEnabled {
            get { return BackingStore?.Get<bool?>("smsNotificationsEnabled"); }
            set { BackingStore?.Set("smsNotificationsEnabled", value); }
        }
        /// <summary>The ID of each bookingStaffMember who is scheduled in this appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StaffMemberIds {
            get { return BackingStore?.Get<List<string>?>("staffMemberIds"); }
            set { BackingStore?.Set("staffMemberIds", value); }
        }
#nullable restore
#else
        public List<string> StaffMemberIds {
            get { return BackingStore?.Get<List<string>>("staffMemberIds"); }
            set { BackingStore?.Set("staffMemberIds", value); }
        }
#endif
        /// <summary>The start property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? Start {
            get { return BackingStore?.Get<DateTimeTimeZone?>("start"); }
            set { BackingStore?.Set("start", value); }
        }
#nullable restore
#else
        public DateTimeTimeZone Start {
            get { return BackingStore?.Get<DateTimeTimeZone>("start"); }
            set { BackingStore?.Set("start", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingAppointment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingAppointment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"anonymousJoinWebUrl", n => { AnonymousJoinWebUrl = n.GetStringValue(); } },
                {"customerEmailAddress", n => { CustomerEmailAddress = n.GetStringValue(); } },
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customerLocation", n => { CustomerLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"customerName", n => { CustomerName = n.GetStringValue(); } },
                {"customerNotes", n => { CustomerNotes = n.GetStringValue(); } },
                {"customerPhone", n => { CustomerPhone = n.GetStringValue(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomerInformationBase>(BookingCustomerInformationBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerTimeZone", n => { CustomerTimeZone = n.GetStringValue(); } },
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
                {"end", n => { End = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"filledAttendeesCount", n => { FilledAttendeesCount = n.GetIntValue(); } },
                {"invoiceAmount", n => { InvoiceAmount = n.GetDoubleValue(); } },
                {"invoiceDate", n => { InvoiceDate = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"invoiceId", n => { InvoiceId = n.GetStringValue(); } },
                {"invoiceStatus", n => { InvoiceStatus = n.GetEnumValue<BookingInvoiceStatus>(); } },
                {"invoiceUrl", n => { InvoiceUrl = n.GetStringValue(); } },
                {"isLocationOnline", n => { IsLocationOnline = n.GetBoolValue(); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"maximumAttendeesCount", n => { MaximumAttendeesCount = n.GetIntValue(); } },
                {"onlineMeetingUrl", n => { OnlineMeetingUrl = n.GetStringValue(); } },
                {"optOutOfCustomerEmail", n => { OptOutOfCustomerEmail = n.GetBoolValue(); } },
                {"postBuffer", n => { PostBuffer = n.GetTimeSpanValue(); } },
                {"preBuffer", n => { PreBuffer = n.GetTimeSpanValue(); } },
                {"price", n => { Price = n.GetDoubleValue(); } },
                {"priceType", n => { PriceType = n.GetEnumValue<BookingPriceType>(); } },
                {"reminders", n => { Reminders = n.GetCollectionOfObjectValues<BookingReminder>(BookingReminder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"selfServiceAppointmentId", n => { SelfServiceAppointmentId = n.GetStringValue(); } },
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
                {"serviceLocation", n => { ServiceLocation = n.GetObjectValue<Location>(Location.CreateFromDiscriminatorValue); } },
                {"serviceName", n => { ServiceName = n.GetStringValue(); } },
                {"serviceNotes", n => { ServiceNotes = n.GetStringValue(); } },
                {"smsNotificationsEnabled", n => { SmsNotificationsEnabled = n.GetBoolValue(); } },
                {"staffMemberIds", n => { StaffMemberIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"start", n => { Start = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("anonymousJoinWebUrl", AnonymousJoinWebUrl);
            writer.WriteStringValue("customerEmailAddress", CustomerEmailAddress);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteObjectValue<Location>("customerLocation", CustomerLocation);
            writer.WriteStringValue("customerName", CustomerName);
            writer.WriteStringValue("customerNotes", CustomerNotes);
            writer.WriteStringValue("customerPhone", CustomerPhone);
            writer.WriteCollectionOfObjectValues<BookingCustomerInformationBase>("customers", Customers);
            writer.WriteStringValue("customerTimeZone", CustomerTimeZone);
            writer.WriteObjectValue<DateTimeTimeZone>("end", End);
            writer.WriteDoubleValue("invoiceAmount", InvoiceAmount);
            writer.WriteObjectValue<DateTimeTimeZone>("invoiceDate", InvoiceDate);
            writer.WriteStringValue("invoiceId", InvoiceId);
            writer.WriteEnumValue<BookingInvoiceStatus>("invoiceStatus", InvoiceStatus);
            writer.WriteStringValue("invoiceUrl", InvoiceUrl);
            writer.WriteBoolValue("isLocationOnline", IsLocationOnline);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteIntValue("maximumAttendeesCount", MaximumAttendeesCount);
            writer.WriteStringValue("onlineMeetingUrl", OnlineMeetingUrl);
            writer.WriteBoolValue("optOutOfCustomerEmail", OptOutOfCustomerEmail);
            writer.WriteTimeSpanValue("postBuffer", PostBuffer);
            writer.WriteTimeSpanValue("preBuffer", PreBuffer);
            writer.WriteDoubleValue("price", Price);
            writer.WriteEnumValue<BookingPriceType>("priceType", PriceType);
            writer.WriteCollectionOfObjectValues<BookingReminder>("reminders", Reminders);
            writer.WriteStringValue("selfServiceAppointmentId", SelfServiceAppointmentId);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteObjectValue<Location>("serviceLocation", ServiceLocation);
            writer.WriteStringValue("serviceName", ServiceName);
            writer.WriteStringValue("serviceNotes", ServiceNotes);
            writer.WriteBoolValue("smsNotificationsEnabled", SmsNotificationsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("staffMemberIds", StaffMemberIds);
            writer.WriteObjectValue<DateTimeTimeZone>("start", Start);
        }
    }
}
