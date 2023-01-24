using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Collection of app diagnostics associated with a user.
    /// </summary>
    public class PowerliftIncidentMetadata : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The name of the application the diagnostic is from. Example: com.microsoft.CompanyPortal</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Application {
            get { return BackingStore?.Get<string?>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#nullable restore
#else
        public string Application {
            get { return BackingStore?.Get<string>("application"); }
            set { BackingStore?.Set("application", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The version of the application. Example: 5.2203.1</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientVersion {
            get { return BackingStore?.Get<string?>("clientVersion"); }
            set { BackingStore?.Set("clientVersion", value); }
        }
#nullable restore
#else
        public string ClientVersion {
            get { return BackingStore?.Get<string>("clientVersion"); }
            set { BackingStore?.Set("clientVersion", value); }
        }
#endif
        /// <summary>The time the app diagnostic was created. Example: 2022-04-19T17:24:45.313Z</summary>
        public DateTimeOffset? CreatedAtDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdAtDateTime"); }
            set { BackingStore?.Set("createdAtDateTime", value); }
        }
        /// <summary>The unique app diagnostic identifier as a user friendly 8 character hexadecimal string. Example: 8520467A</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EasyId {
            get { return BackingStore?.Get<string?>("easyId"); }
            set { BackingStore?.Set("easyId", value); }
        }
#nullable restore
#else
        public string EasyId {
            get { return BackingStore?.Get<string>("easyId"); }
            set { BackingStore?.Set("easyId", value); }
        }
#endif
        /// <summary>A list of files that are associated with the diagnostic.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FileNames {
            get { return BackingStore?.Get<List<string>?>("fileNames"); }
            set { BackingStore?.Set("fileNames", value); }
        }
#nullable restore
#else
        public List<string> FileNames {
            get { return BackingStore?.Get<List<string>>("fileNames"); }
            set { BackingStore?.Set("fileNames", value); }
        }
#endif
        /// <summary>The locale information of the application. Example: en-US</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale {
            get { return BackingStore?.Get<string?>("locale"); }
            set { BackingStore?.Set("locale", value); }
        }
#nullable restore
#else
        public string Locale {
            get { return BackingStore?.Get<string>("locale"); }
            set { BackingStore?.Set("locale", value); }
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
        /// <summary>The device&apos;s OS the diagnostic is from. Example: iOS</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Platform {
            get { return BackingStore?.Get<string?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
#nullable restore
#else
        public string Platform {
            get { return BackingStore?.Get<string>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
#endif
        /// <summary>The unique identifier of the app diagnostic. Example: 8520467a-49a9-44a4-8447-8dfb8bec6726</summary>
        public Guid? PowerliftId {
            get { return BackingStore?.Get<Guid?>("powerliftId"); }
            set { BackingStore?.Set("powerliftId", value); }
        }
        /// <summary>
        /// Instantiates a new powerliftIncidentMetadata and sets the default values.
        /// </summary>
        public PowerliftIncidentMetadata() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PowerliftIncidentMetadata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PowerliftIncidentMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application", n => { Application = n.GetStringValue(); } },
                {"clientVersion", n => { ClientVersion = n.GetStringValue(); } },
                {"createdAtDateTime", n => { CreatedAtDateTime = n.GetDateTimeOffsetValue(); } },
                {"easyId", n => { EasyId = n.GetStringValue(); } },
                {"fileNames", n => { FileNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"platform", n => { Platform = n.GetStringValue(); } },
                {"powerliftId", n => { PowerliftId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("application", Application);
            writer.WriteStringValue("clientVersion", ClientVersion);
            writer.WriteDateTimeOffsetValue("createdAtDateTime", CreatedAtDateTime);
            writer.WriteStringValue("easyId", EasyId);
            writer.WriteCollectionOfPrimitiveValues<string>("fileNames", FileNames);
            writer.WriteStringValue("locale", Locale);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("platform", Platform);
            writer.WriteGuidValue("powerliftId", PowerliftId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
