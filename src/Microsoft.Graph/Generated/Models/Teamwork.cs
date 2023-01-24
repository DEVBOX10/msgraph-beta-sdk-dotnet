using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Teamwork : Entity, IParsable {
        /// <summary>A collection of deleted teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeletedTeam>? DeletedTeams {
            get { return BackingStore?.Get<List<DeletedTeam>?>("deletedTeams"); }
            set { BackingStore?.Set("deletedTeams", value); }
        }
#nullable restore
#else
        public List<DeletedTeam> DeletedTeams {
            get { return BackingStore?.Get<List<DeletedTeam>>("deletedTeams"); }
            set { BackingStore?.Set("deletedTeams", value); }
        }
#endif
        /// <summary>The Teams devices provisioned for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkDevice>? Devices {
            get { return BackingStore?.Get<List<TeamworkDevice>?>("devices"); }
            set { BackingStore?.Set("devices", value); }
        }
#nullable restore
#else
        public List<TeamworkDevice> Devices {
            get { return BackingStore?.Get<List<TeamworkDevice>>("devices"); }
            set { BackingStore?.Set("devices", value); }
        }
#endif
        /// <summary>Represents tenant-wide settings for all Teams apps in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsAppSettings? TeamsAppSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppSettings?>("teamsAppSettings"); }
            set { BackingStore?.Set("teamsAppSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsAppSettings TeamsAppSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppSettings>("teamsAppSettings"); }
            set { BackingStore?.Set("teamsAppSettings", value); }
        }
#endif
        /// <summary>The templates associated with a team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamTemplate>? TeamTemplates {
            get { return BackingStore?.Get<List<TeamTemplate>?>("teamTemplates"); }
            set { BackingStore?.Set("teamTemplates", value); }
        }
#nullable restore
#else
        public List<TeamTemplate> TeamTemplates {
            get { return BackingStore?.Get<List<TeamTemplate>>("teamTemplates"); }
            set { BackingStore?.Set("teamTemplates", value); }
        }
#endif
        /// <summary>A workforce integration with shifts.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkforceIntegration>? WorkforceIntegrations {
            get { return BackingStore?.Get<List<WorkforceIntegration>?>("workforceIntegrations"); }
            set { BackingStore?.Set("workforceIntegrations", value); }
        }
#nullable restore
#else
        public List<WorkforceIntegration> WorkforceIntegrations {
            get { return BackingStore?.Get<List<WorkforceIntegration>>("workforceIntegrations"); }
            set { BackingStore?.Set("workforceIntegrations", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Teamwork CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Teamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deletedTeams", n => { DeletedTeams = n.GetCollectionOfObjectValues<DeletedTeam>(DeletedTeam.CreateFromDiscriminatorValue)?.ToList(); } },
                {"devices", n => { Devices = n.GetCollectionOfObjectValues<TeamworkDevice>(TeamworkDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"teamsAppSettings", n => { TeamsAppSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppSettings>(Microsoft.Graph.Beta.Models.TeamsAppSettings.CreateFromDiscriminatorValue); } },
                {"teamTemplates", n => { TeamTemplates = n.GetCollectionOfObjectValues<TeamTemplate>(TeamTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workforceIntegrations", n => { WorkforceIntegrations = n.GetCollectionOfObjectValues<WorkforceIntegration>(WorkforceIntegration.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeletedTeam>("deletedTeams", DeletedTeams);
            writer.WriteCollectionOfObjectValues<TeamworkDevice>("devices", Devices);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppSettings>("teamsAppSettings", TeamsAppSettings);
            writer.WriteCollectionOfObjectValues<TeamTemplate>("teamTemplates", TeamTemplates);
            writer.WriteCollectionOfObjectValues<WorkforceIntegration>("workforceIntegrations", WorkforceIntegrations);
        }
    }
}
