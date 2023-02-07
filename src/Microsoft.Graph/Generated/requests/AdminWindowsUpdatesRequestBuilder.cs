// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AdminWindowsUpdatesRequestBuilder.
    /// </summary>
    public partial class AdminWindowsUpdatesRequestBuilder : EntityRequestBuilder, IAdminWindowsUpdatesRequestBuilder
    {

        /// <summary>
        /// Constructs a new AdminWindowsUpdatesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AdminWindowsUpdatesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAdminWindowsUpdatesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAdminWindowsUpdatesRequest Request(IEnumerable<Option> options)
        {
            return new AdminWindowsUpdatesRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Catalog.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.WindowsUpdates.ICatalogRequestBuilder"/>.</returns>
        public Microsoft.Graph.WindowsUpdates.ICatalogRequestBuilder Catalog
        {
            get
            {
                return new Microsoft.Graph.WindowsUpdates.CatalogRequestBuilder(this.AppendSegmentToRequestUrl("catalog"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for DeploymentAudiences.
        /// </summary>
        /// <returns>The <see cref="IAdminWindowsUpdatesDeploymentAudiencesCollectionRequestBuilder"/>.</returns>
        public IAdminWindowsUpdatesDeploymentAudiencesCollectionRequestBuilder DeploymentAudiences
        {
            get
            {
                return new AdminWindowsUpdatesDeploymentAudiencesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deploymentAudiences"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Deployments.
        /// </summary>
        /// <returns>The <see cref="IAdminWindowsUpdatesDeploymentsCollectionRequestBuilder"/>.</returns>
        public IAdminWindowsUpdatesDeploymentsCollectionRequestBuilder Deployments
        {
            get
            {
                return new AdminWindowsUpdatesDeploymentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("deployments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ResourceConnections.
        /// </summary>
        /// <returns>The <see cref="IAdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder"/>.</returns>
        public IAdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder ResourceConnections
        {
            get
            {
                return new AdminWindowsUpdatesResourceConnectionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("resourceConnections"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UpdatableAssets.
        /// </summary>
        /// <returns>The <see cref="IAdminWindowsUpdatesUpdatableAssetsCollectionRequestBuilder"/>.</returns>
        public IAdminWindowsUpdatesUpdatableAssetsCollectionRequestBuilder UpdatableAssets
        {
            get
            {
                return new AdminWindowsUpdatesUpdatableAssetsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("updatableAssets"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UpdatePolicies.
        /// </summary>
        /// <returns>The <see cref="IAdminWindowsUpdatesUpdatePoliciesCollectionRequestBuilder"/>.</returns>
        public IAdminWindowsUpdatesUpdatePoliciesCollectionRequestBuilder UpdatePolicies
        {
            get
            {
                return new AdminWindowsUpdatesUpdatePoliciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("updatePolicies"), this.Client);
            }
        }
    
    }
}
