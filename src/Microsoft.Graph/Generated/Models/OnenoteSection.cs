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
    public partial class OnenoteSection : global::Microsoft.Graph.Models.OnenoteEntityHierarchyModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether this is the user&apos;s default section. Read-only.</summary>
        public bool? IsDefault
        {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>Links for opening the section. The oneNoteClientURL link opens the section in the OneNote native client if it&apos;s installed. The oneNoteWebURL link opens the section in OneNote on the web.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SectionLinks? Links
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SectionLinks?>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SectionLinks Links
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SectionLinks>("links"); }
            set { BackingStore?.Set("links", value); }
        }
#endif
        /// <summary>The collection of pages in the section.  Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.OnenotePage>? Pages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenotePage>?>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.OnenotePage> Pages
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.OnenotePage>>("pages"); }
            set { BackingStore?.Set("pages", value); }
        }
#endif
        /// <summary>The pages endpoint where you can get details for all the pages in the section. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PagesUrl
        {
            get { return BackingStore?.Get<string?>("pagesUrl"); }
            set { BackingStore?.Set("pagesUrl", value); }
        }
#nullable restore
#else
        public string PagesUrl
        {
            get { return BackingStore?.Get<string>("pagesUrl"); }
            set { BackingStore?.Set("pagesUrl", value); }
        }
#endif
        /// <summary>The notebook that contains the section.  Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Notebook? ParentNotebook
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Notebook?>("parentNotebook"); }
            set { BackingStore?.Set("parentNotebook", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Notebook ParentNotebook
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Notebook>("parentNotebook"); }
            set { BackingStore?.Set("parentNotebook", value); }
        }
#endif
        /// <summary>The section group that contains the section.  Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SectionGroup? ParentSectionGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SectionGroup?>("parentSectionGroup"); }
            set { BackingStore?.Set("parentSectionGroup", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SectionGroup ParentSectionGroup
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SectionGroup>("parentSectionGroup"); }
            set { BackingStore?.Set("parentSectionGroup", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.OnenoteSection"/> and sets the default values.
        /// </summary>
        public OnenoteSection() : base()
        {
            OdataType = "#microsoft.graph.onenoteSection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.OnenoteSection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.OnenoteSection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.OnenoteSection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isDefault", n => { IsDefault = n.GetBoolValue(); } },
                { "links", n => { Links = n.GetObjectValue<global::Microsoft.Graph.Models.SectionLinks>(global::Microsoft.Graph.Models.SectionLinks.CreateFromDiscriminatorValue); } },
                { "pages", n => { Pages = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenotePage>(global::Microsoft.Graph.Models.OnenotePage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pagesUrl", n => { PagesUrl = n.GetStringValue(); } },
                { "parentNotebook", n => { ParentNotebook = n.GetObjectValue<global::Microsoft.Graph.Models.Notebook>(global::Microsoft.Graph.Models.Notebook.CreateFromDiscriminatorValue); } },
                { "parentSectionGroup", n => { ParentSectionGroup = n.GetObjectValue<global::Microsoft.Graph.Models.SectionGroup>(global::Microsoft.Graph.Models.SectionGroup.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SectionLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.OnenotePage>("pages", Pages);
            writer.WriteStringValue("pagesUrl", PagesUrl);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SectionGroup>("parentSectionGroup", ParentSectionGroup);
        }
    }
}
#pragma warning restore CS0618
