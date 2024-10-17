// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Contains properties for the installation state for a device.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceInstallState : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Device Id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId
        {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId
        {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>Device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName
        {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName
        {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The error code for install failures.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode
        {
            get { return BackingStore?.Get<string?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#nullable restore
#else
        public string ErrorCode
        {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#endif
        /// <summary>Possible values for install state.</summary>
        public global::Microsoft.Graph.Models.InstallState? InstallState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.InstallState?>("installState"); }
            set { BackingStore?.Set("installState", value); }
        }
        /// <summary>Last sync date and time.</summary>
        public DateTimeOffset? LastSyncDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>OS Description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDescription
        {
            get { return BackingStore?.Get<string?>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#nullable restore
#else
        public string OsDescription
        {
            get { return BackingStore?.Get<string>("osDescription"); }
            set { BackingStore?.Set("osDescription", value); }
        }
#endif
        /// <summary>OS Version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion
        {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion
        {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>Device User Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName
        {
            get { return BackingStore?.Get<string?>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#nullable restore
#else
        public string UserName
        {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceInstallState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceInstallState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceInstallState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetStringValue(); } },
                { "installState", n => { InstallState = n.GetEnumValue<global::Microsoft.Graph.Models.InstallState>(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "osDescription", n => { OsDescription = n.GetStringValue(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
                { "userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.InstallState>("installState", InstallState);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
#pragma warning restore CS0618
