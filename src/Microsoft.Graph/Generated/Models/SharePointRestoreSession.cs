// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class SharePointRestoreSession : global::Microsoft.Graph.Models.RestoreSessionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of restore points and destination details that can be used to restore SharePoint sites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SiteRestoreArtifact>? SiteRestoreArtifacts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SiteRestoreArtifact>?>("siteRestoreArtifacts"); }
            set { BackingStore?.Set("siteRestoreArtifacts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SiteRestoreArtifact> SiteRestoreArtifacts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SiteRestoreArtifact>>("siteRestoreArtifacts"); }
            set { BackingStore?.Set("siteRestoreArtifacts", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.SharePointRestoreSession"/> and sets the default values.
        /// </summary>
        public SharePointRestoreSession() : base()
        {
            OdataType = "#microsoft.graph.sharePointRestoreSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SharePointRestoreSession"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.SharePointRestoreSession CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SharePointRestoreSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "siteRestoreArtifacts", n => { SiteRestoreArtifacts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SiteRestoreArtifact>(global::Microsoft.Graph.Models.SiteRestoreArtifact.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SiteRestoreArtifact>("siteRestoreArtifacts", SiteRestoreArtifacts);
        }
    }
}
#pragma warning restore CS0618
