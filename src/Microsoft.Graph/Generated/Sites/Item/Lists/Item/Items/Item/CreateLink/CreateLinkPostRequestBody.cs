// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Sites.Item.Lists.Item.Items.Item.CreateLink
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CreateLinkPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message
        {
            get { return BackingStore?.Get<string?>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#nullable restore
#else
        public string Message
        {
            get { return BackingStore?.Get<string>("message"); }
            set { BackingStore?.Set("message", value); }
        }
#endif
        /// <summary>The password property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Password
        {
            get { return BackingStore?.Get<string?>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#nullable restore
#else
        public string Password
        {
            get { return BackingStore?.Get<string>("password"); }
            set { BackingStore?.Set("password", value); }
        }
#endif
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DriveRecipient>? Recipients
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveRecipient>?>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DriveRecipient> Recipients
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DriveRecipient>>("recipients"); }
            set { BackingStore?.Set("recipients", value); }
        }
#endif
        /// <summary>The retainInheritedPermissions property</summary>
        public bool? RetainInheritedPermissions
        {
            get { return BackingStore?.Get<bool?>("retainInheritedPermissions"); }
            set { BackingStore?.Set("retainInheritedPermissions", value); }
        }
        /// <summary>The scope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Scope
        {
            get { return BackingStore?.Get<string?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public string Scope
        {
            get { return BackingStore?.Get<string>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>The sendNotification property</summary>
        public bool? SendNotification
        {
            get { return BackingStore?.Get<bool?>("sendNotification"); }
            set { BackingStore?.Set("sendNotification", value); }
        }
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type
        {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type
        {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Sites.Item.Lists.Item.Items.Item.CreateLink.CreateLinkPostRequestBody"/> and sets the default values.
        /// </summary>
        public CreateLinkPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Sites.Item.Lists.Item.Items.Item.CreateLink.CreateLinkPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Sites.Item.Lists.Item.Items.Item.CreateLink.CreateLinkPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Sites.Item.Lists.Item.Items.Item.CreateLink.CreateLinkPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "message", n => { Message = n.GetStringValue(); } },
                { "password", n => { Password = n.GetStringValue(); } },
                { "recipients", n => { Recipients = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveRecipient>(global::Microsoft.Graph.Models.DriveRecipient.CreateFromDiscriminatorValue)?.AsList(); } },
                { "retainInheritedPermissions", n => { RetainInheritedPermissions = n.GetBoolValue(); } },
                { "scope", n => { Scope = n.GetStringValue(); } },
                { "sendNotification", n => { SendNotification = n.GetBoolValue(); } },
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("password", Password);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DriveRecipient>("recipients", Recipients);
            writer.WriteBoolValue("retainInheritedPermissions", RetainInheritedPermissions);
            writer.WriteStringValue("scope", Scope);
            writer.WriteBoolValue("sendNotification", SendNotification);
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
