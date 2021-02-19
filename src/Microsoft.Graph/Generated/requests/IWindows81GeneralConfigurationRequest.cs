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
    /// The interface IWindows81GeneralConfigurationRequest.
    /// </summary>
    public partial interface IWindows81GeneralConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows81GeneralConfiguration using POST.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToCreate">The Windows81GeneralConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> CreateAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified Windows81GeneralConfiguration using POST and returns a <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToCreate">The Windows81GeneralConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81GeneralConfiguration>> CreateResponseAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified Windows81GeneralConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <returns>The Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows81GeneralConfiguration and returns a <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81GeneralConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified Windows81GeneralConfiguration and returns a <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81GeneralConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows81GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToUpdate">The Windows81GeneralConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> UpdateAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified Windows81GeneralConfiguration using PATCH and returns a <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToUpdate">The Windows81GeneralConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Windows81GeneralConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<Windows81GeneralConfiguration>> UpdateResponseAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Expand(Expression<Func<Windows81GeneralConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Select(Expression<Func<Windows81GeneralConfiguration, object>> selectExpression);

    }
}
