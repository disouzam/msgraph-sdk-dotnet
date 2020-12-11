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
    /// The type UserAssignLicenseRequestBuilder.
    /// </summary>
    public partial class UserAssignLicenseRequestBuilder : BaseActionMethodRequestBuilder<IUserAssignLicenseRequest>, IUserAssignLicenseRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UserAssignLicenseRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="addLicenses">A addLicenses parameter for the OData method call.</param>
        /// <param name="removeLicenses">A removeLicenses parameter for the OData method call.</param>
        public UserAssignLicenseRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<AssignedLicense> addLicenses,
            IEnumerable<Guid> removeLicenses)
            : base(requestUrl, client)
        {
            this.SetParameter("addLicenses", addLicenses, false);
            this.SetParameter("removeLicenses", removeLicenses, false);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUserAssignLicenseRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new UserAssignLicenseRequest(functionUrl, this.Client, options);

            if (this.HasParameter("addLicenses"))
            {
                request.RequestBody.AddLicenses = this.GetParameter<IEnumerable<AssignedLicense>>("addLicenses");
            }

            if (this.HasParameter("removeLicenses"))
            {
                request.RequestBody.RemoveLicenses = this.GetParameter<IEnumerable<Guid>>("removeLicenses");
            }

            return request;
        }
    }
}
