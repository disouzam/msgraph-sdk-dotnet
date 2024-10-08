// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Communications.Calls.Item.AddLargeGalleryView;
using Microsoft.Graph.Communications.Calls.Item.Answer;
using Microsoft.Graph.Communications.Calls.Item.AudioRoutingGroups;
using Microsoft.Graph.Communications.Calls.Item.CancelMediaProcessing;
using Microsoft.Graph.Communications.Calls.Item.ChangeScreenSharingRole;
using Microsoft.Graph.Communications.Calls.Item.ContentSharingSessions;
using Microsoft.Graph.Communications.Calls.Item.KeepAlive;
using Microsoft.Graph.Communications.Calls.Item.Mute;
using Microsoft.Graph.Communications.Calls.Item.Operations;
using Microsoft.Graph.Communications.Calls.Item.Participants;
using Microsoft.Graph.Communications.Calls.Item.PlayPrompt;
using Microsoft.Graph.Communications.Calls.Item.RecordResponse;
using Microsoft.Graph.Communications.Calls.Item.Redirect;
using Microsoft.Graph.Communications.Calls.Item.Reject;
using Microsoft.Graph.Communications.Calls.Item.SendDtmfTones;
using Microsoft.Graph.Communications.Calls.Item.SubscribeToTone;
using Microsoft.Graph.Communications.Calls.Item.Transfer;
using Microsoft.Graph.Communications.Calls.Item.Unmute;
using Microsoft.Graph.Communications.Calls.Item.UpdateRecordingStatus;
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
namespace Microsoft.Graph.Communications.Calls.Item
{
    /// <summary>
    /// Provides operations to manage the calls property of the microsoft.graph.cloudCommunications entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class CallItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the addLargeGalleryView method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.AddLargeGalleryView.AddLargeGalleryViewRequestBuilder AddLargeGalleryView
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.AddLargeGalleryView.AddLargeGalleryViewRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the answer method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Answer.AnswerRequestBuilder Answer
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Answer.AnswerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the audioRoutingGroups property of the microsoft.graph.call entity.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.AudioRoutingGroups.AudioRoutingGroupsRequestBuilder AudioRoutingGroups
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.AudioRoutingGroups.AudioRoutingGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the cancelMediaProcessing method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.CancelMediaProcessing.CancelMediaProcessingRequestBuilder CancelMediaProcessing
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.CancelMediaProcessing.CancelMediaProcessingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the changeScreenSharingRole method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.ChangeScreenSharingRole.ChangeScreenSharingRoleRequestBuilder ChangeScreenSharingRole
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.ChangeScreenSharingRole.ChangeScreenSharingRoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the contentSharingSessions property of the microsoft.graph.call entity.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.ContentSharingSessions.ContentSharingSessionsRequestBuilder ContentSharingSessions
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.ContentSharingSessions.ContentSharingSessionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the keepAlive method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.KeepAlive.KeepAliveRequestBuilder KeepAlive
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.KeepAlive.KeepAliveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the mute method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Mute.MuteRequestBuilder Mute
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Mute.MuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the operations property of the microsoft.graph.call entity.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Operations.OperationsRequestBuilder Operations
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Operations.OperationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the participants property of the microsoft.graph.call entity.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Participants.ParticipantsRequestBuilder Participants
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Participants.ParticipantsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the playPrompt method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.PlayPrompt.PlayPromptRequestBuilder PlayPrompt
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.PlayPrompt.PlayPromptRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the recordResponse method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.RecordResponse.RecordResponseRequestBuilder RecordResponse
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.RecordResponse.RecordResponseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the redirect method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Redirect.RedirectRequestBuilder Redirect
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Redirect.RedirectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reject method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Reject.RejectRequestBuilder Reject
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Reject.RejectRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the sendDtmfTones method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.SendDtmfTones.SendDtmfTonesRequestBuilder SendDtmfTones
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.SendDtmfTones.SendDtmfTonesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the subscribeToTone method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.SubscribeToTone.SubscribeToToneRequestBuilder SubscribeToTone
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.SubscribeToTone.SubscribeToToneRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the transfer method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Transfer.TransferRequestBuilder Transfer
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Transfer.TransferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unmute method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.Unmute.UnmuteRequestBuilder Unmute
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.Unmute.UnmuteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateRecordingStatus method.</summary>
        public global::Microsoft.Graph.Communications.Calls.Item.UpdateRecordingStatus.UpdateRecordingStatusRequestBuilder UpdateRecordingStatus
        {
            get => new global::Microsoft.Graph.Communications.Calls.Item.UpdateRecordingStatus.UpdateRecordingStatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/communications/calls/{call%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CallItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/communications/calls/{call%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete or hang up an active call. For group calls, this will only delete your call leg and the underlying group call will still continue.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/call-delete?view=graph-rest-1.0" />
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
        /// Retrieve the properties and relationships of a call object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/call-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Call"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Call?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Call> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Call>(requestInfo, global::Microsoft.Graph.Models.Call.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property calls in communications
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Call"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Call?> PatchAsync(global::Microsoft.Graph.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Call> PatchAsync(global::Microsoft.Graph.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Call>(requestInfo, global::Microsoft.Graph.Models.Call.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete or hang up an active call. For group calls, this will only delete your call leg and the underlying group call will still continue.
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
        /// Retrieve the properties and relationships of a call object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property calls in communications
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Call body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CallItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Retrieve the properties and relationships of a call object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CallItemRequestBuilderGetQueryParameters 
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
        public partial class CallItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Communications.Calls.Item.CallItemRequestBuilder.CallItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class CallItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
