using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.MicrosoftGraphNumberValue {
    public class NumberValuePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The decimalSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? DecimalSeparator {
            get { return BackingStore?.Get<Json?>("decimalSeparator"); }
            set { BackingStore?.Set("decimalSeparator", value); }
        }
#nullable restore
#else
        public Json DecimalSeparator {
            get { return BackingStore?.Get<Json>("decimalSeparator"); }
            set { BackingStore?.Set("decimalSeparator", value); }
        }
#endif
        /// <summary>The groupSeparator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? GroupSeparator {
            get { return BackingStore?.Get<Json?>("groupSeparator"); }
            set { BackingStore?.Set("groupSeparator", value); }
        }
#nullable restore
#else
        public Json GroupSeparator {
            get { return BackingStore?.Get<Json>("groupSeparator"); }
            set { BackingStore?.Set("groupSeparator", value); }
        }
#endif
        /// <summary>The text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Text {
            get { return BackingStore?.Get<Json?>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#nullable restore
#else
        public Json Text {
            get { return BackingStore?.Get<Json>("text"); }
            set { BackingStore?.Set("text", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new numberValuePostRequestBody and sets the default values.
        /// </summary>
        public NumberValuePostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NumberValuePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NumberValuePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"decimalSeparator", n => { DecimalSeparator = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"groupSeparator", n => { GroupSeparator = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"text", n => { Text = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("decimalSeparator", DecimalSeparator);
            writer.WriteObjectValue<Json>("groupSeparator", GroupSeparator);
            writer.WriteObjectValue<Json>("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
