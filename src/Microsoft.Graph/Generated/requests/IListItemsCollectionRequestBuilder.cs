// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IListItemsCollectionRequestBuilder.
    /// </summary>
    public partial interface IListItemsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IListItemsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IListItemsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IListItemRequestBuilder"/> for the specified ListItem.
        /// </summary>
        /// <param name="id">The ID for the ListItem.</param>
        /// <returns>The <see cref="IListItemRequestBuilder"/>.</returns>
        IListItemRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for ListItemDelta.
        /// </summary>
        /// <returns>The <see cref="IListItemDeltaRequestBuilder"/>.</returns>
        IListItemDeltaRequestBuilder Delta();

        /// <summary>
        /// Gets the request builder for ListItemDelta.
        /// </summary>
        /// <returns>The <see cref="IListItemDeltaRequestBuilder"/>.</returns>
        IListItemDeltaRequestBuilder Delta(
            string token = null);
    }
}
