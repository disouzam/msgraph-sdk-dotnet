// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models.Security;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class RetentionLabelSettings : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Describes the item behavior during retention period. Possible values are: doNotRetain, retain, retainAsRecord, retainAsRegulatoryRecord, unknownFutureValue. Read-only.</summary>
        public global::Microsoft.Graph.Models.Security.BehaviorDuringRetentionPeriod? BehaviorDuringRetentionPeriod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.Security.BehaviorDuringRetentionPeriod?>("behaviorDuringRetentionPeriod"); }
            set { BackingStore?.Set("behaviorDuringRetentionPeriod", value); }
        }
        /// <summary>Specifies whether updates to document content are allowed. Read-only.</summary>
        public bool? IsContentUpdateAllowed
        {
            get { return BackingStore?.Get<bool?>("isContentUpdateAllowed"); }
            set { BackingStore?.Set("isContentUpdateAllowed", value); }
        }
        /// <summary>Specifies whether the document deletion is allowed. Read-only.</summary>
        public bool? IsDeleteAllowed
        {
            get { return BackingStore?.Get<bool?>("isDeleteAllowed"); }
            set { BackingStore?.Set("isDeleteAllowed", value); }
        }
        /// <summary>Specifies whether you&apos;re allowed to change the retention label on the document. Read-only.</summary>
        public bool? IsLabelUpdateAllowed
        {
            get { return BackingStore?.Get<bool?>("isLabelUpdateAllowed"); }
            set { BackingStore?.Set("isLabelUpdateAllowed", value); }
        }
        /// <summary>Specifies whether updates to the item metadata (for example, the Title field) are blocked. Read-only.</summary>
        public bool? IsMetadataUpdateAllowed
        {
            get { return BackingStore?.Get<bool?>("isMetadataUpdateAllowed"); }
            set { BackingStore?.Set("isMetadataUpdateAllowed", value); }
        }
        /// <summary>Specifies whether the item is locked. Read-write.</summary>
        public bool? IsRecordLocked
        {
            get { return BackingStore?.Get<bool?>("isRecordLocked"); }
            set { BackingStore?.Set("isRecordLocked", value); }
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
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.RetentionLabelSettings"/> and sets the default values.
        /// </summary>
        public RetentionLabelSettings()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.RetentionLabelSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.RetentionLabelSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.RetentionLabelSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "behaviorDuringRetentionPeriod", n => { BehaviorDuringRetentionPeriod = n.GetEnumValue<global::Microsoft.Graph.Models.Security.BehaviorDuringRetentionPeriod>(); } },
                { "isContentUpdateAllowed", n => { IsContentUpdateAllowed = n.GetBoolValue(); } },
                { "isDeleteAllowed", n => { IsDeleteAllowed = n.GetBoolValue(); } },
                { "isLabelUpdateAllowed", n => { IsLabelUpdateAllowed = n.GetBoolValue(); } },
                { "isMetadataUpdateAllowed", n => { IsMetadataUpdateAllowed = n.GetBoolValue(); } },
                { "isRecordLocked", n => { IsRecordLocked = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<global::Microsoft.Graph.Models.Security.BehaviorDuringRetentionPeriod>("behaviorDuringRetentionPeriod", BehaviorDuringRetentionPeriod);
            writer.WriteBoolValue("isContentUpdateAllowed", IsContentUpdateAllowed);
            writer.WriteBoolValue("isDeleteAllowed", IsDeleteAllowed);
            writer.WriteBoolValue("isLabelUpdateAllowed", IsLabelUpdateAllowed);
            writer.WriteBoolValue("isMetadataUpdateAllowed", IsMetadataUpdateAllowed);
            writer.WriteBoolValue("isRecordLocked", IsRecordLocked);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
