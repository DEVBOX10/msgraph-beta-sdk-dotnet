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
    /// The type DeviceCustomAttributeShellScriptRequest.
    /// </summary>
    public partial class DeviceCustomAttributeShellScriptRequest : BaseRequest, IDeviceCustomAttributeShellScriptRequest
    {
        /// <summary>
        /// Constructs a new DeviceCustomAttributeShellScriptRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceCustomAttributeShellScriptRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceCustomAttributeShellScript using POST.
        /// </summary>
        /// <param name="deviceCustomAttributeShellScriptToCreate">The DeviceCustomAttributeShellScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCustomAttributeShellScript.</returns>
        public async System.Threading.Tasks.Task<DeviceCustomAttributeShellScript> CreateAsync(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceCustomAttributeShellScript>(deviceCustomAttributeShellScriptToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceCustomAttributeShellScript using POST and returns a <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object.
        /// </summary>
        /// <param name="deviceCustomAttributeShellScriptToCreate">The DeviceCustomAttributeShellScript to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCustomAttributeShellScript>> CreateResponseAsync(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceCustomAttributeShellScript>(deviceCustomAttributeShellScriptToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceCustomAttributeShellScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceCustomAttributeShellScript>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceCustomAttributeShellScript and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceCustomAttributeShellScript.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCustomAttributeShellScript.</returns>
        public async System.Threading.Tasks.Task<DeviceCustomAttributeShellScript> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceCustomAttributeShellScript>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceCustomAttributeShellScript and returns a <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCustomAttributeShellScript>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceCustomAttributeShellScript>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceCustomAttributeShellScript using PATCH.
        /// </summary>
        /// <param name="deviceCustomAttributeShellScriptToUpdate">The DeviceCustomAttributeShellScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceCustomAttributeShellScript.</returns>
        public async System.Threading.Tasks.Task<DeviceCustomAttributeShellScript> UpdateAsync(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceCustomAttributeShellScript>(deviceCustomAttributeShellScriptToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCustomAttributeShellScript using PATCH and returns a <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object.
        /// </summary>
        /// <param name="deviceCustomAttributeShellScriptToUpdate">The DeviceCustomAttributeShellScript to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCustomAttributeShellScript>> UpdateResponseAsync(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceCustomAttributeShellScript>(deviceCustomAttributeShellScriptToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceCustomAttributeShellScript using PUT.
        /// </summary>
        /// <param name="deviceCustomAttributeShellScriptToUpdate">The DeviceCustomAttributeShellScript object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceCustomAttributeShellScript> PutAsync(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceCustomAttributeShellScript>(deviceCustomAttributeShellScriptToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceCustomAttributeShellScript using PUT and returns a <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/> object.
        /// </summary>
        /// <param name="deviceCustomAttributeShellScriptToUpdate">The DeviceCustomAttributeShellScript object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceCustomAttributeShellScript}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceCustomAttributeShellScript>> PutResponseAsync(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceCustomAttributeShellScript>(deviceCustomAttributeShellScriptToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCustomAttributeShellScriptRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCustomAttributeShellScriptRequest Expand(Expression<Func<DeviceCustomAttributeShellScript, object>> expandExpression)
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
        public IDeviceCustomAttributeShellScriptRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceCustomAttributeShellScriptRequest Select(Expression<Func<DeviceCustomAttributeShellScript, object>> selectExpression)
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
        /// <param name="deviceCustomAttributeShellScriptToInitialize">The <see cref="DeviceCustomAttributeShellScript"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceCustomAttributeShellScript deviceCustomAttributeShellScriptToInitialize)
        {

            if (deviceCustomAttributeShellScriptToInitialize != null && deviceCustomAttributeShellScriptToInitialize.AdditionalData != null)
            {

                if (deviceCustomAttributeShellScriptToInitialize.Assignments != null && deviceCustomAttributeShellScriptToInitialize.Assignments.CurrentPage != null)
                {
                    deviceCustomAttributeShellScriptToInitialize.Assignments.AdditionalData = deviceCustomAttributeShellScriptToInitialize.AdditionalData;

                    if(deviceCustomAttributeShellScriptToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            deviceCustomAttributeShellScriptToInitialize.Assignments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (deviceCustomAttributeShellScriptToInitialize.DeviceRunStates != null && deviceCustomAttributeShellScriptToInitialize.DeviceRunStates.CurrentPage != null)
                {
                    deviceCustomAttributeShellScriptToInitialize.DeviceRunStates.AdditionalData = deviceCustomAttributeShellScriptToInitialize.AdditionalData;

                    if(deviceCustomAttributeShellScriptToInitialize.AdditionalData.TryGetValue("deviceRunStates@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            deviceCustomAttributeShellScriptToInitialize.DeviceRunStates.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (deviceCustomAttributeShellScriptToInitialize.GroupAssignments != null && deviceCustomAttributeShellScriptToInitialize.GroupAssignments.CurrentPage != null)
                {
                    deviceCustomAttributeShellScriptToInitialize.GroupAssignments.AdditionalData = deviceCustomAttributeShellScriptToInitialize.AdditionalData;

                    if(deviceCustomAttributeShellScriptToInitialize.AdditionalData.TryGetValue("groupAssignments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            deviceCustomAttributeShellScriptToInitialize.GroupAssignments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (deviceCustomAttributeShellScriptToInitialize.UserRunStates != null && deviceCustomAttributeShellScriptToInitialize.UserRunStates.CurrentPage != null)
                {
                    deviceCustomAttributeShellScriptToInitialize.UserRunStates.AdditionalData = deviceCustomAttributeShellScriptToInitialize.AdditionalData;

                    if(deviceCustomAttributeShellScriptToInitialize.AdditionalData.TryGetValue("userRunStates@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            deviceCustomAttributeShellScriptToInitialize.UserRunStates.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
