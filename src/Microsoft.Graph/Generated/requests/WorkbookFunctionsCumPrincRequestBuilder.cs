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
    /// The type WorkbookFunctionsCumPrincRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsCumPrincRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsCumPrincRequest>, IWorkbookFunctionsCumPrincRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsCumPrincRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="rate">A rate parameter for the OData method call.</param>
        /// <param name="nper">A nper parameter for the OData method call.</param>
        /// <param name="pv">A pv parameter for the OData method call.</param>
        /// <param name="startPeriod">A startPeriod parameter for the OData method call.</param>
        /// <param name="endPeriod">A endPeriod parameter for the OData method call.</param>
        /// <param name="type">A type parameter for the OData method call.</param>
        public WorkbookFunctionsCumPrincRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken rate,
            Newtonsoft.Json.Linq.JToken nper,
            Newtonsoft.Json.Linq.JToken pv,
            Newtonsoft.Json.Linq.JToken startPeriod,
            Newtonsoft.Json.Linq.JToken endPeriod,
            Newtonsoft.Json.Linq.JToken type)
            : base(requestUrl, client)
        {
            this.SetParameter("rate", rate, true);
            this.SetParameter("nper", nper, true);
            this.SetParameter("pv", pv, true);
            this.SetParameter("startPeriod", startPeriod, true);
            this.SetParameter("endPeriod", endPeriod, true);
            this.SetParameter("type", type, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsCumPrincRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsCumPrincRequest(functionUrl, this.Client, options);

            if (this.HasParameter("rate"))
            {
                request.RequestBody.Rate = this.GetParameter<Newtonsoft.Json.Linq.JToken>("rate");
            }

            if (this.HasParameter("nper"))
            {
                request.RequestBody.Nper = this.GetParameter<Newtonsoft.Json.Linq.JToken>("nper");
            }

            if (this.HasParameter("pv"))
            {
                request.RequestBody.Pv = this.GetParameter<Newtonsoft.Json.Linq.JToken>("pv");
            }

            if (this.HasParameter("startPeriod"))
            {
                request.RequestBody.StartPeriod = this.GetParameter<Newtonsoft.Json.Linq.JToken>("startPeriod");
            }

            if (this.HasParameter("endPeriod"))
            {
                request.RequestBody.EndPeriod = this.GetParameter<Newtonsoft.Json.Linq.JToken>("endPeriod");
            }

            if (this.HasParameter("type"))
            {
                request.RequestBody.Type = this.GetParameter<Newtonsoft.Json.Linq.JToken>("type");
            }

            return request;
        }
    }
}
