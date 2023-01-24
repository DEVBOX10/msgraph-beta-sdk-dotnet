using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class InformationProtection : Entity, IParsable {
        /// <summary>The bitlocker property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Bitlocker? Bitlocker {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Bitlocker?>("bitlocker"); }
            set { BackingStore?.Set("bitlocker", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Bitlocker Bitlocker {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Bitlocker>("bitlocker"); }
            set { BackingStore?.Set("bitlocker", value); }
        }
#endif
        /// <summary>The dataLossPreventionPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DataLossPreventionPolicy>? DataLossPreventionPolicies {
            get { return BackingStore?.Get<List<DataLossPreventionPolicy>?>("dataLossPreventionPolicies"); }
            set { BackingStore?.Set("dataLossPreventionPolicies", value); }
        }
#nullable restore
#else
        public List<DataLossPreventionPolicy> DataLossPreventionPolicies {
            get { return BackingStore?.Get<List<DataLossPreventionPolicy>>("dataLossPreventionPolicies"); }
            set { BackingStore?.Set("dataLossPreventionPolicies", value); }
        }
#endif
        /// <summary>The policy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InformationProtectionPolicy? Policy {
            get { return BackingStore?.Get<InformationProtectionPolicy?>("policy"); }
            set { BackingStore?.Set("policy", value); }
        }
#nullable restore
#else
        public InformationProtectionPolicy Policy {
            get { return BackingStore?.Get<InformationProtectionPolicy>("policy"); }
            set { BackingStore?.Set("policy", value); }
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
        /// <summary>The sensitivityPolicySettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SensitivityPolicySettings? SensitivityPolicySettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SensitivityPolicySettings?>("sensitivityPolicySettings"); }
            set { BackingStore?.Set("sensitivityPolicySettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SensitivityPolicySettings SensitivityPolicySettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SensitivityPolicySettings>("sensitivityPolicySettings"); }
            set { BackingStore?.Set("sensitivityPolicySettings", value); }
        }
#endif
        /// <summary>The threatAssessmentRequests property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ThreatAssessmentRequest>? ThreatAssessmentRequests {
            get { return BackingStore?.Get<List<ThreatAssessmentRequest>?>("threatAssessmentRequests"); }
            set { BackingStore?.Set("threatAssessmentRequests", value); }
        }
#nullable restore
#else
        public List<ThreatAssessmentRequest> ThreatAssessmentRequests {
            get { return BackingStore?.Get<List<ThreatAssessmentRequest>>("threatAssessmentRequests"); }
            set { BackingStore?.Set("threatAssessmentRequests", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bitlocker", n => { Bitlocker = n.GetObjectValue<Microsoft.Graph.Beta.Models.Bitlocker>(Microsoft.Graph.Beta.Models.Bitlocker.CreateFromDiscriminatorValue); } },
                {"dataLossPreventionPolicies", n => { DataLossPreventionPolicies = n.GetCollectionOfObjectValues<DataLossPreventionPolicy>(DataLossPreventionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"policy", n => { Policy = n.GetObjectValue<InformationProtectionPolicy>(InformationProtectionPolicy.CreateFromDiscriminatorValue); } },
                {"sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sensitivityPolicySettings", n => { SensitivityPolicySettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.SensitivityPolicySettings>(Microsoft.Graph.Beta.Models.SensitivityPolicySettings.CreateFromDiscriminatorValue); } },
                {"threatAssessmentRequests", n => { ThreatAssessmentRequests = n.GetCollectionOfObjectValues<ThreatAssessmentRequest>(ThreatAssessmentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Bitlocker>("bitlocker", Bitlocker);
            writer.WriteCollectionOfObjectValues<DataLossPreventionPolicy>("dataLossPreventionPolicies", DataLossPreventionPolicies);
            writer.WriteObjectValue<InformationProtectionPolicy>("policy", Policy);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SensitivityPolicySettings>("sensitivityPolicySettings", SensitivityPolicySettings);
            writer.WriteCollectionOfObjectValues<ThreatAssessmentRequest>("threatAssessmentRequests", ThreatAssessmentRequests);
        }
    }
}
