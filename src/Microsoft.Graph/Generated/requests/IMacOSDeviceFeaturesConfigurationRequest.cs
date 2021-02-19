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
    /// The interface IMacOSDeviceFeaturesConfigurationRequest.
    /// </summary>
    public partial interface IMacOSDeviceFeaturesConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSDeviceFeaturesConfiguration using POST.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToCreate">The MacOSDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> CreateAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified MacOSDeviceFeaturesConfiguration using POST and returns a <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToCreate">The MacOSDeviceFeaturesConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSDeviceFeaturesConfiguration>> CreateResponseAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified MacOSDeviceFeaturesConfiguration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <returns>The MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified MacOSDeviceFeaturesConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSDeviceFeaturesConfiguration and returns a <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <returns>The <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSDeviceFeaturesConfiguration>> GetResponseAsync();

        /// <summary>
        /// Gets the specified MacOSDeviceFeaturesConfiguration and returns a <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSDeviceFeaturesConfiguration>> GetResponseAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSDeviceFeaturesConfiguration using PATCH.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToUpdate">The MacOSDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSDeviceFeaturesConfiguration.</returns>
        System.Threading.Tasks.Task<MacOSDeviceFeaturesConfiguration> UpdateAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified MacOSDeviceFeaturesConfiguration using PATCH and returns a <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object.
        /// </summary>
        /// <param name="macOSDeviceFeaturesConfigurationToUpdate">The MacOSDeviceFeaturesConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MacOSDeviceFeaturesConfiguration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MacOSDeviceFeaturesConfiguration>> UpdateResponseAsync(MacOSDeviceFeaturesConfiguration macOSDeviceFeaturesConfigurationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Expand(Expression<Func<MacOSDeviceFeaturesConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSDeviceFeaturesConfigurationRequest Select(Expression<Func<MacOSDeviceFeaturesConfiguration, object>> selectExpression);

    }
}
