using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory : Entity, IParsable {
        /// <summary>The unique identifier of the device, Intune DeviceID or SCCM device id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values -2147483648 to 2147483647</summary>
        public int? EstimatedRuntimeInMinutes {
            get { return BackingStore?.Get<int?>("estimatedRuntimeInMinutes"); }
            set { BackingStore?.Set("estimatedRuntimeInMinutes", value); }
        }
        /// <summary>The datetime for the instance of runtime history.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuntimeDateTime {
            get { return BackingStore?.Get<string?>("runtimeDateTime"); }
            set { BackingStore?.Set("runtimeDateTime", value); }
        }
#nullable restore
#else
        public string RuntimeDateTime {
            get { return BackingStore?.Get<string>("runtimeDateTime"); }
            set { BackingStore?.Set("runtimeDateTime", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"estimatedRuntimeInMinutes", n => { EstimatedRuntimeInMinutes = n.GetIntValue(); } },
                {"runtimeDateTime", n => { RuntimeDateTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteIntValue("estimatedRuntimeInMinutes", EstimatedRuntimeInMinutes);
            writer.WriteStringValue("runtimeDateTime", RuntimeDateTime);
        }
    }
}
