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
    /// The type AndroidImportedPFXCertificateProfileRequest.
    /// </summary>
    public partial class AndroidImportedPFXCertificateProfileRequest : BaseRequest, IAndroidImportedPFXCertificateProfileRequest
    {
        /// <summary>
        /// Constructs a new AndroidImportedPFXCertificateProfileRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AndroidImportedPFXCertificateProfileRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AndroidImportedPFXCertificateProfile using POST.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToCreate">The AndroidImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> CreateAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AndroidImportedPFXCertificateProfile>(androidImportedPFXCertificateProfileToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AndroidImportedPFXCertificateProfile using POST and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToCreate">The AndroidImportedPFXCertificateProfile to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> CreateResponseAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AndroidImportedPFXCertificateProfile>(androidImportedPFXCertificateProfileToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AndroidImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AndroidImportedPFXCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AndroidImportedPFXCertificateProfile and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AndroidImportedPFXCertificateProfile.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AndroidImportedPFXCertificateProfile>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AndroidImportedPFXCertificateProfile and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AndroidImportedPFXCertificateProfile>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AndroidImportedPFXCertificateProfile using PATCH.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToUpdate">The AndroidImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidImportedPFXCertificateProfile.</returns>
        public async System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> UpdateAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AndroidImportedPFXCertificateProfile>(androidImportedPFXCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidImportedPFXCertificateProfile using PATCH and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToUpdate">The AndroidImportedPFXCertificateProfile to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> UpdateResponseAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AndroidImportedPFXCertificateProfile>(androidImportedPFXCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AndroidImportedPFXCertificateProfile using PUT.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToUpdate">The AndroidImportedPFXCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AndroidImportedPFXCertificateProfile> PutAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AndroidImportedPFXCertificateProfile>(androidImportedPFXCertificateProfileToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AndroidImportedPFXCertificateProfile using PUT and returns a <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/> object.
        /// </summary>
        /// <param name="androidImportedPFXCertificateProfileToUpdate">The AndroidImportedPFXCertificateProfile object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AndroidImportedPFXCertificateProfile}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AndroidImportedPFXCertificateProfile>> PutResponseAsync(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AndroidImportedPFXCertificateProfile>(androidImportedPFXCertificateProfileToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidImportedPFXCertificateProfileRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidImportedPFXCertificateProfileRequest Expand(Expression<Func<AndroidImportedPFXCertificateProfile, object>> expandExpression)
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
        public IAndroidImportedPFXCertificateProfileRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAndroidImportedPFXCertificateProfileRequest Select(Expression<Func<AndroidImportedPFXCertificateProfile, object>> selectExpression)
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
        /// <param name="androidImportedPFXCertificateProfileToInitialize">The <see cref="AndroidImportedPFXCertificateProfile"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AndroidImportedPFXCertificateProfile androidImportedPFXCertificateProfileToInitialize)
        {

            if (androidImportedPFXCertificateProfileToInitialize != null && androidImportedPFXCertificateProfileToInitialize.AdditionalData != null)
            {

                if (androidImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates != null && androidImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.CurrentPage != null)
                {
                    androidImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.AdditionalData = androidImportedPFXCertificateProfileToInitialize.AdditionalData;

                    if(androidImportedPFXCertificateProfileToInitialize.AdditionalData.TryGetValue("managedDeviceCertificateStates@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            androidImportedPFXCertificateProfileToInitialize.ManagedDeviceCertificateStates.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
