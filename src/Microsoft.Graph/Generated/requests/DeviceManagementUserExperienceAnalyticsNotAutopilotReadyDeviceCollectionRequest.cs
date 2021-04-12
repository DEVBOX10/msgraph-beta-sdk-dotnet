// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest.
    /// </summary>
    public partial class DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest : BaseRequest, IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified UserExperienceAnalyticsNotAutopilotReadyDevice to the collection via POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsNotAutopilotReadyDevice">The UserExperienceAnalyticsNotAutopilotReadyDevice to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsNotAutopilotReadyDevice.</returns>
        public System.Threading.Tasks.Task<UserExperienceAnalyticsNotAutopilotReadyDevice> AddAsync(UserExperienceAnalyticsNotAutopilotReadyDevice userExperienceAnalyticsNotAutopilotReadyDevice, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsync<UserExperienceAnalyticsNotAutopilotReadyDevice>(userExperienceAnalyticsNotAutopilotReadyDevice, cancellationToken);
        }

        /// <summary>
        /// Adds the specified UserExperienceAnalyticsNotAutopilotReadyDevice to the collection via POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsNotAutopilotReadyDevice}"/> object of the request.
        /// </summary>
        /// <param name="userExperienceAnalyticsNotAutopilotReadyDevice">The UserExperienceAnalyticsNotAutopilotReadyDevice to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsNotAutopilotReadyDevice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsNotAutopilotReadyDevice>> AddResponseAsync(UserExperienceAnalyticsNotAutopilotReadyDevice userExperienceAnalyticsNotAutopilotReadyDevice, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<UserExperienceAnalyticsNotAutopilotReadyDevice>(userExperienceAnalyticsNotAutopilotReadyDevice, cancellationToken);
        }


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        public async System.Threading.Tasks.Task<IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionPage> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var response = await this.SendAsync<DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionResponse>(null, cancellationToken).ConfigureAwait(false);
            if (response != null && response.Value != null && response.Value.CurrentPage != null)
            {
                if (response.AdditionalData != null)
                {
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
                    // Copy the additional data collection to the page itself so that information is not lost
                    response.Value.AdditionalData = response.AdditionalData;
                }

                return response.Value;
            }

            return null;
        }

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionResponse}"/> object.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionResponse>(null, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Expand(Expression<Func<UserExperienceAnalyticsNotAutopilotReadyDevice, object>> expandExpression)
        {
            if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Select(Expression<Func<UserExperienceAnalyticsNotAutopilotReadyDevice, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Top(int value)
        {
            this.QueryOptions.Add(new QueryOption("$top", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Filter(string value)
        {
            this.QueryOptions.Add(new QueryOption("$filter", value));
            return this;
        }

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest Skip(int value)
        {
            this.QueryOptions.Add(new QueryOption("$skip", value.ToString()));
            return this;
        }

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementUserExperienceAnalyticsNotAutopilotReadyDeviceCollectionRequest OrderBy(string value)
        {
            this.QueryOptions.Add(new QueryOption("$orderby", value));
            return this;
        }
    }
}
