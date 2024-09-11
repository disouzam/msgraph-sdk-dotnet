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
    public partial class ServiceStatus : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The type of consumer. The possible values are: unknown, firstparty, thirdparty, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.BackupServiceConsumer? BackupServiceConsumer
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BackupServiceConsumer?>("backupServiceConsumer"); }
            set { BackingStore?.Set("backupServiceConsumer", value); }
        }
        /// <summary>The reason the service is disabled. The possible values are: none, controllerServiceAppDeleted, invalidBillingProfile, userRequested, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.DisableReason? DisableReason
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DisableReason?>("disableReason"); }
            set { BackingStore?.Set("disableReason", value); }
        }
        /// <summary>The expiration time of the grace period.</summary>
        public DateTimeOffset? GracePeriodDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("gracePeriodDateTime"); }
            set { BackingStore?.Set("gracePeriodDateTime", value); }
        }
        /// <summary>Identity of the person who last modified the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>Timestamp of the last modification of the entity.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
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
        /// <summary>The expiration time of the restoration allowed period.</summary>
        public DateTimeOffset? RestoreAllowedTillDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("restoreAllowedTillDateTime"); }
            set { BackingStore?.Set("restoreAllowedTillDateTime", value); }
        }
        /// <summary>Status of the service. This value indicates what capabilities can be used. The possible values are: disabled, enabled, protectionChangeLocked, restoreLocked, unknownFutureValue.</summary>
        public global::Microsoft.Graph.Models.BackupServiceStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BackupServiceStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.ServiceStatus"/> and sets the default values.
        /// </summary>
        public ServiceStatus()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.ServiceStatus"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.ServiceStatus CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.ServiceStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "backupServiceConsumer", n => { BackupServiceConsumer = n.GetEnumValue<global::Microsoft.Graph.Models.BackupServiceConsumer>(); } },
                { "disableReason", n => { DisableReason = n.GetEnumValue<global::Microsoft.Graph.Models.DisableReason>(); } },
                { "gracePeriodDateTime", n => { GracePeriodDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Models.IdentitySet>(global::Microsoft.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "restoreAllowedTillDateTime", n => { RestoreAllowedTillDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::Microsoft.Graph.Models.BackupServiceStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BackupServiceConsumer>("backupServiceConsumer", BackupServiceConsumer);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.DisableReason>("disableReason", DisableReason);
            writer.WriteDateTimeOffsetValue("gracePeriodDateTime", GracePeriodDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("restoreAllowedTillDateTime", RestoreAllowedTillDateTime);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.BackupServiceStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
