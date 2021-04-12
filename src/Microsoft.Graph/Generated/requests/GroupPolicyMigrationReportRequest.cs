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
    /// The type GroupPolicyMigrationReportRequest.
    /// </summary>
    public partial class GroupPolicyMigrationReportRequest : BaseRequest, IGroupPolicyMigrationReportRequest
    {
        /// <summary>
        /// Constructs a new GroupPolicyMigrationReportRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public GroupPolicyMigrationReportRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified GroupPolicyMigrationReport using POST.
        /// </summary>
        /// <param name="groupPolicyMigrationReportToCreate">The GroupPolicyMigrationReport to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupPolicyMigrationReport.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyMigrationReport> CreateAsync(GroupPolicyMigrationReport groupPolicyMigrationReportToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<GroupPolicyMigrationReport>(groupPolicyMigrationReportToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified GroupPolicyMigrationReport using POST and returns a <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object.
        /// </summary>
        /// <param name="groupPolicyMigrationReportToCreate">The GroupPolicyMigrationReport to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyMigrationReport>> CreateResponseAsync(GroupPolicyMigrationReport groupPolicyMigrationReportToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<GroupPolicyMigrationReport>(groupPolicyMigrationReportToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyMigrationReport.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<GroupPolicyMigrationReport>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified GroupPolicyMigrationReport and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified GroupPolicyMigrationReport.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupPolicyMigrationReport.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyMigrationReport> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<GroupPolicyMigrationReport>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified GroupPolicyMigrationReport and returns a <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyMigrationReport>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<GroupPolicyMigrationReport>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyMigrationReport using PATCH.
        /// </summary>
        /// <param name="groupPolicyMigrationReportToUpdate">The GroupPolicyMigrationReport to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupPolicyMigrationReport.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyMigrationReport> UpdateAsync(GroupPolicyMigrationReport groupPolicyMigrationReportToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<GroupPolicyMigrationReport>(groupPolicyMigrationReportToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyMigrationReport using PATCH and returns a <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object.
        /// </summary>
        /// <param name="groupPolicyMigrationReportToUpdate">The GroupPolicyMigrationReport to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyMigrationReport>> UpdateResponseAsync(GroupPolicyMigrationReport groupPolicyMigrationReportToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<GroupPolicyMigrationReport>(groupPolicyMigrationReportToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified GroupPolicyMigrationReport using PUT.
        /// </summary>
        /// <param name="groupPolicyMigrationReportToUpdate">The GroupPolicyMigrationReport object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<GroupPolicyMigrationReport> PutAsync(GroupPolicyMigrationReport groupPolicyMigrationReportToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<GroupPolicyMigrationReport>(groupPolicyMigrationReportToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified GroupPolicyMigrationReport using PUT and returns a <see cref="GraphResponse{GroupPolicyMigrationReport}"/> object.
        /// </summary>
        /// <param name="groupPolicyMigrationReportToUpdate">The GroupPolicyMigrationReport object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{GroupPolicyMigrationReport}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<GroupPolicyMigrationReport>> PutResponseAsync(GroupPolicyMigrationReport groupPolicyMigrationReportToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<GroupPolicyMigrationReport>(groupPolicyMigrationReportToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyMigrationReportRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyMigrationReportRequest Expand(Expression<Func<GroupPolicyMigrationReport, object>> expandExpression)
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
        public IGroupPolicyMigrationReportRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IGroupPolicyMigrationReportRequest Select(Expression<Func<GroupPolicyMigrationReport, object>> selectExpression)
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
        /// <param name="groupPolicyMigrationReportToInitialize">The <see cref="GroupPolicyMigrationReport"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(GroupPolicyMigrationReport groupPolicyMigrationReportToInitialize)
        {

            if (groupPolicyMigrationReportToInitialize != null && groupPolicyMigrationReportToInitialize.AdditionalData != null)
            {

                if (groupPolicyMigrationReportToInitialize.GroupPolicySettingMappings != null && groupPolicyMigrationReportToInitialize.GroupPolicySettingMappings.CurrentPage != null)
                {
                    groupPolicyMigrationReportToInitialize.GroupPolicySettingMappings.AdditionalData = groupPolicyMigrationReportToInitialize.AdditionalData;

                    if(groupPolicyMigrationReportToInitialize.AdditionalData.TryGetValue("groupPolicySettingMappings@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            groupPolicyMigrationReportToInitialize.GroupPolicySettingMappings.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (groupPolicyMigrationReportToInitialize.UnsupportedGroupPolicyExtensions != null && groupPolicyMigrationReportToInitialize.UnsupportedGroupPolicyExtensions.CurrentPage != null)
                {
                    groupPolicyMigrationReportToInitialize.UnsupportedGroupPolicyExtensions.AdditionalData = groupPolicyMigrationReportToInitialize.AdditionalData;

                    if(groupPolicyMigrationReportToInitialize.AdditionalData.TryGetValue("unsupportedGroupPolicyExtensions@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            groupPolicyMigrationReportToInitialize.UnsupportedGroupPolicyExtensions.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
