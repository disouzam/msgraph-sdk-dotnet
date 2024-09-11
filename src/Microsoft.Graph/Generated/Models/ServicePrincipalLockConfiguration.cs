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
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class ServicePrincipalLockConfiguration : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Enables locking all sensitive properties. The sensitive properties are keyCredentials, passwordCredentials, and tokenEncryptionKeyId.</summary>
        public bool? AllProperties
        {
            get { return BackingStore?.Get<bool?>("allProperties"); }
            set { BackingStore?.Set("allProperties", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Sign.</summary>
        public bool? CredentialsWithUsageSign
        {
            get { return BackingStore?.Get<bool?>("credentialsWithUsageSign"); }
            set { BackingStore?.Set("credentialsWithUsageSign", value); }
        }
        /// <summary>Locks the keyCredentials and passwordCredentials properties for modification where credential usage type is Verify. This locks OAuth service principals.</summary>
        public bool? CredentialsWithUsageVerify
        {
            get { return BackingStore?.Get<bool?>("credentialsWithUsageVerify"); }
            set { BackingStore?.Set("credentialsWithUsageVerify", value); }
        }
        /// <summary>Enables or disables service principal lock configuration. To allow the sensitive properties to be updated, update this property to false to disable the lock on the service principal.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
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
        /// <summary>Locks the tokenEncryptionKeyId property for modification on the service principal.</summary>
        public bool? TokenEncryptionKeyId
        {
            get { return BackingStore?.Get<bool?>("tokenEncryptionKeyId"); }
            set { BackingStore?.Set("tokenEncryptionKeyId", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ServicePrincipalLockConfiguration"/> and sets the default values.
        /// </summary>
        public ServicePrincipalLockConfiguration()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ServicePrincipalLockConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ServicePrincipalLockConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ServicePrincipalLockConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "allProperties", n => { AllProperties = n.GetBoolValue(); } },
                { "credentialsWithUsageSign", n => { CredentialsWithUsageSign = n.GetBoolValue(); } },
                { "credentialsWithUsageVerify", n => { CredentialsWithUsageVerify = n.GetBoolValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allProperties", AllProperties);
            writer.WriteBoolValue("credentialsWithUsageSign", CredentialsWithUsageSign);
            writer.WriteBoolValue("credentialsWithUsageVerify", CredentialsWithUsageVerify);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
