// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class SetDataPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The seriesBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SeriesBy
        {
            get { return BackingStore?.Get<string?>("seriesBy"); }
            set { BackingStore?.Set("seriesBy", value); }
        }
#nullable restore
#else
        public string SeriesBy
        {
            get { return BackingStore?.Get<string>("seriesBy"); }
            set { BackingStore?.Set("seriesBy", value); }
        }
#endif
        /// <summary>The sourceData property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? SourceData
        {
            get { return BackingStore?.Get<UntypedNode?>("sourceData"); }
            set { BackingStore?.Set("sourceData", value); }
        }
#nullable restore
#else
        public UntypedNode SourceData
        {
            get { return BackingStore?.Get<UntypedNode>("sourceData"); }
            set { BackingStore?.Set("sourceData", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData.SetDataPostRequestBody"/> and sets the default values.
        /// </summary>
        public SetDataPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData.SetDataPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData.SetDataPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.SetData.SetDataPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "seriesBy", n => { SeriesBy = n.GetStringValue(); } },
                { "sourceData", n => { SourceData = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("seriesBy", SeriesBy);
            writer.WriteObjectValue<UntypedNode>("sourceData", SourceData);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
