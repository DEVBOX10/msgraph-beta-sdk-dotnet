// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcDomainJoinConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
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
        /// <summary>The Azure network connection ID that matches the virtual network IT admins want the provisioning policy to use when they create Cloud PCs. You can use this property in both domain join types: Azure AD joined or Hybrid Microsoft Entra joined. If you enter an onPremisesConnectionId, leave regionName as empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesConnectionId {
            get { return BackingStore?.Get<string?>("onPremisesConnectionId"); }
            set { BackingStore?.Set("onPremisesConnectionId", value); }
        }
#nullable restore
#else
        public string OnPremisesConnectionId {
            get { return BackingStore?.Get<string>("onPremisesConnectionId"); }
            set { BackingStore?.Set("onPremisesConnectionId", value); }
        }
#endif
        /// <summary>The logical geographic group this region belongs to. Multiple regions can belong to one region group. A customer can select a regionGroup when provisioning a Cloud PC, and the Cloud PC will be put in one of the regions in the group based on resource status. For example, the Europe region group contains the Northern Europe and Western Europe regions. Possible values are: default, australia, canada, usCentral, usEast, usWest, france, germany, europeUnion, unitedKingdom, japan, asia, india, southAmerica, euap, usGovernment, usGovernmentDOD, unknownFutureValue, norway, switzerland, and southKorea. Read-only.</summary>
        public CloudPcRegionGroup? RegionGroup {
            get { return BackingStore?.Get<CloudPcRegionGroup?>("regionGroup"); }
            set { BackingStore?.Set("regionGroup", value); }
        }
        /// <summary>The supported Azure region where the IT admin wants the provisioning policy to create Cloud PCs. The underlying virtual network will be created and managed by the Windows 365 service. This can only be entered if the IT admin chooses Microsoft Entra joined as the domain join type. If you enter a regionName, leave onPremisesConnectionId as empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionName {
            get { return BackingStore?.Get<string?>("regionName"); }
            set { BackingStore?.Set("regionName", value); }
        }
#nullable restore
#else
        public string RegionName {
            get { return BackingStore?.Get<string>("regionName"); }
            set { BackingStore?.Set("regionName", value); }
        }
#endif
        /// <summary>Specifies how the provisioned Cloud PC will be joined to Microsoft Entra ID. If you choose the hybridAzureADJoin type, only provide a value for the onPremisesConnectionId property and leave regionName as empty. If you choose the azureADJoin type, provide a value for either onPremisesConnectionId or regionName. The possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public CloudPcDomainJoinType? Type {
            get { return BackingStore?.Get<CloudPcDomainJoinType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcDomainJoinConfiguration and sets the default values.
        /// </summary>
        public CloudPcDomainJoinConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CloudPcDomainJoinConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcDomainJoinConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onPremisesConnectionId", n => { OnPremisesConnectionId = n.GetStringValue(); } },
                {"regionGroup", n => { RegionGroup = n.GetEnumValue<CloudPcRegionGroup>(); } },
                {"regionName", n => { RegionName = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<CloudPcDomainJoinType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onPremisesConnectionId", OnPremisesConnectionId);
            writer.WriteEnumValue<CloudPcRegionGroup>("regionGroup", RegionGroup);
            writer.WriteStringValue("regionName", RegionName);
            writer.WriteEnumValue<CloudPcDomainJoinType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
