// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type DeviceCompliancePolicyHasPayloadLinksRequest.
    /// </summary>
    public partial class DeviceCompliancePolicyHasPayloadLinksRequest : BaseRequest, IDeviceCompliancePolicyHasPayloadLinksRequest
    {
        /// <summary>
        /// Constructs a new DeviceCompliancePolicyHasPayloadLinksRequest.
        /// </summary>
        public DeviceCompliancePolicyHasPayloadLinksRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.RequestBody = new DeviceCompliancePolicyHasPayloadLinksRequestBody();
        }

        /// <summary>
        /// Gets the request body.
        /// </summary>
        public DeviceCompliancePolicyHasPayloadLinksRequestBody RequestBody { get; private set; }

        /// <summary>
        /// Issues the POST request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        public async System.Threading.Tasks.Task<IDeviceCompliancePolicyHasPayloadLinksCollectionPage> PostAsync(
            CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.POST;
            var response = await this.SendAsync<DeviceCompliancePolicyHasPayloadLinksCollectionResponse>(this.RequestBody, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
                    response.Value.AdditionalData = response.AdditionalData;

                    if(response.AdditionalData.TryGetValue("@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            response.Value.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Issues the POST request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCompliancePolicyHasPayloadLinksCollectionResponse>> PostResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceCompliancePolicyHasPayloadLinksCollectionResponse>(this.RequestBody, cancellationToken);
        }



        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyHasPayloadLinksRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyHasPayloadLinksRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyHasPayloadLinksRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyHasPayloadLinksRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyHasPayloadLinksRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCompliancePolicyHasPayloadLinksRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
