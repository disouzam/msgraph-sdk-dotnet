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
    /// The interface IItemActivityRequest.
    /// </summary>
    public partial interface IItemActivityRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemActivity using POST.
        /// </summary>
        /// <param name="itemActivityToCreate">The ItemActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemActivity.</returns>
        System.Threading.Tasks.Task<ItemActivity> CreateAsync(ItemActivity itemActivityToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified ItemActivity using POST and returns a <see cref="GraphResponse{ItemActivity}"/> object.
        /// </summary>
        /// <param name="itemActivityToCreate">The ItemActivity to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivity>> CreateResponseAsync(ItemActivity itemActivityToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ItemActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified ItemActivity and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified ItemActivity.
        /// </summary>
        /// <returns>The ItemActivity.</returns>
        System.Threading.Tasks.Task<ItemActivity> GetAsync();

        /// <summary>
        /// Gets the specified ItemActivity.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemActivity.</returns>
        System.Threading.Tasks.Task<ItemActivity> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemActivity and returns a <see cref="GraphResponse{ItemActivity}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{ItemActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivity>> GetResponseAsync();

        /// <summary>
        /// Gets the specified ItemActivity and returns a <see cref="GraphResponse{ItemActivity}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ItemActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivity>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemActivity using PATCH.
        /// </summary>
        /// <param name="itemActivityToUpdate">The ItemActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemActivity.</returns>
        System.Threading.Tasks.Task<ItemActivity> UpdateAsync(ItemActivity itemActivityToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified ItemActivity using PATCH and returns a <see cref="GraphResponse{ItemActivity}"/> object.
        /// </summary>
        /// <param name="itemActivityToUpdate">The ItemActivity to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ItemActivity}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ItemActivity>> UpdateResponseAsync(ItemActivity itemActivityToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityRequest Expand(Expression<Func<ItemActivity, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemActivityRequest Select(Expression<Func<ItemActivity, object>> selectExpression);

    }
}
