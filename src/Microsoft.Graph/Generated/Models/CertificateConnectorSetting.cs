using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Certificate connector settings.
    /// </summary>
    public class CertificateConnectorSetting : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Certificate expire time</summary>
        public DateTimeOffset? CertExpiryTime {
            get { return BackingStore?.Get<DateTimeOffset?>("certExpiryTime"); }
            set { BackingStore?.Set("certExpiryTime", value); }
        }
        /// <summary>Version of certificate connector</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConnectorVersion {
            get { return BackingStore?.Get<string?>("connectorVersion"); }
            set { BackingStore?.Set("connectorVersion", value); }
        }
#nullable restore
#else
        public string ConnectorVersion {
            get { return BackingStore?.Get<string>("connectorVersion"); }
            set { BackingStore?.Set("connectorVersion", value); }
        }
#endif
        /// <summary>Certificate connector enrollment error</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EnrollmentError {
            get { return BackingStore?.Get<string?>("enrollmentError"); }
            set { BackingStore?.Set("enrollmentError", value); }
        }
#nullable restore
#else
        public string EnrollmentError {
            get { return BackingStore?.Get<string>("enrollmentError"); }
            set { BackingStore?.Set("enrollmentError", value); }
        }
#endif
        /// <summary>Last time certificate connector connected</summary>
        public DateTimeOffset? LastConnectorConnectionTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastConnectorConnectionTime"); }
            set { BackingStore?.Set("lastConnectorConnectionTime", value); }
        }
        /// <summary>Version of last uploaded certificate connector</summary>
        public long? LastUploadVersion {
            get { return BackingStore?.Get<long?>("lastUploadVersion"); }
            set { BackingStore?.Set("lastUploadVersion", value); }
        }
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
        /// <summary>Certificate connector status</summary>
        public int? Status {
            get { return BackingStore?.Get<int?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new certificateConnectorSetting and sets the default values.
        /// </summary>
        public CertificateConnectorSetting() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CertificateConnectorSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateConnectorSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certExpiryTime", n => { CertExpiryTime = n.GetDateTimeOffsetValue(); } },
                {"connectorVersion", n => { ConnectorVersion = n.GetStringValue(); } },
                {"enrollmentError", n => { EnrollmentError = n.GetStringValue(); } },
                {"lastConnectorConnectionTime", n => { LastConnectorConnectionTime = n.GetDateTimeOffsetValue(); } },
                {"lastUploadVersion", n => { LastUploadVersion = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"status", n => { Status = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("certExpiryTime", CertExpiryTime);
            writer.WriteStringValue("connectorVersion", ConnectorVersion);
            writer.WriteStringValue("enrollmentError", EnrollmentError);
            writer.WriteDateTimeOffsetValue("lastConnectorConnectionTime", LastConnectorConnectionTime);
            writer.WriteLongValue("lastUploadVersion", LastUploadVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
