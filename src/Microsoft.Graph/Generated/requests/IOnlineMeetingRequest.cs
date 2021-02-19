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
    /// The interface IOnlineMeetingRequest.
    /// </summary>
    public partial interface IOnlineMeetingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnlineMeeting using POST.
        /// </summary>
        /// <param name="onlineMeetingToCreate">The OnlineMeeting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> CreateAsync(OnlineMeeting onlineMeetingToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified OnlineMeeting using POST and returns a <see cref="GraphResponse{OnlineMeeting}"/> object.
        /// </summary>
        /// <param name="onlineMeetingToCreate">The OnlineMeeting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnlineMeeting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnlineMeeting>> CreateResponseAsync(OnlineMeeting onlineMeetingToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OnlineMeeting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified OnlineMeeting and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified OnlineMeeting.
        /// </summary>
        /// <returns>The OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> GetAsync();

        /// <summary>
        /// Gets the specified OnlineMeeting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnlineMeeting and returns a <see cref="GraphResponse{OnlineMeeting}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{OnlineMeeting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnlineMeeting>> GetResponseAsync();

        /// <summary>
        /// Gets the specified OnlineMeeting and returns a <see cref="GraphResponse{OnlineMeeting}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OnlineMeeting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnlineMeeting>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnlineMeeting using PATCH.
        /// </summary>
        /// <param name="onlineMeetingToUpdate">The OnlineMeeting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OnlineMeeting.</returns>
        System.Threading.Tasks.Task<OnlineMeeting> UpdateAsync(OnlineMeeting onlineMeetingToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified OnlineMeeting using PATCH and returns a <see cref="GraphResponse{OnlineMeeting}"/> object.
        /// </summary>
        /// <param name="onlineMeetingToUpdate">The OnlineMeeting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OnlineMeeting}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<OnlineMeeting>> UpdateResponseAsync(OnlineMeeting onlineMeetingToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Expand(Expression<Func<OnlineMeeting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnlineMeetingRequest Select(Expression<Func<OnlineMeeting, object>> selectExpression);

    }
}
