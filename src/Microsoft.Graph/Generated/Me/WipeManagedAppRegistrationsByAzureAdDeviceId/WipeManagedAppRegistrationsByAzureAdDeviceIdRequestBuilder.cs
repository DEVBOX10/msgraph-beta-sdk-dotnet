// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.Me.WipeManagedAppRegistrationsByAzureAdDeviceId {
    /// <summary>
    /// Provides operations to call the wipeManagedAppRegistrationsByAzureAdDeviceId method.
    /// </summary>
    public class WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/wipeManagedAppRegistrationsByAzureAdDeviceId", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/wipeManagedAppRegistrationsByAzureAdDeviceId", rawUrl) {
        }
        /// <summary>
        /// Issues a wipe operation on an app registration with specified aad device Id.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody body, Action<WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody body, Action<WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Issues a wipe operation on an app registration with specified aad device Id.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody body, Action<WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(WipeManagedAppRegistrationsByAzureAdDeviceIdPostRequestBody body, Action<WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder WithUrl(string rawUrl) {
            return new WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new wipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public WipeManagedAppRegistrationsByAzureAdDeviceIdRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
