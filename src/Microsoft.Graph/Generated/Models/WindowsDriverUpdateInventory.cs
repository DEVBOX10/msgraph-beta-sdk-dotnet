using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A new entity to represent driver inventories.
    /// </summary>
    public class WindowsDriverUpdateInventory : Entity, IParsable {
        /// <summary>The number of devices for which this driver is applicable.</summary>
        public int? ApplicableDeviceCount {
            get { return BackingStore?.Get<int?>("applicableDeviceCount"); }
            set { BackingStore?.Set("applicableDeviceCount", value); }
        }
        /// <summary>An enum type to represent approval status of a driver.</summary>
        public DriverApprovalStatus? ApprovalStatus {
            get { return BackingStore?.Get<DriverApprovalStatus?>("approvalStatus"); }
            set { BackingStore?.Set("approvalStatus", value); }
        }
        /// <summary>An enum type to represent which category a driver belongs to.</summary>
        public DriverCategory? Category {
            get { return BackingStore?.Get<DriverCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The date time when a driver should be deployed if approvalStatus is approved.</summary>
        public DateTimeOffset? DeployDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("deployDateTime"); }
            set { BackingStore?.Set("deployDateTime", value); }
        }
        /// <summary>The class of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriverClass {
            get { return BackingStore?.Get<string?>("driverClass"); }
            set { BackingStore?.Set("driverClass", value); }
        }
#nullable restore
#else
        public string DriverClass {
            get { return BackingStore?.Get<string>("driverClass"); }
            set { BackingStore?.Set("driverClass", value); }
        }
#endif
        /// <summary>The manufacturer of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The name of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The release date time of the driver.</summary>
        public DateTimeOffset? ReleaseDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("releaseDateTime"); }
            set { BackingStore?.Set("releaseDateTime", value); }
        }
        /// <summary>The version of the driver.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsDriverUpdateInventory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsDriverUpdateInventory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableDeviceCount", n => { ApplicableDeviceCount = n.GetIntValue(); } },
                {"approvalStatus", n => { ApprovalStatus = n.GetEnumValue<DriverApprovalStatus>(); } },
                {"category", n => { Category = n.GetEnumValue<DriverCategory>(); } },
                {"deployDateTime", n => { DeployDateTime = n.GetDateTimeOffsetValue(); } },
                {"driverClass", n => { DriverClass = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("applicableDeviceCount", ApplicableDeviceCount);
            writer.WriteEnumValue<DriverApprovalStatus>("approvalStatus", ApprovalStatus);
            writer.WriteEnumValue<DriverCategory>("category", Category);
            writer.WriteDateTimeOffsetValue("deployDateTime", DeployDateTime);
            writer.WriteStringValue("driverClass", DriverClass);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
