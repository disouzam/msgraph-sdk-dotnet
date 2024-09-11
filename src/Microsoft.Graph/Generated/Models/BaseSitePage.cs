// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class BaseSitePage : global::Microsoft.Graph.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the page layout of the page. The possible values are: microsoftReserved, article, home, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.PageLayoutType? PageLayout
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PageLayoutType?>("pageLayout"); }
            set { BackingStore?.Set("pageLayout", value); }
        }
        /// <summary>The publishing status and the MM.mm version of the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.PublicationFacet? PublishingState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PublicationFacet?>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.PublicationFacet PublishingState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.PublicationFacet>("publishingState"); }
            set { BackingStore?.Set("publishingState", value); }
        }
#endif
        /// <summary>Title of the sitePage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.BaseSitePage"/> and sets the default values.
        /// </summary>
        public BaseSitePage() : base()
        {
            OdataType = "#microsoft.graph.baseSitePage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.BaseSitePage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.BaseSitePage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.sitePage" => new global::Microsoft.Graph.Models.SitePage(),
                _ => new global::Microsoft.Graph.Models.BaseSitePage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "pageLayout", n => { PageLayout = n.GetEnumValue<global::Microsoft.Graph.Models.PageLayoutType>(); } },
                { "publishingState", n => { PublishingState = n.GetObjectValue<global::Microsoft.Graph.Models.PublicationFacet>(global::Microsoft.Graph.Models.PublicationFacet.CreateFromDiscriminatorValue); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.PageLayoutType>("pageLayout", PageLayout);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.PublicationFacet>("publishingState", PublishingState);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
