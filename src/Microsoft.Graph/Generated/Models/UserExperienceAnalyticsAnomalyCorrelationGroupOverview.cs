using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The user experience analytics anomaly correlation group overview entity contains the information for each correlation group of an anomaly.
    /// </summary>
    public class UserExperienceAnalyticsAnomalyCorrelationGroupOverview : Entity, IParsable {
        /// <summary>Indicates the number of correlation groups in the anomaly. Valid values -2147483648 to 2147483647</summary>
        public int? AnomalyCorrelationGroupCount {
            get { return BackingStore?.Get<int?>("anomalyCorrelationGroupCount"); }
            set { BackingStore?.Set("anomalyCorrelationGroupCount", value); }
        }
        /// <summary>The unique identifier of the anomaly. Anomaly details such as name and type can be found in the UserExperienceAnalyticsAnomalySeverityOverview entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AnomalyId {
            get { return BackingStore?.Get<string?>("anomalyId"); }
            set { BackingStore?.Set("anomalyId", value); }
        }
#nullable restore
#else
        public string AnomalyId {
            get { return BackingStore?.Get<string>("anomalyId"); }
            set { BackingStore?.Set("anomalyId", value); }
        }
#endif
        /// <summary>Indicates the total number of devices affected by the anomaly in the correlation group. Valid values -2147483648 to 2147483647</summary>
        public int? CorrelationGroupAnomalousDeviceCount {
            get { return BackingStore?.Get<int?>("correlationGroupAnomalousDeviceCount"); }
            set { BackingStore?.Set("correlationGroupAnomalousDeviceCount", value); }
        }
        /// <summary>Indicates the total number of devices at risk in the correlation group. Valid values -2147483648 to 2147483647</summary>
        public int? CorrelationGroupAtRiskDeviceCount {
            get { return BackingStore?.Get<int?>("correlationGroupAtRiskDeviceCount"); }
            set { BackingStore?.Set("correlationGroupAtRiskDeviceCount", value); }
        }
        /// <summary>Indicates the total number of devices in a correlation group. Valid values -2147483648 to 2147483647</summary>
        public int? CorrelationGroupDeviceCount {
            get { return BackingStore?.Get<int?>("correlationGroupDeviceCount"); }
            set { BackingStore?.Set("correlationGroupDeviceCount", value); }
        }
        /// <summary>Describes the features of a device that are shared between all devices in a correlation group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAnomalyCorrelationGroupFeature>? CorrelationGroupFeatures {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAnomalyCorrelationGroupFeature>?>("correlationGroupFeatures"); }
            set { BackingStore?.Set("correlationGroupFeatures", value); }
        }
#nullable restore
#else
        public List<UserExperienceAnalyticsAnomalyCorrelationGroupFeature> CorrelationGroupFeatures {
            get { return BackingStore?.Get<List<UserExperienceAnalyticsAnomalyCorrelationGroupFeature>>("correlationGroupFeatures"); }
            set { BackingStore?.Set("correlationGroupFeatures", value); }
        }
#endif
        /// <summary>The unique identifier for the correlation group which will uniquely identify one of the correlation group within an anomaly. The correlation Id can be mapped to the correlation group name by concatinating the correlation group features. Example of correlation group name which is the indicative of concatenated features names are  for names, Contoso manufacture 4.4.1 and Windows 11.22621.1485.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationGroupId {
            get { return BackingStore?.Get<string?>("correlationGroupId"); }
            set { BackingStore?.Set("correlationGroupId", value); }
        }
#nullable restore
#else
        public string CorrelationGroupId {
            get { return BackingStore?.Get<string>("correlationGroupId"); }
            set { BackingStore?.Set("correlationGroupId", value); }
        }
#endif
        /// <summary>Indicates the level of prevalence of the correlation group features in the anomaly. Possible values are: high, medium or low</summary>
        public UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence? CorrelationGroupPrevalence {
            get { return BackingStore?.Get<UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence?>("correlationGroupPrevalence"); }
            set { BackingStore?.Set("correlationGroupPrevalence", value); }
        }
        /// <summary>The percentage of the devices in the correlation group that are anomalous. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CorrelationGroupPrevalencePercentage {
            get { return BackingStore?.Get<double?>("correlationGroupPrevalencePercentage"); }
            set { BackingStore?.Set("correlationGroupPrevalencePercentage", value); }
        }
        /// <summary>Indicates the total number of devices in the tenant. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDeviceCount {
            get { return BackingStore?.Get<int?>("totalDeviceCount"); }
            set { BackingStore?.Set("totalDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAnomalyCorrelationGroupOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAnomalyCorrelationGroupOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"anomalyCorrelationGroupCount", n => { AnomalyCorrelationGroupCount = n.GetIntValue(); } },
                {"anomalyId", n => { AnomalyId = n.GetStringValue(); } },
                {"correlationGroupAnomalousDeviceCount", n => { CorrelationGroupAnomalousDeviceCount = n.GetIntValue(); } },
                {"correlationGroupAtRiskDeviceCount", n => { CorrelationGroupAtRiskDeviceCount = n.GetIntValue(); } },
                {"correlationGroupDeviceCount", n => { CorrelationGroupDeviceCount = n.GetIntValue(); } },
                {"correlationGroupFeatures", n => { CorrelationGroupFeatures = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAnomalyCorrelationGroupFeature>(UserExperienceAnalyticsAnomalyCorrelationGroupFeature.CreateFromDiscriminatorValue)?.ToList(); } },
                {"correlationGroupId", n => { CorrelationGroupId = n.GetStringValue(); } },
                {"correlationGroupPrevalence", n => { CorrelationGroupPrevalence = n.GetEnumValue<UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence>(); } },
                {"correlationGroupPrevalencePercentage", n => { CorrelationGroupPrevalencePercentage = n.GetDoubleValue(); } },
                {"totalDeviceCount", n => { TotalDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("anomalyCorrelationGroupCount", AnomalyCorrelationGroupCount);
            writer.WriteStringValue("anomalyId", AnomalyId);
            writer.WriteIntValue("correlationGroupAnomalousDeviceCount", CorrelationGroupAnomalousDeviceCount);
            writer.WriteIntValue("correlationGroupAtRiskDeviceCount", CorrelationGroupAtRiskDeviceCount);
            writer.WriteIntValue("correlationGroupDeviceCount", CorrelationGroupDeviceCount);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAnomalyCorrelationGroupFeature>("correlationGroupFeatures", CorrelationGroupFeatures);
            writer.WriteStringValue("correlationGroupId", CorrelationGroupId);
            writer.WriteEnumValue<UserExperienceAnalyticsAnomalyCorrelationGroupPrevalence>("correlationGroupPrevalence", CorrelationGroupPrevalence);
            writer.WriteDoubleValue("correlationGroupPrevalencePercentage", CorrelationGroupPrevalencePercentage);
            writer.WriteIntValue("totalDeviceCount", TotalDeviceCount);
        }
    }
}
