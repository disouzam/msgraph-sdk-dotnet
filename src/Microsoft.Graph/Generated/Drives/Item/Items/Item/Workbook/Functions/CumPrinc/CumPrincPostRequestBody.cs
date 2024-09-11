// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.CumPrinc
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class CumPrincPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The endPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? EndPeriod
        {
            get { return BackingStore?.Get<UntypedNode?>("endPeriod"); }
            set { BackingStore?.Set("endPeriod", value); }
        }
#nullable restore
#else
        public UntypedNode EndPeriod
        {
            get { return BackingStore?.Get<UntypedNode>("endPeriod"); }
            set { BackingStore?.Set("endPeriod", value); }
        }
#endif
        /// <summary>The nper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Nper
        {
            get { return BackingStore?.Get<UntypedNode?>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#nullable restore
#else
        public UntypedNode Nper
        {
            get { return BackingStore?.Get<UntypedNode>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#endif
        /// <summary>The pv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Pv
        {
            get { return BackingStore?.Get<UntypedNode?>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#nullable restore
#else
        public UntypedNode Pv
        {
            get { return BackingStore?.Get<UntypedNode>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Rate
        {
            get { return BackingStore?.Get<UntypedNode?>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#nullable restore
#else
        public UntypedNode Rate
        {
            get { return BackingStore?.Get<UntypedNode>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#endif
        /// <summary>The startPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? StartPeriod
        {
            get { return BackingStore?.Get<UntypedNode?>("startPeriod"); }
            set { BackingStore?.Set("startPeriod", value); }
        }
#nullable restore
#else
        public UntypedNode StartPeriod
        {
            get { return BackingStore?.Get<UntypedNode>("startPeriod"); }
            set { BackingStore?.Set("startPeriod", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? Type
        {
            get { return BackingStore?.Get<UntypedNode?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public UntypedNode Type
        {
            get { return BackingStore?.Get<UntypedNode>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.CumPrinc.CumPrincPostRequestBody"/> and sets the default values.
        /// </summary>
        public CumPrincPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.CumPrinc.CumPrincPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.CumPrinc.CumPrincPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.CumPrinc.CumPrincPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "endPeriod", n => { EndPeriod = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "nper", n => { Nper = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "pv", n => { Pv = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "rate", n => { Rate = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "startPeriod", n => { StartPeriod = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("endPeriod", EndPeriod);
            writer.WriteObjectValue<UntypedNode>("nper", Nper);
            writer.WriteObjectValue<UntypedNode>("pv", Pv);
            writer.WriteObjectValue<UntypedNode>("rate", Rate);
            writer.WriteObjectValue<UntypedNode>("startPeriod", StartPeriod);
            writer.WriteObjectValue<UntypedNode>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
