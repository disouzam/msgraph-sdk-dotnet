// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Policies.FeatureRolloutPolicies.Item.AppliesTo.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Policies.FeatureRolloutPolicies.Item.AppliesTo.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \policies\featureRolloutPolicies\{featureRolloutPolicy-id}\appliesTo\{directoryObject-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class DirectoryObjectItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the collection of policyRoot entities.</summary>
        public global::Microsoft.Graph.Policies.FeatureRolloutPolicies.Item.AppliesTo.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Policies.FeatureRolloutPolicies.Item.AppliesTo.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Policies.FeatureRolloutPolicies.Item.AppliesTo.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/policies/featureRolloutPolicies/{featureRolloutPolicy%2Did}/appliesTo/{directoryObject%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Policies.FeatureRolloutPolicies.Item.AppliesTo.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/policies/featureRolloutPolicies/{featureRolloutPolicy%2Did}/appliesTo/{directoryObject%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
