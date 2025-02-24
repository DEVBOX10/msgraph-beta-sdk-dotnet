// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class ProtectOnlineMeetingAction : LabelActionBase, IParsable {
        /// <summary>The allowedForwarders property</summary>
        public OnlineMeetingForwarders? AllowedForwarders {
            get { return BackingStore?.Get<OnlineMeetingForwarders?>("allowedForwarders"); }
            set { BackingStore?.Set("allowedForwarders", value); }
        }
        /// <summary>The allowedPresenters property</summary>
        public OnlineMeetingPresenters? AllowedPresenters {
            get { return BackingStore?.Get<OnlineMeetingPresenters?>("allowedPresenters"); }
            set { BackingStore?.Set("allowedPresenters", value); }
        }
        /// <summary>The isCopyToClipboardEnabled property</summary>
        public bool? IsCopyToClipboardEnabled {
            get { return BackingStore?.Get<bool?>("isCopyToClipboardEnabled"); }
            set { BackingStore?.Set("isCopyToClipboardEnabled", value); }
        }
        /// <summary>The isLobbyEnabled property</summary>
        public bool? IsLobbyEnabled {
            get { return BackingStore?.Get<bool?>("isLobbyEnabled"); }
            set { BackingStore?.Set("isLobbyEnabled", value); }
        }
        /// <summary>The lobbyBypassSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.LobbyBypassSettings? LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LobbyBypassSettings?>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.LobbyBypassSettings LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LobbyBypassSettings>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new protectOnlineMeetingAction and sets the default values.
        /// </summary>
        public ProtectOnlineMeetingAction() : base() {
            OdataType = "#microsoft.graph.protectOnlineMeetingAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProtectOnlineMeetingAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectOnlineMeetingAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedForwarders", n => { AllowedForwarders = n.GetEnumValue<OnlineMeetingForwarders>(); } },
                {"allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"isCopyToClipboardEnabled", n => { IsCopyToClipboardEnabled = n.GetBoolValue(); } },
                {"isLobbyEnabled", n => { IsLobbyEnabled = n.GetBoolValue(); } },
                {"lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.LobbyBypassSettings>(Microsoft.Graph.Beta.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<OnlineMeetingForwarders>("allowedForwarders", AllowedForwarders);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteBoolValue("isCopyToClipboardEnabled", IsCopyToClipboardEnabled);
            writer.WriteBoolValue("isLobbyEnabled", IsLobbyEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
        }
    }
}
