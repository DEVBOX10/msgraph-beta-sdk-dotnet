using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ContinuousAccessEvaluationPolicy : Entity, IParsable {
        /// <summary>Continuous access evaluation automatically blocks access to resources and applications in near real time when a user&apos;s access is removed or a client IP address changes. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The value is always Continuous Access Evaluation. Read-only.</summary>
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
        /// <summary>The collection of group identifiers in scope for evaluation. All groups are in scope when the collection is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Groups {
            get { return BackingStore?.Get<List<string>?>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#nullable restore
#else
        public List<string> Groups {
            get { return BackingStore?.Get<List<string>>("groups"); }
            set { BackingStore?.Set("groups", value); }
        }
#endif
        /// <summary>true to indicate whether continuous access evaluation should be performed; otherwise false. Read-only.</summary>
        public bool? IsEnabled {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>true to indicate that the continuous access evaluation policy settings should be or has been migrated to the conditional access policy.</summary>
        public bool? Migrate {
            get { return BackingStore?.Get<bool?>("migrate"); }
            set { BackingStore?.Set("migrate", value); }
        }
        /// <summary>The collection of user identifiers in scope for evaluation. All users are in scope when the collection is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Users {
            get { return BackingStore?.Get<List<string>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<string> Users {
            get { return BackingStore?.Get<List<string>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContinuousAccessEvaluationPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContinuousAccessEvaluationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"groups", n => { Groups = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"migrate", n => { Migrate = n.GetBoolValue(); } },
                {"users", n => { Users = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("groups", Groups);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("migrate", Migrate);
            writer.WriteCollectionOfPrimitiveValues<string>("users", Users);
        }
    }
}
