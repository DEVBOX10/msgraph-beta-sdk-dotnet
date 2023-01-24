using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDeviceSoftwareVersions : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The software version for the admin agent running on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdminAgentSoftwareVersion {
            get { return BackingStore?.Get<string?>("adminAgentSoftwareVersion"); }
            set { BackingStore?.Set("adminAgentSoftwareVersion", value); }
        }
#nullable restore
#else
        public string AdminAgentSoftwareVersion {
            get { return BackingStore?.Get<string>("adminAgentSoftwareVersion"); }
            set { BackingStore?.Set("adminAgentSoftwareVersion", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The software version for the firmware running on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirmwareSoftwareVersion {
            get { return BackingStore?.Get<string?>("firmwareSoftwareVersion"); }
            set { BackingStore?.Set("firmwareSoftwareVersion", value); }
        }
#nullable restore
#else
        public string FirmwareSoftwareVersion {
            get { return BackingStore?.Get<string>("firmwareSoftwareVersion"); }
            set { BackingStore?.Set("firmwareSoftwareVersion", value); }
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
        /// <summary>The software version for the operating system on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemSoftwareVersion {
            get { return BackingStore?.Get<string?>("operatingSystemSoftwareVersion"); }
            set { BackingStore?.Set("operatingSystemSoftwareVersion", value); }
        }
#nullable restore
#else
        public string OperatingSystemSoftwareVersion {
            get { return BackingStore?.Get<string>("operatingSystemSoftwareVersion"); }
            set { BackingStore?.Set("operatingSystemSoftwareVersion", value); }
        }
#endif
        /// <summary>The software version for the partner agent running on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PartnerAgentSoftwareVersion {
            get { return BackingStore?.Get<string?>("partnerAgentSoftwareVersion"); }
            set { BackingStore?.Set("partnerAgentSoftwareVersion", value); }
        }
#nullable restore
#else
        public string PartnerAgentSoftwareVersion {
            get { return BackingStore?.Get<string>("partnerAgentSoftwareVersion"); }
            set { BackingStore?.Set("partnerAgentSoftwareVersion", value); }
        }
#endif
        /// <summary>The software version for the Teams client running on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsClientSoftwareVersion {
            get { return BackingStore?.Get<string?>("teamsClientSoftwareVersion"); }
            set { BackingStore?.Set("teamsClientSoftwareVersion", value); }
        }
#nullable restore
#else
        public string TeamsClientSoftwareVersion {
            get { return BackingStore?.Get<string>("teamsClientSoftwareVersion"); }
            set { BackingStore?.Set("teamsClientSoftwareVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkDeviceSoftwareVersions and sets the default values.
        /// </summary>
        public TeamworkDeviceSoftwareVersions() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkDeviceSoftwareVersions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDeviceSoftwareVersions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"adminAgentSoftwareVersion", n => { AdminAgentSoftwareVersion = n.GetStringValue(); } },
                {"firmwareSoftwareVersion", n => { FirmwareSoftwareVersion = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operatingSystemSoftwareVersion", n => { OperatingSystemSoftwareVersion = n.GetStringValue(); } },
                {"partnerAgentSoftwareVersion", n => { PartnerAgentSoftwareVersion = n.GetStringValue(); } },
                {"teamsClientSoftwareVersion", n => { TeamsClientSoftwareVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("adminAgentSoftwareVersion", AdminAgentSoftwareVersion);
            writer.WriteStringValue("firmwareSoftwareVersion", FirmwareSoftwareVersion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operatingSystemSoftwareVersion", OperatingSystemSoftwareVersion);
            writer.WriteStringValue("partnerAgentSoftwareVersion", PartnerAgentSoftwareVersion);
            writer.WriteStringValue("teamsClientSoftwareVersion", TeamsClientSoftwareVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
