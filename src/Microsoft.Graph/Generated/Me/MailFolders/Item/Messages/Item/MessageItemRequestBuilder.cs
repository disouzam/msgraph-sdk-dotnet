// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Attachments;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Copy;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateForward;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateReply;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateReplyAll;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Extensions;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Forward;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Move;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Reply;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.ReplyAll;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Send;
using Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Value;
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
namespace Microsoft.Graph.Me.MailFolders.Item.Messages.Item
{
    /// <summary>
    /// Provides operations to manage the messages property of the microsoft.graph.mailFolder entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MessageItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the attachments property of the microsoft.graph.message entity.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Attachments.AttachmentsRequestBuilder Attachments
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Attachments.AttachmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the media for the user entity.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Value.ContentRequestBuilder Content
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Value.ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the copy method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Copy.CopyRequestBuilder Copy
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Copy.CopyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createForward method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateForward.CreateForwardRequestBuilder CreateForward
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateForward.CreateForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createReply method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateReply.CreateReplyRequestBuilder CreateReply
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateReply.CreateReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createReplyAll method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateReplyAll.CreateReplyAllRequestBuilder CreateReplyAll
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.CreateReplyAll.CreateReplyAllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the extensions property of the microsoft.graph.message entity.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Extensions.ExtensionsRequestBuilder Extensions
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Extensions.ExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the forward method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Forward.ForwardRequestBuilder Forward
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Forward.ForwardRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the move method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Move.MoveRequestBuilder Move
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Move.MoveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the reply method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Reply.ReplyRequestBuilder Reply
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Reply.ReplyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the replyAll method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.ReplyAll.ReplyAllRequestBuilder ReplyAll
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.ReplyAll.ReplyAllRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the send method.</summary>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Send.SendRequestBuilder Send
        {
            get => new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.Send.SendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MessageItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/mailFolders/{mailFolder%2Did}/messages/{message%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MessageItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/me/mailFolders/{mailFolder%2Did}/messages/{message%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property messages for me
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
        /// The collection of messages in the mailFolder.
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Message"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Message?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder.MessageItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Message> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder.MessageItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Message>(requestInfo, global::Microsoft.Graph.Models.Message.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property messages in me
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Message"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.Message?> PatchAsync(global::Microsoft.Graph.Models.Message body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.Message> PatchAsync(global::Microsoft.Graph.Models.Message body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.Message>(requestInfo, global::Microsoft.Graph.Models.Message.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property messages for me
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
        /// The collection of messages in the mailFolder.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder.MessageItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder.MessageItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property messages in me
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Message body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.Message body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MessageItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The collection of messages in the mailFolder.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MessageItemRequestBuilderGetQueryParameters 
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
        public partial class MessageItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.Me.MailFolders.Item.Messages.Item.MessageItemRequestBuilder.MessageItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MessageItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
