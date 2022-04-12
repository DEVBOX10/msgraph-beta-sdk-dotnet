using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsDeviceScores : Entity, IParsable {
        /// <summary>The user experience analytics device app reliability score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? AppReliabilityScore { get; set; }
        /// <summary>The user experience analytics device name.</summary>
        public string DeviceName { get; set; }
        /// <summary>The user experience analytics device score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? EndpointAnalyticsScore { get; set; }
        /// <summary>The health state of the user experience analytics device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals.</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The user experience analytics device manufacturer.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The user experience analytics device model.</summary>
        public string Model { get; set; }
        /// <summary>The user experience analytics device startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StartupPerformanceScore { get; set; }
        /// <summary>The user experience analytics device work From anywhere score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserExperienceAnalyticsDeviceScores CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceScores();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appReliabilityScore", n => { AppReliabilityScore = n.GetDoubleValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"endpointAnalyticsScore", n => { EndpointAnalyticsScore = n.GetDoubleValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"startupPerformanceScore", n => { StartupPerformanceScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", n => { WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("appReliabilityScore", AppReliabilityScore);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDoubleValue("endpointAnalyticsScore", EndpointAnalyticsScore);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}
