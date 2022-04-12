using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RemoteAssistanceSettings : Entity, IParsable {
        /// <summary>Indicates if sessions to unenrolled devices are allowed for the account. This setting is configurable by the admin. Default value is false.</summary>
        public bool? AllowSessionsToUnenrolledDevices { get; set; }
        /// <summary>The current state of remote assistance for the account. Possible values are: disabled, enabled. This setting is configurable by the admin. Remote assistance settings that have not yet been configured by the admin have a disabled state. Returned by default. Possible values are: disabled, enabled.</summary>
        public Microsoft.Graph.Beta.Models.RemoteAssistanceState? RemoteAssistanceState { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RemoteAssistanceSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteAssistanceSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowSessionsToUnenrolledDevices", n => { AllowSessionsToUnenrolledDevices = n.GetBoolValue(); } },
                {"remoteAssistanceState", n => { RemoteAssistanceState = n.GetEnumValue<RemoteAssistanceState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowSessionsToUnenrolledDevices", AllowSessionsToUnenrolledDevices);
            writer.WriteEnumValue<RemoteAssistanceState>("remoteAssistanceState", RemoteAssistanceState);
        }
    }
}
