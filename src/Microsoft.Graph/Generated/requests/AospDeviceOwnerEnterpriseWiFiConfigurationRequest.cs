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
    /// The type AospDeviceOwnerEnterpriseWiFiConfigurationRequest.
    /// </summary>
    public partial class AospDeviceOwnerEnterpriseWiFiConfigurationRequest : BaseRequest, IAospDeviceOwnerEnterpriseWiFiConfigurationRequest
    {
        /// <summary>
        /// Constructs a new AospDeviceOwnerEnterpriseWiFiConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AospDeviceOwnerEnterpriseWiFiConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AospDeviceOwnerEnterpriseWiFiConfiguration using POST.
        /// </summary>
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AospDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AospDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerEnterpriseWiFiConfiguration> CreateAsync(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AospDeviceOwnerEnterpriseWiFiConfiguration>(aospDeviceOwnerEnterpriseWiFiConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AospDeviceOwnerEnterpriseWiFiConfiguration using POST and returns a <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToCreate">The AospDeviceOwnerEnterpriseWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>> CreateResponseAsync(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>(aospDeviceOwnerEnterpriseWiFiConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AospDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AospDeviceOwnerEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AospDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AospDeviceOwnerEnterpriseWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AospDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerEnterpriseWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AospDeviceOwnerEnterpriseWiFiConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AospDeviceOwnerEnterpriseWiFiConfiguration and returns a <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerEnterpriseWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AospDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AospDeviceOwnerEnterpriseWiFiConfiguration.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerEnterpriseWiFiConfiguration> UpdateAsync(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AospDeviceOwnerEnterpriseWiFiConfiguration>(aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerEnterpriseWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AospDeviceOwnerEnterpriseWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>> UpdateResponseAsync(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>(aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerEnterpriseWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AospDeviceOwnerEnterpriseWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AospDeviceOwnerEnterpriseWiFiConfiguration> PutAsync(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AospDeviceOwnerEnterpriseWiFiConfiguration>(aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AospDeviceOwnerEnterpriseWiFiConfiguration using PUT and returns a <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate">The AospDeviceOwnerEnterpriseWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AospDeviceOwnerEnterpriseWiFiConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>> PutResponseAsync(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AospDeviceOwnerEnterpriseWiFiConfiguration>(aospDeviceOwnerEnterpriseWiFiConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAospDeviceOwnerEnterpriseWiFiConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAospDeviceOwnerEnterpriseWiFiConfigurationRequest Expand(Expression<Func<AospDeviceOwnerEnterpriseWiFiConfiguration, object>> expandExpression)
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
        public IAospDeviceOwnerEnterpriseWiFiConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAospDeviceOwnerEnterpriseWiFiConfigurationRequest Select(Expression<Func<AospDeviceOwnerEnterpriseWiFiConfiguration, object>> selectExpression)
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
        /// <param name="aospDeviceOwnerEnterpriseWiFiConfigurationToInitialize">The <see cref="AospDeviceOwnerEnterpriseWiFiConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AospDeviceOwnerEnterpriseWiFiConfiguration aospDeviceOwnerEnterpriseWiFiConfigurationToInitialize)
        {

        }
    }
}
