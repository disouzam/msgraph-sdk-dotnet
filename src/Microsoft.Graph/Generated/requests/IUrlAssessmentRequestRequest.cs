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
    /// The interface IUrlAssessmentRequestRequest.
    /// </summary>
    public partial interface IUrlAssessmentRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UrlAssessmentRequestObject using POST.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToCreate">The UrlAssessmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UrlAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<UrlAssessmentRequestObject> CreateAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified UrlAssessmentRequestObject using POST and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToCreate">The UrlAssessmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> CreateResponseAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UrlAssessmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified UrlAssessmentRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified UrlAssessmentRequestObject.
        /// </summary>
        /// <returns>The UrlAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<UrlAssessmentRequestObject> GetAsync();

        /// <summary>
        /// Gets the specified UrlAssessmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UrlAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<UrlAssessmentRequestObject> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified UrlAssessmentRequestObject and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> GetResponseAsync();

        /// <summary>
        /// Gets the specified UrlAssessmentRequestObject and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified UrlAssessmentRequestObject using PATCH.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToUpdate">The UrlAssessmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UrlAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<UrlAssessmentRequestObject> UpdateAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified UrlAssessmentRequestObject using PATCH and returns a <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="urlAssessmentRequestObjectToUpdate">The UrlAssessmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UrlAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UrlAssessmentRequestObject>> UpdateResponseAsync(UrlAssessmentRequestObject urlAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUrlAssessmentRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUrlAssessmentRequestRequest Expand(Expression<Func<UrlAssessmentRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUrlAssessmentRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUrlAssessmentRequestRequest Select(Expression<Func<UrlAssessmentRequestObject, object>> selectExpression);

    }
}
