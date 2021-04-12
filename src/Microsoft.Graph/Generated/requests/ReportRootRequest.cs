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
    /// The type ReportRootRequest.
    /// </summary>
    public partial class ReportRootRequest : BaseRequest, IReportRootRequest
    {
        /// <summary>
        /// Constructs a new ReportRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public ReportRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified ReportRoot using POST.
        /// </summary>
        /// <param name="reportRootToCreate">The ReportRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ReportRoot.</returns>
        public async System.Threading.Tasks.Task<ReportRoot> CreateAsync(ReportRoot reportRootToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<ReportRoot>(reportRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified ReportRoot using POST and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="reportRootToCreate">The ReportRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRoot>> CreateResponseAsync(ReportRoot reportRootToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<ReportRoot>(reportRootToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified ReportRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<ReportRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified ReportRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified ReportRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ReportRoot.</returns>
        public async System.Threading.Tasks.Task<ReportRoot> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<ReportRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified ReportRoot and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ReportRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRoot>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<ReportRoot>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ReportRoot using PATCH.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ReportRoot.</returns>
        public async System.Threading.Tasks.Task<ReportRoot> UpdateAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<ReportRoot>(reportRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ReportRoot using PATCH and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ReportRoot}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRoot>> UpdateResponseAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<ReportRoot>(reportRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified ReportRoot using PUT.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<ReportRoot> PutAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<ReportRoot>(reportRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified ReportRoot using PUT and returns a <see cref="GraphResponse{ReportRoot}"/> object.
        /// </summary>
        /// <param name="reportRootToUpdate">The ReportRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{ReportRoot}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<ReportRoot>> PutResponseAsync(ReportRoot reportRootToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<ReportRoot>(reportRootToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootRequest Expand(Expression<Func<ReportRoot, object>> expandExpression)
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
        public IReportRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IReportRootRequest Select(Expression<Func<ReportRoot, object>> selectExpression)
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
        /// <param name="reportRootToInitialize">The <see cref="ReportRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(ReportRoot reportRootToInitialize)
        {

            if (reportRootToInitialize != null && reportRootToInitialize.AdditionalData != null)
            {

                if (reportRootToInitialize.ApplicationSignInDetailedSummary != null && reportRootToInitialize.ApplicationSignInDetailedSummary.CurrentPage != null)
                {
                    reportRootToInitialize.ApplicationSignInDetailedSummary.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("applicationSignInDetailedSummary@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.ApplicationSignInDetailedSummary.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.CredentialUserRegistrationDetails != null && reportRootToInitialize.CredentialUserRegistrationDetails.CurrentPage != null)
                {
                    reportRootToInitialize.CredentialUserRegistrationDetails.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("credentialUserRegistrationDetails@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.CredentialUserRegistrationDetails.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.UserCredentialUsageDetails != null && reportRootToInitialize.UserCredentialUsageDetails.CurrentPage != null)
                {
                    reportRootToInitialize.UserCredentialUsageDetails.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("userCredentialUsageDetails@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.UserCredentialUsageDetails.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.DailyPrintUsageByPrinter != null && reportRootToInitialize.DailyPrintUsageByPrinter.CurrentPage != null)
                {
                    reportRootToInitialize.DailyPrintUsageByPrinter.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("dailyPrintUsageByPrinter@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.DailyPrintUsageByPrinter.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.DailyPrintUsageByUser != null && reportRootToInitialize.DailyPrintUsageByUser.CurrentPage != null)
                {
                    reportRootToInitialize.DailyPrintUsageByUser.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("dailyPrintUsageByUser@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.DailyPrintUsageByUser.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.DailyPrintUsageSummariesByPrinter != null && reportRootToInitialize.DailyPrintUsageSummariesByPrinter.CurrentPage != null)
                {
                    reportRootToInitialize.DailyPrintUsageSummariesByPrinter.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("dailyPrintUsageSummariesByPrinter@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.DailyPrintUsageSummariesByPrinter.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.DailyPrintUsageSummariesByUser != null && reportRootToInitialize.DailyPrintUsageSummariesByUser.CurrentPage != null)
                {
                    reportRootToInitialize.DailyPrintUsageSummariesByUser.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("dailyPrintUsageSummariesByUser@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.DailyPrintUsageSummariesByUser.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.MonthlyPrintUsageByPrinter != null && reportRootToInitialize.MonthlyPrintUsageByPrinter.CurrentPage != null)
                {
                    reportRootToInitialize.MonthlyPrintUsageByPrinter.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("monthlyPrintUsageByPrinter@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.MonthlyPrintUsageByPrinter.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.MonthlyPrintUsageByUser != null && reportRootToInitialize.MonthlyPrintUsageByUser.CurrentPage != null)
                {
                    reportRootToInitialize.MonthlyPrintUsageByUser.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("monthlyPrintUsageByUser@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.MonthlyPrintUsageByUser.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.MonthlyPrintUsageSummariesByPrinter != null && reportRootToInitialize.MonthlyPrintUsageSummariesByPrinter.CurrentPage != null)
                {
                    reportRootToInitialize.MonthlyPrintUsageSummariesByPrinter.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("monthlyPrintUsageSummariesByPrinter@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.MonthlyPrintUsageSummariesByPrinter.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

                if (reportRootToInitialize.MonthlyPrintUsageSummariesByUser != null && reportRootToInitialize.MonthlyPrintUsageSummariesByUser.CurrentPage != null)
                {
                    reportRootToInitialize.MonthlyPrintUsageSummariesByUser.AdditionalData = reportRootToInitialize.AdditionalData;

                    if(reportRootToInitialize.AdditionalData.TryGetValue("monthlyPrintUsageSummariesByUser@odata.nextLink", out var nextPageLink))
                    {
                        // Ensure it is a non empty JsonElement string
                        if (nextPageLink is System.Text.Json.JsonElement element
                            && element.ValueKind == System.Text.Json.JsonValueKind.String
                            && !string.IsNullOrEmpty(element.ToString()))
                        {
                            reportRootToInitialize.MonthlyPrintUsageSummariesByUser.InitializeNextPageRequest(
                                this.Client,
                                element.ToString());
                        }
                    }
                }

            }


        }
    }
}
