// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionReferencesRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The type UserOauth2PermissionGrantsCollectionReferencesRequest.
    /// </summary>
    public partial class UserOauth2PermissionGrantsCollectionReferencesRequest : BaseRequest, IUserOauth2PermissionGrantsCollectionReferencesRequest
    {
        /// <summary>
        /// Constructs a new UserOauth2PermissionGrantsCollectionReferencesRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public UserOauth2PermissionGrantsCollectionReferencesRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }
        /// <summary>
        /// Adds the specified OAuth2PermissionGrant to the collection via POST.
        /// </summary>
        /// <param name="oAuth2PermissionGrant">The OAuth2PermissionGrant to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task AddAsync(OAuth2PermissionGrant oAuth2PermissionGrant, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";

            if (string.IsNullOrEmpty(oAuth2PermissionGrant.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/oauth2PermissionGrants/{1}", this.Client.BaseUrl, oAuth2PermissionGrant.Id) };
            return this.SendAsync(requestBody, cancellationToken);
        }

        /// <summary>
        /// Adds the specified OAuth2PermissionGrant to the collection via POST and returns a <see cref="GraphResponse{OAuth2PermissionGrant}"/> object of the request.
        /// </summary>
        /// <param name="oAuth2PermissionGrant">The OAuth2PermissionGrant to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> AddResponseAsync(OAuth2PermissionGrant oAuth2PermissionGrant, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = "POST";

            if (string.IsNullOrEmpty(oAuth2PermissionGrant.Id))
            {
                throw new ServiceException(new Error { Code = "invalidRequest", Message = "ID is required to add a reference." });
            }

            var requestBody = new ReferenceRequestBody { ODataId = string.Format("{0}/oauth2PermissionGrants/{1}", this.Client.BaseUrl, oAuth2PermissionGrant.Id) };
            return this.SendAsyncWithGraphResponse(requestBody, cancellationToken);
        }

    }
}
