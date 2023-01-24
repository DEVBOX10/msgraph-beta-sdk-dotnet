using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenantAlertRuleDefinition : Entity, IParsable {
        /// <summary>The alertRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantAlertRule>? AlertRules {
            get { return BackingStore?.Get<List<ManagedTenantAlertRule>?>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
#nullable restore
#else
        public List<ManagedTenantAlertRule> AlertRules {
            get { return BackingStore?.Get<List<ManagedTenantAlertRule>>("alertRules"); }
            set { BackingStore?.Set("alertRules", value); }
        }
#endif
        /// <summary>The createdByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedByUserId {
            get { return BackingStore?.Get<string?>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#nullable restore
#else
        public string CreatedByUserId {
            get { return BackingStore?.Get<string>("createdByUserId"); }
            set { BackingStore?.Set("createdByUserId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The definitionTemplate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AlertRuleDefinitionTemplate? DefinitionTemplate {
            get { return BackingStore?.Get<AlertRuleDefinitionTemplate?>("definitionTemplate"); }
            set { BackingStore?.Set("definitionTemplate", value); }
        }
#nullable restore
#else
        public AlertRuleDefinitionTemplate DefinitionTemplate {
            get { return BackingStore?.Get<AlertRuleDefinitionTemplate>("definitionTemplate"); }
            set { BackingStore?.Set("definitionTemplate", value); }
        }
#endif
        /// <summary>The displayName property</summary>
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
        /// <summary>The lastActionByUserId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastActionByUserId {
            get { return BackingStore?.Get<string?>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#nullable restore
#else
        public string LastActionByUserId {
            get { return BackingStore?.Get<string>("lastActionByUserId"); }
            set { BackingStore?.Set("lastActionByUserId", value); }
        }
#endif
        /// <summary>The lastActionDateTime property</summary>
        public DateTimeOffset? LastActionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActionDateTime"); }
            set { BackingStore?.Set("lastActionDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedTenantAlertRuleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedTenantAlertRuleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertRules", n => { AlertRules = n.GetCollectionOfObjectValues<ManagedTenantAlertRule>(ManagedTenantAlertRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"definitionTemplate", n => { DefinitionTemplate = n.GetObjectValue<AlertRuleDefinitionTemplate>(AlertRuleDefinitionTemplate.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertRule>("alertRules", AlertRules);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<AlertRuleDefinitionTemplate>("definitionTemplate", DefinitionTemplate);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
        }
    }
}
