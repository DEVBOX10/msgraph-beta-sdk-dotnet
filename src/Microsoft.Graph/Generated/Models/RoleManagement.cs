using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoleManagement : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The cloudPC property</summary>
        public RbacApplicationMultiple CloudPC {
            get { return BackingStore?.Get<RbacApplicationMultiple>("cloudPC"); }
            set { BackingStore?.Set("cloudPC", value); }
        }
        /// <summary>The RbacApplication for Device Management</summary>
        public RbacApplicationMultiple DeviceManagement {
            get { return BackingStore?.Get<RbacApplicationMultiple>("deviceManagement"); }
            set { BackingStore?.Set("deviceManagement", value); }
        }
        /// <summary>The directory property</summary>
        public RbacApplication DirectoryObject {
            get { return BackingStore?.Get<RbacApplication>("directory"); }
            set { BackingStore?.Set("directory", value); }
        }
        /// <summary>Container for roles and assignments for entitlement management resources.</summary>
        public RbacApplication EntitlementManagement {
            get { return BackingStore?.Get<RbacApplication>("entitlementManagement"); }
            set { BackingStore?.Set("entitlementManagement", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new RoleManagement and sets the default values.
        /// </summary>
        public RoleManagement() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.roleManagement";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RoleManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cloudPC", n => { CloudPC = n.GetObjectValue<RbacApplicationMultiple>(RbacApplicationMultiple.CreateFromDiscriminatorValue); } },
                {"deviceManagement", n => { DeviceManagement = n.GetObjectValue<RbacApplicationMultiple>(RbacApplicationMultiple.CreateFromDiscriminatorValue); } },
                {"directory", n => { DirectoryObject = n.GetObjectValue<RbacApplication>(RbacApplication.CreateFromDiscriminatorValue); } },
                {"entitlementManagement", n => { EntitlementManagement = n.GetObjectValue<RbacApplication>(RbacApplication.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<RbacApplicationMultiple>("cloudPC", CloudPC);
            writer.WriteObjectValue<RbacApplicationMultiple>("deviceManagement", DeviceManagement);
            writer.WriteObjectValue<RbacApplication>("directory", DirectoryObject);
            writer.WriteObjectValue<RbacApplication>("entitlementManagement", EntitlementManagement);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
