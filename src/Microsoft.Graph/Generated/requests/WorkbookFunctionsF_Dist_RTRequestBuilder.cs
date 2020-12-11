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
    /// The type WorkbookFunctionsF_Dist_RTRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsF_Dist_RTRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsF_Dist_RTRequest>, IWorkbookFunctionsF_Dist_RTRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsF_Dist_RTRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="x">A x parameter for the OData method call.</param>
        /// <param name="degFreedom1">A degFreedom1 parameter for the OData method call.</param>
        /// <param name="degFreedom2">A degFreedom2 parameter for the OData method call.</param>
        public WorkbookFunctionsF_Dist_RTRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken x,
            Newtonsoft.Json.Linq.JToken degFreedom1,
            Newtonsoft.Json.Linq.JToken degFreedom2)
            : base(requestUrl, client)
        {
            this.SetParameter("x", x, true);
            this.SetParameter("degFreedom1", degFreedom1, true);
            this.SetParameter("degFreedom2", degFreedom2, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsF_Dist_RTRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsF_Dist_RTRequest(functionUrl, this.Client, options);

            if (this.HasParameter("x"))
            {
                request.RequestBody.X = this.GetParameter<Newtonsoft.Json.Linq.JToken>("x");
            }

            if (this.HasParameter("degFreedom1"))
            {
                request.RequestBody.DegFreedom1 = this.GetParameter<Newtonsoft.Json.Linq.JToken>("degFreedom1");
            }

            if (this.HasParameter("degFreedom2"))
            {
                request.RequestBody.DegFreedom2 = this.GetParameter<Newtonsoft.Json.Linq.JToken>("degFreedom2");
            }

            return request;
        }
    }
}
