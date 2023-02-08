using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphComplex {
    public class ComplexPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The iNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? INum {
            get { return BackingStore?.Get<Json?>("iNum"); }
            set { BackingStore?.Set("iNum", value); }
        }
#nullable restore
#else
        public Json INum {
            get { return BackingStore?.Get<Json>("iNum"); }
            set { BackingStore?.Set("iNum", value); }
        }
#endif
        /// <summary>The realNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? RealNum {
            get { return BackingStore?.Get<Json?>("realNum"); }
            set { BackingStore?.Set("realNum", value); }
        }
#nullable restore
#else
        public Json RealNum {
            get { return BackingStore?.Get<Json>("realNum"); }
            set { BackingStore?.Set("realNum", value); }
        }
#endif
        /// <summary>The suffix property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Suffix {
            get { return BackingStore?.Get<Json?>("suffix"); }
            set { BackingStore?.Set("suffix", value); }
        }
#nullable restore
#else
        public Json Suffix {
            get { return BackingStore?.Get<Json>("suffix"); }
            set { BackingStore?.Set("suffix", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new complexPostRequestBody and sets the default values.
        /// </summary>
        public ComplexPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ComplexPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ComplexPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"iNum", n => { INum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"realNum", n => { RealNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"suffix", n => { Suffix = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("iNum", INum);
            writer.WriteObjectValue<Json>("realNum", RealNum);
            writer.WriteObjectValue<Json>("suffix", Suffix);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
