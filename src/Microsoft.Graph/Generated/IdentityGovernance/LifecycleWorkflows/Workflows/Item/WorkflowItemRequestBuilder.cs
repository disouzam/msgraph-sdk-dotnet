// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.CreatedBy;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.ExecutionScope;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.LastModifiedBy;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceActivate;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceCreateNewVersion;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceRestore;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Runs;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Tasks;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults;
using Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions;
using Microsoft.Graph.Models.IdentityGovernance;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item
{
    /// <summary>
    /// Provides operations to manage the workflows property of the microsoft.graph.identityGovernance.lifecycleWorkflowsContainer entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class WorkflowItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the createdBy property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.CreatedBy.CreatedByRequestBuilder CreatedBy
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.CreatedBy.CreatedByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the executionScope property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder ExecutionScope
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.ExecutionScope.ExecutionScopeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the lastModifiedBy property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.LastModifiedBy.LastModifiedByRequestBuilder LastModifiedBy
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.LastModifiedBy.LastModifiedByRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the activate method.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceActivate.MicrosoftGraphIdentityGovernanceActivateRequestBuilder MicrosoftGraphIdentityGovernanceActivate
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceActivate.MicrosoftGraphIdentityGovernanceActivateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createNewVersion method.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceCreateNewVersion.MicrosoftGraphIdentityGovernanceCreateNewVersionRequestBuilder MicrosoftGraphIdentityGovernanceCreateNewVersion
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceCreateNewVersion.MicrosoftGraphIdentityGovernanceCreateNewVersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the restore method.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceRestore.MicrosoftGraphIdentityGovernanceRestoreRequestBuilder MicrosoftGraphIdentityGovernanceRestore
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.MicrosoftGraphIdentityGovernanceRestore.MicrosoftGraphIdentityGovernanceRestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the runs property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Runs.RunsRequestBuilder Runs
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Runs.RunsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the taskReports property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports.TaskReportsRequestBuilder TaskReports
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.TaskReports.TaskReportsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tasks property of the microsoft.graph.identityGovernance.workflowBase entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Tasks.TasksRequestBuilder Tasks
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Tasks.TasksRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userProcessingResults property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.UserProcessingResultsRequestBuilder UserProcessingResults
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.UserProcessingResults.UserProcessingResultsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the versions property of the microsoft.graph.identityGovernance.workflow entity.</summary>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions.VersionsRequestBuilder Versions
        {
            get => new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions.VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkflowItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete a workflow object and its associated tasks, taskProcessingResults and versions. You can restore a deleted workflow and its associated objects within 30 days of deletion.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-workflow-delete?view=graph-rest-1.0" />
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
        /// Read the properties and relationships of a workflow object.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-workflow-get?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.Workflow"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.Workflow?> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder.WorkflowItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.Workflow> GetAsync(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder.WorkflowItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityGovernance.Workflow>(requestInfo, global::Microsoft.Graph.Models.IdentityGovernance.Workflow.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of a workflow object. Only the properties listed in the request body table can be updated. To update any other workflow properties, see workflow: createNewVersion.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-workflow-update?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.Workflow"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.Workflow?> PatchAsync(global::Microsoft.Graph.Models.IdentityGovernance.Workflow body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.Workflow> PatchAsync(global::Microsoft.Graph.Models.IdentityGovernance.Workflow body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityGovernance.Workflow>(requestInfo, global::Microsoft.Graph.Models.IdentityGovernance.Workflow.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete a workflow object and its associated tasks, taskProcessingResults and versions. You can restore a deleted workflow and its associated objects within 30 days of deletion.
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
        /// Read the properties and relationships of a workflow object.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder.WorkflowItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder.WorkflowItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a workflow object. Only the properties listed in the request body table can be updated. To update any other workflow properties, see workflow: createNewVersion.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.IdentityGovernance.Workflow body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(global::Microsoft.Graph.Models.IdentityGovernance.Workflow body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WorkflowItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Read the properties and relationships of a workflow object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WorkflowItemRequestBuilderGetQueryParameters 
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
        public partial class WorkflowItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Workflows.Item.WorkflowItemRequestBuilder.WorkflowItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
        public partial class WorkflowItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
