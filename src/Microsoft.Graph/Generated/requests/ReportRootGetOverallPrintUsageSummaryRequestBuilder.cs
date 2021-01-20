// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ReportRootGetOverallPrintUsageSummaryRequestBuilder.
    /// </summary>
    public partial class ReportRootGetOverallPrintUsageSummaryRequestBuilder : BaseFunctionMethodRequestBuilder<IReportRootGetOverallPrintUsageSummaryRequest>, IReportRootGetOverallPrintUsageSummaryRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ReportRootGetOverallPrintUsageSummaryRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="periodStart">A periodStart parameter for the OData method call.</param>
        /// <param name="periodEnd">A periodEnd parameter for the OData method call.</param>
        /// <param name="topListsSize">A topListsSize parameter for the OData method call.</param>
        public ReportRootGetOverallPrintUsageSummaryRequestBuilder(
            string requestUrl,
            IBaseClient client,
            DateTimeOffset periodStart,
            DateTimeOffset periodEnd,
            Int32 topListsSize)
            : base(requestUrl, client)
        {
            this.SetParameter("periodStart", periodStart, false);
            this.SetParameter("periodEnd", periodEnd, false);
            this.SetParameter("topListsSize", topListsSize, false);
            this.SetFunctionParameters();
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IReportRootGetOverallPrintUsageSummaryRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ReportRootGetOverallPrintUsageSummaryRequest(functionUrl, this.Client, options);

            return request;
        }
    }
}
