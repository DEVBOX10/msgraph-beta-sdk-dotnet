// <auto-generated/>
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Instances;
using Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item.Stop;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.IdentityGovernance.AccessReviews.Definitions.Item {
    /// <summary>
    /// Provides operations to manage the definitions property of the microsoft.graph.accessReviewSet entity.
    /// </summary>
    public class AccessReviewScheduleDefinitionItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the instances property of the microsoft.graph.accessReviewScheduleDefinition entity.</summary>
        public InstancesRequestBuilder Instances { get =>
            new InstancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the stop method.</summary>
        public StopRequestBuilder Stop { get =>
            new StopRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AccessReviewScheduleDefinitionItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewScheduleDefinitionItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AccessReviewScheduleDefinitionItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccessReviewScheduleDefinitionItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Delete an accessReviewScheduleDefinition object. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewscheduledefinition-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an accessReviewScheduleDefinition object by ID. This returns all properties of the scheduled access review series except for the associated accessReviewInstances. Each accessReviewScheduleDefinition has at least one instance. An instance represents a review for a specific resource (such as a particular group&apos;s members), during one occurrence (for example, March 2021) of a recurring review. To retrieve the instances of the access review series, use the list accessReviewInstance API. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewscheduledefinition-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessReviewScheduleDefinition?> GetAsync(Action<AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessReviewScheduleDefinition> GetAsync(Action<AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReviewScheduleDefinition>(requestInfo, AccessReviewScheduleDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update an existing accessReviewScheduleDefinition object to change one or more of its properties.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/accessreviewscheduledefinition-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AccessReviewScheduleDefinition?> PatchAsync(AccessReviewScheduleDefinition body, Action<AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AccessReviewScheduleDefinition> PatchAsync(AccessReviewScheduleDefinition body, Action<AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<AccessReviewScheduleDefinition>(requestInfo, AccessReviewScheduleDefinition.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete an accessReviewScheduleDefinition object. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json, application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve an accessReviewScheduleDefinition object by ID. This returns all properties of the scheduled access review series except for the associated accessReviewInstances. Each accessReviewScheduleDefinition has at least one instance. An instance represents a review for a specific resource (such as a particular group&apos;s members), during one occurrence (for example, March 2021) of a recurring review. To retrieve the instances of the access review series, use the list accessReviewInstance API. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            return requestInfo;
        }
        /// <summary>
        /// Update an existing accessReviewScheduleDefinition object to change one or more of its properties.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AccessReviewScheduleDefinition body, Action<AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AccessReviewScheduleDefinition body, Action<AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json;q=1");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AccessReviewScheduleDefinitionItemRequestBuilder WithUrl(string rawUrl) {
            return new AccessReviewScheduleDefinitionItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewScheduleDefinitionItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Retrieve an accessReviewScheduleDefinition object by ID. This returns all properties of the scheduled access review series except for the associated accessReviewInstances. Each accessReviewScheduleDefinition has at least one instance. An instance represents a review for a specific resource (such as a particular group&apos;s members), during one occurrence (for example, March 2021) of a recurring review. To retrieve the instances of the access review series, use the list accessReviewInstance API. This API is available in the following national cloud deployments.
        /// </summary>
        public class AccessReviewScheduleDefinitionItemRequestBuilderGetQueryParameters {
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
        public class AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AccessReviewScheduleDefinitionItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new AccessReviewScheduleDefinitionItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewScheduleDefinitionItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public AccessReviewScheduleDefinitionItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
