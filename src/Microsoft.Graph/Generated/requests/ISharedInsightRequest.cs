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
    /// The interface ISharedInsightRequest.
    /// </summary>
    public partial interface ISharedInsightRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharedInsight using POST.
        /// </summary>
        /// <param name="sharedInsightToCreate">The SharedInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> CreateAsync(SharedInsight sharedInsightToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified SharedInsight using POST and returns a <see cref="GraphResponse{SharedInsight}"/> object.
        /// </summary>
        /// <param name="sharedInsightToCreate">The SharedInsight to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedInsight>> CreateResponseAsync(SharedInsight sharedInsightToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SharedInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified SharedInsight and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified SharedInsight.
        /// </summary>
        /// <returns>The SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> GetAsync();

        /// <summary>
        /// Gets the specified SharedInsight.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharedInsight and returns a <see cref="GraphResponse{SharedInsight}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{SharedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedInsight>> GetResponseAsync();

        /// <summary>
        /// Gets the specified SharedInsight and returns a <see cref="GraphResponse{SharedInsight}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SharedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedInsight>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharedInsight using PATCH.
        /// </summary>
        /// <param name="sharedInsightToUpdate">The SharedInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SharedInsight.</returns>
        System.Threading.Tasks.Task<SharedInsight> UpdateAsync(SharedInsight sharedInsightToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified SharedInsight using PATCH and returns a <see cref="GraphResponse{SharedInsight}"/> object.
        /// </summary>
        /// <param name="sharedInsightToUpdate">The SharedInsight to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SharedInsight}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SharedInsight>> UpdateResponseAsync(SharedInsight sharedInsightToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Expand(Expression<Func<SharedInsight, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharedInsightRequest Select(Expression<Func<SharedInsight, object>> selectExpression);

    }
}
