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
namespace Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId
{
    /// <summary>
    /// Provides operations to manage the learningCourseActivities property of the microsoft.graph.learningProvider entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="externalcourseActivityId">Alternate key of learningCourseActivity</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string externalcourseActivityId = "") : base(requestAdapter, "{+baseurl}/employeeExperience/learningProviders/{learningProvider%2Did}/learningCourseActivities(externalcourseActivityId='{externalcourseActivityId}'){?%24expand,%24select}", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(externalcourseActivityId)) PathParameters.Add("externalcourseActivityId", externalcourseActivityId);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/employeeExperience/learningProviders/{learningProvider%2Did}/learningCourseActivities(externalcourseActivityId='{externalcourseActivityId}'){?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a learningCourseActivity object using the course activity ID of either an assignment or a self-initiated activity.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/learningcourseactivity-delete?view=graph-rest-1.0" />
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
        /// Get learningCourseActivities from employeeExperience
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.LearningCourseActivity"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.LearningCourseActivity?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.LearningCourseActivity> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.LearningCourseActivity>(requestInfo, global::Microsoft.Graph.Models.LearningCourseActivity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a learningCourseActivity object. 
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/learningcourseactivity-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.LearningCourseActivity"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.LearningCourseActivity?> PatchAsync(global::Microsoft.Graph.Models.LearningCourseActivity body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.LearningCourseActivity> PatchAsync(global::Microsoft.Graph.Models.LearningCourseActivity body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.LearningCourseActivity>(requestInfo, global::Microsoft.Graph.Models.LearningCourseActivity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a learningCourseActivity object using the course activity ID of either an assignment or a self-initiated activity.
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
        /// Get learningCourseActivities from employeeExperience
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a learningCourseActivity object. 
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.LearningCourseActivity body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.LearningCourseActivity body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get learningCourseActivities from employeeExperience
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetQueryParameters 
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
        public partial class LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.EmployeeExperience.LearningProviders.Item.LearningCourseActivitiesWithExternalcourseActivityId.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilder.LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class LearningCourseActivitiesWithExternalcourseActivityIdRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
