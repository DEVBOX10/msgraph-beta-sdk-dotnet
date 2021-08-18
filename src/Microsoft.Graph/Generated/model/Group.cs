// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Group.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Group>))]
    public partial class Group : DirectoryObject
    {
    
        ///<summary>
        /// The Group constructor
        ///</summary>
        public Group()
        {
            this.ODataType = "microsoft.graph.group";
        }

        /// <summary>
        /// Gets or sets assigned labels.
        /// The list of sensitivity label pairs (label ID, label name) associated with a Microsoft 365 group. Returned only on $select.
        /// </summary>
        [JsonPropertyName("assignedLabels")]
        public IEnumerable<AssignedLabel> AssignedLabels { get; set; }
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// The licenses that are assigned to the group. Returned only on $select. Supports $filter (eq). Read-only.
        /// </summary>
        [JsonPropertyName("assignedLicenses")]
        public IEnumerable<AssignedLicense> AssignedLicenses { get; set; }
    
        /// <summary>
        /// Gets or sets classification.
        /// Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.Returned by default. Supports $filter (eq, ne, NOT, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("classification")]
        public string Classification { get; set; }
    
        /// <summary>
        /// Gets or sets created by app id.
        /// App ID of the app used to create the group. Can be null for some groups. Returned by default. Read-only. Supports $filter (eq, ne, NOT, in, startsWith).
        /// </summary>
        [JsonPropertyName("createdByAppId")]
        public string CreatedByAppId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Timestamp of when the group was created. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in). Read-only.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// An optional description for the group. Returned by default. Supports $filter (eq, ne, NOT, ge, le, startsWith) and $search.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the group. This property is required when a group is created and cannot be cleared during updates. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in, startsWith), $search, and $orderBy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Timestamp of when the group is set to expire. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in). Read-only.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets group types.
        /// Specifies the group type and its membership.  If the collection contains Unified, the group is a Microsoft 365 group; otherwise, it's either a security group or distribution group. For details, see groups overview.If the collection includes DynamicMembership, the group has dynamic membership; otherwise, membership is static.  Returned by default. Supports $filter (eq, NOT).
        /// </summary>
        [JsonPropertyName("groupTypes")]
        public IEnumerable<string> GroupTypes { get; set; }
    
        /// <summary>
        /// Gets or sets has members with license errors.
        /// Indicates whether there are members in this group that have license errors from its group-based license assignment. This property is never returned on a GET operation. You can use it as a $filter argument to get groups that have members with license errors (that is, filter for this property being true).  Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("hasMembersWithLicenseErrors")]
        public bool? HasMembersWithLicenseErrors { get; set; }
    
        /// <summary>
        /// Gets or sets info catalogs.
        /// Identifies the info segments assigned to the group. Returned by default. Supports $filter (eq, NOT, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("infoCatalogs")]
        public IEnumerable<string> InfoCatalogs { get; set; }
    
        /// <summary>
        /// Gets or sets is assignable to role.
        /// Indicates whether this group can be assigned to an Azure Active Directory role.This property can only be set while creating the group and is immutable. If set to true, the securityEnabled property must also be set to true and the group cannot be a dynamic group (that is, groupTypes cannot contain DynamicMembership). Only callers in Global administrator and Privileged role administrator roles can set this property. The caller must be assigned the RoleManagement.ReadWrite.Directory permission to set this property or update the membership of such groups. For more, see Using a group to manage Azure AD role assignmentsReturned by default. Supports $filter (eq, ne, NOT).
        /// </summary>
        [JsonPropertyName("isAssignableToRole")]
        public bool? IsAssignableToRole { get; set; }
    
        /// <summary>
        /// Gets or sets license processing state.
        /// Indicates status of the group license assignment to all members of the group. Possible values: QueuedForProcessing, ProcessingInProgress, and ProcessingComplete. Returned only on $select. Read-only.
        /// </summary>
        [JsonPropertyName("licenseProcessingState")]
        public LicenseProcessingState LicenseProcessingState { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the group, for example, 'serviceadmins@contoso.onmicrosoft.com'. Returned by default. Read-only. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
        /// </summary>
        [JsonPropertyName("mail")]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail enabled.
        /// Specifies whether the group is mail-enabled. Returned by default. Supports $filter (eq, ne, NOT).
        /// </summary>
        [JsonPropertyName("mailEnabled")]
        public bool? MailEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the group, unique in the organization. This property must be specified when a group is created. These characters cannot be used in the mailNickName: @()/[]';:.&amp;lt;&amp;gt;,SPACE. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
        /// </summary>
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets mdm app id.
        /// </summary>
        [JsonPropertyName("mdmAppId")]
        public string MdmAppId { get; set; }
    
        /// <summary>
        /// Gets or sets membership rule.
        /// The rule that determines members for this group if the group is a dynamic group (groupTypes contains DynamicMembership). For more information about the syntax of the membership rule, see Membership Rules syntax. Returned by default. Supports $filter (eq, ne, NOT, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("membershipRule")]
        public string MembershipRule { get; set; }
    
        /// <summary>
        /// Gets or sets membership rule processing state.
        /// Indicates whether the dynamic membership processing is on or paused. Possible values are On or Paused. Returned by default. Supports $filter (eq, ne, NOT, in).
        /// </summary>
        [JsonPropertyName("membershipRuleProcessingState")]
        public string MembershipRuleProcessingState { get; set; }
    
        /// <summary>
        /// Gets or sets on premises domain name.
        /// Contains the on-premises domain FQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesDomainName")]
        public string OnPremisesDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Indicates the last time at which the group was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Read-only. Supports $filter (eq, ne, NOT, ge, le, in).
        /// </summary>
        [JsonPropertyName("onPremisesLastSyncDateTime")]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises net bios name.
        /// Contains the on-premises netBios name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesNetBiosName")]
        public string OnPremisesNetBiosName { get; set; }
    
        /// <summary>
        /// Gets or sets on premises provisioning errors.
        /// Errors when using Microsoft synchronization product during provisioning. Returned by default. Supports $filter (eq, NOT).
        /// </summary>
        [JsonPropertyName("onPremisesProvisioningErrors")]
        public IEnumerable<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sam account name.
        /// Contains the on-premises SAM account name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Supports $filter (eq, ne, NOT, ge, le, in, startsWith). Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesSamAccountName")]
        public string OnPremisesSamAccountName { get; set; }
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// Contains the on-premises security identifier (SID) for the group that was synchronized from on-premises to the cloud. Returned by default. Supports $filter on null values. Read-only.
        /// </summary>
        [JsonPropertyName("onPremisesSecurityIdentifier")]
        public string OnPremisesSecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this group is synced from an on-premises directory; false if this group was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Returned by default. Read-only. Supports $filter (eq, ne, NOT, in).
        /// </summary>
        [JsonPropertyName("onPremisesSyncEnabled")]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets organization id.
        /// </summary>
        [JsonPropertyName("organizationId")]
        public string OrganizationId { get; set; }
    
        /// <summary>
        /// Gets or sets preferred data location.
        /// The preferred data location for the group. For more information, see  OneDrive Online Multi-Geo. Returned by default.
        /// </summary>
        [JsonPropertyName("preferredDataLocation")]
        public string PreferredDataLocation { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for a Microsoft 365 group. Should follow ISO 639-1 Code; for example 'en-US'. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in, startsWith).
        /// </summary>
        [JsonPropertyName("preferredLanguage")]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// Email addresses for the group that direct to the same group mailbox. For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com']. The any operator is required for filter expressions on multi-valued properties. Returned by default. Read-only. Not nullable. Supports $filter (eq, NOT, ge, le, startsWith).
        /// </summary>
        [JsonPropertyName("proxyAddresses")]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets renewed date time.
        /// Timestamp of when the group was last renewed. This cannot be modified directly and is only updated via the renew service action. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, NOT, ge, le, in). Read-only.
        /// </summary>
        [JsonPropertyName("renewedDateTime")]
        public DateTimeOffset? RenewedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets resource behavior options.
        /// Specifies the group behaviors that can be set for a Microsoft 365 group during creation. This can be set only as part of creation (POST). Possible values are AllowOnlyMembersToPost, HideGroupInOutlook, SubscribeNewGroupMembers, WelcomeEmailDisabled. For more information, see Set Microsoft 365 group behaviors and provisioning options.
        /// </summary>
        [JsonPropertyName("resourceBehaviorOptions")]
        public IEnumerable<string> ResourceBehaviorOptions { get; set; }
    
        /// <summary>
        /// Gets or sets resource provisioning options.
        /// Specifies the group resources that are provisioned as part of Microsoft 365 group creation, that are not normally part of default group creation. Possible value is Team. For more information, see Set Microsoft 365 group behaviors and provisioning options.
        /// </summary>
        [JsonPropertyName("resourceProvisioningOptions")]
        public IEnumerable<string> ResourceProvisioningOptions { get; set; }
    
        /// <summary>
        /// Gets or sets security enabled.
        /// Specifies whether the group is a security group. Returned by default. Supports $filter (eq, ne, NOT, in).
        /// </summary>
        [JsonPropertyName("securityEnabled")]
        public bool? SecurityEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets security identifier.
        /// Security identifier of the group, used in Windows scenarios. Returned by default.
        /// </summary>
        [JsonPropertyName("securityIdentifier")]
        public string SecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets theme.
        /// Specifies a Microsoft 365 group's color theme. Possible values are Teal, Purple, Green, Blue, Pink, Orange or Red. Returned by default.
        /// </summary>
        [JsonPropertyName("theme")]
        public string Theme { get; set; }
    
        /// <summary>
        /// Gets or sets visibility.
        /// Specifies the group join policy and group content visibility for groups. Possible values are: Private, Public, or Hiddenmembership. Hiddenmembership can be set only for Microsoft 365 groups, when the groups are created. It can't be updated later. Other values of visibility can be updated after group creation. If visibility value is not specified during group creation on Microsoft Graph, a security group is created as Private by default and Microsoft 365 group is Public. See group visibility options to learn more. Returned by default.
        /// </summary>
        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }
    
        /// <summary>
        /// Gets or sets access type.
        /// </summary>
        [JsonPropertyName("accessType")]
        public GroupAccessType? AccessType { get; set; }
    
        /// <summary>
        /// Gets or sets allow external senders.
        /// Indicates if people external to the organization can send messages to the group. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).
        /// </summary>
        [JsonPropertyName("allowExternalSenders")]
        public bool? AllowExternalSenders { get; set; }
    
        /// <summary>
        /// Gets or sets auto subscribe new members.
        /// Indicates if new members added to the group will be auto-subscribed to receive email notifications. You can set this property in a PATCH request for the group; do not set it in the initial POST request that creates the group. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).
        /// </summary>
        [JsonPropertyName("autoSubscribeNewMembers")]
        public bool? AutoSubscribeNewMembers { get; set; }
    
        /// <summary>
        /// Gets or sets hide from address lists.
        /// true if the group is not displayed in certain parts of the Outlook user interface: in the Address Book, in address lists for selecting message recipients, and in the Browse Groups dialog for searching groups; false otherwise. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).
        /// </summary>
        [JsonPropertyName("hideFromAddressLists")]
        public bool? HideFromAddressLists { get; set; }
    
        /// <summary>
        /// Gets or sets hide from outlook clients.
        /// true if the group is not displayed in Outlook clients, such as Outlook for Windows and Outlook on the web, false otherwise. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).
        /// </summary>
        [JsonPropertyName("hideFromOutlookClients")]
        public bool? HideFromOutlookClients { get; set; }
    
        /// <summary>
        /// Gets or sets is favorite.
        /// </summary>
        [JsonPropertyName("isFavorite")]
        public bool? IsFavorite { get; set; }
    
        /// <summary>
        /// Gets or sets is subscribed by mail.
        /// Indicates whether the signed-in user is subscribed to receive email conversations. Default value is true. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).
        /// </summary>
        [JsonPropertyName("isSubscribedByMail")]
        public bool? IsSubscribedByMail { get; set; }
    
        /// <summary>
        /// Gets or sets unseen conversations count.
        /// Count of conversations that have been delivered one or more new posts since the signed-in user's last visit to the group. This property is the same as unseenCount. Returned only on $select.
        /// </summary>
        [JsonPropertyName("unseenConversationsCount")]
        public Int32? UnseenConversationsCount { get; set; }
    
        /// <summary>
        /// Gets or sets unseen count.
        /// Count of conversations that have received new posts since the signed-in user last visited the group. This property is the same as unseenConversationsCount.Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).
        /// </summary>
        [JsonPropertyName("unseenCount")]
        public Int32? UnseenCount { get; set; }
    
        /// <summary>
        /// Gets or sets unseen messages count.
        /// Count of new posts that have been delivered to the group's conversations since the signed-in user's last visit to the group. Returned only on $select.
        /// </summary>
        [JsonPropertyName("unseenMessagesCount")]
        public Int32? UnseenMessagesCount { get; set; }
    
        /// <summary>
        /// Gets or sets membership rule processing status.
        /// Describes the processing status for rules-based dynamic groups. The property is null for non-rule based dynamic groups or if the dynamic group processing has been paused. Returned only on $select. Read-only.
        /// </summary>
        [JsonPropertyName("membershipRuleProcessingStatus")]
        public MembershipRuleProcessingStatus MembershipRuleProcessingStatus { get; set; }
    
        /// <summary>
        /// Gets or sets is archived.
        /// </summary>
        [JsonPropertyName("isArchived")]
        public bool? IsArchived { get; set; }
    
        /// <summary>
        /// Gets or sets app role assignments.
        /// Represents the app roles a group has been granted for an application. Supports $expand.
        /// </summary>
        [JsonPropertyName("appRoleAssignments")]
        public IGroupAppRoleAssignmentsCollectionPage AppRoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets appRoleAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("appRoleAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppRoleAssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets created on behalf of.
        /// The user (or application) that created the group. Note: This is not set if the user is an administrator. Read-only.
        /// </summary>
        [JsonPropertyName("createdOnBehalfOf")]
        public DirectoryObject CreatedOnBehalfOf { get; set; }
    
        /// <summary>
        /// Gets or sets endpoints.
        /// Endpoints for the group. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("endpoints")]
        public IGroupEndpointsCollectionPage Endpoints { get; set; }

        /// <summary>
        /// Gets or sets endpointsNextLink.
        /// </summary>
        [JsonPropertyName("endpoints@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string EndpointsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// Groups and administrative units that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("memberOf")]
        public IGroupMemberOfCollectionWithReferencesPage MemberOf { get; set; }

        /// <summary>
        /// Gets or sets memberOfNextLink.
        /// </summary>
        [JsonPropertyName("memberOf@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Users, contacts, and groups that are members of this group. HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("members")]
        public IGroupMembersCollectionWithReferencesPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets members with license errors.
        /// A list of group members with license errors from this group-based license assignment. Read-only.
        /// </summary>
        [JsonPropertyName("membersWithLicenseErrors")]
        public IGroupMembersWithLicenseErrorsCollectionWithReferencesPage MembersWithLicenseErrors { get; set; }

        /// <summary>
        /// Gets or sets membersWithLicenseErrorsNextLink.
        /// </summary>
        [JsonPropertyName("membersWithLicenseErrors@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersWithLicenseErrorsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets owners.
        /// The owners of the group. The owners are a set of non-admin users who are allowed to modify this object. HTTP Methods: GET (supported for all groups), POST (supported for security groups and mail-enabled security groups), DELETE (supported only for security groups) Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("owners")]
        public IGroupOwnersCollectionWithReferencesPage Owners { get; set; }

        /// <summary>
        /// Gets or sets ownersNextLink.
        /// </summary>
        [JsonPropertyName("owners@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OwnersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets permission grants.
        /// The permissions that have been granted for a group to a specific application. Supports $expand.
        /// </summary>
        [JsonPropertyName("permissionGrants")]
        public IGroupPermissionGrantsCollectionPage PermissionGrants { get; set; }

        /// <summary>
        /// Gets or sets permissionGrantsNextLink.
        /// </summary>
        [JsonPropertyName("permissionGrants@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PermissionGrantsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets settings.
        /// Settings that can govern this group's behavior, like whether members can invite guest users to the group. Nullable.
        /// </summary>
        [JsonPropertyName("settings")]
        public IGroupSettingsCollectionPage Settings { get; set; }

        /// <summary>
        /// Gets or sets settingsNextLink.
        /// </summary>
        [JsonPropertyName("settings@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SettingsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive member of.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf")]
        public IGroupTransitiveMemberOfCollectionWithReferencesPage TransitiveMemberOf { get; set; }

        /// <summary>
        /// Gets or sets transitiveMemberOfNextLink.
        /// </summary>
        [JsonPropertyName("transitiveMemberOf@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TransitiveMemberOfNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive members.
        /// </summary>
        [JsonPropertyName("transitiveMembers")]
        public IGroupTransitiveMembersCollectionWithReferencesPage TransitiveMembers { get; set; }

        /// <summary>
        /// Gets or sets transitiveMembersNextLink.
        /// </summary>
        [JsonPropertyName("transitiveMembers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TransitiveMembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets accepted senders.
        /// The list of users or groups that are allowed to create post's or calendar events in this group. If this list is non-empty then only users or groups listed here are allowed to post.
        /// </summary>
        [JsonPropertyName("acceptedSenders")]
        public IGroupAcceptedSendersCollectionWithReferencesPage AcceptedSenders { get; set; }

        /// <summary>
        /// Gets or sets acceptedSendersNextLink.
        /// </summary>
        [JsonPropertyName("acceptedSenders@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AcceptedSendersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The group's calendar. Read-only.
        /// </summary>
        [JsonPropertyName("calendar")]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Read-only.
        /// </summary>
        [JsonPropertyName("calendarView")]
        public IGroupCalendarViewCollectionPage CalendarView { get; set; }

        /// <summary>
        /// Gets or sets calendarViewNextLink.
        /// </summary>
        [JsonPropertyName("calendarView@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CalendarViewNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets conversations.
        /// The group's conversations.
        /// </summary>
        [JsonPropertyName("conversations")]
        public IGroupConversationsCollectionPage Conversations { get; set; }

        /// <summary>
        /// Gets or sets conversationsNextLink.
        /// </summary>
        [JsonPropertyName("conversations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ConversationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// The group's events.
        /// </summary>
        [JsonPropertyName("events")]
        public IGroupEventsCollectionPage Events { get; set; }

        /// <summary>
        /// Gets or sets eventsNextLink.
        /// </summary>
        [JsonPropertyName("events@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string EventsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets rejected senders.
        /// The list of users or groups that are not allowed to create posts or calendar events in this group. Nullable
        /// </summary>
        [JsonPropertyName("rejectedSenders")]
        public IGroupRejectedSendersCollectionWithReferencesPage RejectedSenders { get; set; }

        /// <summary>
        /// Gets or sets rejectedSendersNextLink.
        /// </summary>
        [JsonPropertyName("rejectedSenders@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RejectedSendersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets threads.
        /// The group's conversation threads. Nullable.
        /// </summary>
        [JsonPropertyName("threads")]
        public IGroupThreadsCollectionPage Threads { get; set; }

        /// <summary>
        /// Gets or sets threadsNextLink.
        /// </summary>
        [JsonPropertyName("threads@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ThreadsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// The group's default drive. Read-only.
        /// </summary>
        [JsonPropertyName("drive")]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// The group's drives. Read-only.
        /// </summary>
        [JsonPropertyName("drives")]
        public IGroupDrivesCollectionPage Drives { get; set; }

        /// <summary>
        /// Gets or sets drivesNextLink.
        /// </summary>
        [JsonPropertyName("drives@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DrivesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sites.
        /// The list of SharePoint sites in this group. Access the default site with /sites/root.
        /// </summary>
        [JsonPropertyName("sites")]
        public IGroupSitesCollectionPage Sites { get; set; }

        /// <summary>
        /// Gets or sets sitesNextLink.
        /// </summary>
        [JsonPropertyName("sites@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SitesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the group. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IGroupExtensionsCollectionPage Extensions { get; set; }

        /// <summary>
        /// Gets or sets extensionsNextLink.
        /// </summary>
        [JsonPropertyName("extensions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ExtensionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets group lifecycle policies.
        /// The collection of lifecycle policies for this group. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("groupLifecyclePolicies")]
        public IGroupGroupLifecyclePoliciesCollectionPage GroupLifecyclePolicies { get; set; }

        /// <summary>
        /// Gets or sets groupLifecyclePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("groupLifecyclePolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string GroupLifecyclePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets planner.
        /// Selective Planner services available to the group. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("planner")]
        public PlannerGroup Planner { get; set; }
    
        /// <summary>
        /// Gets or sets onenote.
        /// Read-only.
        /// </summary>
        [JsonPropertyName("onenote")]
        public Onenote Onenote { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// The group's profile photo.
        /// </summary>
        [JsonPropertyName("photo")]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets photos.
        /// The profile photos owned by the group. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("photos")]
        public IGroupPhotosCollectionPage Photos { get; set; }

        /// <summary>
        /// Gets or sets photosNextLink.
        /// </summary>
        [JsonPropertyName("photos@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PhotosNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets team.
        /// </summary>
        [JsonPropertyName("team")]
        public Team Team { get; set; }
    
    }
}

