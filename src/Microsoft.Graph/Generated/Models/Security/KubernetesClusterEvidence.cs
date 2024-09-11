// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class KubernetesClusterEvidence : global::Microsoft.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The cloud identifier of the cluster. Can be either an amazonResourceEvidence, azureResourceEvidence, or googleCloudResourceEvidence object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.AlertEvidence? CloudResource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AlertEvidence?>("cloudResource"); }
            set { BackingStore?.Set("cloudResource", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.AlertEvidence CloudResource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AlertEvidence>("cloudResource"); }
            set { BackingStore?.Set("cloudResource", value); }
        }
#endif
        /// <summary>The distribution type of the cluster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Distribution
        {
            get { return BackingStore?.Get<string?>("distribution"); }
            set { BackingStore?.Set("distribution", value); }
        }
#nullable restore
#else
        public string Distribution
        {
            get { return BackingStore?.Get<string>("distribution"); }
            set { BackingStore?.Set("distribution", value); }
        }
#endif
        /// <summary>The cluster name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The platform the cluster runs on. Possible values are: unknown, aks, eks, gke, arc, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.Security.KubernetesPlatform? Platform
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.KubernetesPlatform?>("platform"); }
            set { BackingStore?.Set("platform", value); }
        }
        /// <summary>The kubernetes version of the cluster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesClusterEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.kubernetesClusterEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.KubernetesClusterEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "cloudResource", n => { CloudResource = n.GetObjectValue<global::Microsoft.Graph.Models.Security.AlertEvidence>(global::Microsoft.Graph.Models.Security.AlertEvidence.CreateFromDiscriminatorValue); } },
                { "distribution", n => { Distribution = n.GetStringValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "platform", n => { Platform = n.GetEnumValue<global::Microsoft.Graph.Models.Security.KubernetesPlatform>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.AlertEvidence>("cloudResource", CloudResource);
            writer.WriteStringValue("distribution", Distribution);
            writer.WriteStringValue("name", Name);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.KubernetesPlatform>("platform", Platform);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
