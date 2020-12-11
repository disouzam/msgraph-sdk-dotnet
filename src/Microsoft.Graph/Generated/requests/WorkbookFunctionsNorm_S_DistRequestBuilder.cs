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
    /// The type WorkbookFunctionsNorm_S_DistRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsNorm_S_DistRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsNorm_S_DistRequest>, IWorkbookFunctionsNorm_S_DistRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsNorm_S_DistRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="z">A z parameter for the OData method call.</param>
        /// <param name="cumulative">A cumulative parameter for the OData method call.</param>
        public WorkbookFunctionsNorm_S_DistRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken z,
            Newtonsoft.Json.Linq.JToken cumulative)
            : base(requestUrl, client)
        {
            this.SetParameter("z", z, true);
            this.SetParameter("cumulative", cumulative, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsNorm_S_DistRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsNorm_S_DistRequest(functionUrl, this.Client, options);

            if (this.HasParameter("z"))
            {
                request.RequestBody.Z = this.GetParameter<Newtonsoft.Json.Linq.JToken>("z");
            }

            if (this.HasParameter("cumulative"))
            {
                request.RequestBody.Cumulative = this.GetParameter<Newtonsoft.Json.Linq.JToken>("cumulative");
            }

            return request;
        }
    }
}
