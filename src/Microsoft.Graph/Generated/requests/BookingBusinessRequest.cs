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
    /// The type BookingBusinessRequest.
    /// </summary>
    public partial class BookingBusinessRequest : BaseRequest, IBookingBusinessRequest
    {
        /// <summary>
        /// Constructs a new BookingBusinessRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public BookingBusinessRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified BookingBusiness using POST.
        /// </summary>
        /// <param name="bookingBusinessToCreate">The BookingBusiness to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingBusiness.</returns>
        public async System.Threading.Tasks.Task<BookingBusiness> CreateAsync(BookingBusiness bookingBusinessToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<BookingBusiness>(bookingBusinessToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified BookingBusiness using POST and returns a <see cref="GraphResponse{BookingBusiness}"/> object.
        /// </summary>
        /// <param name="bookingBusinessToCreate">The BookingBusiness to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingBusiness}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingBusiness>> CreateResponseAsync(BookingBusiness bookingBusinessToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<BookingBusiness>(bookingBusinessToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified BookingBusiness.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<BookingBusiness>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified BookingBusiness and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified BookingBusiness.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BookingBusiness.</returns>
        public async System.Threading.Tasks.Task<BookingBusiness> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<BookingBusiness>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified BookingBusiness and returns a <see cref="GraphResponse{BookingBusiness}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingBusiness}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingBusiness>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<BookingBusiness>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified BookingBusiness using PATCH.
        /// </summary>
        /// <param name="bookingBusinessToUpdate">The BookingBusiness to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BookingBusiness.</returns>
        public async System.Threading.Tasks.Task<BookingBusiness> UpdateAsync(BookingBusiness bookingBusinessToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<BookingBusiness>(bookingBusinessToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BookingBusiness using PATCH and returns a <see cref="GraphResponse{BookingBusiness}"/> object.
        /// </summary>
        /// <param name="bookingBusinessToUpdate">The BookingBusiness to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{BookingBusiness}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingBusiness>> UpdateResponseAsync(BookingBusiness bookingBusinessToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<BookingBusiness>(bookingBusinessToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified BookingBusiness using PUT.
        /// </summary>
        /// <param name="bookingBusinessToUpdate">The BookingBusiness object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<BookingBusiness> PutAsync(BookingBusiness bookingBusinessToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<BookingBusiness>(bookingBusinessToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified BookingBusiness using PUT and returns a <see cref="GraphResponse{BookingBusiness}"/> object.
        /// </summary>
        /// <param name="bookingBusinessToUpdate">The BookingBusiness object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{BookingBusiness}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<BookingBusiness>> PutResponseAsync(BookingBusiness bookingBusinessToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<BookingBusiness>(bookingBusinessToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBookingBusinessRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBookingBusinessRequest Expand(Expression<Func<BookingBusiness, object>> expandExpression)
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
        public IBookingBusinessRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IBookingBusinessRequest Select(Expression<Func<BookingBusiness, object>> selectExpression)
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
        /// <param name="bookingBusinessToInitialize">The <see cref="BookingBusiness"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(BookingBusiness bookingBusinessToInitialize)
        {

            if (bookingBusinessToInitialize != null && bookingBusinessToInitialize.AdditionalData != null)
            {

                if (bookingBusinessToInitialize.Appointments != null && bookingBusinessToInitialize.Appointments.CurrentPage != null)
                {
                    bookingBusinessToInitialize.Appointments.AdditionalData = bookingBusinessToInitialize.AdditionalData;

                    if(bookingBusinessToInitialize.AdditionalData.TryGetValue("appointments@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            bookingBusinessToInitialize.Appointments.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (bookingBusinessToInitialize.CalendarView != null && bookingBusinessToInitialize.CalendarView.CurrentPage != null)
                {
                    bookingBusinessToInitialize.CalendarView.AdditionalData = bookingBusinessToInitialize.AdditionalData;

                    if(bookingBusinessToInitialize.AdditionalData.TryGetValue("calendarView@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            bookingBusinessToInitialize.CalendarView.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (bookingBusinessToInitialize.Customers != null && bookingBusinessToInitialize.Customers.CurrentPage != null)
                {
                    bookingBusinessToInitialize.Customers.AdditionalData = bookingBusinessToInitialize.AdditionalData;

                    if(bookingBusinessToInitialize.AdditionalData.TryGetValue("customers@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            bookingBusinessToInitialize.Customers.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (bookingBusinessToInitialize.Services != null && bookingBusinessToInitialize.Services.CurrentPage != null)
                {
                    bookingBusinessToInitialize.Services.AdditionalData = bookingBusinessToInitialize.AdditionalData;

                    if(bookingBusinessToInitialize.AdditionalData.TryGetValue("services@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            bookingBusinessToInitialize.Services.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (bookingBusinessToInitialize.StaffMembers != null && bookingBusinessToInitialize.StaffMembers.CurrentPage != null)
                {
                    bookingBusinessToInitialize.StaffMembers.AdditionalData = bookingBusinessToInitialize.AdditionalData;

                    if(bookingBusinessToInitialize.AdditionalData.TryGetValue("staffMembers@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            bookingBusinessToInitialize.StaffMembers.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
