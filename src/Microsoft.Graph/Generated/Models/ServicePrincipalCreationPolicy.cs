using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ServicePrincipalCreationPolicy : PolicyBase, IParsable {
        /// <summary>The excludes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicePrincipalCreationConditionSet>? Excludes {
            get { return BackingStore?.Get<List<ServicePrincipalCreationConditionSet>?>("excludes"); }
            set { BackingStore?.Set("excludes", value); }
        }
#nullable restore
#else
        public List<ServicePrincipalCreationConditionSet> Excludes {
            get { return BackingStore?.Get<List<ServicePrincipalCreationConditionSet>>("excludes"); }
            set { BackingStore?.Set("excludes", value); }
        }
#endif
        /// <summary>The includes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServicePrincipalCreationConditionSet>? Includes {
            get { return BackingStore?.Get<List<ServicePrincipalCreationConditionSet>?>("includes"); }
            set { BackingStore?.Set("includes", value); }
        }
#nullable restore
#else
        public List<ServicePrincipalCreationConditionSet> Includes {
            get { return BackingStore?.Get<List<ServicePrincipalCreationConditionSet>>("includes"); }
            set { BackingStore?.Set("includes", value); }
        }
#endif
        /// <summary>The isBuiltIn property</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalCreationPolicy and sets the default values.
        /// </summary>
        public ServicePrincipalCreationPolicy() : base() {
            OdataType = "#microsoft.graph.servicePrincipalCreationPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServicePrincipalCreationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServicePrincipalCreationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"excludes", n => { Excludes = n.GetCollectionOfObjectValues<ServicePrincipalCreationConditionSet>(ServicePrincipalCreationConditionSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"includes", n => { Includes = n.GetCollectionOfObjectValues<ServicePrincipalCreationConditionSet>(ServicePrincipalCreationConditionSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServicePrincipalCreationConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<ServicePrincipalCreationConditionSet>("includes", Includes);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
        }
    }
}
