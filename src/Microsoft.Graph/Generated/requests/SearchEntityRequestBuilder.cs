// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SearchEntityRequestBuilder.
    /// </summary>
    public partial class SearchEntityRequestBuilder : EntityRequestBuilder, ISearchEntityRequestBuilder
    {

        /// <summary>
        /// Constructs a new SearchEntityRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SearchEntityRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISearchEntityRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISearchEntityRequest Request(IEnumerable<Option> options)
        {
            return new SearchEntityRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SearchEntityQuery.
        /// </summary>
        /// <returns>The <see cref="ISearchEntityQueryRequestBuilder"/>.</returns>
        public ISearchEntityQueryRequestBuilder Query(
            IEnumerable<SearchRequestObject> requests)
        {
            return new SearchEntityQueryRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.query"),
                this.Client,
                requests);
        }
    
    }
}
