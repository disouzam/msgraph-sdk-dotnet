// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Groups.Item.Owners.Item.GraphApplication;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphDevice;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphGroup;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphOrgContact;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphServicePrincipal;
using Microsoft.Graph.Groups.Item.Owners.Item.GraphUser;
using Microsoft.Graph.Groups.Item.Owners.Item.Ref;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Groups.Item.Owners.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \groups\{group-id}\owners\{directoryObject-id}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class DirectoryObjectItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Casts the previous resource to application.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.GraphApplication.GraphApplicationRequestBuilder GraphApplication
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.GraphApplication.GraphApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to device.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.GraphDevice.GraphDeviceRequestBuilder GraphDevice
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.GraphDevice.GraphDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.GraphGroup.GraphGroupRequestBuilder GraphGroup
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.GraphGroup.GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to orgContact.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.GraphOrgContact.GraphOrgContactRequestBuilder GraphOrgContact
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.GraphOrgContact.GraphOrgContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.GraphServicePrincipal.GraphServicePrincipalRequestBuilder GraphServicePrincipal
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.GraphServicePrincipal.GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.GraphUser.GraphUserRequestBuilder GraphUser
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.GraphUser.GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of group entities.</summary>
        public global::Microsoft.Graph.Groups.Item.Owners.Item.Ref.RefRequestBuilder Ref
        {
            get => new global::Microsoft.Graph.Groups.Item.Owners.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Owners.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/owners/{directoryObject%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Groups.Item.Owners.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/owners/{directoryObject%2Did}", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
