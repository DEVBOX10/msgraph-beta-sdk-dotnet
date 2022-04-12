using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRole : Entity, IParsable {
        /// <summary>The assignments for this role. Read-only. Nullable.</summary>
        public List<PrivilegedRoleAssignment> Assignments { get; set; }
        /// <summary>Role name.</summary>
        public string Name { get; set; }
        /// <summary>The settings for this role. Read-only. Nullable.</summary>
        public PrivilegedRoleSettings Settings { get; set; }
        /// <summary>The summary information for this role. Read-only. Nullable.</summary>
        public PrivilegedRoleSummary Summary { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedRole CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRole();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<PrivilegedRoleAssignment>(PrivilegedRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetObjectValue<PrivilegedRoleSettings>(PrivilegedRoleSettings.CreateFromDiscriminatorValue); } },
                {"summary", n => { Summary = n.GetObjectValue<PrivilegedRoleSummary>(PrivilegedRoleSummary.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PrivilegedRoleAssignment>("assignments", Assignments);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<PrivilegedRoleSettings>("settings", Settings);
            writer.WriteObjectValue<PrivilegedRoleSummary>("summary", Summary);
        }
    }
}
