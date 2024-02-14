// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class DelegatedAdminAccessContainer : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The identifier of the access container (for example, a security group). For &apos;securityGroup&apos; access containers, this must be a valid ID of a Microsoft Entra security group in the Microsoft partner&apos;s tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessContainerId {
            get { return BackingStore?.Get<string?>("accessContainerId"); }
            set { BackingStore?.Set("accessContainerId", value); }
        }
#nullable restore
#else
        public string AccessContainerId {
            get { return BackingStore?.Get<string>("accessContainerId"); }
            set { BackingStore?.Set("accessContainerId", value); }
        }
#endif
        /// <summary>The accessContainerType property</summary>
        public DelegatedAdminAccessContainerType? AccessContainerType {
            get { return BackingStore?.Get<DelegatedAdminAccessContainerType?>("accessContainerType"); }
            set { BackingStore?.Set("accessContainerType", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="DelegatedAdminAccessContainer"/> and sets the default values.
        /// </summary>
        public DelegatedAdminAccessContainer() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DelegatedAdminAccessContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DelegatedAdminAccessContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminAccessContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessContainerId", n => { AccessContainerId = n.GetStringValue(); } },
                {"accessContainerType", n => { AccessContainerType = n.GetEnumValue<DelegatedAdminAccessContainerType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accessContainerId", AccessContainerId);
            writer.WriteEnumValue<DelegatedAdminAccessContainerType>("accessContainerType", AccessContainerType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
