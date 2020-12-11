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
    /// The type WorkbookFunctionsQuotientRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsQuotientRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsQuotientRequest>, IWorkbookFunctionsQuotientRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsQuotientRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="numerator">A numerator parameter for the OData method call.</param>
        /// <param name="denominator">A denominator parameter for the OData method call.</param>
        public WorkbookFunctionsQuotientRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken numerator,
            Newtonsoft.Json.Linq.JToken denominator)
            : base(requestUrl, client)
        {
            this.SetParameter("numerator", numerator, true);
            this.SetParameter("denominator", denominator, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsQuotientRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsQuotientRequest(functionUrl, this.Client, options);

            if (this.HasParameter("numerator"))
            {
                request.RequestBody.Numerator = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numerator");
            }

            if (this.HasParameter("denominator"))
            {
                request.RequestBody.Denominator = this.GetParameter<Newtonsoft.Json.Linq.JToken>("denominator");
            }

            return request;
        }
    }
}
