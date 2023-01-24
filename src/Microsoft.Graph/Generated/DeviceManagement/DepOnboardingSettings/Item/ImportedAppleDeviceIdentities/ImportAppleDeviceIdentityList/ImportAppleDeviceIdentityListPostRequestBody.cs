using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.DepOnboardingSettings.Item.ImportedAppleDeviceIdentities.ImportAppleDeviceIdentityList {
    public class ImportAppleDeviceIdentityListPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The importedAppleDeviceIdentities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImportedAppleDeviceIdentity>? ImportedAppleDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedAppleDeviceIdentity>?>("importedAppleDeviceIdentities"); }
            set { BackingStore?.Set("importedAppleDeviceIdentities", value); }
        }
#nullable restore
#else
        public List<ImportedAppleDeviceIdentity> ImportedAppleDeviceIdentities {
            get { return BackingStore?.Get<List<ImportedAppleDeviceIdentity>>("importedAppleDeviceIdentities"); }
            set { BackingStore?.Set("importedAppleDeviceIdentities", value); }
        }
#endif
        /// <summary>The overwriteImportedDeviceIdentities property</summary>
        public bool? OverwriteImportedDeviceIdentities {
            get { return BackingStore?.Get<bool?>("overwriteImportedDeviceIdentities"); }
            set { BackingStore?.Set("overwriteImportedDeviceIdentities", value); }
        }
        /// <summary>
        /// Instantiates a new importAppleDeviceIdentityListPostRequestBody and sets the default values.
        /// </summary>
        public ImportAppleDeviceIdentityListPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ImportAppleDeviceIdentityListPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportAppleDeviceIdentityListPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"importedAppleDeviceIdentities", n => { ImportedAppleDeviceIdentities = n.GetCollectionOfObjectValues<ImportedAppleDeviceIdentity>(ImportedAppleDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"overwriteImportedDeviceIdentities", n => { OverwriteImportedDeviceIdentities = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ImportedAppleDeviceIdentity>("importedAppleDeviceIdentities", ImportedAppleDeviceIdentities);
            writer.WriteBoolValue("overwriteImportedDeviceIdentities", OverwriteImportedDeviceIdentities);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
