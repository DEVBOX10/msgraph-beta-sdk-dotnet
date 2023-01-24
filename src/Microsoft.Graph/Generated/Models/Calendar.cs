using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Calendar : Entity, IParsable {
        /// <summary>Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnlineMeetingProviderType?>? AllowedOnlineMeetingProviders {
            get { return BackingStore?.Get<List<OnlineMeetingProviderType?>?>("allowedOnlineMeetingProviders"); }
            set { BackingStore?.Set("allowedOnlineMeetingProviders", value); }
        }
#nullable restore
#else
        public List<OnlineMeetingProviderType?> AllowedOnlineMeetingProviders {
            get { return BackingStore?.Get<List<OnlineMeetingProviderType?>>("allowedOnlineMeetingProviders"); }
            set { BackingStore?.Set("allowedOnlineMeetingProviders", value); }
        }
#endif
        /// <summary>The calendarGroup in which to create the calendar. If the user has never explicitly set a group for the calendar, this property is  null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CalendarGroupId {
            get { return BackingStore?.Get<string?>("calendarGroupId"); }
            set { BackingStore?.Set("calendarGroupId", value); }
        }
#nullable restore
#else
        public string CalendarGroupId {
            get { return BackingStore?.Get<string>("calendarGroupId"); }
            set { BackingStore?.Set("calendarGroupId", value); }
        }
#endif
        /// <summary>The permissions of the users with whom the calendar is shared.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CalendarPermission>? CalendarPermissions {
            get { return BackingStore?.Get<List<CalendarPermission>?>("calendarPermissions"); }
            set { BackingStore?.Set("calendarPermissions", value); }
        }
#nullable restore
#else
        public List<CalendarPermission> CalendarPermissions {
            get { return BackingStore?.Get<List<CalendarPermission>>("calendarPermissions"); }
            set { BackingStore?.Set("calendarPermissions", value); }
        }
#endif
        /// <summary>The calendar view for the calendar. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? CalendarView {
            get { return BackingStore?.Get<List<Event>?>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#nullable restore
#else
        public List<Event> CalendarView {
            get { return BackingStore?.Get<List<Event>>("calendarView"); }
            set { BackingStore?.Set("calendarView", value); }
        }
#endif
        /// <summary>true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanEdit {
            get { return BackingStore?.Get<bool?>("canEdit"); }
            set { BackingStore?.Set("canEdit", value); }
        }
        /// <summary>true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.</summary>
        public bool? CanShare {
            get { return BackingStore?.Get<bool?>("canShare"); }
            set { BackingStore?.Set("canShare", value); }
        }
        /// <summary>true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? CanViewPrivateItems {
            get { return BackingStore?.Get<bool?>("canViewPrivateItems"); }
            set { BackingStore?.Set("canViewPrivateItems", value); }
        }
        /// <summary>Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey {
            get { return BackingStore?.Get<string?>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#nullable restore
#else
        public string ChangeKey {
            get { return BackingStore?.Get<string>("changeKey"); }
            set { BackingStore?.Set("changeKey", value); }
        }
#endif
        /// <summary>Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: auto, lightBlue, lightGreen, lightOrange, lightGray, lightYellow, lightTeal, lightPink, lightBrown, lightRed, maxColor.</summary>
        public CalendarColor? Color {
            get { return BackingStore?.Get<CalendarColor?>("color"); }
            set { BackingStore?.Set("color", value); }
        }
        /// <summary>The default online meeting provider for meetings sent from this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.</summary>
        public OnlineMeetingProviderType? DefaultOnlineMeetingProvider {
            get { return BackingStore?.Get<OnlineMeetingProviderType?>("defaultOnlineMeetingProvider"); }
            set { BackingStore?.Set("defaultOnlineMeetingProvider", value); }
        }
        /// <summary>The events in the calendar. Navigation property. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? Events {
            get { return BackingStore?.Get<List<Event>?>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#nullable restore
#else
        public List<Event> Events {
            get { return BackingStore?.Get<List<Event>>("events"); }
            set { BackingStore?.Set("events", value); }
        }
#endif
        /// <summary>The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HexColor {
            get { return BackingStore?.Get<string?>("hexColor"); }
            set { BackingStore?.Set("hexColor", value); }
        }
#nullable restore
#else
        public string HexColor {
            get { return BackingStore?.Get<string>("hexColor"); }
            set { BackingStore?.Set("hexColor", value); }
        }
#endif
        /// <summary>true if this is the default calendar where new events are created by default, false otherwise.</summary>
        public bool? IsDefaultCalendar {
            get { return BackingStore?.Get<bool?>("isDefaultCalendar"); }
            set { BackingStore?.Set("isDefaultCalendar", value); }
        }
        /// <summary>Indicates whether this user calendar can be deleted from the user mailbox.</summary>
        public bool? IsRemovable {
            get { return BackingStore?.Get<bool?>("isRemovable"); }
            set { BackingStore?.Set("isRemovable", value); }
        }
        /// <summary>true if the user has shared the calendar with other users, false otherwise. Since only the user who created the calendar can share it, isShared and isSharedWithMe cannot be true for the same user. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? IsShared {
            get { return BackingStore?.Get<bool?>("isShared"); }
            set { BackingStore?.Set("isShared", value); }
        }
        /// <summary>true if the user has been shared this calendar, false otherwise. This property is always false for a calendar owner. This property is set when sharing is initiated in an Outlook client, and can be reset when the sharing is cancelled through the client or the corresponding calendarPermission resource. Read-only.</summary>
        public bool? IsSharedWithMe {
            get { return BackingStore?.Get<bool?>("isSharedWithMe"); }
            set { BackingStore?.Set("isSharedWithMe", value); }
        }
        /// <summary>Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users&apos; primary calendars support tracking of meeting responses.</summary>
        public bool? IsTallyingResponses {
            get { return BackingStore?.Get<bool?>("isTallyingResponses"); }
            set { BackingStore?.Set("isTallyingResponses", value); }
        }
        /// <summary>The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>?>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties {
            get { return BackingStore?.Get<List<MultiValueLegacyExtendedProperty>>("multiValueExtendedProperties"); }
            set { BackingStore?.Set("multiValueExtendedProperties", value); }
        }
#endif
        /// <summary>The calendar name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailAddress? Owner {
            get { return BackingStore?.Get<EmailAddress?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public EmailAddress Owner {
            get { return BackingStore?.Get<EmailAddress>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The collection of single-value extended properties defined for the calendar. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>?>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#nullable restore
#else
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties {
            get { return BackingStore?.Get<List<SingleValueLegacyExtendedProperty>>("singleValueExtendedProperties"); }
            set { BackingStore?.Set("singleValueExtendedProperties", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Calendar CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Calendar();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedOnlineMeetingProviders", n => { AllowedOnlineMeetingProviders = n.GetCollectionOfEnumValues<OnlineMeetingProviderType>()?.ToList(); } },
                {"calendarGroupId", n => { CalendarGroupId = n.GetStringValue(); } },
                {"calendarPermissions", n => { CalendarPermissions = n.GetCollectionOfObjectValues<CalendarPermission>(CalendarPermission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"canEdit", n => { CanEdit = n.GetBoolValue(); } },
                {"canShare", n => { CanShare = n.GetBoolValue(); } },
                {"canViewPrivateItems", n => { CanViewPrivateItems = n.GetBoolValue(); } },
                {"changeKey", n => { ChangeKey = n.GetStringValue(); } },
                {"color", n => { Color = n.GetEnumValue<CalendarColor>(); } },
                {"defaultOnlineMeetingProvider", n => { DefaultOnlineMeetingProvider = n.GetEnumValue<OnlineMeetingProviderType>(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hexColor", n => { HexColor = n.GetStringValue(); } },
                {"isDefaultCalendar", n => { IsDefaultCalendar = n.GetBoolValue(); } },
                {"isRemovable", n => { IsRemovable = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"isSharedWithMe", n => { IsSharedWithMe = n.GetBoolValue(); } },
                {"isTallyingResponses", n => { IsTallyingResponses = n.GetBoolValue(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"owner", n => { Owner = n.GetObjectValue<EmailAddress>(EmailAddress.CreateFromDiscriminatorValue); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<OnlineMeetingProviderType>("allowedOnlineMeetingProviders", AllowedOnlineMeetingProviders);
            writer.WriteStringValue("calendarGroupId", CalendarGroupId);
            writer.WriteCollectionOfObjectValues<CalendarPermission>("calendarPermissions", CalendarPermissions);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteBoolValue("canEdit", CanEdit);
            writer.WriteBoolValue("canShare", CanShare);
            writer.WriteBoolValue("canViewPrivateItems", CanViewPrivateItems);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteEnumValue<CalendarColor>("color", Color);
            writer.WriteEnumValue<OnlineMeetingProviderType>("defaultOnlineMeetingProvider", DefaultOnlineMeetingProvider);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteStringValue("hexColor", HexColor);
            writer.WriteBoolValue("isDefaultCalendar", IsDefaultCalendar);
            writer.WriteBoolValue("isRemovable", IsRemovable);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteBoolValue("isSharedWithMe", IsSharedWithMe);
            writer.WriteBoolValue("isTallyingResponses", IsTallyingResponses);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<EmailAddress>("owner", Owner);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
        }
    }
}
