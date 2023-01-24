using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.ApproveApps {
    public class ApproveAppsPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The approveAllPermissions property</summary>
        public bool? ApproveAllPermissions {
            get { return BackingStore?.Get<bool?>("approveAllPermissions"); }
            set { BackingStore?.Set("approveAllPermissions", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The packageIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PackageIds {
            get { return BackingStore?.Get<List<string>?>("packageIds"); }
            set { BackingStore?.Set("packageIds", value); }
        }
#nullable restore
#else
        public List<string> PackageIds {
            get { return BackingStore?.Get<List<string>>("packageIds"); }
            set { BackingStore?.Set("packageIds", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new approveAppsPostRequestBody and sets the default values.
        /// </summary>
        public ApproveAppsPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApproveAppsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApproveAppsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"approveAllPermissions", n => { ApproveAllPermissions = n.GetBoolValue(); } },
                {"packageIds", n => { PackageIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("approveAllPermissions", ApproveAllPermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("packageIds", PackageIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
