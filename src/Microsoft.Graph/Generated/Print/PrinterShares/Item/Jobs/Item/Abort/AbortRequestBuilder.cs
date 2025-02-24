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
namespace Microsoft.Graph.Beta.Print.PrinterShares.Item.Jobs.Item.Abort {
    /// <summary>
    /// Provides operations to call the abort method.
    /// </summary>
    public class AbortRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new AbortRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AbortRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/printerShares/{printerShare%2Did}/jobs/{printJob%2Did}/abort", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AbortRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AbortRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/printerShares/{printerShare%2Did}/jobs/{printJob%2Did}/abort", rawUrl) {
        }
        /// <summary>
        /// Abort a print job. Only applications using application permissions can abort a print job. Aborting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created. For details about how to register a task trigger, see Extending Universal Print to support pull printing. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/printjob-abort?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(AbortPostRequestBody body, Action<AbortRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(AbortPostRequestBody body, Action<AbortRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
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
        /// Abort a print job. Only applications using application permissions can abort a print job. Aborting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created. For details about how to register a task trigger, see Extending Universal Print to support pull printing. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AbortPostRequestBody body, Action<AbortRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AbortPostRequestBody body, Action<AbortRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new AbortRequestBuilderPostRequestConfiguration();
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
        [Obsolete("The printerShares navigation property is deprecated and will stop returning data on July 31, 2023. Please use the shares navigation property instead of this. as of 2023-06/Tasks_And_Plans on 2023-06-13 and will be removed 2023-07-31")]
        public AbortRequestBuilder WithUrl(string rawUrl) {
            return new AbortRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AbortRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new abortRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public AbortRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
