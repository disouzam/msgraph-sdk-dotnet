// <auto-generated/>
#pragma warning disable CS0618
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
namespace Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Insights.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTime
{
    /// <summary>
    /// Provides operations to call the workflowsProcessedByCategory method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Insights.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTime.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, DateTimeOffset? endDateTime = default, DateTimeOffset? startDateTime = default) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/insights/microsoft.graph.identityGovernance.workflowsProcessedByCategory(startDateTime={startDateTime},endDateTime={endDateTime})", pathParameters)
        {
            if (endDateTime != null) PathParameters.Add("endDateTime", endDateTime);
            if (startDateTime != null) PathParameters.Add("startDateTime", startDateTime);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Insights.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTime.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identityGovernance/lifecycleWorkflows/insights/microsoft.graph.identityGovernance.workflowsProcessedByCategory(startDateTime={startDateTime},endDateTime={endDateTime})", rawUrl)
        {
        }
        /// <summary>
        /// Provide a summary of workflows processed, by category, in a tenant. This allows you to quickly get category information, by numerical value, bypassing other information found in the WorkflowsProcessedSummary call.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/identitygovernance-insights-workflowsprocessedbycategory?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory>(requestInfo, global::Microsoft.Graph.Models.IdentityGovernance.WorkflowsInsightsByCategory.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provide a summary of workflows processed, by category, in a tenant. This allows you to quickly get category information, by numerical value, bypassing other information found in the WorkflowsProcessedSummary call.
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
        /// <returns>A <see cref="global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Insights.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTime.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Insights.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTime.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Microsoft.Graph.IdentityGovernance.LifecycleWorkflows.Insights.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTime.MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
        public partial class MicrosoftGraphIdentityGovernanceWorkflowsProcessedByCategoryWithStartDateTimeWithEndDateTimeRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
