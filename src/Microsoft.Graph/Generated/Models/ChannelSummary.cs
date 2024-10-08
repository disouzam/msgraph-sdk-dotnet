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
    public partial class ChannelSummary : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Count of guests in a channel.</summary>
        public int? GuestsCount
        {
            get { return BackingStore?.Get<int?>("guestsCount"); }
            set { BackingStore?.Set("guestsCount", value); }
        }
        /// <summary>Indicates whether external members are included on the channel.</summary>
        public bool? HasMembersFromOtherTenants
        {
            get { return BackingStore?.Get<bool?>("hasMembersFromOtherTenants"); }
            set { BackingStore?.Set("hasMembersFromOtherTenants", value); }
        }
        /// <summary>Count of members in a channel.</summary>
        public int? MembersCount
        {
            get { return BackingStore?.Get<int?>("membersCount"); }
            set { BackingStore?.Set("membersCount", value); }
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
        /// <summary>Count of owners in a channel.</summary>
        public int? OwnersCount
        {
            get { return BackingStore?.Get<int?>("ownersCount"); }
            set { BackingStore?.Set("ownersCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ChannelSummary"/> and sets the default values.
        /// </summary>
        public ChannelSummary()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ChannelSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ChannelSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ChannelSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "guestsCount", n => { GuestsCount = n.GetIntValue(); } },
                { "hasMembersFromOtherTenants", n => { HasMembersFromOtherTenants = n.GetBoolValue(); } },
                { "membersCount", n => { MembersCount = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "ownersCount", n => { OwnersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("guestsCount", GuestsCount);
            writer.WriteBoolValue("hasMembersFromOtherTenants", HasMembersFromOtherTenants);
            writer.WriteIntValue("membersCount", MembersCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("ownersCount", OwnersCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
