using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcSupportedRegion : Entity, IParsable {
        /// <summary>The name for the supported region. Read-only.</summary>
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
        /// <summary>The regionGroup property</summary>
        public CloudPcRegionGroup? RegionGroup {
            get { return BackingStore?.Get<CloudPcRegionGroup?>("regionGroup"); }
            set { BackingStore?.Set("regionGroup", value); }
        }
        /// <summary>The status of the supported region. Possible values are: available, restricted, unavailable, unknownFutureValue. Read-only.</summary>
        public CloudPcSupportedRegionStatus? RegionStatus {
            get { return BackingStore?.Get<CloudPcSupportedRegionStatus?>("regionStatus"); }
            set { BackingStore?.Set("regionStatus", value); }
        }
        /// <summary>The supportedSolution property</summary>
        public CloudPcManagementService? SupportedSolution {
            get { return BackingStore?.Get<CloudPcManagementService?>("supportedSolution"); }
            set { BackingStore?.Set("supportedSolution", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudPcSupportedRegion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcSupportedRegion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"regionGroup", n => { RegionGroup = n.GetEnumValue<CloudPcRegionGroup>(); } },
                {"regionStatus", n => { RegionStatus = n.GetEnumValue<CloudPcSupportedRegionStatus>(); } },
                {"supportedSolution", n => { SupportedSolution = n.GetEnumValue<CloudPcManagementService>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<CloudPcRegionGroup>("regionGroup", RegionGroup);
            writer.WriteEnumValue<CloudPcSupportedRegionStatus>("regionStatus", RegionStatus);
            writer.WriteEnumValue<CloudPcManagementService>("supportedSolution", SupportedSolution);
        }
    }
}
