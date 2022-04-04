using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.DeviceAppManagement.AndroidManagedAppProtections;
using MicrosoftGraphSdk.DeviceAppManagement.DefaultManagedAppProtections;
using MicrosoftGraphSdk.DeviceAppManagement.DeviceAppManagementTasks;
using MicrosoftGraphSdk.DeviceAppManagement.EnterpriseCodeSigningCertificates;
using MicrosoftGraphSdk.DeviceAppManagement.IosLobAppProvisioningConfigurations;
using MicrosoftGraphSdk.DeviceAppManagement.IosManagedAppProtections;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedAppPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedAppRegistrations;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedAppStatuses;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedEBookCategories;
using MicrosoftGraphSdk.DeviceAppManagement.ManagedEBooks;
using MicrosoftGraphSdk.DeviceAppManagement.MdmWindowsInformationProtectionPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.MobileAppCategories;
using MicrosoftGraphSdk.DeviceAppManagement.MobileAppConfigurations;
using MicrosoftGraphSdk.DeviceAppManagement.MobileApps;
using MicrosoftGraphSdk.DeviceAppManagement.PolicySets;
using MicrosoftGraphSdk.DeviceAppManagement.SideLoadingKeys;
using MicrosoftGraphSdk.DeviceAppManagement.SymantecCodeSigningCertificate;
using MicrosoftGraphSdk.DeviceAppManagement.SyncMicrosoftStoreForBusinessApps;
using MicrosoftGraphSdk.DeviceAppManagement.TargetedManagedAppConfigurations;
using MicrosoftGraphSdk.DeviceAppManagement.VppTokens;
using MicrosoftGraphSdk.DeviceAppManagement.WdacSupplementalPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsInformationProtectionDeviceRegistrations;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsInformationProtectionPolicies;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsInformationProtectionWipeActions;
using MicrosoftGraphSdk.DeviceAppManagement.WindowsManagementApp;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ODataErrors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.DeviceAppManagement {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class DeviceAppManagementRequestBuilder {
        /// <summary>The androidManagedAppProtections property</summary>
        public AndroidManagedAppProtectionsRequestBuilder AndroidManagedAppProtections { get =>
            new AndroidManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The defaultManagedAppProtections property</summary>
        public DefaultManagedAppProtectionsRequestBuilder DefaultManagedAppProtections { get =>
            new DefaultManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deviceAppManagementTasks property</summary>
        public DeviceAppManagementTasksRequestBuilder DeviceAppManagementTasks { get =>
            new DeviceAppManagementTasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The enterpriseCodeSigningCertificates property</summary>
        public EnterpriseCodeSigningCertificatesRequestBuilder EnterpriseCodeSigningCertificates { get =>
            new EnterpriseCodeSigningCertificatesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The iosLobAppProvisioningConfigurations property</summary>
        public IosLobAppProvisioningConfigurationsRequestBuilder IosLobAppProvisioningConfigurations { get =>
            new IosLobAppProvisioningConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The iosManagedAppProtections property</summary>
        public IosManagedAppProtectionsRequestBuilder IosManagedAppProtections { get =>
            new IosManagedAppProtectionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppPolicies property</summary>
        public ManagedAppPoliciesRequestBuilder ManagedAppPolicies { get =>
            new ManagedAppPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppRegistrations property</summary>
        public ManagedAppRegistrationsRequestBuilder ManagedAppRegistrations { get =>
            new ManagedAppRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedAppStatuses property</summary>
        public ManagedAppStatusesRequestBuilder ManagedAppStatuses { get =>
            new ManagedAppStatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedEBookCategories property</summary>
        public ManagedEBookCategoriesRequestBuilder ManagedEBookCategories { get =>
            new ManagedEBookCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The managedEBooks property</summary>
        public ManagedEBooksRequestBuilder ManagedEBooks { get =>
            new ManagedEBooksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mdmWindowsInformationProtectionPolicies property</summary>
        public MdmWindowsInformationProtectionPoliciesRequestBuilder MdmWindowsInformationProtectionPolicies { get =>
            new MdmWindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppCategories property</summary>
        public MobileAppCategoriesRequestBuilder MobileAppCategories { get =>
            new MobileAppCategoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileAppConfigurations property</summary>
        public MobileAppConfigurationsRequestBuilder MobileAppConfigurations { get =>
            new MobileAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mobileApps property</summary>
        public MobileAppsRequestBuilder MobileApps { get =>
            new MobileAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The policySets property</summary>
        public PolicySetsRequestBuilder PolicySets { get =>
            new PolicySetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The sideLoadingKeys property</summary>
        public SideLoadingKeysRequestBuilder SideLoadingKeys { get =>
            new SideLoadingKeysRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The symantecCodeSigningCertificate property</summary>
        public SymantecCodeSigningCertificateRequestBuilder SymantecCodeSigningCertificate { get =>
            new SymantecCodeSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The syncMicrosoftStoreForBusinessApps property</summary>
        public SyncMicrosoftStoreForBusinessAppsRequestBuilder SyncMicrosoftStoreForBusinessApps { get =>
            new SyncMicrosoftStoreForBusinessAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The targetedManagedAppConfigurations property</summary>
        public TargetedManagedAppConfigurationsRequestBuilder TargetedManagedAppConfigurations { get =>
            new TargetedManagedAppConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The vppTokens property</summary>
        public VppTokensRequestBuilder VppTokens { get =>
            new VppTokensRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The wdacSupplementalPolicies property</summary>
        public WdacSupplementalPoliciesRequestBuilder WdacSupplementalPolicies { get =>
            new WdacSupplementalPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionDeviceRegistrations property</summary>
        public WindowsInformationProtectionDeviceRegistrationsRequestBuilder WindowsInformationProtectionDeviceRegistrations { get =>
            new WindowsInformationProtectionDeviceRegistrationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionPolicies property</summary>
        public WindowsInformationProtectionPoliciesRequestBuilder WindowsInformationProtectionPolicies { get =>
            new WindowsInformationProtectionPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsInformationProtectionWipeActions property</summary>
        public WindowsInformationProtectionWipeActionsRequestBuilder WindowsInformationProtectionWipeActions { get =>
            new WindowsInformationProtectionWipeActionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The windowsManagementApp property</summary>
        public WindowsManagementAppRequestBuilder WindowsManagementApp { get =>
            new WindowsManagementAppRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new DeviceAppManagementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public DeviceAppManagementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceAppManagement{?select,expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get deviceAppManagement
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Get deviceAppManagement
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement> GetAsync(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(queryParameters, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement>(requestInfo, MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update deviceAppManagement
        /// <param name="body"></param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task PatchAsync(MicrosoftGraphSdk.Models.Microsoft.Graph.DeviceAppManagement body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = CreatePatchRequestInformation(body, headers, options);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get deviceAppManagement</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
