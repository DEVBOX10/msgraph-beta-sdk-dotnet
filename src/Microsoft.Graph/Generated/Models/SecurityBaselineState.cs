using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Security baseline state for a device.
    /// </summary>
    public class SecurityBaselineState : Entity, IParsable {
        /// <summary>The display name of the security baseline</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The security baseline template id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecurityBaselineTemplateId {
            get { return BackingStore?.Get<string?>("securityBaselineTemplateId"); }
            set { BackingStore?.Set("securityBaselineTemplateId", value); }
        }
#nullable restore
#else
        public string SecurityBaselineTemplateId {
            get { return BackingStore?.Get<string>("securityBaselineTemplateId"); }
            set { BackingStore?.Set("securityBaselineTemplateId", value); }
        }
#endif
        /// <summary>The security baseline state for different settings for a device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SecurityBaselineSettingState>? SettingStates {
            get { return BackingStore?.Get<List<SecurityBaselineSettingState>?>("settingStates"); }
            set { BackingStore?.Set("settingStates", value); }
        }
#nullable restore
#else
        public List<SecurityBaselineSettingState> SettingStates {
            get { return BackingStore?.Get<List<SecurityBaselineSettingState>>("settingStates"); }
            set { BackingStore?.Set("settingStates", value); }
        }
#endif
        /// <summary>Security Baseline Compliance State</summary>
        public SecurityBaselineComplianceState? State {
            get { return BackingStore?.Get<SecurityBaselineComplianceState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>User Principal Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityBaselineState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"securityBaselineTemplateId", n => { SecurityBaselineTemplateId = n.GetStringValue(); } },
                {"settingStates", n => { SettingStates = n.GetCollectionOfObjectValues<SecurityBaselineSettingState>(SecurityBaselineSettingState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<SecurityBaselineComplianceState>(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("securityBaselineTemplateId", SecurityBaselineTemplateId);
            writer.WriteCollectionOfObjectValues<SecurityBaselineSettingState>("settingStates", SettingStates);
            writer.WriteEnumValue<SecurityBaselineComplianceState>("state", State);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
