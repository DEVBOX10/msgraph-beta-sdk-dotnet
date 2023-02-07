using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppManagementPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignedTo;
using Microsoft.Graph.Beta.ServicePrincipals.Item.AppRoleAssignments;
using Microsoft.Graph.Beta.ServicePrincipals.Item.ClaimsMappingPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.CreatedObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.DelegatedPermissionClassifications;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Endpoints;
using Microsoft.Graph.Beta.ServicePrincipals.Item.FederatedIdentityCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.HomeRealmDiscoveryPolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.LicenseDetails;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphAddTokenSigningCertificate;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphCheckMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphCheckMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphCreatePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphDeletePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphGetMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphGetMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphGetPasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphRestore;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MicrosoftGraphUpdatePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Oauth2PermissionGrants;
using Microsoft.Graph.Beta.ServicePrincipals.Item.OwnedObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Owners;
using Microsoft.Graph.Beta.ServicePrincipals.Item.Synchronization;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TokenIssuancePolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TokenLifetimePolicies;
using Microsoft.Graph.Beta.ServicePrincipals.Item.TransitiveMemberOf;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item {
    /// <summary>
    /// Provides operations to manage the collection of servicePrincipal entities.
    /// </summary>
    public class ServicePrincipalItemRequestBuilder {
        /// <summary>Provides operations to manage the appManagementPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public AppManagementPoliciesRequestBuilder AppManagementPolicies { get =>
            new AppManagementPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignedTo property of the microsoft.graph.servicePrincipal entity.</summary>
        public AppRoleAssignedToRequestBuilder AppRoleAssignedTo { get =>
            new AppRoleAssignedToRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the appRoleAssignments property of the microsoft.graph.servicePrincipal entity.</summary>
        public AppRoleAssignmentsRequestBuilder AppRoleAssignments { get =>
            new AppRoleAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the claimsMappingPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public ClaimsMappingPoliciesRequestBuilder ClaimsMappingPolicies { get =>
            new ClaimsMappingPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the createdObjects property of the microsoft.graph.servicePrincipal entity.</summary>
        public CreatedObjectsRequestBuilder CreatedObjects { get =>
            new CreatedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the delegatedPermissionClassifications property of the microsoft.graph.servicePrincipal entity.</summary>
        public DelegatedPermissionClassificationsRequestBuilder DelegatedPermissionClassifications { get =>
            new DelegatedPermissionClassificationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the endpoints property of the microsoft.graph.servicePrincipal entity.</summary>
        public EndpointsRequestBuilder Endpoints { get =>
            new EndpointsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the federatedIdentityCredentials property of the microsoft.graph.servicePrincipal entity.</summary>
        public FederatedIdentityCredentialsRequestBuilder FederatedIdentityCredentials { get =>
            new FederatedIdentityCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the homeRealmDiscoveryPolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public HomeRealmDiscoveryPoliciesRequestBuilder HomeRealmDiscoveryPolicies { get =>
            new HomeRealmDiscoveryPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the licenseDetails property of the microsoft.graph.servicePrincipal entity.</summary>
        public LicenseDetailsRequestBuilder LicenseDetails { get =>
            new LicenseDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the memberOf property of the microsoft.graph.servicePrincipal entity.</summary>
        public MemberOfRequestBuilder MemberOf { get =>
            new MemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the addTokenSigningCertificate method.</summary>
        public MicrosoftGraphAddTokenSigningCertificateRequestBuilder MicrosoftGraphAddTokenSigningCertificate { get =>
            new MicrosoftGraphAddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberGroups method.</summary>
        public MicrosoftGraphCheckMemberGroupsRequestBuilder MicrosoftGraphCheckMemberGroups { get =>
            new MicrosoftGraphCheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the checkMemberObjects method.</summary>
        public MicrosoftGraphCheckMemberObjectsRequestBuilder MicrosoftGraphCheckMemberObjects { get =>
            new MicrosoftGraphCheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createPasswordSingleSignOnCredentials method.</summary>
        public MicrosoftGraphCreatePasswordSingleSignOnCredentialsRequestBuilder MicrosoftGraphCreatePasswordSingleSignOnCredentials { get =>
            new MicrosoftGraphCreatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deletePasswordSingleSignOnCredentials method.</summary>
        public MicrosoftGraphDeletePasswordSingleSignOnCredentialsRequestBuilder MicrosoftGraphDeletePasswordSingleSignOnCredentials { get =>
            new MicrosoftGraphDeletePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberGroups method.</summary>
        public MicrosoftGraphGetMemberGroupsRequestBuilder MicrosoftGraphGetMemberGroups { get =>
            new MicrosoftGraphGetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getMemberObjects method.</summary>
        public MicrosoftGraphGetMemberObjectsRequestBuilder MicrosoftGraphGetMemberObjects { get =>
            new MicrosoftGraphGetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getPasswordSingleSignOnCredentials method.</summary>
        public MicrosoftGraphGetPasswordSingleSignOnCredentialsRequestBuilder MicrosoftGraphGetPasswordSingleSignOnCredentials { get =>
            new MicrosoftGraphGetPasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public MicrosoftGraphRestoreRequestBuilder MicrosoftGraphRestore { get =>
            new MicrosoftGraphRestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updatePasswordSingleSignOnCredentials method.</summary>
        public MicrosoftGraphUpdatePasswordSingleSignOnCredentialsRequestBuilder MicrosoftGraphUpdatePasswordSingleSignOnCredentials { get =>
            new MicrosoftGraphUpdatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the oauth2PermissionGrants property of the microsoft.graph.servicePrincipal entity.</summary>
        public Oauth2PermissionGrantsRequestBuilder Oauth2PermissionGrants { get =>
            new Oauth2PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the ownedObjects property of the microsoft.graph.servicePrincipal entity.</summary>
        public OwnedObjectsRequestBuilder OwnedObjects { get =>
            new OwnedObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the owners property of the microsoft.graph.servicePrincipal entity.</summary>
        public OwnersRequestBuilder Owners { get =>
            new OwnersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the synchronization property of the microsoft.graph.servicePrincipal entity.</summary>
        public SynchronizationRequestBuilder Synchronization { get =>
            new SynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenIssuancePolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public TokenIssuancePoliciesRequestBuilder TokenIssuancePolicies { get =>
            new TokenIssuancePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tokenLifetimePolicies property of the microsoft.graph.servicePrincipal entity.</summary>
        public TokenLifetimePoliciesRequestBuilder TokenLifetimePolicies { get =>
            new TokenLifetimePoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.servicePrincipal entity.</summary>
        public TransitiveMemberOfRequestBuilder TransitiveMemberOf { get =>
            new TransitiveMemberOfRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ServicePrincipalItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServicePrincipalItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServicePrincipalItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete a servicePrincipal object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/serviceprincipal-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<ServicePrincipalItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<ServicePrincipalItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/serviceprincipal-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ServicePrincipal?> GetAsync(Action<ServicePrincipalItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ServicePrincipal> GetAsync(Action<ServicePrincipalItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ServicePrincipal>(requestInfo, ServicePrincipal.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update the properties of servicePrincipal object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/serviceprincipal-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ServicePrincipal?> PatchAsync(ServicePrincipal body, Action<ServicePrincipalItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ServicePrincipal> PatchAsync(ServicePrincipal body, Action<ServicePrincipalItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ServicePrincipal>(requestInfo, ServicePrincipal.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Delete a servicePrincipal object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<ServicePrincipalItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<ServicePrincipalItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ServicePrincipalItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ServicePrincipalItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of servicePrincipal object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ServicePrincipal body, Action<ServicePrincipalItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ServicePrincipal body, Action<ServicePrincipalItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ServicePrincipalItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Retrieve the properties and relationships of a servicePrincipal object.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ServicePrincipalItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ServicePrincipalItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ServicePrincipalItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ServicePrincipalItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new ServicePrincipalItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
