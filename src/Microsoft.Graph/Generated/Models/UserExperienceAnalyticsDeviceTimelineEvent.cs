using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics device event entity contains NRT device event details.
    /// </summary>
    public class UserExperienceAnalyticsDeviceTimelineEvent : Entity, IParsable {
        /// <summary>The id of the device where the event occurred.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The time the event occured.</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>The details provided by the event, format depends on event type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventDetails {
            get { return BackingStore?.Get<string?>("eventDetails"); }
            set { BackingStore?.Set("eventDetails", value); }
        }
#nullable restore
#else
        public string EventDetails {
            get { return BackingStore?.Get<string>("eventDetails"); }
            set { BackingStore?.Set("eventDetails", value); }
        }
#endif
        /// <summary>Indicates device event level. Possible values are: None, Verbose, Information, Warning, Error, Critical</summary>
        public DeviceEventLevel? EventLevel {
            get { return BackingStore?.Get<DeviceEventLevel?>("eventLevel"); }
            set { BackingStore?.Set("eventLevel", value); }
        }
        /// <summary>The name of the event. Examples include: BootEvent, LogonEvent, AppCrashEvent, AppHangEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventName {
            get { return BackingStore?.Get<string?>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#nullable restore
#else
        public string EventName {
            get { return BackingStore?.Get<string>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#endif
        /// <summary>The source of the event. Examples include: Intune, Sccm.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventSource {
            get { return BackingStore?.Get<string?>("eventSource"); }
            set { BackingStore?.Set("eventSource", value); }
        }
#nullable restore
#else
        public string EventSource {
            get { return BackingStore?.Get<string>("eventSource"); }
            set { BackingStore?.Set("eventSource", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsDeviceTimelineEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceTimelineEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventDetails", n => { EventDetails = n.GetStringValue(); } },
                {"eventLevel", n => { EventLevel = n.GetEnumValue<DeviceEventLevel>(); } },
                {"eventName", n => { EventName = n.GetStringValue(); } },
                {"eventSource", n => { EventSource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventDetails", EventDetails);
            writer.WriteEnumValue<DeviceEventLevel>("eventLevel", EventLevel);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteStringValue("eventSource", EventSource);
        }
    }
}
