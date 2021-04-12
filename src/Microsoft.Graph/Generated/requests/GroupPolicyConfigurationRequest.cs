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
    /// The type GroupPolicyConfigurationRequest.
    /// </summary>
    public partial class GroupPolicyConfigurationRequest : BaseRequest, IGroupPolicyConfigurationRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyConfiguration using POST.
        /// </summary>
        /// <param name="groupPolicyConfigurationToCreate">The GroupPolicyConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyConfiguration.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfiguration> CreateAsync(GroupPolicyConfiguration groupPolicyConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyConfiguration>(groupPolicyConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyConfiguration using POST and returns a <see cref="GraphResponse{GroupPolicyConfiguration}"/> object.
        /// </summary>
        /// <param name="groupPolicyConfigurationToCreate">The GroupPolicyConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfiguration>> CreateResponseAsync(GroupPolicyConfiguration groupPolicyConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfiguration>(groupPolicyConfigurationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyConfiguration.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfiguration> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyConfiguration and returns a <see cref="GraphResponse{GroupPolicyConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfiguration>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfiguration using PATCH.
        /// </summary>
        /// <param name="groupPolicyConfigurationToUpdate">The GroupPolicyConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyConfiguration.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfiguration> UpdateAsync(GroupPolicyConfiguration groupPolicyConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyConfiguration>(groupPolicyConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfiguration using PATCH and returns a <see cref="GraphResponse{GroupPolicyConfiguration}"/> object.
        /// </summary>
        /// <param name="groupPolicyConfigurationToUpdate">The GroupPolicyConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyConfiguration}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfiguration>> UpdateResponseAsync(GroupPolicyConfiguration groupPolicyConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfiguration>(groupPolicyConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfiguration using PUT.
        /// </summary>
        /// <param name="groupPolicyConfigurationToUpdate">The GroupPolicyConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyConfiguration> PutAsync(GroupPolicyConfiguration groupPolicyConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyConfiguration>(groupPolicyConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyConfiguration using PUT and returns a <see cref="GraphResponse{GroupPolicyConfiguration}"/> object.
        /// </summary>
        /// <param name="groupPolicyConfigurationToUpdate">The GroupPolicyConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyConfiguration}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyConfiguration>> PutResponseAsync(GroupPolicyConfiguration groupPolicyConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyConfiguration>(groupPolicyConfigurationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyConfigurationRequest Expand(Expression<Func<GroupPolicyConfiguration, object>> expandExpression)
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
        public IGroupPolicyConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyConfigurationRequest Select(Expression<Func<GroupPolicyConfiguration, object>> selectExpression)
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
        /// <param name="groupPolicyConfigurationToInitialize">The <see cref="GroupPolicyConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyConfiguration groupPolicyConfigurationToInitialize)
        {

            if (groupPolicyConfigurationToInitialize != null && groupPolicyConfigurationToInitialize.AdditionalData != null)
            {

                if (groupPolicyConfigurationToInitialize.Assignments != null && groupPolicyConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    groupPolicyConfigurationToInitialize.Assignments.AdditionalData = groupPolicyConfigurationToInitialize.AdditionalData;

                    if(groupPolicyConfigurationToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            groupPolicyConfigurationToInitialize.Assignments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (groupPolicyConfigurationToInitialize.DefinitionValues != null && groupPolicyConfigurationToInitialize.DefinitionValues.CurrentPage != null)
                {
                    groupPolicyConfigurationToInitialize.DefinitionValues.AdditionalData = groupPolicyConfigurationToInitialize.AdditionalData;

                    if(groupPolicyConfigurationToInitialize.AdditionalData.TryGetValue("definitionValues@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            groupPolicyConfigurationToInitialize.DefinitionValues.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
