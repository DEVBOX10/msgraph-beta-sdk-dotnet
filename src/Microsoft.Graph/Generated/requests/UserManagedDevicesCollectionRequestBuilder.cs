// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserManagedDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class UserManagedDevicesCollectionRequestBuilder : BaseRequestBuilder, IUserManagedDevicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserManagedDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserManagedDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserManagedDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserManagedDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserManagedDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceRequestBuilder"/> for the specified UserManagedDevice.
        /// </summary>
        /// <param name="id">The ID for the UserManagedDevice.</param>
        /// <returns>The <see cref="IManagedDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceBulkReprovisionCloudPc.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBulkReprovisionCloudPcRequestBuilder"/>.</returns>
        public IManagedDeviceBulkReprovisionCloudPcRequestBuilder BulkReprovisionCloudPc(
            IEnumerable<string> managedDeviceIds = null)
        {
            return new ManagedDeviceBulkReprovisionCloudPcRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.bulkReprovisionCloudPc"),
                this.Client,
                managedDeviceIds);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceExecuteAction.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceExecuteActionRequestBuilder"/>.</returns>
        public IManagedDeviceExecuteActionRequestBuilder ExecuteAction(
            ManagedDeviceRemoteAction actionName,
            bool? keepEnrollmentData = null,
            bool? keepUserData = null,
            IEnumerable<string> deviceIds = null,
            string notificationTitle = null,
            string notificationBody = null,
            string deviceName = null)
        {
            return new ManagedDeviceExecuteActionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.executeAction"),
                this.Client,
                actionName,
                keepEnrollmentData,
                keepUserData,
                deviceIds,
                notificationTitle,
                notificationBody,
                deviceName);
        }
    }
}
