// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WindowsDefenderApplicationControlSupplementalPolicyRequest.
    /// </summary>
    public partial class WindowsDefenderApplicationControlSupplementalPolicyRequest : BaseRequest, IWindowsDefenderApplicationControlSupplementalPolicyRequest
    {
        /// <summary>
        /// Constructs a new WindowsDefenderApplicationControlSupplementalPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WindowsDefenderApplicationControlSupplementalPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WindowsDefenderApplicationControlSupplementalPolicy using POST.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToCreate">The WindowsDefenderApplicationControlSupplementalPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsDefenderApplicationControlSupplementalPolicy.</returns>
        public async System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicy> CreateAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<WindowsDefenderApplicationControlSupplementalPolicy>(windowsDefenderApplicationControlSupplementalPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified WindowsDefenderApplicationControlSupplementalPolicy using POST and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToCreate">The WindowsDefenderApplicationControlSupplementalPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>> CreateResponseAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>(windowsDefenderApplicationControlSupplementalPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified WindowsDefenderApplicationControlSupplementalPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<WindowsDefenderApplicationControlSupplementalPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified WindowsDefenderApplicationControlSupplementalPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified WindowsDefenderApplicationControlSupplementalPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsDefenderApplicationControlSupplementalPolicy.</returns>
        public async System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<WindowsDefenderApplicationControlSupplementalPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified WindowsDefenderApplicationControlSupplementalPolicy and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicy using PATCH.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToUpdate">The WindowsDefenderApplicationControlSupplementalPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsDefenderApplicationControlSupplementalPolicy.</returns>
        public async System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicy> UpdateAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<WindowsDefenderApplicationControlSupplementalPolicy>(windowsDefenderApplicationControlSupplementalPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicy using PATCH and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToUpdate">The WindowsDefenderApplicationControlSupplementalPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>> UpdateResponseAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>(windowsDefenderApplicationControlSupplementalPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicy using PUT.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToUpdate">The WindowsDefenderApplicationControlSupplementalPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<WindowsDefenderApplicationControlSupplementalPolicy> PutAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<WindowsDefenderApplicationControlSupplementalPolicy>(windowsDefenderApplicationControlSupplementalPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified WindowsDefenderApplicationControlSupplementalPolicy using PUT and returns a <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/> object.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToUpdate">The WindowsDefenderApplicationControlSupplementalPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{WindowsDefenderApplicationControlSupplementalPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>> PutResponseAsync(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<WindowsDefenderApplicationControlSupplementalPolicy>(windowsDefenderApplicationControlSupplementalPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDefenderApplicationControlSupplementalPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDefenderApplicationControlSupplementalPolicyRequest Expand(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicy, object>> expandExpression)
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
        public IWindowsDefenderApplicationControlSupplementalPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindowsDefenderApplicationControlSupplementalPolicyRequest Select(Expression<Func<WindowsDefenderApplicationControlSupplementalPolicy, object>> selectExpression)
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
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="windowsDefenderApplicationControlSupplementalPolicyToInitialize">The <see cref="WindowsDefenderApplicationControlSupplementalPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WindowsDefenderApplicationControlSupplementalPolicy windowsDefenderApplicationControlSupplementalPolicyToInitialize)
        {

            if (windowsDefenderApplicationControlSupplementalPolicyToInitialize != null && windowsDefenderApplicationControlSupplementalPolicyToInitialize.AdditionalData != null)
            {

                if (windowsDefenderApplicationControlSupplementalPolicyToInitialize.Assignments != null && windowsDefenderApplicationControlSupplementalPolicyToInitialize.Assignments.CurrentPage != null)
                {
                    windowsDefenderApplicationControlSupplementalPolicyToInitialize.Assignments.AdditionalData = windowsDefenderApplicationControlSupplementalPolicyToInitialize.AdditionalData;

                    if(windowsDefenderApplicationControlSupplementalPolicyToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            windowsDefenderApplicationControlSupplementalPolicyToInitialize.Assignments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (windowsDefenderApplicationControlSupplementalPolicyToInitialize.DeviceStatuses != null && windowsDefenderApplicationControlSupplementalPolicyToInitialize.DeviceStatuses.CurrentPage != null)
                {
                    windowsDefenderApplicationControlSupplementalPolicyToInitialize.DeviceStatuses.AdditionalData = windowsDefenderApplicationControlSupplementalPolicyToInitialize.AdditionalData;

                    if(windowsDefenderApplicationControlSupplementalPolicyToInitialize.AdditionalData.TryGetValue("deviceStatuses@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            windowsDefenderApplicationControlSupplementalPolicyToInitialize.DeviceStatuses.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
