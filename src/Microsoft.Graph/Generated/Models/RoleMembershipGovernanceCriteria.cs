using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoleMembershipGovernanceCriteria : GovernanceCriteria, IParsable {
        /// <summary>The roleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleId {
            get { return BackingStore?.Get<string?>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#nullable restore
#else
        public string RoleId {
            get { return BackingStore?.Get<string>("roleId"); }
            set { BackingStore?.Set("roleId", value); }
        }
#endif
        /// <summary>The roleTemplateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleTemplateId {
            get { return BackingStore?.Get<string?>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#nullable restore
#else
        public string RoleTemplateId {
            get { return BackingStore?.Get<string>("roleTemplateId"); }
            set { BackingStore?.Set("roleTemplateId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new RoleMembershipGovernanceCriteria and sets the default values.
        /// </summary>
        public RoleMembershipGovernanceCriteria() : base() {
            OdataType = "#microsoft.graph.roleMembershipGovernanceCriteria";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoleMembershipGovernanceCriteria CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleMembershipGovernanceCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleTemplateId", n => { RoleTemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteStringValue("roleTemplateId", RoleTemplateId);
        }
    }
}
