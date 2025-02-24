// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class PrintConnector : Entity, IParsable {
        /// <summary>The connector&apos;s version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppVersion {
            get { return BackingStore?.Get<string?>("appVersion"); }
            set { BackingStore?.Set("appVersion", value); }
        }
#nullable restore
#else
        public string AppVersion {
            get { return BackingStore?.Get<string>("appVersion"); }
            set { BackingStore?.Set("appVersion", value); }
        }
#endif
        /// <summary>The connector&apos;s device health.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceHealth? DeviceHealth {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceHealth?>("deviceHealth"); }
            set { BackingStore?.Set("deviceHealth", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceHealth DeviceHealth {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceHealth>("deviceHealth"); }
            set { BackingStore?.Set("deviceHealth", value); }
        }
#endif
        /// <summary>The name of the connector.</summary>
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
        /// <summary>The connector machine&apos;s hostname.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullyQualifiedDomainName {
            get { return BackingStore?.Get<string?>("fullyQualifiedDomainName"); }
            set { BackingStore?.Set("fullyQualifiedDomainName", value); }
        }
#nullable restore
#else
        public string FullyQualifiedDomainName {
            get { return BackingStore?.Get<string>("fullyQualifiedDomainName"); }
            set { BackingStore?.Set("fullyQualifiedDomainName", value); }
        }
#endif
        /// <summary>The physical and/or organizational location of the connector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrinterLocation? Location {
            get { return BackingStore?.Get<PrinterLocation?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public PrinterLocation Location {
            get { return BackingStore?.Get<PrinterLocation>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>The name property</summary>
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
        /// <summary>The connector machine&apos;s operating system version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The DateTimeOffset when the connector was registered.</summary>
        public DateTimeOffset? RegisteredDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("registeredDateTime"); }
            set { BackingStore?.Set("registeredDateTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrintConnector CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintConnector();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"deviceHealth", n => { DeviceHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceHealth>(Microsoft.Graph.Beta.Models.DeviceHealth.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"fullyQualifiedDomainName", n => { FullyQualifiedDomainName = n.GetStringValue(); } },
                {"location", n => { Location = n.GetObjectValue<PrinterLocation>(PrinterLocation.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"registeredDateTime", n => { RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceHealth>("deviceHealth", DeviceHealth);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("fullyQualifiedDomainName", FullyQualifiedDomainName);
            writer.WriteObjectValue<PrinterLocation>("location", Location);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
        }
    }
}
