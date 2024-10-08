// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class TeamFunSettings : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>If set to true, enables users to include custom memes.</summary>
        public bool? AllowCustomMemes
        {
            get { return BackingStore?.Get<bool?>("allowCustomMemes"); }
            set { BackingStore?.Set("allowCustomMemes", value); }
        }
        /// <summary>If set to true, enables Giphy use.</summary>
        public bool? AllowGiphy
        {
            get { return BackingStore?.Get<bool?>("allowGiphy"); }
            set { BackingStore?.Set("allowGiphy", value); }
        }
        /// <summary>If set to true, enables users to include stickers and memes.</summary>
        public bool? AllowStickersAndMemes
        {
            get { return BackingStore?.Get<bool?>("allowStickersAndMemes"); }
            set { BackingStore?.Set("allowStickersAndMemes", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Giphy content rating. Possible values are: moderate, strict.</summary>
        public global::Microsoft.Graph.Models.GiphyRatingType? GiphyContentRating
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.GiphyRatingType?>("giphyContentRating"); }
            set { BackingStore?.Set("giphyContentRating", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.TeamFunSettings"/> and sets the default values.
        /// </summary>
        public TeamFunSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.TeamFunSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.TeamFunSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.TeamFunSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allowCustomMemes", n => { AllowCustomMemes = n.GetBoolValue(); } },
                { "allowGiphy", n => { AllowGiphy = n.GetBoolValue(); } },
                { "allowStickersAndMemes", n => { AllowStickersAndMemes = n.GetBoolValue(); } },
                { "giphyContentRating", n => { GiphyContentRating = n.GetEnumValue<global::Microsoft.Graph.Models.GiphyRatingType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomMemes", AllowCustomMemes);
            writer.WriteBoolValue("allowGiphy", AllowGiphy);
            writer.WriteBoolValue("allowStickersAndMemes", AllowStickersAndMemes);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.GiphyRatingType>("giphyContentRating", GiphyContentRating);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
