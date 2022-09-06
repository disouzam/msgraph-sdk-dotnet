// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type EdiscoveryCustodianRequest.
    /// </summary>
    public partial class EdiscoveryCustodianRequest : Microsoft.Graph.BaseRequest, IEdiscoveryCustodianRequest
    {
        /// <summary>
        /// Constructs a new EdiscoveryCustodianRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EdiscoveryCustodianRequest(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            IEnumerable<Microsoft.Graph.Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EdiscoveryCustodian using POST.
        /// </summary>
        /// <param name="ediscoveryCustodianToCreate">The EdiscoveryCustodian to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EdiscoveryCustodian.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryCustodian> CreateAsync(EdiscoveryCustodian ediscoveryCustodianToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<EdiscoveryCustodian>(ediscoveryCustodianToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified EdiscoveryCustodian using POST and returns a <see cref="GraphResponse{EdiscoveryCustodian}"/> object.
        /// </summary>
        /// <param name="ediscoveryCustodianToCreate">The EdiscoveryCustodian to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryCustodian}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryCustodian>> CreateResponseAsync(EdiscoveryCustodian ediscoveryCustodianToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<EdiscoveryCustodian>(ediscoveryCustodianToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryCustodian.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<EdiscoveryCustodian>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified EdiscoveryCustodian and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified EdiscoveryCustodian.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EdiscoveryCustodian.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryCustodian> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<EdiscoveryCustodian>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified EdiscoveryCustodian and returns a <see cref="GraphResponse{EdiscoveryCustodian}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{EdiscoveryCustodian}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryCustodian>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<EdiscoveryCustodian>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryCustodian using PATCH.
        /// </summary>
        /// <param name="ediscoveryCustodianToUpdate">The EdiscoveryCustodian to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated EdiscoveryCustodian.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryCustodian> UpdateAsync(EdiscoveryCustodian ediscoveryCustodianToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<EdiscoveryCustodian>(ediscoveryCustodianToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryCustodian using PATCH and returns a <see cref="GraphResponse{EdiscoveryCustodian}"/> object.
        /// </summary>
        /// <param name="ediscoveryCustodianToUpdate">The EdiscoveryCustodian to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="Microsoft.Graph.ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{EdiscoveryCustodian}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryCustodian>> UpdateResponseAsync(EdiscoveryCustodian ediscoveryCustodianToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<EdiscoveryCustodian>(ediscoveryCustodianToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified EdiscoveryCustodian using PUT.
        /// </summary>
        /// <param name="ediscoveryCustodianToUpdate">The EdiscoveryCustodian object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<EdiscoveryCustodian> PutAsync(EdiscoveryCustodian ediscoveryCustodianToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<EdiscoveryCustodian>(ediscoveryCustodianToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified EdiscoveryCustodian using PUT and returns a <see cref="GraphResponse{EdiscoveryCustodian}"/> object.
        /// </summary>
        /// <param name="ediscoveryCustodianToUpdate">The EdiscoveryCustodian object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{EdiscoveryCustodian}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<EdiscoveryCustodian>> PutResponseAsync(EdiscoveryCustodian ediscoveryCustodianToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<EdiscoveryCustodian>(ediscoveryCustodianToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryCustodianRequest Expand(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryCustodianRequest Expand(Expression<Func<EdiscoveryCustodian, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryCustodianRequest Select(string value)
        {
            this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEdiscoveryCustodianRequest Select(Expression<Func<EdiscoveryCustodian, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = Microsoft.Graph.ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new Microsoft.Graph.QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="ediscoveryCustodianToInitialize">The <see cref="EdiscoveryCustodian"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EdiscoveryCustodian ediscoveryCustodianToInitialize)
        {

            if (ediscoveryCustodianToInitialize != null)
            {
                if (ediscoveryCustodianToInitialize.SiteSources != null && ediscoveryCustodianToInitialize.SiteSources.CurrentPage != null)
                {
                    ediscoveryCustodianToInitialize.SiteSources.InitializeNextPageRequest(this.Client, ediscoveryCustodianToInitialize.SiteSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoveryCustodianToInitialize.SiteSources.AdditionalData = ediscoveryCustodianToInitialize.AdditionalData;
                }
                if (ediscoveryCustodianToInitialize.UnifiedGroupSources != null && ediscoveryCustodianToInitialize.UnifiedGroupSources.CurrentPage != null)
                {
                    ediscoveryCustodianToInitialize.UnifiedGroupSources.InitializeNextPageRequest(this.Client, ediscoveryCustodianToInitialize.UnifiedGroupSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoveryCustodianToInitialize.UnifiedGroupSources.AdditionalData = ediscoveryCustodianToInitialize.AdditionalData;
                }
                if (ediscoveryCustodianToInitialize.UserSources != null && ediscoveryCustodianToInitialize.UserSources.CurrentPage != null)
                {
                    ediscoveryCustodianToInitialize.UserSources.InitializeNextPageRequest(this.Client, ediscoveryCustodianToInitialize.UserSourcesNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    ediscoveryCustodianToInitialize.UserSources.AdditionalData = ediscoveryCustodianToInitialize.AdditionalData;
                }

            }


        }
    }
}