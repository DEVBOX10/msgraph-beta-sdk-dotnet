using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Application;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Count;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Device;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Group;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Item;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.OrgContact;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.ServicePrincipal;
using Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.User;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf {
    /// <summary>
    /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.device entity.
    /// </summary>
    public class TransitiveMemberOfRequestBuilder {
        /// <summary>Casts the previous resource to application.</summary>
        public ApplicationRequestBuilder Application { get =>
            new ApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count { get =>
            new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to device.</summary>
        public Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Device.DeviceRequestBuilder Device { get =>
            new Microsoft.Graph.Beta.Me.Authentication.PasswordlessMicrosoftAuthenticatorMethods.Item.Device.TransitiveMemberOf.Device.DeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public GroupRequestBuilder Group { get =>
            new GroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to orgContact.</summary>
        public OrgContactRequestBuilder OrgContact { get =>
            new OrgContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public ServicePrincipalRequestBuilder ServicePrincipal { get =>
            new ServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>Casts the previous resource to user.</summary>
        public UserRequestBuilder User { get =>
            new UserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the transitiveMemberOf property of the microsoft.graph.device entity.</summary>
        public DirectoryObjectItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("directoryObject%2Did", position);
            return new DirectoryObjectItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new TransitiveMemberOfRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitiveMemberOfRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication/passwordlessMicrosoftAuthenticatorMethods/{passwordlessMicrosoftAuthenticatorAuthenticationMethod%2Did}/device/transitiveMemberOf{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new TransitiveMemberOfRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitiveMemberOfRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/me/authentication/passwordlessMicrosoftAuthenticatorMethods/{passwordlessMicrosoftAuthenticatorAuthenticationMethod%2Did}/device/transitiveMemberOf{?%24top,%24skip,%24search,%24filter,%24count,%24orderby,%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Groups and administrative units that this device is a member of. This operation is transitive. Supports $expand.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/device-list-transitivememberof?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public async Task<DirectoryObjectCollectionResponse> GetAsync(Action<TransitiveMemberOfRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DirectoryObjectCollectionResponse>(requestInfo, DirectoryObjectCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Groups and administrative units that this device is a member of. This operation is transitive. Supports $expand.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        public RequestInformation ToGetRequestInformation(Action<TransitiveMemberOfRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new TransitiveMemberOfRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Groups and administrative units that this device is a member of. This operation is transitive. Supports $expand.
        /// </summary>
        public class TransitiveMemberOfRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Filter items by property values</summary>
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
            /// <summary>Order items by property values</summary>
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
            /// <summary>Search items by search phrases</summary>
            [QueryParameter("%24search")]
            public string Search { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class TransitiveMemberOfRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public TransitiveMemberOfRequestBuilderGetQueryParameters QueryParameters { get; set; } = new TransitiveMemberOfRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new transitiveMemberOfRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public TransitiveMemberOfRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
