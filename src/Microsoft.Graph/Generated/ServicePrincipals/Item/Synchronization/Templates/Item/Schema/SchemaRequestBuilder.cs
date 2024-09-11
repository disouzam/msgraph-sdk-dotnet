// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.Directories;
using Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.FilterOperators;
using Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.Functions;
using Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.ParseExpression;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema
{
    /// <summary>
    /// Provides operations to manage the schema property of the microsoft.graph.synchronizationTemplate entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class SchemaRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the directories property of the microsoft.graph.synchronizationSchema entity.</summary>
        public global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.Directories.DirectoriesRequestBuilder Directories
        {
            get => new global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.Directories.DirectoriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the filterOperators method.</summary>
        public global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.FilterOperators.FilterOperatorsRequestBuilder FilterOperators
        {
            get => new global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.FilterOperators.FilterOperatorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the functions method.</summary>
        public global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.Functions.FunctionsRequestBuilder Functions
        {
            get => new global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.Functions.FunctionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the parseExpression method.</summary>
        public global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionRequestBuilder ParseExpression
        {
            get => new global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.ParseExpression.ParseExpressionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SchemaRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/templates/{synchronizationTemplate%2Did}/schema{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SchemaRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/synchronization/templates/{synchronizationTemplate%2Did}/schema{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property schema for servicePrincipals
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
        /// Default synchronization schema for the jobs based on this template.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SynchronizationSchema"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.SynchronizationSchema?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder.SchemaRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.SynchronizationSchema> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder.SchemaRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.SynchronizationSchema>(requestInfo, global::Microsoft.Graph.Models.SynchronizationSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property schema in servicePrincipals
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SynchronizationSchema"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.SynchronizationSchema?> PatchAsync(global::Microsoft.Graph.Models.SynchronizationSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.SynchronizationSchema> PatchAsync(global::Microsoft.Graph.Models.SynchronizationSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.SynchronizationSchema>(requestInfo, global::Microsoft.Graph.Models.SynchronizationSchema.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property schema for servicePrincipals
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
        /// Default synchronization schema for the jobs based on this template.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder.SchemaRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder.SchemaRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property schema in servicePrincipals
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.SynchronizationSchema body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.SynchronizationSchema body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SchemaRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Default synchronization schema for the jobs based on this template.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SchemaRequestBuilderGetQueryParameters 
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
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SchemaRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.ServicePrincipals.Item.Synchronization.Templates.Item.Schema.SchemaRequestBuilder.SchemaRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class SchemaRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
