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
    /// The type WorkbookFunctionsConfidence_NormRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsConfidence_NormRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsConfidence_NormRequest>, IWorkbookFunctionsConfidence_NormRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsConfidence_NormRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="alpha">A alpha parameter for the OData method call.</param>
        /// <param name="standardDev">A standardDev parameter for the OData method call.</param>
        /// <param name="size">A size parameter for the OData method call.</param>
        public WorkbookFunctionsConfidence_NormRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken alpha,
            Newtonsoft.Json.Linq.JToken standardDev,
            Newtonsoft.Json.Linq.JToken size)
            : base(requestUrl, client)
        {
            this.SetParameter("alpha", alpha, true);
            this.SetParameter("standardDev", standardDev, true);
            this.SetParameter("size", size, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsConfidence_NormRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsConfidence_NormRequest(functionUrl, this.Client, options);

            if (this.HasParameter("alpha"))
            {
                request.RequestBody.Alpha = this.GetParameter<Newtonsoft.Json.Linq.JToken>("alpha");
            }

            if (this.HasParameter("standardDev"))
            {
                request.RequestBody.StandardDev = this.GetParameter<Newtonsoft.Json.Linq.JToken>("standardDev");
            }

            if (this.HasParameter("size"))
            {
                request.RequestBody.Size = this.GetParameter<Newtonsoft.Json.Linq.JToken>("size");
            }

            return request;
        }
    }
}
