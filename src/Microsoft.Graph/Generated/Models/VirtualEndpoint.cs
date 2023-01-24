using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEndpoint : Entity, IParsable {
        /// <summary>Cloud PC audit event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcAuditEvent>? AuditEvents {
            get { return BackingStore?.Get<List<CloudPcAuditEvent>?>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#nullable restore
#else
        public List<CloudPcAuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<CloudPcAuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#endif
        /// <summary>Cloud managed virtual desktops.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPC>? CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>?>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
#nullable restore
#else
        public List<CloudPC> CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
#endif
        /// <summary>Cloud PC organization mapping between public and US Government Community Cloud (GCC) organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcCrossCloudGovernmentOrganizationMapping? CrossCloudGovernmentOrganizationMapping {
            get { return BackingStore?.Get<CloudPcCrossCloudGovernmentOrganizationMapping?>("crossCloudGovernmentOrganizationMapping"); }
            set { BackingStore?.Set("crossCloudGovernmentOrganizationMapping", value); }
        }
#nullable restore
#else
        public CloudPcCrossCloudGovernmentOrganizationMapping CrossCloudGovernmentOrganizationMapping {
            get { return BackingStore?.Get<CloudPcCrossCloudGovernmentOrganizationMapping>("crossCloudGovernmentOrganizationMapping"); }
            set { BackingStore?.Set("crossCloudGovernmentOrganizationMapping", value); }
        }
#endif
        /// <summary>The image resource on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcDeviceImage>? DeviceImages {
            get { return BackingStore?.Get<List<CloudPcDeviceImage>?>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
#nullable restore
#else
        public List<CloudPcDeviceImage> DeviceImages {
            get { return BackingStore?.Get<List<CloudPcDeviceImage>>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
#endif
        /// <summary>The external partner settings on a Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcExternalPartnerSetting>? ExternalPartnerSettings {
            get { return BackingStore?.Get<List<CloudPcExternalPartnerSetting>?>("externalPartnerSettings"); }
            set { BackingStore?.Set("externalPartnerSettings", value); }
        }
#nullable restore
#else
        public List<CloudPcExternalPartnerSetting> ExternalPartnerSettings {
            get { return BackingStore?.Get<List<CloudPcExternalPartnerSetting>>("externalPartnerSettings"); }
            set { BackingStore?.Set("externalPartnerSettings", value); }
        }
#endif
        /// <summary>The gallery image resource on Cloud PC.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcGalleryImage>? GalleryImages {
            get { return BackingStore?.Get<List<CloudPcGalleryImage>?>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
#nullable restore
#else
        public List<CloudPcGalleryImage> GalleryImages {
            get { return BackingStore?.Get<List<CloudPcGalleryImage>>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
#endif
        /// <summary>A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcOnPremisesConnection>? OnPremisesConnections {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnection>?>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
#nullable restore
#else
        public List<CloudPcOnPremisesConnection> OnPremisesConnections {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnection>>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
#endif
        /// <summary>The Cloud PC organization settings for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcOrganizationSettings? OrganizationSettings {
            get { return BackingStore?.Get<CloudPcOrganizationSettings?>("organizationSettings"); }
            set { BackingStore?.Set("organizationSettings", value); }
        }
#nullable restore
#else
        public CloudPcOrganizationSettings OrganizationSettings {
            get { return BackingStore?.Get<CloudPcOrganizationSettings>("organizationSettings"); }
            set { BackingStore?.Set("organizationSettings", value); }
        }
#endif
        /// <summary>Cloud PC provisioning policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcProvisioningPolicy>? ProvisioningPolicies {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicy>?>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
#nullable restore
#else
        public List<CloudPcProvisioningPolicy> ProvisioningPolicies {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicy>>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
#endif
        /// <summary>Cloud PC related reports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CloudPcReports? Reports {
            get { return BackingStore?.Get<CloudPcReports?>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#nullable restore
#else
        public CloudPcReports Reports {
            get { return BackingStore?.Get<CloudPcReports>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#endif
        /// <summary>Cloud PC service plans.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcServicePlan>? ServicePlans {
            get { return BackingStore?.Get<List<CloudPcServicePlan>?>("servicePlans"); }
            set { BackingStore?.Set("servicePlans", value); }
        }
#nullable restore
#else
        public List<CloudPcServicePlan> ServicePlans {
            get { return BackingStore?.Get<List<CloudPcServicePlan>>("servicePlans"); }
            set { BackingStore?.Set("servicePlans", value); }
        }
#endif
        /// <summary>The sharedUseServicePlans property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSharedUseServicePlan>? SharedUseServicePlans {
            get { return BackingStore?.Get<List<CloudPcSharedUseServicePlan>?>("sharedUseServicePlans"); }
            set { BackingStore?.Set("sharedUseServicePlans", value); }
        }
#nullable restore
#else
        public List<CloudPcSharedUseServicePlan> SharedUseServicePlans {
            get { return BackingStore?.Get<List<CloudPcSharedUseServicePlan>>("sharedUseServicePlans"); }
            set { BackingStore?.Set("sharedUseServicePlans", value); }
        }
#endif
        /// <summary>Cloud PC snapshots.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSnapshot>? Snapshots {
            get { return BackingStore?.Get<List<CloudPcSnapshot>?>("snapshots"); }
            set { BackingStore?.Set("snapshots", value); }
        }
#nullable restore
#else
        public List<CloudPcSnapshot> Snapshots {
            get { return BackingStore?.Get<List<CloudPcSnapshot>>("snapshots"); }
            set { BackingStore?.Set("snapshots", value); }
        }
#endif
        /// <summary>Cloud PC supported regions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcSupportedRegion>? SupportedRegions {
            get { return BackingStore?.Get<List<CloudPcSupportedRegion>?>("supportedRegions"); }
            set { BackingStore?.Set("supportedRegions", value); }
        }
#nullable restore
#else
        public List<CloudPcSupportedRegion> SupportedRegions {
            get { return BackingStore?.Get<List<CloudPcSupportedRegion>>("supportedRegions"); }
            set { BackingStore?.Set("supportedRegions", value); }
        }
#endif
        /// <summary>Cloud PC user settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcUserSetting>? UserSettings {
            get { return BackingStore?.Get<List<CloudPcUserSetting>?>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
#nullable restore
#else
        public List<CloudPcUserSetting> UserSettings {
            get { return BackingStore?.Get<List<CloudPcUserSetting>>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<CloudPcAuditEvent>(CloudPcAuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<CloudPC>(CloudPC.CreateFromDiscriminatorValue)?.ToList(); } },
                {"crossCloudGovernmentOrganizationMapping", n => { CrossCloudGovernmentOrganizationMapping = n.GetObjectValue<CloudPcCrossCloudGovernmentOrganizationMapping>(CloudPcCrossCloudGovernmentOrganizationMapping.CreateFromDiscriminatorValue); } },
                {"deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<CloudPcDeviceImage>(CloudPcDeviceImage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalPartnerSettings", n => { ExternalPartnerSettings = n.GetCollectionOfObjectValues<CloudPcExternalPartnerSetting>(CloudPcExternalPartnerSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<CloudPcGalleryImage>(CloudPcGalleryImage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnection>(CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"organizationSettings", n => { OrganizationSettings = n.GetObjectValue<CloudPcOrganizationSettings>(CloudPcOrganizationSettings.CreateFromDiscriminatorValue); } },
                {"provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicy>(CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<CloudPcReports>(CloudPcReports.CreateFromDiscriminatorValue); } },
                {"servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<CloudPcServicePlan>(CloudPcServicePlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sharedUseServicePlans", n => { SharedUseServicePlans = n.GetCollectionOfObjectValues<CloudPcSharedUseServicePlan>(CloudPcSharedUseServicePlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"snapshots", n => { Snapshots = n.GetCollectionOfObjectValues<CloudPcSnapshot>(CloudPcSnapshot.CreateFromDiscriminatorValue)?.ToList(); } },
                {"supportedRegions", n => { SupportedRegions = n.GetCollectionOfObjectValues<CloudPcSupportedRegion>(CloudPcSupportedRegion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<CloudPcUserSetting>(CloudPcUserSetting.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<CloudPC>("cloudPCs", CloudPCs);
            writer.WriteObjectValue<CloudPcCrossCloudGovernmentOrganizationMapping>("crossCloudGovernmentOrganizationMapping", CrossCloudGovernmentOrganizationMapping);
            writer.WriteCollectionOfObjectValues<CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<CloudPcExternalPartnerSetting>("externalPartnerSettings", ExternalPartnerSettings);
            writer.WriteCollectionOfObjectValues<CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteObjectValue<CloudPcOrganizationSettings>("organizationSettings", OrganizationSettings);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteObjectValue<CloudPcReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<CloudPcServicePlan>("servicePlans", ServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcSharedUseServicePlan>("sharedUseServicePlans", SharedUseServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcSnapshot>("snapshots", Snapshots);
            writer.WriteCollectionOfObjectValues<CloudPcSupportedRegion>("supportedRegions", SupportedRegions);
            writer.WriteCollectionOfObjectValues<CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
