using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationAppDeviceDetails : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The version of the client authentication app used during the authentication step.</summary>
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
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of the client authentication app used during the authentication step.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientApp {
            get { return BackingStore?.Get<string?>("clientApp"); }
            set { BackingStore?.Set("clientApp", value); }
        }
#nullable restore
#else
        public string ClientApp {
            get { return BackingStore?.Get<string>("clientApp"); }
            set { BackingStore?.Set("clientApp", value); }
        }
#endif
        /// <summary>ID of the device used during the authentication step.</summary>
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
        /// <summary>The operating system running on the device used for the authentication step.</summary>
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
        /// <summary>
        /// Instantiates a new authenticationAppDeviceDetails and sets the default values.
        /// </summary>
        public AuthenticationAppDeviceDetails() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationAppDeviceDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationAppDeviceDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"clientApp", n => { ClientApp = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteStringValue("clientApp", ClientApp);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
