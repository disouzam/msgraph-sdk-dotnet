// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.BackgroundImage;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.BannerLogo;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.CustomCSS;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.Favicon;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.HeaderLogo;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.SquareLogo;
using Microsoft.Graph.Organization.Item.Branding.Localizations.Item.SquareLogoDark;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Organization.Item.Branding.Localizations.Item
{
    /// <summary>
    /// Provides operations to manage the localizations property of the microsoft.graph.organizationalBranding entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class OrganizationalBrandingLocalizationItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.BackgroundImage.BackgroundImageRequestBuilder BackgroundImage
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.BackgroundImage.BackgroundImageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.BannerLogo.BannerLogoRequestBuilder BannerLogo
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.BannerLogo.BannerLogoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.CustomCSS.CustomCSSRequestBuilder CustomCSS
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.CustomCSS.CustomCSSRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.Favicon.FaviconRequestBuilder Favicon
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.Favicon.FaviconRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.HeaderLogo.HeaderLogoRequestBuilder HeaderLogo
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.HeaderLogo.HeaderLogoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.SquareLogo.SquareLogoRequestBuilder SquareLogo
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.SquareLogo.SquareLogoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the organization entity.</summary>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.SquareLogoDark.SquareLogoDarkRequestBuilder SquareLogoDark
        {
            get => new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.SquareLogoDark.SquareLogoDarkRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationalBrandingLocalizationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organization/{organization%2Did}/branding/localizations/{organizationalBrandingLocalization%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OrganizationalBrandingLocalizationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/organization/{organization%2Did}/branding/localizations/{organizationalBrandingLocalization%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a localized branding object. To delete the organizationalBrandingLocalization object, all images (Stream types) must first be removed from the object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-delete?view=graph-rest-1.0" />
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
        /// Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OrganizationalBrandingLocalization"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.OrganizationalBrandingLocalization?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder.OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.OrganizationalBrandingLocalization> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder.OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.OrganizationalBrandingLocalization>(requestInfo, global::Microsoft.Graph.Models.OrganizationalBrandingLocalization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of an organizationalBrandingLocalization object for a specific localization.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/organizationalbrandinglocalization-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OrganizationalBrandingLocalization"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.OrganizationalBrandingLocalization?> PatchAsync(global::Microsoft.Graph.Models.OrganizationalBrandingLocalization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.OrganizationalBrandingLocalization> PatchAsync(global::Microsoft.Graph.Models.OrganizationalBrandingLocalization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.OrganizationalBrandingLocalization>(requestInfo, global::Microsoft.Graph.Models.OrganizationalBrandingLocalization.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a localized branding object. To delete the organizationalBrandingLocalization object, all images (Stream types) must first be removed from the object.
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
        /// Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder.OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder.OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an organizationalBrandingLocalization object for a specific localization.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.OrganizationalBrandingLocalization body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.OrganizationalBrandingLocalization body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class OrganizationalBrandingLocalizationItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of an organizationalBrandingLocalization object. To retrieve a localization branding object, specify the value of id in the URL.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters 
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
        public partial class OrganizationalBrandingLocalizationItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Organization.Item.Branding.Localizations.Item.OrganizationalBrandingLocalizationItemRequestBuilder.OrganizationalBrandingLocalizationItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class OrganizationalBrandingLocalizationItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
