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
    /// The type MessageRequest.
    /// </summary>
    public partial class MessageRequest : BaseRequest, IMessageRequest
    {
        /// <summary>
        /// Constructs a new MessageRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MessageRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Message using POST.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Message.</returns>
        public async System.Threading.Tasks.Task<Message> CreateAsync(Message messageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Message>(messageToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Message using POST and returns a <see cref="GraphResponse{Message}"/> object.
        /// </summary>
        /// <param name="messageToCreate">The Message to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Message}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Message>> CreateResponseAsync(Message messageToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Message>(messageToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Message>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Message and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Message.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Message.</returns>
        public async System.Threading.Tasks.Task<Message> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Message>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Message and returns a <see cref="GraphResponse{Message}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Message}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Message>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Message>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Message using PATCH.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Message.</returns>
        public async System.Threading.Tasks.Task<Message> UpdateAsync(Message messageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Message>(messageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Message using PATCH and returns a <see cref="GraphResponse{Message}"/> object.
        /// </summary>
        /// <param name="messageToUpdate">The Message to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Message}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Message>> UpdateResponseAsync(Message messageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Message>(messageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Message using PUT.
        /// </summary>
        /// <param name="messageToUpdate">The Message object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Message> PutAsync(Message messageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Message>(messageToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Message using PUT and returns a <see cref="GraphResponse{Message}"/> object.
        /// </summary>
        /// <param name="messageToUpdate">The Message object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Message}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Message>> PutResponseAsync(Message messageToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Message>(messageToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageRequest Expand(Expression<Func<Message, object>> expandExpression)
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
        public IMessageRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMessageRequest Select(Expression<Func<Message, object>> selectExpression)
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
        /// <param name="messageToInitialize">The <see cref="Message"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Message messageToInitialize)
        {

            if (messageToInitialize != null && messageToInitialize.AdditionalData != null)
            {

                if (messageToInitialize.Attachments != null && messageToInitialize.Attachments.CurrentPage != null)
                {
                    messageToInitialize.Attachments.AdditionalData = messageToInitialize.AdditionalData;

                    if(messageToInitialize.AdditionalData.TryGetValue("attachments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            messageToInitialize.Attachments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (messageToInitialize.Extensions != null && messageToInitialize.Extensions.CurrentPage != null)
                {
                    messageToInitialize.Extensions.AdditionalData = messageToInitialize.AdditionalData;

                    if(messageToInitialize.AdditionalData.TryGetValue("extensions@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            messageToInitialize.Extensions.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (messageToInitialize.Mentions != null && messageToInitialize.Mentions.CurrentPage != null)
                {
                    messageToInitialize.Mentions.AdditionalData = messageToInitialize.AdditionalData;

                    if(messageToInitialize.AdditionalData.TryGetValue("mentions@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            messageToInitialize.Mentions.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (messageToInitialize.MultiValueExtendedProperties != null && messageToInitialize.MultiValueExtendedProperties.CurrentPage != null)
                {
                    messageToInitialize.MultiValueExtendedProperties.AdditionalData = messageToInitialize.AdditionalData;

                    if(messageToInitialize.AdditionalData.TryGetValue("multiValueExtendedProperties@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            messageToInitialize.MultiValueExtendedProperties.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (messageToInitialize.SingleValueExtendedProperties != null && messageToInitialize.SingleValueExtendedProperties.CurrentPage != null)
                {
                    messageToInitialize.SingleValueExtendedProperties.AdditionalData = messageToInitialize.AdditionalData;

                    if(messageToInitialize.AdditionalData.TryGetValue("singleValueExtendedProperties@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            messageToInitialize.SingleValueExtendedProperties.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
