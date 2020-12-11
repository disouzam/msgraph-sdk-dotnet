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
    /// The type WorkbookFunctionsReplaceRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsReplaceRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsReplaceRequest>, IWorkbookFunctionsReplaceRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsReplaceRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="oldText">A oldText parameter for the OData method call.</param>
        /// <param name="startNum">A startNum parameter for the OData method call.</param>
        /// <param name="numChars">A numChars parameter for the OData method call.</param>
        /// <param name="newText">A newText parameter for the OData method call.</param>
        public WorkbookFunctionsReplaceRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken oldText,
            Newtonsoft.Json.Linq.JToken startNum,
            Newtonsoft.Json.Linq.JToken numChars,
            Newtonsoft.Json.Linq.JToken newText)
            : base(requestUrl, client)
        {
            this.SetParameter("oldText", oldText, true);
            this.SetParameter("startNum", startNum, true);
            this.SetParameter("numChars", numChars, true);
            this.SetParameter("newText", newText, true);
            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsReplaceRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsReplaceRequest(functionUrl, this.Client, options);

            if (this.HasParameter("oldText"))
            {
                request.RequestBody.OldText = this.GetParameter<Newtonsoft.Json.Linq.JToken>("oldText");
            }

            if (this.HasParameter("startNum"))
            {
                request.RequestBody.StartNum = this.GetParameter<Newtonsoft.Json.Linq.JToken>("startNum");
            }

            if (this.HasParameter("numChars"))
            {
                request.RequestBody.NumChars = this.GetParameter<Newtonsoft.Json.Linq.JToken>("numChars");
            }

            if (this.HasParameter("newText"))
            {
                request.RequestBody.NewText = this.GetParameter<Newtonsoft.Json.Linq.JToken>("newText");
            }

            return request;
        }
    }
}
