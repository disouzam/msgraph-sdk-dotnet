// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Users.Item.Onenote.Sections.Item.CopyToSectionGroup
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class CopyToSectionGroupPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The groupId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId
        {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId
        {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id
        {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id
        {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>The renameAs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RenameAs
        {
            get { return BackingStore?.Get<string?>("renameAs"); }
            set { BackingStore?.Set("renameAs", value); }
        }
#nullable restore
#else
        public string RenameAs
        {
            get { return BackingStore?.Get<string>("renameAs"); }
            set { BackingStore?.Set("renameAs", value); }
        }
#endif
        /// <summary>The siteCollectionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteCollectionId
        {
            get { return BackingStore?.Get<string?>("siteCollectionId"); }
            set { BackingStore?.Set("siteCollectionId", value); }
        }
#nullable restore
#else
        public string SiteCollectionId
        {
            get { return BackingStore?.Get<string>("siteCollectionId"); }
            set { BackingStore?.Set("siteCollectionId", value); }
        }
#endif
        /// <summary>The siteId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteId
        {
            get { return BackingStore?.Get<string?>("siteId"); }
            set { BackingStore?.Set("siteId", value); }
        }
#nullable restore
#else
        public string SiteId
        {
            get { return BackingStore?.Get<string>("siteId"); }
            set { BackingStore?.Set("siteId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Users.Item.Onenote.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody"/> and sets the default values.
        /// </summary>
        public CopyToSectionGroupPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Users.Item.Onenote.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Users.Item.Onenote.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Users.Item.Onenote.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "groupId", n => { GroupId = n.GetStringValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "renameAs", n => { RenameAs = n.GetStringValue(); } },
                { "siteCollectionId", n => { SiteCollectionId = n.GetStringValue(); } },
                { "siteId", n => { SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
