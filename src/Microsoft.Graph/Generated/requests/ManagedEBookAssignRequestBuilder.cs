// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedEBookAssignRequestBuilder.
    /// </summary>
    public partial class ManagedEBookAssignRequestBuilder : BaseActionMethodRequestBuilder<IManagedEBookAssignRequest>, IManagedEBookAssignRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ManagedEBookAssignRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="managedEBookAssignments">A managedEBookAssignments parameter for the OData method call.</param>
        public ManagedEBookAssignRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<ManagedEBookAssignment> managedEBookAssignments)
            : base(requestUrl, client)
        {
            this.SetParameter("managedEBookAssignments", managedEBookAssignments, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IManagedEBookAssignRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ManagedEBookAssignRequest(functionUrl, this.Client, options);

            if (this.HasParameter("managedEBookAssignments"))
            {
                request.RequestBody.ManagedEBookAssignments = this.GetParameter<IEnumerable<ManagedEBookAssignment>>("managedEBookAssignments");
            }

            return request;
        }
    }
}
