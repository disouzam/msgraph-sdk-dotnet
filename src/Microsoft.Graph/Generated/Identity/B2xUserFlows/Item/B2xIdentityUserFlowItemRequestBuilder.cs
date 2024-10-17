// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration;
using Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders;
using Microsoft.Graph.Identity.B2xUserFlows.Item.Languages;
using Microsoft.Graph.Identity.B2xUserFlows.Item.UserAttributeAssignments;
using Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders;
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
namespace Microsoft.Graph.Identity.B2xUserFlows.Item
{
    /// <summary>
    /// Provides operations to manage the b2xUserFlows property of the microsoft.graph.identityContainer entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class B2xIdentityUserFlowItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The apiConnectorConfiguration property</summary>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.ApiConnectorConfigurationRequestBuilder ApiConnectorConfiguration
        {
            get => new global::Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.ApiConnectorConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identityProviders property of the microsoft.graph.b2xIdentityUserFlow entity.</summary>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.IdentityProvidersRequestBuilder IdentityProviders
        {
            get => new global::Microsoft.Graph.Identity.B2xUserFlows.Item.IdentityProviders.IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the languages property of the microsoft.graph.b2xIdentityUserFlow entity.</summary>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.Languages.LanguagesRequestBuilder Languages
        {
            get => new global::Microsoft.Graph.Identity.B2xUserFlows.Item.Languages.LanguagesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userAttributeAssignments property of the microsoft.graph.b2xIdentityUserFlow entity.</summary>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserAttributeAssignments.UserAttributeAssignmentsRequestBuilder UserAttributeAssignments
        {
            get => new global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserAttributeAssignments.UserAttributeAssignmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userFlowIdentityProviders property of the microsoft.graph.b2xIdentityUserFlow entity.</summary>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.UserFlowIdentityProvidersRequestBuilder UserFlowIdentityProviders
        {
            get => new global::Microsoft.Graph.Identity.B2xUserFlows.Item.UserFlowIdentityProviders.UserFlowIdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public B2xIdentityUserFlowItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public B2xIdentityUserFlowItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/b2xUserFlows/{b2xIdentityUserFlow%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a b2xIdentityUserFlow object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/b2xidentityuserflow-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the properties and relationships of a b2xIdentityUserFlow object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/b2xidentityuserflow-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.B2xIdentityUserFlow"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.B2xIdentityUserFlow?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder.B2xIdentityUserFlowItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.B2xIdentityUserFlow> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder.B2xIdentityUserFlowItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.B2xIdentityUserFlow>(requestInfo, global::Microsoft.Graph.Models.B2xIdentityUserFlow.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property b2xUserFlows in identity
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.B2xIdentityUserFlow"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.B2xIdentityUserFlow?> PatchAsync(global::Microsoft.Graph.Models.B2xIdentityUserFlow body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.B2xIdentityUserFlow> PatchAsync(global::Microsoft.Graph.Models.B2xIdentityUserFlow body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.B2xIdentityUserFlow>(requestInfo, global::Microsoft.Graph.Models.B2xIdentityUserFlow.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a b2xIdentityUserFlow object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of a b2xIdentityUserFlow object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder.B2xIdentityUserFlowItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder.B2xIdentityUserFlowItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property b2xUserFlows in identity
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.B2xIdentityUserFlow body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.B2xIdentityUserFlow body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class B2xIdentityUserFlowItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the properties and relationships of a b2xIdentityUserFlow object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class B2xIdentityUserFlowItemRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class B2xIdentityUserFlowItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Identity.B2xUserFlows.Item.B2xIdentityUserFlowItemRequestBuilder.B2xIdentityUserFlowItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class B2xIdentityUserFlowItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
