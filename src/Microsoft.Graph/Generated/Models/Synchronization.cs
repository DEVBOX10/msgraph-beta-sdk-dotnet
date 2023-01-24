using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Synchronization : Entity, IParsable {
        /// <summary>Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationJob>? Jobs {
            get { return BackingStore?.Get<List<SynchronizationJob>?>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#nullable restore
#else
        public List<SynchronizationJob> Jobs {
            get { return BackingStore?.Get<List<SynchronizationJob>>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#endif
        /// <summary>Represents a collection of credentials to access provisioned cloud applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationSecretKeyStringValuePair>? Secrets {
            get { return BackingStore?.Get<List<SynchronizationSecretKeyStringValuePair>?>("secrets"); }
            set { BackingStore?.Set("secrets", value); }
        }
#nullable restore
#else
        public List<SynchronizationSecretKeyStringValuePair> Secrets {
            get { return BackingStore?.Get<List<SynchronizationSecretKeyStringValuePair>>("secrets"); }
            set { BackingStore?.Set("secrets", value); }
        }
#endif
        /// <summary>Pre-configured synchronization settings for a particular application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationTemplate>? Templates {
            get { return BackingStore?.Get<List<SynchronizationTemplate>?>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#nullable restore
#else
        public List<SynchronizationTemplate> Templates {
            get { return BackingStore?.Get<List<SynchronizationTemplate>>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Synchronization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Synchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"jobs", n => { Jobs = n.GetCollectionOfObjectValues<SynchronizationJob>(SynchronizationJob.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secrets", n => { Secrets = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>(SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templates", n => { Templates = n.GetCollectionOfObjectValues<SynchronizationTemplate>(SynchronizationTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SynchronizationJob>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("secrets", Secrets);
            writer.WriteCollectionOfObjectValues<SynchronizationTemplate>("templates", Templates);
        }
    }
}
