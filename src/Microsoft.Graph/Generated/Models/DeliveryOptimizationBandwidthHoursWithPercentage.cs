using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeliveryOptimizationBandwidthHoursWithPercentage : DeliveryOptimizationBandwidth, IParsable {
        /// <summary>Background download percentage hours.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeliveryOptimizationBandwidthBusinessHoursLimit? BandwidthBackgroundPercentageHours {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidthBusinessHoursLimit?>("bandwidthBackgroundPercentageHours"); }
            set { BackingStore?.Set("bandwidthBackgroundPercentageHours", value); }
        }
#nullable restore
#else
        public DeliveryOptimizationBandwidthBusinessHoursLimit BandwidthBackgroundPercentageHours {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthBackgroundPercentageHours"); }
            set { BackingStore?.Set("bandwidthBackgroundPercentageHours", value); }
        }
#endif
        /// <summary>Foreground download percentage hours.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeliveryOptimizationBandwidthBusinessHoursLimit? BandwidthForegroundPercentageHours {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidthBusinessHoursLimit?>("bandwidthForegroundPercentageHours"); }
            set { BackingStore?.Set("bandwidthForegroundPercentageHours", value); }
        }
#nullable restore
#else
        public DeliveryOptimizationBandwidthBusinessHoursLimit BandwidthForegroundPercentageHours {
            get { return BackingStore?.Get<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthForegroundPercentageHours"); }
            set { BackingStore?.Set("bandwidthForegroundPercentageHours", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeliveryOptimizationBandwidthHoursWithPercentage and sets the default values.
        /// </summary>
        public DeliveryOptimizationBandwidthHoursWithPercentage() : base() {
            OdataType = "#microsoft.graph.deliveryOptimizationBandwidthHoursWithPercentage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeliveryOptimizationBandwidthHoursWithPercentage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeliveryOptimizationBandwidthHoursWithPercentage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bandwidthBackgroundPercentageHours", n => { BandwidthBackgroundPercentageHours = n.GetObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>(DeliveryOptimizationBandwidthBusinessHoursLimit.CreateFromDiscriminatorValue); } },
                {"bandwidthForegroundPercentageHours", n => { BandwidthForegroundPercentageHours = n.GetObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>(DeliveryOptimizationBandwidthBusinessHoursLimit.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthBackgroundPercentageHours", BandwidthBackgroundPercentageHours);
            writer.WriteObjectValue<DeliveryOptimizationBandwidthBusinessHoursLimit>("bandwidthForegroundPercentageHours", BandwidthForegroundPercentageHours);
        }
    }
}
