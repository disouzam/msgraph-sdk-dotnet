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
namespace Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName
{
    /// <summary>
    /// Provides operations to call the findTenantInformationByDomainName method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FindTenantInformationByDomainNameWithDomainNameRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="domainName">Usage: domainName=&apos;{domainName}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string domainName = "") : base(requestAdapter, "{+baseurl}/tenantRelationships/findTenantInformationByDomainName(domainName='{domainName}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(domainName)) PathParameters.Add("domainName", domainName);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FindTenantInformationByDomainNameWithDomainNameRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/findTenantInformationByDomainName(domainName='{domainName}')", rawUrl)
        {
        }
        /// <summary>
        /// Given a domain name, search for a tenant and read its tenantInformation. You can use this API to validate tenant information and use the tenantId to configure cross-tenant access settings between you and the tenant.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/tenantrelationship-findtenantinformationbydomainname?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TenantInformation"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.TenantInformation?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.TenantInformation> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.TenantInformation>(requestInfo, global::Microsoft.Graph.Models.TenantInformation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Given a domain name, search for a tenant and read its tenantInformation. You can use this API to validate tenant information and use the tenantId to configure cross-tenant access settings between you and the tenant.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.TenantRelationships.FindTenantInformationByDomainNameWithDomainName.FindTenantInformationByDomainNameWithDomainNameRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class FindTenantInformationByDomainNameWithDomainNameRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
