// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWorkflowRequestBuilder.
    /// </summary>
    public partial interface IWorkflowRequestBuilder : IWorkflowBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWorkflowRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWorkflowRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for ExecutionScope.
        /// </summary>
        /// <returns>The <see cref="IWorkflowExecutionScopeCollectionWithReferencesRequestBuilder"/>.</returns>
        IWorkflowExecutionScopeCollectionWithReferencesRequestBuilder ExecutionScope { get; }

        /// <summary>
        /// Gets the request builder for Runs.
        /// </summary>
        /// <returns>The <see cref="IWorkflowRunsCollectionRequestBuilder"/>.</returns>
        IWorkflowRunsCollectionRequestBuilder Runs { get; }

        /// <summary>
        /// Gets the request builder for TaskReports.
        /// </summary>
        /// <returns>The <see cref="IWorkflowTaskReportsCollectionRequestBuilder"/>.</returns>
        IWorkflowTaskReportsCollectionRequestBuilder TaskReports { get; }

        /// <summary>
        /// Gets the request builder for UserProcessingResults.
        /// </summary>
        /// <returns>The <see cref="IWorkflowUserProcessingResultsCollectionRequestBuilder"/>.</returns>
        IWorkflowUserProcessingResultsCollectionRequestBuilder UserProcessingResults { get; }

        /// <summary>
        /// Gets the request builder for Versions.
        /// </summary>
        /// <returns>The <see cref="IWorkflowVersionsCollectionRequestBuilder"/>.</returns>
        IWorkflowVersionsCollectionRequestBuilder Versions { get; }
    
        /// <summary>
        /// Gets the request builder for WorkflowActivate.
        /// </summary>
        /// <returns>The <see cref="IWorkflowActivateRequestBuilder"/>.</returns>
        IWorkflowActivateRequestBuilder Activate(
            IEnumerable<Microsoft.Graph.User> subjects = null);

        /// <summary>
        /// Gets the request builder for WorkflowCreateNewVersion.
        /// </summary>
        /// <returns>The <see cref="IWorkflowCreateNewVersionRequestBuilder"/>.</returns>
        IWorkflowCreateNewVersionRequestBuilder CreateNewVersion(
            Workflow workflow = null);

        /// <summary>
        /// Gets the request builder for WorkflowRestore.
        /// </summary>
        /// <returns>The <see cref="IWorkflowRestoreRequestBuilder"/>.</returns>
        IWorkflowRestoreRequestBuilder Restore();
    
    }
}
