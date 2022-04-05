// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IAospDeviceOwnerWiFiConfigurationRequest.
    /// </summary>
    public partial interface IAospDeviceOwnerWiFiConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AospDeviceOwnerWiFiConfiguration using POST.
        /// </summary>
        /// <param name="aospDeviceOwnerWiFiConfigurationToCreate">The AospDeviceOwnerWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AospDeviceOwnerWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerWiFiConfiguration> CreateAsync(AospDeviceOwnerWiFiConfiguration aospDeviceOwnerWiFiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified AospDeviceOwnerWiFiConfiguration using POST and returns a <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerWiFiConfigurationToCreate">The AospDeviceOwnerWiFiConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerWiFiConfiguration>> CreateResponseAsync(AospDeviceOwnerWiFiConfiguration aospDeviceOwnerWiFiConfigurationToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AospDeviceOwnerWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified AospDeviceOwnerWiFiConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AospDeviceOwnerWiFiConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AospDeviceOwnerWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerWiFiConfiguration> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified AospDeviceOwnerWiFiConfiguration and returns a <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerWiFiConfiguration>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AospDeviceOwnerWiFiConfiguration using PATCH.
        /// </summary>
        /// <param name="aospDeviceOwnerWiFiConfigurationToUpdate">The AospDeviceOwnerWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AospDeviceOwnerWiFiConfiguration.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerWiFiConfiguration> UpdateAsync(AospDeviceOwnerWiFiConfiguration aospDeviceOwnerWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AospDeviceOwnerWiFiConfiguration using PATCH and returns a <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerWiFiConfigurationToUpdate">The AospDeviceOwnerWiFiConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerWiFiConfiguration>> UpdateResponseAsync(AospDeviceOwnerWiFiConfiguration aospDeviceOwnerWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AospDeviceOwnerWiFiConfiguration using PUT.
        /// </summary>
        /// <param name="aospDeviceOwnerWiFiConfigurationToUpdate">The AospDeviceOwnerWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<AospDeviceOwnerWiFiConfiguration> PutAsync(AospDeviceOwnerWiFiConfiguration aospDeviceOwnerWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified AospDeviceOwnerWiFiConfiguration using PUT and returns a <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> object.
        /// </summary>
        /// <param name="aospDeviceOwnerWiFiConfigurationToUpdate">The AospDeviceOwnerWiFiConfiguration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{AospDeviceOwnerWiFiConfiguration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<AospDeviceOwnerWiFiConfiguration>> PutResponseAsync(AospDeviceOwnerWiFiConfiguration aospDeviceOwnerWiFiConfigurationToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerWiFiConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerWiFiConfigurationRequest Expand(Expression<Func<AospDeviceOwnerWiFiConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerWiFiConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAospDeviceOwnerWiFiConfigurationRequest Select(Expression<Func<AospDeviceOwnerWiFiConfiguration, object>> selectExpression);

    }
}
