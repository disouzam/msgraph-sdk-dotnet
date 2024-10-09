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
    /// <summary>
    /// Contains properties for file encryption information for the content version of a line of business app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class FileEncryptionInfo : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The key used to encrypt the file content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? EncryptionKey
        {
            get { return BackingStore?.Get<byte[]?>("encryptionKey"); }
            set { BackingStore?.Set("encryptionKey", value); }
        }
#nullable restore
#else
        public byte[] EncryptionKey
        {
            get { return BackingStore?.Get<byte[]>("encryptionKey"); }
            set { BackingStore?.Set("encryptionKey", value); }
        }
#endif
        /// <summary>The file digest prior to encryption. ProfileVersion1 requires a non-null FileDigest.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? FileDigest
        {
            get { return BackingStore?.Get<byte[]?>("fileDigest"); }
            set { BackingStore?.Set("fileDigest", value); }
        }
#nullable restore
#else
        public byte[] FileDigest
        {
            get { return BackingStore?.Get<byte[]>("fileDigest"); }
            set { BackingStore?.Set("fileDigest", value); }
        }
#endif
        /// <summary>The file digest algorithm. ProfileVersion1 currently only supports SHA256 for the FileDigestAlgorithm.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileDigestAlgorithm
        {
            get { return BackingStore?.Get<string?>("fileDigestAlgorithm"); }
            set { BackingStore?.Set("fileDigestAlgorithm", value); }
        }
#nullable restore
#else
        public string FileDigestAlgorithm
        {
            get { return BackingStore?.Get<string>("fileDigestAlgorithm"); }
            set { BackingStore?.Set("fileDigestAlgorithm", value); }
        }
#endif
        /// <summary>The initialization vector (IV) used for the encryption algorithm. Must be 16 bytes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? InitializationVector
        {
            get { return BackingStore?.Get<byte[]?>("initializationVector"); }
            set { BackingStore?.Set("initializationVector", value); }
        }
#nullable restore
#else
        public byte[] InitializationVector
        {
            get { return BackingStore?.Get<byte[]>("initializationVector"); }
            set { BackingStore?.Set("initializationVector", value); }
        }
#endif
        /// <summary>The hash of the concatenation of the IV and encrypted file content. Must be 32 bytes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Mac
        {
            get { return BackingStore?.Get<byte[]?>("mac"); }
            set { BackingStore?.Set("mac", value); }
        }
#nullable restore
#else
        public byte[] Mac
        {
            get { return BackingStore?.Get<byte[]>("mac"); }
            set { BackingStore?.Set("mac", value); }
        }
#endif
        /// <summary>The key used to compute the message authentication code of the concatenation of the IV and encrypted file content. Must be 32 bytes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? MacKey
        {
            get { return BackingStore?.Get<byte[]?>("macKey"); }
            set { BackingStore?.Set("macKey", value); }
        }
#nullable restore
#else
        public byte[] MacKey
        {
            get { return BackingStore?.Get<byte[]>("macKey"); }
            set { BackingStore?.Set("macKey", value); }
        }
#endif
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
        /// <summary>The profile identifier. Maps to the strategy used to encrypt the file. Currently, only ProfileVersion1 is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProfileIdentifier
        {
            get { return BackingStore?.Get<string?>("profileIdentifier"); }
            set { BackingStore?.Set("profileIdentifier", value); }
        }
#nullable restore
#else
        public string ProfileIdentifier
        {
            get { return BackingStore?.Get<string>("profileIdentifier"); }
            set { BackingStore?.Set("profileIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.FileEncryptionInfo"/> and sets the default values.
        /// </summary>
        public FileEncryptionInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.FileEncryptionInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.FileEncryptionInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.FileEncryptionInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "encryptionKey", n => { EncryptionKey = n.GetByteArrayValue(); } },
                { "fileDigest", n => { FileDigest = n.GetByteArrayValue(); } },
                { "fileDigestAlgorithm", n => { FileDigestAlgorithm = n.GetStringValue(); } },
                { "initializationVector", n => { InitializationVector = n.GetByteArrayValue(); } },
                { "mac", n => { Mac = n.GetByteArrayValue(); } },
                { "macKey", n => { MacKey = n.GetByteArrayValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "profileIdentifier", n => { ProfileIdentifier = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("encryptionKey", EncryptionKey);
            writer.WriteByteArrayValue("fileDigest", FileDigest);
            writer.WriteStringValue("fileDigestAlgorithm", FileDigestAlgorithm);
            writer.WriteByteArrayValue("initializationVector", InitializationVector);
            writer.WriteByteArrayValue("mac", Mac);
            writer.WriteByteArrayValue("macKey", MacKey);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("profileIdentifier", ProfileIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
