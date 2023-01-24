using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDateTimeConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date format for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateFormat {
            get { return BackingStore?.Get<string?>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
#nullable restore
#else
        public string DateFormat {
            get { return BackingStore?.Get<string>("dateFormat"); }
            set { BackingStore?.Set("dateFormat", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The time of the day when the device is turned off.</summary>
        public Time? OfficeHoursEndTime {
            get { return BackingStore?.Get<Time?>("officeHoursEndTime"); }
            set { BackingStore?.Set("officeHoursEndTime", value); }
        }
        /// <summary>The time of the day when the device is turned on.</summary>
        public Time? OfficeHoursStartTime {
            get { return BackingStore?.Get<Time?>("officeHoursStartTime"); }
            set { BackingStore?.Set("officeHoursStartTime", value); }
        }
        /// <summary>The time format for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeFormat {
            get { return BackingStore?.Get<string?>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
#nullable restore
#else
        public string TimeFormat {
            get { return BackingStore?.Get<string>("timeFormat"); }
            set { BackingStore?.Set("timeFormat", value); }
        }
#endif
        /// <summary>The time zone to which the office hours apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkDateTimeConfiguration and sets the default values.
        /// </summary>
        public TeamworkDateTimeConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkDateTimeConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDateTimeConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"officeHoursEndTime", n => { OfficeHoursEndTime = n.GetTimeValue(); } },
                {"officeHoursStartTime", n => { OfficeHoursStartTime = n.GetTimeValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeValue("officeHoursEndTime", OfficeHoursEndTime);
            writer.WriteTimeValue("officeHoursStartTime", OfficeHoursStartTime);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
