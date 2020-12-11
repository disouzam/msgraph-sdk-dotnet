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
    /// The type DirectoryObjectValidatePropertiesRequestBuilder.
    /// </summary>
    public partial class DirectoryObjectValidatePropertiesRequestBuilder : BaseActionMethodRequestBuilder<IDirectoryObjectValidatePropertiesRequest>, IDirectoryObjectValidatePropertiesRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DirectoryObjectValidatePropertiesRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="entityType">A entityType parameter for the OData method call.</param>
        /// <param name="displayName">A displayName parameter for the OData method call.</param>
        /// <param name="mailNickname">A mailNickname parameter for the OData method call.</param>
        /// <param name="onBehalfOfUserId">A onBehalfOfUserId parameter for the OData method call.</param>
        public DirectoryObjectValidatePropertiesRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string entityType,
            string displayName,
            string mailNickname,
            Guid? onBehalfOfUserId)
            : base(requestUrl, client)
        {
            this.SetParameter("entityType", entityType, true);
            this.SetParameter("displayName", displayName, true);
            this.SetParameter("mailNickname", mailNickname, true);
            this.SetParameter("onBehalfOfUserId", onBehalfOfUserId, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDirectoryObjectValidatePropertiesRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DirectoryObjectValidatePropertiesRequest(functionUrl, this.Client, options);

            if (this.HasParameter("entityType"))
            {
                request.RequestBody.EntityType = this.GetParameter<string>("entityType");
            }

            if (this.HasParameter("displayName"))
            {
                request.RequestBody.DisplayName = this.GetParameter<string>("displayName");
            }

            if (this.HasParameter("mailNickname"))
            {
                request.RequestBody.MailNickname = this.GetParameter<string>("mailNickname");
            }

            if (this.HasParameter("onBehalfOfUserId"))
            {
                request.RequestBody.OnBehalfOfUserId = this.GetParameter<Guid?>("onBehalfOfUserId");
            }

            return request;
        }
    }
}
