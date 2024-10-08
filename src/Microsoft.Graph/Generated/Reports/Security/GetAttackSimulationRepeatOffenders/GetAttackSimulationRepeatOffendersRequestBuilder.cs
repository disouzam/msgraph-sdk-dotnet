// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders
{
    /// <summary>
    /// Provides operations to call the getAttackSimulationRepeatOffenders method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class GetAttackSimulationRepeatOffendersRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetAttackSimulationRepeatOffendersRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/security/getAttackSimulationRepeatOffenders(){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetAttackSimulationRepeatOffendersRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/reports/security/getAttackSimulationRepeatOffenders(){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List the tenant users who have yielded to attacks more than once in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/securityreportsroot-getattacksimulationrepeatoffenders?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersGetResponse?> GetAsGetAttackSimulationRepeatOffendersGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersGetResponse> GetAsGetAttackSimulationRepeatOffendersGetResponseAsync(Action<RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersGetResponse>(requestInfo, global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the tenant users who have yielded to attacks more than once in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/securityreportsroot-getattacksimulationrepeatoffenders?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetAttackSimulationRepeatOffendersGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersResponse?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersResponse> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersResponse>(requestInfo, global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the tenant users who have yielded to attacks more than once in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the tenant users who have yielded to attacks more than once in attack simulation and training campaigns. This function supports @odata.nextLink for pagination.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GetAttackSimulationRepeatOffendersRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Reports.Security.GetAttackSimulationRepeatOffenders.GetAttackSimulationRepeatOffendersRequestBuilder.GetAttackSimulationRepeatOffendersRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
