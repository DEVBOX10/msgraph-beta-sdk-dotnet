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
    /// The type PurchaseInvoiceRequest.
    /// </summary>
    public partial class PurchaseInvoiceRequest : BaseRequest, IPurchaseInvoiceRequest
    {
        /// <summary>
        /// Constructs a new PurchaseInvoiceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public PurchaseInvoiceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified PurchaseInvoice using POST.
        /// </summary>
        /// <param name="purchaseInvoiceToCreate">The PurchaseInvoice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PurchaseInvoice.</returns>
        public async System.Threading.Tasks.Task<PurchaseInvoice> CreateAsync(PurchaseInvoice purchaseInvoiceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<PurchaseInvoice>(purchaseInvoiceToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified PurchaseInvoice using POST and returns a <see cref="GraphResponse{PurchaseInvoice}"/> object.
        /// </summary>
        /// <param name="purchaseInvoiceToCreate">The PurchaseInvoice to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PurchaseInvoice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PurchaseInvoice>> CreateResponseAsync(PurchaseInvoice purchaseInvoiceToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<PurchaseInvoice>(purchaseInvoiceToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified PurchaseInvoice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<PurchaseInvoice>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified PurchaseInvoice and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified PurchaseInvoice.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PurchaseInvoice.</returns>
        public async System.Threading.Tasks.Task<PurchaseInvoice> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<PurchaseInvoice>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified PurchaseInvoice and returns a <see cref="GraphResponse{PurchaseInvoice}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{PurchaseInvoice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PurchaseInvoice>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<PurchaseInvoice>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PurchaseInvoice using PATCH.
        /// </summary>
        /// <param name="purchaseInvoiceToUpdate">The PurchaseInvoice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PurchaseInvoice.</returns>
        public async System.Threading.Tasks.Task<PurchaseInvoice> UpdateAsync(PurchaseInvoice purchaseInvoiceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<PurchaseInvoice>(purchaseInvoiceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PurchaseInvoice using PATCH and returns a <see cref="GraphResponse{PurchaseInvoice}"/> object.
        /// </summary>
        /// <param name="purchaseInvoiceToUpdate">The PurchaseInvoice to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{PurchaseInvoice}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PurchaseInvoice>> UpdateResponseAsync(PurchaseInvoice purchaseInvoiceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<PurchaseInvoice>(purchaseInvoiceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified PurchaseInvoice using PUT.
        /// </summary>
        /// <param name="purchaseInvoiceToUpdate">The PurchaseInvoice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<PurchaseInvoice> PutAsync(PurchaseInvoice purchaseInvoiceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<PurchaseInvoice>(purchaseInvoiceToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified PurchaseInvoice using PUT and returns a <see cref="GraphResponse{PurchaseInvoice}"/> object.
        /// </summary>
        /// <param name="purchaseInvoiceToUpdate">The PurchaseInvoice object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{PurchaseInvoice}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<PurchaseInvoice>> PutResponseAsync(PurchaseInvoice purchaseInvoiceToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<PurchaseInvoice>(purchaseInvoiceToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPurchaseInvoiceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IPurchaseInvoiceRequest Expand(Expression<Func<PurchaseInvoice, object>> expandExpression)
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
        public IPurchaseInvoiceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IPurchaseInvoiceRequest Select(Expression<Func<PurchaseInvoice, object>> selectExpression)
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
        /// <param name="purchaseInvoiceToInitialize">The <see cref="PurchaseInvoice"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(PurchaseInvoice purchaseInvoiceToInitialize)
        {

            if (purchaseInvoiceToInitialize != null && purchaseInvoiceToInitialize.AdditionalData != null)
            {

                if (purchaseInvoiceToInitialize.PurchaseInvoiceLines != null && purchaseInvoiceToInitialize.PurchaseInvoiceLines.CurrentPage != null)
                {
                    purchaseInvoiceToInitialize.PurchaseInvoiceLines.AdditionalData = purchaseInvoiceToInitialize.AdditionalData;

                    if(purchaseInvoiceToInitialize.AdditionalData.TryGetValue("purchaseInvoiceLines@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            purchaseInvoiceToInitialize.PurchaseInvoiceLines.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
