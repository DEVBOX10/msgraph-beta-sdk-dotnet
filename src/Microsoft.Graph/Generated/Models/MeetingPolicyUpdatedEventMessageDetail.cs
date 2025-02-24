// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingPolicyUpdatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator {
            get { return BackingStore?.Get<IdentitySet?>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#nullable restore
#else
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>("initiator"); }
            set { BackingStore?.Set("initiator", value); }
        }
#endif
        /// <summary>Represents whether the meeting chat is enabled or not.</summary>
        public bool? MeetingChatEnabled {
            get { return BackingStore?.Get<bool?>("meetingChatEnabled"); }
            set { BackingStore?.Set("meetingChatEnabled", value); }
        }
        /// <summary>Unique identifier of the meeting chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MeetingChatId {
            get { return BackingStore?.Get<string?>("meetingChatId"); }
            set { BackingStore?.Set("meetingChatId", value); }
        }
#nullable restore
#else
        public string MeetingChatId {
            get { return BackingStore?.Get<string>("meetingChatId"); }
            set { BackingStore?.Set("meetingChatId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new meetingPolicyUpdatedEventMessageDetail and sets the default values.
        /// </summary>
        public MeetingPolicyUpdatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.meetingPolicyUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MeetingPolicyUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingPolicyUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"meetingChatEnabled", n => { MeetingChatEnabled = n.GetBoolValue(); } },
                {"meetingChatId", n => { MeetingChatId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteBoolValue("meetingChatEnabled", MeetingChatEnabled);
            writer.WriteStringValue("meetingChatId", MeetingChatId);
        }
    }
}
