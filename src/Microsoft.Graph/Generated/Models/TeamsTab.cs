// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TeamsTab : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Container for custom settings applied to a tab. The tab is considered configured only once this property is set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamsTabConfiguration? Configuration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsTabConfiguration?>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamsTabConfiguration Configuration
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsTabConfiguration>("configuration"); }
            set { BackingStore?.Set("configuration", value); }
        }
#endif
        /// <summary>Name of the tab.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The application that is linked to the tab. This can&apos;t be changed after tab creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.TeamsApp? TeamsApp
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsApp?>("teamsApp"); }
            set { BackingStore?.Set("teamsApp", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.TeamsApp TeamsApp
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.TeamsApp>("teamsApp"); }
            set { BackingStore?.Set("teamsApp", value); }
        }
#endif
        /// <summary>Deep link URL of the tab instance. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamsTab"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.TeamsTab CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TeamsTab();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<global::Microsoft.Graph.Models.TeamsTabConfiguration>(global::Microsoft.Graph.Models.TeamsTabConfiguration.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "teamsApp", n => { TeamsApp = n.GetObjectValue<global::Microsoft.Graph.Models.TeamsApp>(global::Microsoft.Graph.Models.TeamsApp.CreateFromDiscriminatorValue); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamsTabConfiguration>("configuration", Configuration);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.TeamsApp>("teamsApp", TeamsApp);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
