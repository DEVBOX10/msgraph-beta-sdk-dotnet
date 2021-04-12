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
    /// The type DeviceManagementConfigurationPolicyRequest.
    /// </summary>
    public partial class DeviceManagementConfigurationPolicyRequest : BaseRequest, IDeviceManagementConfigurationPolicyRequest
    {
        /// <summary>
        /// Constructs a new DeviceManagementConfigurationPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceManagementConfigurationPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicy using POST.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyToCreate">The DeviceManagementConfigurationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceManagementConfigurationPolicy.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicy> CreateAsync(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<DeviceManagementConfigurationPolicy>(deviceManagementConfigurationPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified DeviceManagementConfigurationPolicy using POST and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyToCreate">The DeviceManagementConfigurationPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicy>> CreateResponseAsync(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicy>(deviceManagementConfigurationPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<DeviceManagementConfigurationPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified DeviceManagementConfigurationPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceManagementConfigurationPolicy.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<DeviceManagementConfigurationPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified DeviceManagementConfigurationPolicy and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicy using PATCH.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyToUpdate">The DeviceManagementConfigurationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceManagementConfigurationPolicy.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicy> UpdateAsync(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationPolicy>(deviceManagementConfigurationPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicy using PATCH and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyToUpdate">The DeviceManagementConfigurationPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicy>> UpdateResponseAsync(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicy>(deviceManagementConfigurationPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicy using PUT.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyToUpdate">The DeviceManagementConfigurationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<DeviceManagementConfigurationPolicy> PutAsync(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<DeviceManagementConfigurationPolicy>(deviceManagementConfigurationPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceManagementConfigurationPolicy using PUT and returns a <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/> object.
        /// </summary>
        /// <param name="deviceManagementConfigurationPolicyToUpdate">The DeviceManagementConfigurationPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{DeviceManagementConfigurationPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<DeviceManagementConfigurationPolicy>> PutResponseAsync(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<DeviceManagementConfigurationPolicy>(deviceManagementConfigurationPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyRequest Expand(Expression<Func<DeviceManagementConfigurationPolicy, object>> expandExpression)
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
        public IDeviceManagementConfigurationPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceManagementConfigurationPolicyRequest Select(Expression<Func<DeviceManagementConfigurationPolicy, object>> selectExpression)
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
        /// <param name="deviceManagementConfigurationPolicyToInitialize">The <see cref="DeviceManagementConfigurationPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceManagementConfigurationPolicy deviceManagementConfigurationPolicyToInitialize)
        {

            if (deviceManagementConfigurationPolicyToInitialize != null && deviceManagementConfigurationPolicyToInitialize.AdditionalData != null)
            {

                if (deviceManagementConfigurationPolicyToInitialize.Assignments != null && deviceManagementConfigurationPolicyToInitialize.Assignments.CurrentPage != null)
                {
                    deviceManagementConfigurationPolicyToInitialize.Assignments.AdditionalData = deviceManagementConfigurationPolicyToInitialize.AdditionalData;

                    if(deviceManagementConfigurationPolicyToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            deviceManagementConfigurationPolicyToInitialize.Assignments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (deviceManagementConfigurationPolicyToInitialize.Settings != null && deviceManagementConfigurationPolicyToInitialize.Settings.CurrentPage != null)
                {
                    deviceManagementConfigurationPolicyToInitialize.Settings.AdditionalData = deviceManagementConfigurationPolicyToInitialize.AdditionalData;

                    if(deviceManagementConfigurationPolicyToInitialize.AdditionalData.TryGetValue("settings@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            deviceManagementConfigurationPolicyToInitialize.Settings.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
