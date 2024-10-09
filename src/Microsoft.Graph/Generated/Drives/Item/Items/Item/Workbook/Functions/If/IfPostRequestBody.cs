// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.If
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class IfPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The logicalTest property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? LogicalTest
        {
            get { return BackingStore?.Get<UntypedNode?>("logicalTest"); }
            set { BackingStore?.Set("logicalTest", value); }
        }
#nullable restore
#else
        public UntypedNode LogicalTest
        {
            get { return BackingStore?.Get<UntypedNode>("logicalTest"); }
            set { BackingStore?.Set("logicalTest", value); }
        }
#endif
        /// <summary>The valueIfFalse property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ValueIfFalse
        {
            get { return BackingStore?.Get<UntypedNode?>("valueIfFalse"); }
            set { BackingStore?.Set("valueIfFalse", value); }
        }
#nullable restore
#else
        public UntypedNode ValueIfFalse
        {
            get { return BackingStore?.Get<UntypedNode>("valueIfFalse"); }
            set { BackingStore?.Set("valueIfFalse", value); }
        }
#endif
        /// <summary>The valueIfTrue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UntypedNode? ValueIfTrue
        {
            get { return BackingStore?.Get<UntypedNode?>("valueIfTrue"); }
            set { BackingStore?.Set("valueIfTrue", value); }
        }
#nullable restore
#else
        public UntypedNode ValueIfTrue
        {
            get { return BackingStore?.Get<UntypedNode>("valueIfTrue"); }
            set { BackingStore?.Set("valueIfTrue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.If.IfPostRequestBody"/> and sets the default values.
        /// </summary>
        public IfPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.If.IfPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.If.IfPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.If.IfPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "logicalTest", n => { LogicalTest = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "valueIfFalse", n => { ValueIfFalse = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
                { "valueIfTrue", n => { ValueIfTrue = n.GetObjectValue<UntypedNode>(UntypedNode.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UntypedNode>("logicalTest", LogicalTest);
            writer.WriteObjectValue<UntypedNode>("valueIfFalse", ValueIfFalse);
            writer.WriteObjectValue<UntypedNode>("valueIfTrue", ValueIfTrue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
