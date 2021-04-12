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
    /// The type IdentityProtectionRootRequest.
    /// </summary>
    public partial class IdentityProtectionRootRequest : BaseRequest, IIdentityProtectionRootRequest
    {
        /// <summary>
        /// Constructs a new IdentityProtectionRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public IdentityProtectionRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified IdentityProtectionRoot using POST.
        /// </summary>
        /// <param name="identityProtectionRootToCreate">The IdentityProtectionRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityProtectionRoot.</returns>
        public async System.Threading.Tasks.Task<IdentityProtectionRoot> CreateAsync(IdentityProtectionRoot identityProtectionRootToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<IdentityProtectionRoot>(identityProtectionRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified IdentityProtectionRoot using POST and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="identityProtectionRootToCreate">The IdentityProtectionRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityProtectionRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> CreateResponseAsync(IdentityProtectionRoot identityProtectionRootToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<IdentityProtectionRoot>(identityProtectionRootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified IdentityProtectionRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<IdentityProtectionRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified IdentityProtectionRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified IdentityProtectionRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityProtectionRoot.</returns>
        public async System.Threading.Tasks.Task<IdentityProtectionRoot> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<IdentityProtectionRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified IdentityProtectionRoot and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityProtectionRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<IdentityProtectionRoot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PATCH.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityProtectionRoot.</returns>
        public async System.Threading.Tasks.Task<IdentityProtectionRoot> UpdateAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<IdentityProtectionRoot>(identityProtectionRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PATCH and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityProtectionRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> UpdateResponseAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<IdentityProtectionRoot>(identityProtectionRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PUT.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<IdentityProtectionRoot> PutAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<IdentityProtectionRoot>(identityProtectionRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified IdentityProtectionRoot using PUT and returns a <see cref="GraphResponse{IdentityProtectionRoot}"/> object.
        /// </summary>
        /// <param name="identityProtectionRootToUpdate">The IdentityProtectionRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{IdentityProtectionRoot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<IdentityProtectionRoot>> PutResponseAsync(IdentityProtectionRoot identityProtectionRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<IdentityProtectionRoot>(identityProtectionRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityProtectionRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityProtectionRootRequest Expand(Expression<Func<IdentityProtectionRoot, object>> expandExpression)
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
        public IIdentityProtectionRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IIdentityProtectionRootRequest Select(Expression<Func<IdentityProtectionRoot, object>> selectExpression)
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
        /// <param name="identityProtectionRootToInitialize">The <see cref="IdentityProtectionRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(IdentityProtectionRoot identityProtectionRootToInitialize)
        {

            if (identityProtectionRootToInitialize != null && identityProtectionRootToInitialize.AdditionalData != null)
            {

                if (identityProtectionRootToInitialize.RiskDetections != null && identityProtectionRootToInitialize.RiskDetections.CurrentPage != null)
                {
                    identityProtectionRootToInitialize.RiskDetections.AdditionalData = identityProtectionRootToInitialize.AdditionalData;

                    if(identityProtectionRootToInitialize.AdditionalData.TryGetValue("riskDetections@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            identityProtectionRootToInitialize.RiskDetections.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (identityProtectionRootToInitialize.RiskyUsers != null && identityProtectionRootToInitialize.RiskyUsers.CurrentPage != null)
                {
                    identityProtectionRootToInitialize.RiskyUsers.AdditionalData = identityProtectionRootToInitialize.AdditionalData;

                    if(identityProtectionRootToInitialize.AdditionalData.TryGetValue("riskyUsers@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            identityProtectionRootToInitialize.RiskyUsers.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
