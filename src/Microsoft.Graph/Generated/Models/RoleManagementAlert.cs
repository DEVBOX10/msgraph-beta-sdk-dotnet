// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class RoleManagementAlert : Entity, IParsable {
        /// <summary>The various configurations of an alert for Microsoft Entra roles. The configurations are predefined and can&apos;t be created or deleted, but some of the configurations can be modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlertConfiguration>? AlertConfigurations {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlertConfiguration>?>("alertConfigurations"); }
            set { BackingStore?.Set("alertConfigurations", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementAlertConfiguration> AlertConfigurations {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlertConfiguration>>("alertConfigurations"); }
            set { BackingStore?.Set("alertConfigurations", value); }
        }
#endif
        /// <summary>Defines an alert, its impact, and measures to mitigate or prevent it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlertDefinition>? AlertDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlertDefinition>?>("alertDefinitions"); }
            set { BackingStore?.Set("alertDefinitions", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementAlertDefinition> AlertDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlertDefinition>>("alertDefinitions"); }
            set { BackingStore?.Set("alertDefinitions", value); }
        }
#endif
        /// <summary>Represents the alert entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleManagementAlert>? Alerts {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlert>?>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#nullable restore
#else
        public List<UnifiedRoleManagementAlert> Alerts {
            get { return BackingStore?.Get<List<UnifiedRoleManagementAlert>>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#endif
        /// <summary>Represents operations on resources that take a long time to complete and can run in the background until completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LongRunningOperation>? Operations {
            get { return BackingStore?.Get<List<LongRunningOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<LongRunningOperation> Operations {
            get { return BackingStore?.Get<List<LongRunningOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoleManagementAlert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleManagementAlert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alertConfigurations", n => { AlertConfigurations = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlertConfiguration>(UnifiedRoleManagementAlertConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alertDefinitions", n => { AlertDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlertDefinition>(UnifiedRoleManagementAlertDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<UnifiedRoleManagementAlert>(UnifiedRoleManagementAlert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<LongRunningOperation>(LongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlertConfiguration>("alertConfigurations", AlertConfigurations);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlertDefinition>("alertDefinitions", AlertDefinitions);
            writer.WriteCollectionOfObjectValues<UnifiedRoleManagementAlert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<LongRunningOperation>("operations", Operations);
        }
    }
}
