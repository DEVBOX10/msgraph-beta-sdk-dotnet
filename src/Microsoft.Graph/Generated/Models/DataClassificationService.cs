using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DataClassificationService : Entity, IParsable {
        /// <summary>The classifyFileJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JobResponseBase>? ClassifyFileJobs {
            get { return BackingStore?.Get<List<JobResponseBase>?>("classifyFileJobs"); }
            set { BackingStore?.Set("classifyFileJobs", value); }
        }
#nullable restore
#else
        public List<JobResponseBase> ClassifyFileJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("classifyFileJobs"); }
            set { BackingStore?.Set("classifyFileJobs", value); }
        }
#endif
        /// <summary>The classifyTextJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JobResponseBase>? ClassifyTextJobs {
            get { return BackingStore?.Get<List<JobResponseBase>?>("classifyTextJobs"); }
            set { BackingStore?.Set("classifyTextJobs", value); }
        }
#nullable restore
#else
        public List<JobResponseBase> ClassifyTextJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("classifyTextJobs"); }
            set { BackingStore?.Set("classifyTextJobs", value); }
        }
#endif
        /// <summary>The evaluateDlpPoliciesJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JobResponseBase>? EvaluateDlpPoliciesJobs {
            get { return BackingStore?.Get<List<JobResponseBase>?>("evaluateDlpPoliciesJobs"); }
            set { BackingStore?.Set("evaluateDlpPoliciesJobs", value); }
        }
#nullable restore
#else
        public List<JobResponseBase> EvaluateDlpPoliciesJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("evaluateDlpPoliciesJobs"); }
            set { BackingStore?.Set("evaluateDlpPoliciesJobs", value); }
        }
#endif
        /// <summary>The evaluateLabelJobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JobResponseBase>? EvaluateLabelJobs {
            get { return BackingStore?.Get<List<JobResponseBase>?>("evaluateLabelJobs"); }
            set { BackingStore?.Set("evaluateLabelJobs", value); }
        }
#nullable restore
#else
        public List<JobResponseBase> EvaluateLabelJobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("evaluateLabelJobs"); }
            set { BackingStore?.Set("evaluateLabelJobs", value); }
        }
#endif
        /// <summary>The exactMatchDataStores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExactMatchDataStore>? ExactMatchDataStores {
            get { return BackingStore?.Get<List<ExactMatchDataStore>?>("exactMatchDataStores"); }
            set { BackingStore?.Set("exactMatchDataStores", value); }
        }
#nullable restore
#else
        public List<ExactMatchDataStore> ExactMatchDataStores {
            get { return BackingStore?.Get<List<ExactMatchDataStore>>("exactMatchDataStores"); }
            set { BackingStore?.Set("exactMatchDataStores", value); }
        }
#endif
        /// <summary>The exactMatchUploadAgents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExactMatchUploadAgent>? ExactMatchUploadAgents {
            get { return BackingStore?.Get<List<ExactMatchUploadAgent>?>("exactMatchUploadAgents"); }
            set { BackingStore?.Set("exactMatchUploadAgents", value); }
        }
#nullable restore
#else
        public List<ExactMatchUploadAgent> ExactMatchUploadAgents {
            get { return BackingStore?.Get<List<ExactMatchUploadAgent>>("exactMatchUploadAgents"); }
            set { BackingStore?.Set("exactMatchUploadAgents", value); }
        }
#endif
        /// <summary>The jobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JobResponseBase>? Jobs {
            get { return BackingStore?.Get<List<JobResponseBase>?>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#nullable restore
#else
        public List<JobResponseBase> Jobs {
            get { return BackingStore?.Get<List<JobResponseBase>>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#endif
        /// <summary>The sensitiveTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SensitiveType>? SensitiveTypes {
            get { return BackingStore?.Get<List<SensitiveType>?>("sensitiveTypes"); }
            set { BackingStore?.Set("sensitiveTypes", value); }
        }
#nullable restore
#else
        public List<SensitiveType> SensitiveTypes {
            get { return BackingStore?.Get<List<SensitiveType>>("sensitiveTypes"); }
            set { BackingStore?.Set("sensitiveTypes", value); }
        }
#endif
        /// <summary>The sensitivityLabels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SensitivityLabel>? SensitivityLabels {
            get { return BackingStore?.Get<List<SensitivityLabel>?>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#nullable restore
#else
        public List<SensitivityLabel> SensitivityLabels {
            get { return BackingStore?.Get<List<SensitivityLabel>>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DataClassificationService CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataClassificationService();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classifyFileJobs", n => { ClassifyFileJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classifyTextJobs", n => { ClassifyTextJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"evaluateDlpPoliciesJobs", n => { EvaluateDlpPoliciesJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"evaluateLabelJobs", n => { EvaluateLabelJobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exactMatchDataStores", n => { ExactMatchDataStores = n.GetCollectionOfObjectValues<ExactMatchDataStore>(ExactMatchDataStore.CreateFromDiscriminatorValue)?.ToList(); } },
                {"exactMatchUploadAgents", n => { ExactMatchUploadAgents = n.GetCollectionOfObjectValues<ExactMatchUploadAgent>(ExactMatchUploadAgent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"jobs", n => { Jobs = n.GetCollectionOfObjectValues<JobResponseBase>(JobResponseBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sensitiveTypes", n => { SensitiveTypes = n.GetCollectionOfObjectValues<SensitiveType>(SensitiveType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("classifyFileJobs", ClassifyFileJobs);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("classifyTextJobs", ClassifyTextJobs);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("evaluateDlpPoliciesJobs", EvaluateDlpPoliciesJobs);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("evaluateLabelJobs", EvaluateLabelJobs);
            writer.WriteCollectionOfObjectValues<ExactMatchDataStore>("exactMatchDataStores", ExactMatchDataStores);
            writer.WriteCollectionOfObjectValues<ExactMatchUploadAgent>("exactMatchUploadAgents", ExactMatchUploadAgents);
            writer.WriteCollectionOfObjectValues<JobResponseBase>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<SensitiveType>("sensitiveTypes", SensitiveTypes);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
        }
    }
}
