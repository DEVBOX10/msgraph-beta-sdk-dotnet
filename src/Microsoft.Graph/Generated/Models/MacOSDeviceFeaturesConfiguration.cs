using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSDeviceFeaturesConfiguration : AppleDeviceFeaturesConfigurationBase, IParsable {
        /// <summary>Whether to show admin host information on the login window.</summary>
        public bool? AdminShowHostInfo {
            get { return BackingStore?.Get<bool?>("adminShowHostInfo"); }
            set { BackingStore?.Set("adminShowHostInfo", value); }
        }
        /// <summary>Gets or sets a list that maps apps to their associated domains. Application identifiers must be unique. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSAssociatedDomainsItem>? AppAssociatedDomains {
            get { return BackingStore?.Get<List<MacOSAssociatedDomainsItem>?>("appAssociatedDomains"); }
            set { BackingStore?.Set("appAssociatedDomains", value); }
        }
#nullable restore
#else
        public List<MacOSAssociatedDomainsItem> AppAssociatedDomains {
            get { return BackingStore?.Get<List<MacOSAssociatedDomainsItem>>("appAssociatedDomains"); }
            set { BackingStore?.Set("appAssociatedDomains", value); }
        }
#endif
        /// <summary>DEPRECATED: use appAssociatedDomains instead. Gets or sets a list that maps apps to their associated domains. The key should match the app&apos;s ID, and the value should be a string in the form of &apos;service:domain&apos; where domain is a fully qualified hostname (e.g. webcredentials:example.com). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? AssociatedDomains {
            get { return BackingStore?.Get<List<KeyValuePair>?>("associatedDomains"); }
            set { BackingStore?.Set("associatedDomains", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> AssociatedDomains {
            get { return BackingStore?.Get<List<KeyValuePair>>("associatedDomains"); }
            set { BackingStore?.Set("associatedDomains", value); }
        }
#endif
        /// <summary>Whether to show the name and password dialog or a list of users on the login window.</summary>
        public bool? AuthorizedUsersListHidden {
            get { return BackingStore?.Get<bool?>("authorizedUsersListHidden"); }
            set { BackingStore?.Set("authorizedUsersListHidden", value); }
        }
        /// <summary>Whether to hide admin users in the authorized users list on the login window.</summary>
        public bool? AuthorizedUsersListHideAdminUsers {
            get { return BackingStore?.Get<bool?>("authorizedUsersListHideAdminUsers"); }
            set { BackingStore?.Set("authorizedUsersListHideAdminUsers", value); }
        }
        /// <summary>Whether to show only network and system users in the authorized users list on the login window.</summary>
        public bool? AuthorizedUsersListHideLocalUsers {
            get { return BackingStore?.Get<bool?>("authorizedUsersListHideLocalUsers"); }
            set { BackingStore?.Set("authorizedUsersListHideLocalUsers", value); }
        }
        /// <summary>Whether to hide mobile users in the authorized users list on the login window.</summary>
        public bool? AuthorizedUsersListHideMobileAccounts {
            get { return BackingStore?.Get<bool?>("authorizedUsersListHideMobileAccounts"); }
            set { BackingStore?.Set("authorizedUsersListHideMobileAccounts", value); }
        }
        /// <summary>Whether to show network users in the authorized users list on the login window.</summary>
        public bool? AuthorizedUsersListIncludeNetworkUsers {
            get { return BackingStore?.Get<bool?>("authorizedUsersListIncludeNetworkUsers"); }
            set { BackingStore?.Set("authorizedUsersListIncludeNetworkUsers", value); }
        }
        /// <summary>Whether to show other users in the authorized users list on the login window.</summary>
        public bool? AuthorizedUsersListShowOtherManagedUsers {
            get { return BackingStore?.Get<bool?>("authorizedUsersListShowOtherManagedUsers"); }
            set { BackingStore?.Set("authorizedUsersListShowOtherManagedUsers", value); }
        }
        /// <summary>List of applications, files, folders, and other items to launch when the user logs in. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MacOSLaunchItem>? AutoLaunchItems {
            get { return BackingStore?.Get<List<MacOSLaunchItem>?>("autoLaunchItems"); }
            set { BackingStore?.Set("autoLaunchItems", value); }
        }
#nullable restore
#else
        public List<MacOSLaunchItem> AutoLaunchItems {
            get { return BackingStore?.Get<List<MacOSLaunchItem>>("autoLaunchItems"); }
            set { BackingStore?.Set("autoLaunchItems", value); }
        }
#endif
        /// <summary>Whether the Other user will disregard use of the console special user name.</summary>
        public bool? ConsoleAccessDisabled {
            get { return BackingStore?.Get<bool?>("consoleAccessDisabled"); }
            set { BackingStore?.Set("consoleAccessDisabled", value); }
        }
        /// <summary>Prevents content caches from purging content to free up disk space for other apps.</summary>
        public bool? ContentCachingBlockDeletion {
            get { return BackingStore?.Get<bool?>("contentCachingBlockDeletion"); }
            set { BackingStore?.Set("contentCachingBlockDeletion", value); }
        }
        /// <summary>A list of custom IP ranges content caches will use to listen for clients. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpRange>? ContentCachingClientListenRanges {
            get { return BackingStore?.Get<List<IpRange>?>("contentCachingClientListenRanges"); }
            set { BackingStore?.Set("contentCachingClientListenRanges", value); }
        }
#nullable restore
#else
        public List<IpRange> ContentCachingClientListenRanges {
            get { return BackingStore?.Get<List<IpRange>>("contentCachingClientListenRanges"); }
            set { BackingStore?.Set("contentCachingClientListenRanges", value); }
        }
#endif
        /// <summary>Determines which clients a content cache will serve.</summary>
        public MacOSContentCachingClientPolicy? ContentCachingClientPolicy {
            get { return BackingStore?.Get<MacOSContentCachingClientPolicy?>("contentCachingClientPolicy"); }
            set { BackingStore?.Set("contentCachingClientPolicy", value); }
        }
        /// <summary>The path to the directory used to store cached content. The value must be (or end with) /Library/Application Support/Apple/AssetCache/Data</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentCachingDataPath {
            get { return BackingStore?.Get<string?>("contentCachingDataPath"); }
            set { BackingStore?.Set("contentCachingDataPath", value); }
        }
#nullable restore
#else
        public string ContentCachingDataPath {
            get { return BackingStore?.Get<string>("contentCachingDataPath"); }
            set { BackingStore?.Set("contentCachingDataPath", value); }
        }
#endif
        /// <summary>Disables internet connection sharing.</summary>
        public bool? ContentCachingDisableConnectionSharing {
            get { return BackingStore?.Get<bool?>("contentCachingDisableConnectionSharing"); }
            set { BackingStore?.Set("contentCachingDisableConnectionSharing", value); }
        }
        /// <summary>Enables content caching and prevents it from being disabled by the user.</summary>
        public bool? ContentCachingEnabled {
            get { return BackingStore?.Get<bool?>("contentCachingEnabled"); }
            set { BackingStore?.Set("contentCachingEnabled", value); }
        }
        /// <summary>Forces internet connection sharing. contentCachingDisableConnectionSharing overrides this setting.</summary>
        public bool? ContentCachingForceConnectionSharing {
            get { return BackingStore?.Get<bool?>("contentCachingForceConnectionSharing"); }
            set { BackingStore?.Set("contentCachingForceConnectionSharing", value); }
        }
        /// <summary>Prevent the device from sleeping if content caching is enabled.</summary>
        public bool? ContentCachingKeepAwake {
            get { return BackingStore?.Get<bool?>("contentCachingKeepAwake"); }
            set { BackingStore?.Set("contentCachingKeepAwake", value); }
        }
        /// <summary>Enables logging of IP addresses and ports of clients that request cached content.</summary>
        public bool? ContentCachingLogClientIdentities {
            get { return BackingStore?.Get<bool?>("contentCachingLogClientIdentities"); }
            set { BackingStore?.Set("contentCachingLogClientIdentities", value); }
        }
        /// <summary>The maximum number of bytes of disk space that will be used for the content cache. A value of 0 (default) indicates unlimited disk space.</summary>
        public long? ContentCachingMaxSizeBytes {
            get { return BackingStore?.Get<long?>("contentCachingMaxSizeBytes"); }
            set { BackingStore?.Set("contentCachingMaxSizeBytes", value); }
        }
        /// <summary>A list of IP addresses representing parent content caches.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ContentCachingParents {
            get { return BackingStore?.Get<List<string>?>("contentCachingParents"); }
            set { BackingStore?.Set("contentCachingParents", value); }
        }
#nullable restore
#else
        public List<string> ContentCachingParents {
            get { return BackingStore?.Get<List<string>>("contentCachingParents"); }
            set { BackingStore?.Set("contentCachingParents", value); }
        }
#endif
        /// <summary>Determines how content caches select a parent cache.</summary>
        public MacOSContentCachingParentSelectionPolicy? ContentCachingParentSelectionPolicy {
            get { return BackingStore?.Get<MacOSContentCachingParentSelectionPolicy?>("contentCachingParentSelectionPolicy"); }
            set { BackingStore?.Set("contentCachingParentSelectionPolicy", value); }
        }
        /// <summary>A list of custom IP ranges content caches will use to query for content from peers caches. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpRange>? ContentCachingPeerFilterRanges {
            get { return BackingStore?.Get<List<IpRange>?>("contentCachingPeerFilterRanges"); }
            set { BackingStore?.Set("contentCachingPeerFilterRanges", value); }
        }
#nullable restore
#else
        public List<IpRange> ContentCachingPeerFilterRanges {
            get { return BackingStore?.Get<List<IpRange>>("contentCachingPeerFilterRanges"); }
            set { BackingStore?.Set("contentCachingPeerFilterRanges", value); }
        }
#endif
        /// <summary>A list of custom IP ranges content caches will use to listen for peer caches. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpRange>? ContentCachingPeerListenRanges {
            get { return BackingStore?.Get<List<IpRange>?>("contentCachingPeerListenRanges"); }
            set { BackingStore?.Set("contentCachingPeerListenRanges", value); }
        }
#nullable restore
#else
        public List<IpRange> ContentCachingPeerListenRanges {
            get { return BackingStore?.Get<List<IpRange>>("contentCachingPeerListenRanges"); }
            set { BackingStore?.Set("contentCachingPeerListenRanges", value); }
        }
#endif
        /// <summary>Determines which content caches other content caches will peer with.</summary>
        public MacOSContentCachingPeerPolicy? ContentCachingPeerPolicy {
            get { return BackingStore?.Get<MacOSContentCachingPeerPolicy?>("contentCachingPeerPolicy"); }
            set { BackingStore?.Set("contentCachingPeerPolicy", value); }
        }
        /// <summary>Sets the port used for content caching. If the value is 0, a random available port will be selected. Valid values 0 to 65535</summary>
        public int? ContentCachingPort {
            get { return BackingStore?.Get<int?>("contentCachingPort"); }
            set { BackingStore?.Set("contentCachingPort", value); }
        }
        /// <summary>A list of custom IP ranges that Apple&apos;s content caching service should use to match clients to content caches. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IpRange>? ContentCachingPublicRanges {
            get { return BackingStore?.Get<List<IpRange>?>("contentCachingPublicRanges"); }
            set { BackingStore?.Set("contentCachingPublicRanges", value); }
        }
#nullable restore
#else
        public List<IpRange> ContentCachingPublicRanges {
            get { return BackingStore?.Get<List<IpRange>>("contentCachingPublicRanges"); }
            set { BackingStore?.Set("contentCachingPublicRanges", value); }
        }
#endif
        /// <summary>Display content caching alerts as system notifications.</summary>
        public bool? ContentCachingShowAlerts {
            get { return BackingStore?.Get<bool?>("contentCachingShowAlerts"); }
            set { BackingStore?.Set("contentCachingShowAlerts", value); }
        }
        /// <summary>Indicates the type of content allowed to be cached by Apple&apos;s content caching service.</summary>
        public MacOSContentCachingType? ContentCachingType {
            get { return BackingStore?.Get<MacOSContentCachingType?>("contentCachingType"); }
            set { BackingStore?.Set("contentCachingType", value); }
        }
        /// <summary>Custom text to be displayed on the login window.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoginWindowText {
            get { return BackingStore?.Get<string?>("loginWindowText"); }
            set { BackingStore?.Set("loginWindowText", value); }
        }
#nullable restore
#else
        public string LoginWindowText {
            get { return BackingStore?.Get<string>("loginWindowText"); }
            set { BackingStore?.Set("loginWindowText", value); }
        }
#endif
        /// <summary>Whether the Log Out menu item on the login window will be disabled while the user is logged in.</summary>
        public bool? LogOutDisabledWhileLoggedIn {
            get { return BackingStore?.Get<bool?>("logOutDisabledWhileLoggedIn"); }
            set { BackingStore?.Set("logOutDisabledWhileLoggedIn", value); }
        }
        /// <summary>Gets or sets a single sign-on extension profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension? MacOSSingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension?>("macOSSingleSignOnExtension"); }
            set { BackingStore?.Set("macOSSingleSignOnExtension", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension MacOSSingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension>("macOSSingleSignOnExtension"); }
            set { BackingStore?.Set("macOSSingleSignOnExtension", value); }
        }
#endif
        /// <summary>Whether the Power Off menu item on the login window will be disabled while the user is logged in.</summary>
        public bool? PowerOffDisabledWhileLoggedIn {
            get { return BackingStore?.Get<bool?>("powerOffDisabledWhileLoggedIn"); }
            set { BackingStore?.Set("powerOffDisabledWhileLoggedIn", value); }
        }
        /// <summary>Whether to hide the Restart button item on the login window.</summary>
        public bool? RestartDisabled {
            get { return BackingStore?.Get<bool?>("restartDisabled"); }
            set { BackingStore?.Set("restartDisabled", value); }
        }
        /// <summary>Whether the Restart menu item on the login window will be disabled while the user is logged in.</summary>
        public bool? RestartDisabledWhileLoggedIn {
            get { return BackingStore?.Get<bool?>("restartDisabledWhileLoggedIn"); }
            set { BackingStore?.Set("restartDisabledWhileLoggedIn", value); }
        }
        /// <summary>Whether to disable the immediate screen lock functions.</summary>
        public bool? ScreenLockDisableImmediate {
            get { return BackingStore?.Get<bool?>("screenLockDisableImmediate"); }
            set { BackingStore?.Set("screenLockDisableImmediate", value); }
        }
        /// <summary>Whether to hide the Shut Down button item on the login window.</summary>
        public bool? ShutDownDisabled {
            get { return BackingStore?.Get<bool?>("shutDownDisabled"); }
            set { BackingStore?.Set("shutDownDisabled", value); }
        }
        /// <summary>Whether the Shut Down menu item on the login window will be disabled while the user is logged in.</summary>
        public bool? ShutDownDisabledWhileLoggedIn {
            get { return BackingStore?.Get<bool?>("shutDownDisabledWhileLoggedIn"); }
            set { BackingStore?.Set("shutDownDisabledWhileLoggedIn", value); }
        }
        /// <summary>Gets or sets a single sign-on extension profile. Deprecated: use MacOSSingleSignOnExtension instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension? SingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension?>("singleSignOnExtension"); }
            set { BackingStore?.Set("singleSignOnExtension", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension SingleSignOnExtension {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension"); }
            set { BackingStore?.Set("singleSignOnExtension", value); }
        }
#endif
        /// <summary>PKINIT Certificate for the authentication with single sign-on extensions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MacOSCertificateProfileBase? SingleSignOnExtensionPkinitCertificate {
            get { return BackingStore?.Get<MacOSCertificateProfileBase?>("singleSignOnExtensionPkinitCertificate"); }
            set { BackingStore?.Set("singleSignOnExtensionPkinitCertificate", value); }
        }
#nullable restore
#else
        public MacOSCertificateProfileBase SingleSignOnExtensionPkinitCertificate {
            get { return BackingStore?.Get<MacOSCertificateProfileBase>("singleSignOnExtensionPkinitCertificate"); }
            set { BackingStore?.Set("singleSignOnExtensionPkinitCertificate", value); }
        }
#endif
        /// <summary>Whether to hide the Sleep menu item on the login window.</summary>
        public bool? SleepDisabled {
            get { return BackingStore?.Get<bool?>("sleepDisabled"); }
            set { BackingStore?.Set("sleepDisabled", value); }
        }
        /// <summary>
        /// Instantiates a new MacOSDeviceFeaturesConfiguration and sets the default values.
        /// </summary>
        public MacOSDeviceFeaturesConfiguration() : base() {
            OdataType = "#microsoft.graph.macOSDeviceFeaturesConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSDeviceFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSDeviceFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"adminShowHostInfo", n => { AdminShowHostInfo = n.GetBoolValue(); } },
                {"appAssociatedDomains", n => { AppAssociatedDomains = n.GetCollectionOfObjectValues<MacOSAssociatedDomainsItem>(MacOSAssociatedDomainsItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"associatedDomains", n => { AssociatedDomains = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"authorizedUsersListHidden", n => { AuthorizedUsersListHidden = n.GetBoolValue(); } },
                {"authorizedUsersListHideAdminUsers", n => { AuthorizedUsersListHideAdminUsers = n.GetBoolValue(); } },
                {"authorizedUsersListHideLocalUsers", n => { AuthorizedUsersListHideLocalUsers = n.GetBoolValue(); } },
                {"authorizedUsersListHideMobileAccounts", n => { AuthorizedUsersListHideMobileAccounts = n.GetBoolValue(); } },
                {"authorizedUsersListIncludeNetworkUsers", n => { AuthorizedUsersListIncludeNetworkUsers = n.GetBoolValue(); } },
                {"authorizedUsersListShowOtherManagedUsers", n => { AuthorizedUsersListShowOtherManagedUsers = n.GetBoolValue(); } },
                {"autoLaunchItems", n => { AutoLaunchItems = n.GetCollectionOfObjectValues<MacOSLaunchItem>(MacOSLaunchItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"consoleAccessDisabled", n => { ConsoleAccessDisabled = n.GetBoolValue(); } },
                {"contentCachingBlockDeletion", n => { ContentCachingBlockDeletion = n.GetBoolValue(); } },
                {"contentCachingClientListenRanges", n => { ContentCachingClientListenRanges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentCachingClientPolicy", n => { ContentCachingClientPolicy = n.GetEnumValue<MacOSContentCachingClientPolicy>(); } },
                {"contentCachingDataPath", n => { ContentCachingDataPath = n.GetStringValue(); } },
                {"contentCachingDisableConnectionSharing", n => { ContentCachingDisableConnectionSharing = n.GetBoolValue(); } },
                {"contentCachingEnabled", n => { ContentCachingEnabled = n.GetBoolValue(); } },
                {"contentCachingForceConnectionSharing", n => { ContentCachingForceConnectionSharing = n.GetBoolValue(); } },
                {"contentCachingKeepAwake", n => { ContentCachingKeepAwake = n.GetBoolValue(); } },
                {"contentCachingLogClientIdentities", n => { ContentCachingLogClientIdentities = n.GetBoolValue(); } },
                {"contentCachingMaxSizeBytes", n => { ContentCachingMaxSizeBytes = n.GetLongValue(); } },
                {"contentCachingParents", n => { ContentCachingParents = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"contentCachingParentSelectionPolicy", n => { ContentCachingParentSelectionPolicy = n.GetEnumValue<MacOSContentCachingParentSelectionPolicy>(); } },
                {"contentCachingPeerFilterRanges", n => { ContentCachingPeerFilterRanges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentCachingPeerListenRanges", n => { ContentCachingPeerListenRanges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentCachingPeerPolicy", n => { ContentCachingPeerPolicy = n.GetEnumValue<MacOSContentCachingPeerPolicy>(); } },
                {"contentCachingPort", n => { ContentCachingPort = n.GetIntValue(); } },
                {"contentCachingPublicRanges", n => { ContentCachingPublicRanges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentCachingShowAlerts", n => { ContentCachingShowAlerts = n.GetBoolValue(); } },
                {"contentCachingType", n => { ContentCachingType = n.GetEnumValue<MacOSContentCachingType>(); } },
                {"loginWindowText", n => { LoginWindowText = n.GetStringValue(); } },
                {"logOutDisabledWhileLoggedIn", n => { LogOutDisabledWhileLoggedIn = n.GetBoolValue(); } },
                {"macOSSingleSignOnExtension", n => { MacOSSingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension>(Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension.CreateFromDiscriminatorValue); } },
                {"powerOffDisabledWhileLoggedIn", n => { PowerOffDisabledWhileLoggedIn = n.GetBoolValue(); } },
                {"restartDisabled", n => { RestartDisabled = n.GetBoolValue(); } },
                {"restartDisabledWhileLoggedIn", n => { RestartDisabledWhileLoggedIn = n.GetBoolValue(); } },
                {"screenLockDisableImmediate", n => { ScreenLockDisableImmediate = n.GetBoolValue(); } },
                {"shutDownDisabled", n => { ShutDownDisabled = n.GetBoolValue(); } },
                {"shutDownDisabledWhileLoggedIn", n => { ShutDownDisabledWhileLoggedIn = n.GetBoolValue(); } },
                {"singleSignOnExtension", n => { SingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>(Microsoft.Graph.Beta.Models.SingleSignOnExtension.CreateFromDiscriminatorValue); } },
                {"singleSignOnExtensionPkinitCertificate", n => { SingleSignOnExtensionPkinitCertificate = n.GetObjectValue<MacOSCertificateProfileBase>(MacOSCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"sleepDisabled", n => { SleepDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("adminShowHostInfo", AdminShowHostInfo);
            writer.WriteCollectionOfObjectValues<MacOSAssociatedDomainsItem>("appAssociatedDomains", AppAssociatedDomains);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("associatedDomains", AssociatedDomains);
            writer.WriteBoolValue("authorizedUsersListHidden", AuthorizedUsersListHidden);
            writer.WriteBoolValue("authorizedUsersListHideAdminUsers", AuthorizedUsersListHideAdminUsers);
            writer.WriteBoolValue("authorizedUsersListHideLocalUsers", AuthorizedUsersListHideLocalUsers);
            writer.WriteBoolValue("authorizedUsersListHideMobileAccounts", AuthorizedUsersListHideMobileAccounts);
            writer.WriteBoolValue("authorizedUsersListIncludeNetworkUsers", AuthorizedUsersListIncludeNetworkUsers);
            writer.WriteBoolValue("authorizedUsersListShowOtherManagedUsers", AuthorizedUsersListShowOtherManagedUsers);
            writer.WriteCollectionOfObjectValues<MacOSLaunchItem>("autoLaunchItems", AutoLaunchItems);
            writer.WriteBoolValue("consoleAccessDisabled", ConsoleAccessDisabled);
            writer.WriteBoolValue("contentCachingBlockDeletion", ContentCachingBlockDeletion);
            writer.WriteCollectionOfObjectValues<IpRange>("contentCachingClientListenRanges", ContentCachingClientListenRanges);
            writer.WriteEnumValue<MacOSContentCachingClientPolicy>("contentCachingClientPolicy", ContentCachingClientPolicy);
            writer.WriteStringValue("contentCachingDataPath", ContentCachingDataPath);
            writer.WriteBoolValue("contentCachingDisableConnectionSharing", ContentCachingDisableConnectionSharing);
            writer.WriteBoolValue("contentCachingEnabled", ContentCachingEnabled);
            writer.WriteBoolValue("contentCachingForceConnectionSharing", ContentCachingForceConnectionSharing);
            writer.WriteBoolValue("contentCachingKeepAwake", ContentCachingKeepAwake);
            writer.WriteBoolValue("contentCachingLogClientIdentities", ContentCachingLogClientIdentities);
            writer.WriteLongValue("contentCachingMaxSizeBytes", ContentCachingMaxSizeBytes);
            writer.WriteCollectionOfPrimitiveValues<string>("contentCachingParents", ContentCachingParents);
            writer.WriteEnumValue<MacOSContentCachingParentSelectionPolicy>("contentCachingParentSelectionPolicy", ContentCachingParentSelectionPolicy);
            writer.WriteCollectionOfObjectValues<IpRange>("contentCachingPeerFilterRanges", ContentCachingPeerFilterRanges);
            writer.WriteCollectionOfObjectValues<IpRange>("contentCachingPeerListenRanges", ContentCachingPeerListenRanges);
            writer.WriteEnumValue<MacOSContentCachingPeerPolicy>("contentCachingPeerPolicy", ContentCachingPeerPolicy);
            writer.WriteIntValue("contentCachingPort", ContentCachingPort);
            writer.WriteCollectionOfObjectValues<IpRange>("contentCachingPublicRanges", ContentCachingPublicRanges);
            writer.WriteBoolValue("contentCachingShowAlerts", ContentCachingShowAlerts);
            writer.WriteEnumValue<MacOSContentCachingType>("contentCachingType", ContentCachingType);
            writer.WriteStringValue("loginWindowText", LoginWindowText);
            writer.WriteBoolValue("logOutDisabledWhileLoggedIn", LogOutDisabledWhileLoggedIn);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension>("macOSSingleSignOnExtension", MacOSSingleSignOnExtension);
            writer.WriteBoolValue("powerOffDisabledWhileLoggedIn", PowerOffDisabledWhileLoggedIn);
            writer.WriteBoolValue("restartDisabled", RestartDisabled);
            writer.WriteBoolValue("restartDisabledWhileLoggedIn", RestartDisabledWhileLoggedIn);
            writer.WriteBoolValue("screenLockDisableImmediate", ScreenLockDisableImmediate);
            writer.WriteBoolValue("shutDownDisabled", ShutDownDisabled);
            writer.WriteBoolValue("shutDownDisabledWhileLoggedIn", ShutDownDisabledWhileLoggedIn);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension", SingleSignOnExtension);
            writer.WriteObjectValue<MacOSCertificateProfileBase>("singleSignOnExtensionPkinitCertificate", SingleSignOnExtensionPkinitCertificate);
            writer.WriteBoolValue("sleepDisabled", SleepDisabled);
        }
    }
}
