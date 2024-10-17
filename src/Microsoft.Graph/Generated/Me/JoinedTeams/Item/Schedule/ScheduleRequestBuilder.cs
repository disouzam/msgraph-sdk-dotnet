// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OfferShiftRequests;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OpenShiftChangeRequests;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OpenShifts;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.SchedulingGroups;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.Share;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.Shifts;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.SwapShiftsChangeRequests;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimeOffReasons;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimeOffRequests;
using Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimesOff;
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
namespace Microsoft.Graph.Me.JoinedTeams.Item.Schedule
{
    /// <summary>
    /// Provides operations to manage the schedule property of the microsoft.graph.team entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ScheduleRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the offerShiftRequests property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OfferShiftRequests.OfferShiftRequestsRequestBuilder OfferShiftRequests
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OfferShiftRequests.OfferShiftRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the openShiftChangeRequests property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OpenShiftChangeRequests.OpenShiftChangeRequestsRequestBuilder OpenShiftChangeRequests
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OpenShiftChangeRequests.OpenShiftChangeRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the openShifts property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OpenShifts.OpenShiftsRequestBuilder OpenShifts
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.OpenShifts.OpenShiftsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the schedulingGroups property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.SchedulingGroups.SchedulingGroupsRequestBuilder SchedulingGroups
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.SchedulingGroups.SchedulingGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the share method.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.Share.ShareRequestBuilder Share
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.Share.ShareRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the shifts property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.Shifts.ShiftsRequestBuilder Shifts
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.Shifts.ShiftsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the swapShiftsChangeRequests property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.SwapShiftsChangeRequests.SwapShiftsChangeRequestsRequestBuilder SwapShiftsChangeRequests
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.SwapShiftsChangeRequests.SwapShiftsChangeRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timeOffReasons property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimeOffReasons.TimeOffReasonsRequestBuilder TimeOffReasons
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimeOffReasons.TimeOffReasonsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timeOffRequests property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimeOffRequests.TimeOffRequestsRequestBuilder TimeOffRequests
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimeOffRequests.TimeOffRequestsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the timesOff property of the microsoft.graph.schedule entity.</summary>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimesOff.TimesOffRequestBuilder TimesOff
        {
            get => new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.TimesOff.TimesOffRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/joinedTeams/{team%2Did}/schedule{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ScheduleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/joinedTeams/{team%2Did}/schedule{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property schedule for me
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
        /// The schedule of shifts for this team.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Schedule"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Schedule?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Schedule> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Schedule>(requestInfo, global::Microsoft.Graph.Models.Schedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property schedule in me
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Schedule"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Schedule?> PutAsync(global::Microsoft.Graph.Models.Schedule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Schedule> PutAsync(global::Microsoft.Graph.Models.Schedule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Schedule>(requestInfo, global::Microsoft.Graph.Models.Schedule.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property schedule for me
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
        /// The schedule of shifts for this team.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property schedule in me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Microsoft.Graph.Models.Schedule body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Microsoft.Graph.Models.Schedule body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScheduleRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The schedule of shifts for this team.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScheduleRequestBuilderGetQueryParameters 
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
        public partial class ScheduleRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.JoinedTeams.Item.Schedule.ScheduleRequestBuilder.ScheduleRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class ScheduleRequestBuilderPutRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
