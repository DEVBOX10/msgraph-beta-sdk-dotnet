// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DeploymentAudience : Entity, IParsable {
        /// <summary>Content eligible to deploy to devices in the audience. Not nullable. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent>? ApplicableContent {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent>?>("applicableContent"); }
            set { BackingStore?.Set("applicableContent", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent> ApplicableContent {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent>>("applicableContent"); }
            set { BackingStore?.Set("applicableContent", value); }
        }
#endif
        /// <summary>Specifies the assets to exclude from the audience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAsset>? Exclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("exclusions"); }
            set { BackingStore?.Set("exclusions", value); }
        }
#nullable restore
#else
        public List<UpdatableAsset> Exclusions {
            get { return BackingStore?.Get<List<UpdatableAsset>>("exclusions"); }
            set { BackingStore?.Set("exclusions", value); }
        }
#endif
        /// <summary>Specifies the assets to include in the audience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UpdatableAsset>? Members {
            get { return BackingStore?.Get<List<UpdatableAsset>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<UpdatableAsset> Members {
            get { return BackingStore?.Get<List<UpdatableAsset>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeploymentAudience CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentAudience();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableContent", n => { ApplicableContent = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent>(Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exclusions", n => { Exclusions = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<UpdatableAsset>(UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.ApplicableContent>("applicableContent", ApplicableContent);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("exclusions", Exclusions);
            writer.WriteCollectionOfObjectValues<UpdatableAsset>("members", Members);
        }
    }
}
