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
namespace Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment
{
    /// <summary>
    /// Casts the previous resource to appRoleAssignment.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class GraphAppRoleAssignmentRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphAppRoleAssignmentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/registeredDevices/{directoryObject%2Did}/graph.appRoleAssignment{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GraphAppRoleAssignmentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/registeredDevices/{directoryObject%2Did}/graph.appRoleAssignment{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AppRoleAssignment"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.AppRoleAssignment?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder.GraphAppRoleAssignmentRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.AppRoleAssignment> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder.GraphAppRoleAssignmentRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.AppRoleAssignment>(requestInfo, global::Microsoft.Graph.Models.AppRoleAssignment.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder.GraphAppRoleAssignmentRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder.GraphAppRoleAssignmentRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.appRoleAssignment
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GraphAppRoleAssignmentRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class GraphAppRoleAssignmentRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Users.Item.RegisteredDevices.Item.GraphAppRoleAssignment.GraphAppRoleAssignmentRequestBuilder.GraphAppRoleAssignmentRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
