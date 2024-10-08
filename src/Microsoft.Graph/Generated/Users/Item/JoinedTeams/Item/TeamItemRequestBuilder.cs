// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.AllChannels;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Archive;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Channels;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Clone;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.CompleteMigration;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Group;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.IncomingChannels;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.InstalledApps;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Members;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Operations;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.PermissionGrants;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Photo;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.PrimaryChannel;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Schedule;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.SendActivityNotification;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Tags;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Template;
using Microsoft.Graph.Users.Item.JoinedTeams.Item.Unarchive;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Users.Item.JoinedTeams.Item
{
    /// <summary>
    /// Provides operations to manage the joinedTeams property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class TeamItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the allChannels property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.AllChannels.AllChannelsRequestBuilder AllChannels
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.AllChannels.AllChannelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the archive method.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Archive.ArchiveRequestBuilder Archive
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Archive.ArchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the channels property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Channels.ChannelsRequestBuilder Channels
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Channels.ChannelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the clone method.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Clone.CloneRequestBuilder Clone
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Clone.CloneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the completeMigration method.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.CompleteMigration.CompleteMigrationRequestBuilder CompleteMigration
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.CompleteMigration.CompleteMigrationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the group property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Group.GroupRequestBuilder Group
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Group.GroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the incomingChannels property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.IncomingChannels.IncomingChannelsRequestBuilder IncomingChannels
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.IncomingChannels.IncomingChannelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the installedApps property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.InstalledApps.InstalledAppsRequestBuilder InstalledApps
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.InstalledApps.InstalledAppsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the members property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Members.MembersRequestBuilder Members
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the permissionGrants property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.PermissionGrants.PermissionGrantsRequestBuilder PermissionGrants
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.PermissionGrants.PermissionGrantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the photo property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Photo.PhotoRequestBuilder Photo
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Photo.PhotoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the primaryChannel property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.PrimaryChannel.PrimaryChannelRequestBuilder PrimaryChannel
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.PrimaryChannel.PrimaryChannelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the schedule property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Schedule.ScheduleRequestBuilder Schedule
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Schedule.ScheduleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendActivityNotification method.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.SendActivityNotification.SendActivityNotificationRequestBuilder SendActivityNotification
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.SendActivityNotification.SendActivityNotificationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tags property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Tags.TagsRequestBuilder Tags
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Tags.TagsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the template property of the microsoft.graph.team entity.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Template.TemplateRequestBuilder Template
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Template.TemplateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unarchive method.</summary>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Unarchive.UnarchiveRequestBuilder Unarchive
        {
            get => new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.Unarchive.UnarchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/joinedTeams/{team%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TeamItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/joinedTeams/{team%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property joinedTeams for users
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
        /// Get joinedTeams from users
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Team"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Team?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder.TeamItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Team> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder.TeamItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Team>(requestInfo, global::Microsoft.Graph.Models.Team.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property joinedTeams in users
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Team"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Team?> PatchAsync(global::Microsoft.Graph.Models.Team body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Team> PatchAsync(global::Microsoft.Graph.Models.Team body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Team>(requestInfo, global::Microsoft.Graph.Models.Team.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property joinedTeams for users
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
        /// Get joinedTeams from users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder.TeamItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder.TeamItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property joinedTeams in users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Team body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Team body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Get joinedTeams from users
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamItemRequestBuilderGetQueryParameters 
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
        public partial class TeamItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Users.Item.JoinedTeams.Item.TeamItemRequestBuilder.TeamItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class TeamItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
