// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GitHubRepoEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The baseUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUrl
        {
            get { return BackingStore?.Get<string?>("baseUrl"); }
            set { BackingStore?.Set("baseUrl", value); }
        }
#nullable restore
#else
        public string BaseUrl
        {
            get { return BackingStore?.Get<string>("baseUrl"); }
            set { BackingStore?.Set("baseUrl", value); }
        }
#endif
        /// <summary>The login property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Login
        {
            get { return BackingStore?.Get<string?>("login"); }
            set { BackingStore?.Set("login", value); }
        }
#nullable restore
#else
        public string Login
        {
            get { return BackingStore?.Get<string>("login"); }
            set { BackingStore?.Set("login", value); }
        }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner
        {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public string Owner
        {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The ownerType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OwnerType
        {
            get { return BackingStore?.Get<string?>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
#nullable restore
#else
        public string OwnerType
        {
            get { return BackingStore?.Get<string>("ownerType"); }
            set { BackingStore?.Set("ownerType", value); }
        }
#endif
        /// <summary>The repoId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RepoId
        {
            get { return BackingStore?.Get<string?>("repoId"); }
            set { BackingStore?.Set("repoId", value); }
        }
#nullable restore
#else
        public string RepoId
        {
            get { return BackingStore?.Get<string>("repoId"); }
            set { BackingStore?.Set("repoId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.GitHubRepoEvidence"/> and sets the default values.
        /// </summary>
        public GitHubRepoEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.gitHubRepoEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.GitHubRepoEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.GitHubRepoEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.GitHubRepoEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "baseUrl", n => { BaseUrl = n.GetStringValue(); } },
                { "login", n => { Login = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetStringValue(); } },
                { "ownerType", n => { OwnerType = n.GetStringValue(); } },
                { "repoId", n => { RepoId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("baseUrl", BaseUrl);
            writer.WriteStringValue("login", Login);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("ownerType", OwnerType);
            writer.WriteStringValue("repoId", RepoId);
        }
    }
}
#pragma warning restore CS0618
