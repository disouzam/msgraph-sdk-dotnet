// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class UploadClientCertificatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The pkcs12Value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Pkcs12Value
        {
            get { return BackingStore?.Get<string?>("pkcs12Value"); }
            set { BackingStore?.Set("pkcs12Value", value); }
        }
#nullable restore
#else
        public string Pkcs12Value
        {
            get { return BackingStore?.Get<string>("pkcs12Value"); }
            set { BackingStore?.Set("pkcs12Value", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate.UploadClientCertificatePostRequestBody"/> and sets the default values.
        /// </summary>
        public UploadClientCertificatePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate.UploadClientCertificatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate.UploadClientCertificatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate.UploadClientCertificatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "password", n => { Password = n.GetStringValue(); } },
                { "pkcs12Value", n => { Pkcs12Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("password", Password);
            writer.WriteStringValue("pkcs12Value", Pkcs12Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
