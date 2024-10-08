// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Print.Printers.Item.Jobs.Item.Start
{
    /// <summary>
    /// Provides operations to call the start method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class StartRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Print.Printers.Item.Jobs.Item.Start.StartRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StartRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/printers/{printer%2Did}/jobs/{printJob%2Did}/start", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Print.Printers.Item.Jobs.Item.Start.StartRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StartRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/print/printers/{printer%2Did}/jobs/{printJob%2Did}/start", rawUrl)
        {
        }
        /// <summary>
        /// Submits the print job to the associated printer or printerShare. It will be printed after any existing pending jobs are completed, aborted, or canceled.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/printjob-start?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.PrintJobStatus"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.PrintJobStatus?> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.PrintJobStatus> PostAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToPostRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.PrintJobStatus>(requestInfo, global::Microsoft.Graph.Models.PrintJobStatus.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Submits the print job to the associated printer or printerShare. It will be printed after any existing pending jobs are completed, aborted, or canceled.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Print.Printers.Item.Jobs.Item.Start.StartRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Print.Printers.Item.Jobs.Item.Start.StartRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Print.Printers.Item.Jobs.Item.Start.StartRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class StartRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
