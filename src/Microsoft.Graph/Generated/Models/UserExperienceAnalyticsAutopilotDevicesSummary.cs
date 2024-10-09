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
    /// The user experience analytics summary of Devices not windows autopilot ready.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class UserExperienceAnalyticsAutopilotDevicesSummary : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The count of intune devices that are not autopilot registerd. Read-only.</summary>
        public int? DevicesNotAutopilotRegistered
        {
            get { return BackingStore?.Get<int?>("devicesNotAutopilotRegistered"); }
            set { BackingStore?.Set("devicesNotAutopilotRegistered", value); }
        }
        /// <summary>The count of intune devices not autopilot profile assigned. Read-only.</summary>
        public int? DevicesWithoutAutopilotProfileAssigned
        {
            get { return BackingStore?.Get<int?>("devicesWithoutAutopilotProfileAssigned"); }
            set { BackingStore?.Set("devicesWithoutAutopilotProfileAssigned", value); }
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
        /// <summary>The count of windows 10 devices that are Intune and co-managed. Read-only.</summary>
        public int? TotalWindows10DevicesWithoutTenantAttached
        {
            get { return BackingStore?.Get<int?>("totalWindows10DevicesWithoutTenantAttached"); }
            set { BackingStore?.Set("totalWindows10DevicesWithoutTenantAttached", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.UserExperienceAnalyticsAutopilotDevicesSummary"/> and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsAutopilotDevicesSummary()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.UserExperienceAnalyticsAutopilotDevicesSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Models.UserExperienceAnalyticsAutopilotDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.UserExperienceAnalyticsAutopilotDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "devicesNotAutopilotRegistered", n => { DevicesNotAutopilotRegistered = n.GetIntValue(); } },
                { "devicesWithoutAutopilotProfileAssigned", n => { DevicesWithoutAutopilotProfileAssigned = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "totalWindows10DevicesWithoutTenantAttached", n => { TotalWindows10DevicesWithoutTenantAttached = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("devicesNotAutopilotRegistered", DevicesNotAutopilotRegistered);
            writer.WriteIntValue("devicesWithoutAutopilotProfileAssigned", DevicesWithoutAutopilotProfileAssigned);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("totalWindows10DevicesWithoutTenantAttached", TotalWindows10DevicesWithoutTenantAttached);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
