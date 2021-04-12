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
    /// The type PolicyRootRequest.
    /// </summary>
    public partial class PolicyRootRequest : BaseRequest, IPolicyRootRequest
    {
        /// <summary>
        /// Constructs a new PolicyRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PolicyRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PolicyRoot using POST.
        /// </summary>
        /// <param name="policyRootToCreate">The PolicyRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PolicyRoot.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> CreateAsync(PolicyRoot policyRootToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<PolicyRoot>(policyRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PolicyRoot using POST and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToCreate">The PolicyRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> CreateResponseAsync(PolicyRoot policyRootToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<PolicyRoot>(policyRootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PolicyRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PolicyRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PolicyRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PolicyRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PolicyRoot.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<PolicyRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PolicyRoot and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<PolicyRoot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PATCH.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PolicyRoot.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> UpdateAsync(PolicyRoot policyRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<PolicyRoot>(policyRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PATCH and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PolicyRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> UpdateResponseAsync(PolicyRoot policyRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<PolicyRoot>(policyRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PUT.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<PolicyRoot> PutAsync(PolicyRoot policyRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<PolicyRoot>(policyRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PolicyRoot using PUT and returns a <see cref="GraphResponse{PolicyRoot}"/> object.
        /// </summary>
        /// <param name="policyRootToUpdate">The PolicyRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{PolicyRoot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PolicyRoot>> PutResponseAsync(PolicyRoot policyRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<PolicyRoot>(policyRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicyRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicyRootRequest Expand(Expression<Func<PolicyRoot, object>> expandExpression)
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
        public IPolicyRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPolicyRootRequest Select(Expression<Func<PolicyRoot, object>> selectExpression)
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
        /// <param name="policyRootToInitialize">The <see cref="PolicyRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PolicyRoot policyRootToInitialize)
        {

            if (policyRootToInitialize != null && policyRootToInitialize.AdditionalData != null)
            {

                if (policyRootToInitialize.ActivityBasedTimeoutPolicies != null && policyRootToInitialize.ActivityBasedTimeoutPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.ActivityBasedTimeoutPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("activityBasedTimeoutPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.ActivityBasedTimeoutPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.AuthorizationPolicy != null && policyRootToInitialize.AuthorizationPolicy.CurrentPage != null)
                {
                    policyRootToInitialize.AuthorizationPolicy.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("authorizationPolicy@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.AuthorizationPolicy.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.ClaimsMappingPolicies != null && policyRootToInitialize.ClaimsMappingPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.ClaimsMappingPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("claimsMappingPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.ClaimsMappingPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.HomeRealmDiscoveryPolicies != null && policyRootToInitialize.HomeRealmDiscoveryPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.HomeRealmDiscoveryPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("homeRealmDiscoveryPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.HomeRealmDiscoveryPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.PermissionGrantPolicies != null && policyRootToInitialize.PermissionGrantPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.PermissionGrantPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("permissionGrantPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.PermissionGrantPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.PrivateLinkResourcePolicies != null && policyRootToInitialize.PrivateLinkResourcePolicies.CurrentPage != null)
                {
                    policyRootToInitialize.PrivateLinkResourcePolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("privateLinkResourcePolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.PrivateLinkResourcePolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.TokenIssuancePolicies != null && policyRootToInitialize.TokenIssuancePolicies.CurrentPage != null)
                {
                    policyRootToInitialize.TokenIssuancePolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("tokenIssuancePolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.TokenIssuancePolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.TokenLifetimePolicies != null && policyRootToInitialize.TokenLifetimePolicies.CurrentPage != null)
                {
                    policyRootToInitialize.TokenLifetimePolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("tokenLifetimePolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.TokenLifetimePolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.FeatureRolloutPolicies != null && policyRootToInitialize.FeatureRolloutPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.FeatureRolloutPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("featureRolloutPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.FeatureRolloutPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.ConditionalAccessPolicies != null && policyRootToInitialize.ConditionalAccessPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.ConditionalAccessPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("conditionalAccessPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.ConditionalAccessPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.RoleManagementPolicies != null && policyRootToInitialize.RoleManagementPolicies.CurrentPage != null)
                {
                    policyRootToInitialize.RoleManagementPolicies.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("roleManagementPolicies@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.RoleManagementPolicies.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (policyRootToInitialize.RoleManagementPolicyAssignments != null && policyRootToInitialize.RoleManagementPolicyAssignments.CurrentPage != null)
                {
                    policyRootToInitialize.RoleManagementPolicyAssignments.AdditionalData = policyRootToInitialize.AdditionalData;

                    if(policyRootToInitialize.AdditionalData.TryGetValue("roleManagementPolicyAssignments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            policyRootToInitialize.RoleManagementPolicyAssignments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
