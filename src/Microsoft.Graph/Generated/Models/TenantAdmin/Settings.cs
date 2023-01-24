using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    public class Settings : Entity, IParsable {
        /// <summary>Collection of trusted domain GUIDs for the OneDrive sync app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? AllowedDomainGuidsForSyncApp {
            get { return BackingStore?.Get<List<Guid?>?>("allowedDomainGuidsForSyncApp"); }
            set { BackingStore?.Set("allowedDomainGuidsForSyncApp", value); }
        }
#nullable restore
#else
        public List<Guid?> AllowedDomainGuidsForSyncApp {
            get { return BackingStore?.Get<List<Guid?>>("allowedDomainGuidsForSyncApp"); }
            set { BackingStore?.Set("allowedDomainGuidsForSyncApp", value); }
        }
#endif
        /// <summary>Collection of managed paths available for site creation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AvailableManagedPathsForSiteCreation {
            get { return BackingStore?.Get<List<string>?>("availableManagedPathsForSiteCreation"); }
            set { BackingStore?.Set("availableManagedPathsForSiteCreation", value); }
        }
#nullable restore
#else
        public List<string> AvailableManagedPathsForSiteCreation {
            get { return BackingStore?.Get<List<string>>("availableManagedPathsForSiteCreation"); }
            set { BackingStore?.Set("availableManagedPathsForSiteCreation", value); }
        }
#endif
        /// <summary>The number of days for preserving a deleted user&apos;s OneDrive.</summary>
        public int? DeletedUserPersonalSiteRetentionPeriodInDays {
            get { return BackingStore?.Get<int?>("deletedUserPersonalSiteRetentionPeriodInDays"); }
            set { BackingStore?.Set("deletedUserPersonalSiteRetentionPeriodInDays", value); }
        }
        /// <summary>Collection of file extensions not uploaded by the OneDrive sync app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludedFileExtensionsForSyncApp {
            get { return BackingStore?.Get<List<string>?>("excludedFileExtensionsForSyncApp"); }
            set { BackingStore?.Set("excludedFileExtensionsForSyncApp", value); }
        }
#nullable restore
#else
        public List<string> ExcludedFileExtensionsForSyncApp {
            get { return BackingStore?.Get<List<string>>("excludedFileExtensionsForSyncApp"); }
            set { BackingStore?.Set("excludedFileExtensionsForSyncApp", value); }
        }
#endif
        /// <summary>Specifies the idle session sign-out policies for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut? IdleSessionSignOut {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut?>("idleSessionSignOut"); }
            set { BackingStore?.Set("idleSessionSignOut", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut IdleSessionSignOut {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut>("idleSessionSignOut"); }
            set { BackingStore?.Set("idleSessionSignOut", value); }
        }
#endif
        /// <summary>Specifies the image tagging option for the tenant. Possible values are: disabled, basic, enhanced.</summary>
        public ImageTaggingChoice? ImageTaggingOption {
            get { return BackingStore?.Get<ImageTaggingChoice?>("imageTaggingOption"); }
            set { BackingStore?.Set("imageTaggingOption", value); }
        }
        /// <summary>Indicates whether comments are allowed on modern site pages in SharePoint.</summary>
        public bool? IsCommentingOnSitePagesEnabled {
            get { return BackingStore?.Get<bool?>("isCommentingOnSitePagesEnabled"); }
            set { BackingStore?.Set("isCommentingOnSitePagesEnabled", value); }
        }
        /// <summary>Indicates whether push notifications are enabled for OneDrive events.</summary>
        public bool? IsFileActivityNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isFileActivityNotificationEnabled"); }
            set { BackingStore?.Set("isFileActivityNotificationEnabled", value); }
        }
        /// <summary>Indicates whether legacy authentication protocols are enabled for the tenant.</summary>
        public bool? IsLegacyAuthProtocolsEnabled {
            get { return BackingStore?.Get<bool?>("isLegacyAuthProtocolsEnabled"); }
            set { BackingStore?.Set("isLegacyAuthProtocolsEnabled", value); }
        }
        /// <summary>Indicates whetherif Fluid Framework is allowed on SharePoint sites.</summary>
        public bool? IsLoopEnabled {
            get { return BackingStore?.Get<bool?>("isLoopEnabled"); }
            set { BackingStore?.Set("isLoopEnabled", value); }
        }
        /// <summary>Indicates whether files can be synced using the OneDrive sync app for Mac.</summary>
        public bool? IsMacSyncAppEnabled {
            get { return BackingStore?.Get<bool?>("isMacSyncAppEnabled"); }
            set { BackingStore?.Set("isMacSyncAppEnabled", value); }
        }
        /// <summary>Indicates whether guests must sign in using the same account to which sharing invitations are sent.</summary>
        public bool? IsRequireAcceptingUserToMatchInvitedUserEnabled {
            get { return BackingStore?.Get<bool?>("isRequireAcceptingUserToMatchInvitedUserEnabled"); }
            set { BackingStore?.Set("isRequireAcceptingUserToMatchInvitedUserEnabled", value); }
        }
        /// <summary>Indicates whether guests are allowed to reshare files, folders, and sites they don&apos;t own.</summary>
        public bool? IsResharingByExternalUsersEnabled {
            get { return BackingStore?.Get<bool?>("isResharingByExternalUsersEnabled"); }
            set { BackingStore?.Set("isResharingByExternalUsersEnabled", value); }
        }
        /// <summary>Indicates whether mobile push notifications are enabled for SharePoint.</summary>
        public bool? IsSharePointMobileNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isSharePointMobileNotificationEnabled"); }
            set { BackingStore?.Set("isSharePointMobileNotificationEnabled", value); }
        }
        /// <summary>Indicates whether the newsfeed is allowed on the modern site pages in SharePoint.</summary>
        public bool? IsSharePointNewsfeedEnabled {
            get { return BackingStore?.Get<bool?>("isSharePointNewsfeedEnabled"); }
            set { BackingStore?.Set("isSharePointNewsfeedEnabled", value); }
        }
        /// <summary>Indicates whether users are allowed to create sites.</summary>
        public bool? IsSiteCreationEnabled {
            get { return BackingStore?.Get<bool?>("isSiteCreationEnabled"); }
            set { BackingStore?.Set("isSiteCreationEnabled", value); }
        }
        /// <summary>Indicates whether the UI commands for creating sites are shown.</summary>
        public bool? IsSiteCreationUIEnabled {
            get { return BackingStore?.Get<bool?>("isSiteCreationUIEnabled"); }
            set { BackingStore?.Set("isSiteCreationUIEnabled", value); }
        }
        /// <summary>Indicates whether creating new modern pages is allowed on SharePoint sites.</summary>
        public bool? IsSitePagesCreationEnabled {
            get { return BackingStore?.Get<bool?>("isSitePagesCreationEnabled"); }
            set { BackingStore?.Set("isSitePagesCreationEnabled", value); }
        }
        /// <summary>Indicates whether site storage space is automatically managed or if specific storage limits are set per site.</summary>
        public bool? IsSitesStorageLimitAutomatic {
            get { return BackingStore?.Get<bool?>("isSitesStorageLimitAutomatic"); }
            set { BackingStore?.Set("isSitesStorageLimitAutomatic", value); }
        }
        /// <summary>Indicates whether the sync button in OneDrive is hidden.</summary>
        public bool? IsSyncButtonHiddenOnPersonalSite {
            get { return BackingStore?.Get<bool?>("isSyncButtonHiddenOnPersonalSite"); }
            set { BackingStore?.Set("isSyncButtonHiddenOnPersonalSite", value); }
        }
        /// <summary>Indicates whether users are allowed to sync files only on PCs joined to specific domains.</summary>
        public bool? IsUnmanagedSyncAppForTenantRestricted {
            get { return BackingStore?.Get<bool?>("isUnmanagedSyncAppForTenantRestricted"); }
            set { BackingStore?.Set("isUnmanagedSyncAppForTenantRestricted", value); }
        }
        /// <summary>The default OneDrive storage limit for all new and existing users who are assigned a qualifying license. Measured in megabytes (MB).</summary>
        public long? PersonalSiteDefaultStorageLimitInMB {
            get { return BackingStore?.Get<long?>("personalSiteDefaultStorageLimitInMB"); }
            set { BackingStore?.Set("personalSiteDefaultStorageLimitInMB", value); }
        }
        /// <summary>Collection of email domains that are allowed for sharing outside the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SharingAllowedDomainList {
            get { return BackingStore?.Get<List<string>?>("sharingAllowedDomainList"); }
            set { BackingStore?.Set("sharingAllowedDomainList", value); }
        }
#nullable restore
#else
        public List<string> SharingAllowedDomainList {
            get { return BackingStore?.Get<List<string>>("sharingAllowedDomainList"); }
            set { BackingStore?.Set("sharingAllowedDomainList", value); }
        }
#endif
        /// <summary>Collection of email domains that are blocked for sharing outside the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SharingBlockedDomainList {
            get { return BackingStore?.Get<List<string>?>("sharingBlockedDomainList"); }
            set { BackingStore?.Set("sharingBlockedDomainList", value); }
        }
#nullable restore
#else
        public List<string> SharingBlockedDomainList {
            get { return BackingStore?.Get<List<string>>("sharingBlockedDomainList"); }
            set { BackingStore?.Set("sharingBlockedDomainList", value); }
        }
#endif
        /// <summary>Sharing capability for the tenant. Possible values are: disabled, externalUserSharingOnly, externalUserAndGuestSharing, existingExternalUserSharingOnly.</summary>
        public SharingCapabilities? SharingCapability {
            get { return BackingStore?.Get<SharingCapabilities?>("sharingCapability"); }
            set { BackingStore?.Set("sharingCapability", value); }
        }
        /// <summary>Specifies the external sharing mode for domains. Possible values are: none, allowList, blockList.</summary>
        public Microsoft.Graph.Beta.Models.TenantAdmin.SharingDomainRestrictionMode? SharingDomainRestrictionMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.SharingDomainRestrictionMode?>("sharingDomainRestrictionMode"); }
            set { BackingStore?.Set("sharingDomainRestrictionMode", value); }
        }
        /// <summary>The value of the team site managed path. This is the path under which new team sites will be created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteCreationDefaultManagedPath {
            get { return BackingStore?.Get<string?>("siteCreationDefaultManagedPath"); }
            set { BackingStore?.Set("siteCreationDefaultManagedPath", value); }
        }
#nullable restore
#else
        public string SiteCreationDefaultManagedPath {
            get { return BackingStore?.Get<string>("siteCreationDefaultManagedPath"); }
            set { BackingStore?.Set("siteCreationDefaultManagedPath", value); }
        }
#endif
        /// <summary>The default storage quota for a new site upon creation. Measured in megabytes (MB).</summary>
        public int? SiteCreationDefaultStorageLimitInMB {
            get { return BackingStore?.Get<int?>("siteCreationDefaultStorageLimitInMB"); }
            set { BackingStore?.Set("siteCreationDefaultStorageLimitInMB", value); }
        }
        /// <summary>The default timezone of a tenant for newly created sites. For a list of possible values, see SPRegionalSettings.TimeZones property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDefaultTimezone {
            get { return BackingStore?.Get<string?>("tenantDefaultTimezone"); }
            set { BackingStore?.Set("tenantDefaultTimezone", value); }
        }
#nullable restore
#else
        public string TenantDefaultTimezone {
            get { return BackingStore?.Get<string>("tenantDefaultTimezone"); }
            set { BackingStore?.Set("tenantDefaultTimezone", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Settings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Settings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDomainGuidsForSyncApp", n => { AllowedDomainGuidsForSyncApp = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"availableManagedPathsForSiteCreation", n => { AvailableManagedPathsForSiteCreation = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deletedUserPersonalSiteRetentionPeriodInDays", n => { DeletedUserPersonalSiteRetentionPeriodInDays = n.GetIntValue(); } },
                {"excludedFileExtensionsForSyncApp", n => { ExcludedFileExtensionsForSyncApp = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"idleSessionSignOut", n => { IdleSessionSignOut = n.GetObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut>(Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut.CreateFromDiscriminatorValue); } },
                {"imageTaggingOption", n => { ImageTaggingOption = n.GetEnumValue<ImageTaggingChoice>(); } },
                {"isCommentingOnSitePagesEnabled", n => { IsCommentingOnSitePagesEnabled = n.GetBoolValue(); } },
                {"isFileActivityNotificationEnabled", n => { IsFileActivityNotificationEnabled = n.GetBoolValue(); } },
                {"isLegacyAuthProtocolsEnabled", n => { IsLegacyAuthProtocolsEnabled = n.GetBoolValue(); } },
                {"isLoopEnabled", n => { IsLoopEnabled = n.GetBoolValue(); } },
                {"isMacSyncAppEnabled", n => { IsMacSyncAppEnabled = n.GetBoolValue(); } },
                {"isRequireAcceptingUserToMatchInvitedUserEnabled", n => { IsRequireAcceptingUserToMatchInvitedUserEnabled = n.GetBoolValue(); } },
                {"isResharingByExternalUsersEnabled", n => { IsResharingByExternalUsersEnabled = n.GetBoolValue(); } },
                {"isSharePointMobileNotificationEnabled", n => { IsSharePointMobileNotificationEnabled = n.GetBoolValue(); } },
                {"isSharePointNewsfeedEnabled", n => { IsSharePointNewsfeedEnabled = n.GetBoolValue(); } },
                {"isSiteCreationEnabled", n => { IsSiteCreationEnabled = n.GetBoolValue(); } },
                {"isSiteCreationUIEnabled", n => { IsSiteCreationUIEnabled = n.GetBoolValue(); } },
                {"isSitePagesCreationEnabled", n => { IsSitePagesCreationEnabled = n.GetBoolValue(); } },
                {"isSitesStorageLimitAutomatic", n => { IsSitesStorageLimitAutomatic = n.GetBoolValue(); } },
                {"isSyncButtonHiddenOnPersonalSite", n => { IsSyncButtonHiddenOnPersonalSite = n.GetBoolValue(); } },
                {"isUnmanagedSyncAppForTenantRestricted", n => { IsUnmanagedSyncAppForTenantRestricted = n.GetBoolValue(); } },
                {"personalSiteDefaultStorageLimitInMB", n => { PersonalSiteDefaultStorageLimitInMB = n.GetLongValue(); } },
                {"sharingAllowedDomainList", n => { SharingAllowedDomainList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sharingBlockedDomainList", n => { SharingBlockedDomainList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sharingCapability", n => { SharingCapability = n.GetEnumValue<SharingCapabilities>(); } },
                {"sharingDomainRestrictionMode", n => { SharingDomainRestrictionMode = n.GetEnumValue<SharingDomainRestrictionMode>(); } },
                {"siteCreationDefaultManagedPath", n => { SiteCreationDefaultManagedPath = n.GetStringValue(); } },
                {"siteCreationDefaultStorageLimitInMB", n => { SiteCreationDefaultStorageLimitInMB = n.GetIntValue(); } },
                {"tenantDefaultTimezone", n => { TenantDefaultTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("allowedDomainGuidsForSyncApp", AllowedDomainGuidsForSyncApp);
            writer.WriteCollectionOfPrimitiveValues<string>("availableManagedPathsForSiteCreation", AvailableManagedPathsForSiteCreation);
            writer.WriteIntValue("deletedUserPersonalSiteRetentionPeriodInDays", DeletedUserPersonalSiteRetentionPeriodInDays);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedFileExtensionsForSyncApp", ExcludedFileExtensionsForSyncApp);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TenantAdmin.IdleSessionSignOut>("idleSessionSignOut", IdleSessionSignOut);
            writer.WriteEnumValue<ImageTaggingChoice>("imageTaggingOption", ImageTaggingOption);
            writer.WriteBoolValue("isCommentingOnSitePagesEnabled", IsCommentingOnSitePagesEnabled);
            writer.WriteBoolValue("isFileActivityNotificationEnabled", IsFileActivityNotificationEnabled);
            writer.WriteBoolValue("isLegacyAuthProtocolsEnabled", IsLegacyAuthProtocolsEnabled);
            writer.WriteBoolValue("isLoopEnabled", IsLoopEnabled);
            writer.WriteBoolValue("isMacSyncAppEnabled", IsMacSyncAppEnabled);
            writer.WriteBoolValue("isRequireAcceptingUserToMatchInvitedUserEnabled", IsRequireAcceptingUserToMatchInvitedUserEnabled);
            writer.WriteBoolValue("isResharingByExternalUsersEnabled", IsResharingByExternalUsersEnabled);
            writer.WriteBoolValue("isSharePointMobileNotificationEnabled", IsSharePointMobileNotificationEnabled);
            writer.WriteBoolValue("isSharePointNewsfeedEnabled", IsSharePointNewsfeedEnabled);
            writer.WriteBoolValue("isSiteCreationEnabled", IsSiteCreationEnabled);
            writer.WriteBoolValue("isSiteCreationUIEnabled", IsSiteCreationUIEnabled);
            writer.WriteBoolValue("isSitePagesCreationEnabled", IsSitePagesCreationEnabled);
            writer.WriteBoolValue("isSitesStorageLimitAutomatic", IsSitesStorageLimitAutomatic);
            writer.WriteBoolValue("isSyncButtonHiddenOnPersonalSite", IsSyncButtonHiddenOnPersonalSite);
            writer.WriteBoolValue("isUnmanagedSyncAppForTenantRestricted", IsUnmanagedSyncAppForTenantRestricted);
            writer.WriteLongValue("personalSiteDefaultStorageLimitInMB", PersonalSiteDefaultStorageLimitInMB);
            writer.WriteCollectionOfPrimitiveValues<string>("sharingAllowedDomainList", SharingAllowedDomainList);
            writer.WriteCollectionOfPrimitiveValues<string>("sharingBlockedDomainList", SharingBlockedDomainList);
            writer.WriteEnumValue<SharingCapabilities>("sharingCapability", SharingCapability);
            writer.WriteEnumValue<SharingDomainRestrictionMode>("sharingDomainRestrictionMode", SharingDomainRestrictionMode);
            writer.WriteStringValue("siteCreationDefaultManagedPath", SiteCreationDefaultManagedPath);
            writer.WriteIntValue("siteCreationDefaultStorageLimitInMB", SiteCreationDefaultStorageLimitInMB);
            writer.WriteStringValue("tenantDefaultTimezone", TenantDefaultTimezone);
        }
    }
}
