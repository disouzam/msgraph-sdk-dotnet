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
    /// The type WorkbookFunctionsLeftbRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsLeftbRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsLeftbRequest>, IWorkbookFunctionsLeftbRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsLeftbRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="text">A text parameter for the OData method call.</param>
        /// <param name="numBytes">A numBytes parameter for the OData method call.</param>
        public WorkbookFunctionsLeftbRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken text,
            Newtonsoft.Json.Linq.JToken numBytes)
            : base(requestUrl, client)
        {
            this.SetParameter("text", text, true);
            this.SetParameter("numBytes", numBytes, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsLeftbRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsLeftbRequest(functionUrl, this.Client, options);

            if (this.HasParameter("text"))
            {
                request.RequestBody.Text = this.GetParameter<Newtonsoft.Json.Linq.JToken>("text");
            }

            if (this.HasParameter("numBytes"))
            {
                request.RequestBody.NumBytes = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numBytes");
            }

            return request;
        }
    }
}
