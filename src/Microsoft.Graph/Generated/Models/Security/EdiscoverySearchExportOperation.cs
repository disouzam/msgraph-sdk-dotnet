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
    public partial class EdiscoverySearchExportOperation : global::Microsoft.Graph.Models.Security.CaseOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The additionalOptions property</summary>
        public global::Microsoft.Graph.Models.Security.AdditionalOptions? AdditionalOptions
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.AdditionalOptions?>("additionalOptions"); }
            set { BackingStore?.Set("additionalOptions", value); }
        }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
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
        /// <summary>The exportCriteria property</summary>
        public global::Microsoft.Graph.Models.Security.ExportCriteria? ExportCriteria
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ExportCriteria?>("exportCriteria"); }
            set { BackingStore?.Set("exportCriteria", value); }
        }
        /// <summary>The exportFileMetadata property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.Security.ExportFileMetadata>? ExportFileMetadata
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.ExportFileMetadata>?>("exportFileMetadata"); }
            set { BackingStore?.Set("exportFileMetadata", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.Security.ExportFileMetadata> ExportFileMetadata
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.Security.ExportFileMetadata>>("exportFileMetadata"); }
            set { BackingStore?.Set("exportFileMetadata", value); }
        }
#endif
        /// <summary>The exportFormat property</summary>
        public global::Microsoft.Graph.Models.Security.ExportFormat? ExportFormat
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ExportFormat?>("exportFormat"); }
            set { BackingStore?.Set("exportFormat", value); }
        }
        /// <summary>The exportLocation property</summary>
        public global::Microsoft.Graph.Models.Security.ExportLocation? ExportLocation
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.ExportLocation?>("exportLocation"); }
            set { BackingStore?.Set("exportLocation", value); }
        }
        /// <summary>The exportSingleItems property</summary>
        public bool? ExportSingleItems
        {
            get { return BackingStore?.Get<bool?>("exportSingleItems"); }
            set { BackingStore?.Set("exportSingleItems", value); }
        }
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.Security.EdiscoverySearch? Search
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoverySearch?>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.Security.EdiscoverySearch Search
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.EdiscoverySearch>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Security.EdiscoverySearchExportOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Security.EdiscoverySearchExportOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Security.EdiscoverySearchExportOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalOptions", n => { AdditionalOptions = n.GetEnumValue<global::Microsoft.Graph.Models.Security.AdditionalOptions>(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "exportCriteria", n => { ExportCriteria = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ExportCriteria>(); } },
                { "exportFileMetadata", n => { ExportFileMetadata = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.ExportFileMetadata>(global::Microsoft.Graph.Models.Security.ExportFileMetadata.CreateFromDiscriminatorValue)?.AsList(); } },
                { "exportFormat", n => { ExportFormat = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ExportFormat>(); } },
                { "exportLocation", n => { ExportLocation = n.GetEnumValue<global::Microsoft.Graph.Models.Security.ExportLocation>(); } },
                { "exportSingleItems", n => { ExportSingleItems = n.GetBoolValue(); } },
                { "search", n => { Search = n.GetObjectValue<global::Microsoft.Graph.Models.Security.EdiscoverySearch>(global::Microsoft.Graph.Models.Security.EdiscoverySearch.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.AdditionalOptions>("additionalOptions", AdditionalOptions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ExportCriteria>("exportCriteria", ExportCriteria);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.Security.ExportFileMetadata>("exportFileMetadata", ExportFileMetadata);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ExportFormat>("exportFormat", ExportFormat);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.ExportLocation>("exportLocation", ExportLocation);
            writer.WriteBoolValue("exportSingleItems", ExportSingleItems);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.Security.EdiscoverySearch>("search", Search);
        }
    }
}
#pragma warning restore CS0618
