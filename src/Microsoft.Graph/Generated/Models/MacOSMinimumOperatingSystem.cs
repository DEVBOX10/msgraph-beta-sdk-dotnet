using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The minimum operating system required for a macOS app.
    /// </summary>
    public class MacOSMinimumOperatingSystem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>When TRUE, indicates OS X 10.10 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V1010 {
            get { return BackingStore?.Get<bool?>("v10_10"); }
            set { BackingStore?.Set("v10_10", value); }
        }
        /// <summary>When TRUE, indicates OS X 10.11 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V1011 {
            get { return BackingStore?.Get<bool?>("v10_11"); }
            set { BackingStore?.Set("v10_11", value); }
        }
        /// <summary>When TRUE, indicates macOS 10.12 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V1012 {
            get { return BackingStore?.Get<bool?>("v10_12"); }
            set { BackingStore?.Set("v10_12", value); }
        }
        /// <summary>When TRUE, indicates macOS 10.13 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V1013 {
            get { return BackingStore?.Get<bool?>("v10_13"); }
            set { BackingStore?.Set("v10_13", value); }
        }
        /// <summary>When TRUE, indicates macOS 10.14 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V1014 {
            get { return BackingStore?.Get<bool?>("v10_14"); }
            set { BackingStore?.Set("v10_14", value); }
        }
        /// <summary>When TRUE, indicates macOS 10.15 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V1015 {
            get { return BackingStore?.Get<bool?>("v10_15"); }
            set { BackingStore?.Set("v10_15", value); }
        }
        /// <summary>When TRUE, indicates Mac OS X 10.7 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V107 {
            get { return BackingStore?.Get<bool?>("v10_7"); }
            set { BackingStore?.Set("v10_7", value); }
        }
        /// <summary>When TRUE, indicates OS X 10.8 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V108 {
            get { return BackingStore?.Get<bool?>("v10_8"); }
            set { BackingStore?.Set("v10_8", value); }
        }
        /// <summary>When TRUE, indicates OS X 10.9 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V109 {
            get { return BackingStore?.Get<bool?>("v10_9"); }
            set { BackingStore?.Set("v10_9", value); }
        }
        /// <summary>When TRUE, indicates macOS 11.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V110 {
            get { return BackingStore?.Get<bool?>("v11_0"); }
            set { BackingStore?.Set("v11_0", value); }
        }
        /// <summary>When TRUE, indicates macOS 12.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V120 {
            get { return BackingStore?.Get<bool?>("v12_0"); }
            set { BackingStore?.Set("v12_0", value); }
        }
        /// <summary>When TRUE, indicates macOS 13.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.</summary>
        public bool? V130 {
            get { return BackingStore?.Get<bool?>("v13_0"); }
            set { BackingStore?.Set("v13_0", value); }
        }
        /// <summary>
        /// Instantiates a new macOSMinimumOperatingSystem and sets the default values.
        /// </summary>
        public MacOSMinimumOperatingSystem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MacOSMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"v10_10", n => { V1010 = n.GetBoolValue(); } },
                {"v10_11", n => { V1011 = n.GetBoolValue(); } },
                {"v10_12", n => { V1012 = n.GetBoolValue(); } },
                {"v10_13", n => { V1013 = n.GetBoolValue(); } },
                {"v10_14", n => { V1014 = n.GetBoolValue(); } },
                {"v10_15", n => { V1015 = n.GetBoolValue(); } },
                {"v10_7", n => { V107 = n.GetBoolValue(); } },
                {"v10_8", n => { V108 = n.GetBoolValue(); } },
                {"v10_9", n => { V109 = n.GetBoolValue(); } },
                {"v11_0", n => { V110 = n.GetBoolValue(); } },
                {"v12_0", n => { V120 = n.GetBoolValue(); } },
                {"v13_0", n => { V130 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_10", V1010);
            writer.WriteBoolValue("v10_11", V1011);
            writer.WriteBoolValue("v10_12", V1012);
            writer.WriteBoolValue("v10_13", V1013);
            writer.WriteBoolValue("v10_14", V1014);
            writer.WriteBoolValue("v10_15", V1015);
            writer.WriteBoolValue("v10_7", V107);
            writer.WriteBoolValue("v10_8", V108);
            writer.WriteBoolValue("v10_9", V109);
            writer.WriteBoolValue("v11_0", V110);
            writer.WriteBoolValue("v12_0", V120);
            writer.WriteBoolValue("v13_0", V130);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
