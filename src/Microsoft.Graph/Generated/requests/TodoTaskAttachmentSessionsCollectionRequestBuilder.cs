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
    /// The type TodoTaskAttachmentSessionsCollectionRequestBuilder.
    /// </summary>
    public partial class TodoTaskAttachmentSessionsCollectionRequestBuilder : BaseRequestBuilder, ITodoTaskAttachmentSessionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TodoTaskAttachmentSessionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TodoTaskAttachmentSessionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITodoTaskAttachmentSessionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITodoTaskAttachmentSessionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TodoTaskAttachmentSessionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAttachmentSessionRequestBuilder"/> for the specified TodoTaskAttachmentSession.
        /// </summary>
        /// <param name="id">The ID for the TodoTaskAttachmentSession.</param>
        /// <returns>The <see cref="IAttachmentSessionRequestBuilder"/>.</returns>
        public IAttachmentSessionRequestBuilder this[string id]
        {
            get
            {
                return new AttachmentSessionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}