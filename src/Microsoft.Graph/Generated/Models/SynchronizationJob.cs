// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class SynchronizationJob : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The bulk upload operation for the job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.BulkUpload? BulkUpload
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BulkUpload?>("bulkUpload"); }
            set { BackingStore?.Set("bulkUpload", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.BulkUpload BulkUpload
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.BulkUpload>("bulkUpload"); }
            set { BackingStore?.Set("bulkUpload", value); }
        }
#endif
        /// <summary>Schedule used to run the job. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SynchronizationSchedule? Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationSchedule?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SynchronizationSchedule Schedule
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationSchedule>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>The synchronization schema configured for the job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SynchronizationSchema? Schema
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationSchema?>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SynchronizationSchema Schema
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationSchema>("schema"); }
            set { BackingStore?.Set("schema", value); }
        }
#endif
        /// <summary>Status of the job, which includes when the job was last run, current job state, and errors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.SynchronizationStatus? Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.SynchronizationStatus Status
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.SynchronizationStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>Settings associated with the job. Some settings are inherited from the template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.KeyValuePair>? SynchronizationJobSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValuePair>?>("synchronizationJobSettings"); }
            set { BackingStore?.Set("synchronizationJobSettings", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.KeyValuePair> SynchronizationJobSettings
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.KeyValuePair>>("synchronizationJobSettings"); }
            set { BackingStore?.Set("synchronizationJobSettings", value); }
        }
#endif
        /// <summary>Identifier of the synchronization template this job is based on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId
        {
            get { return BackingStore?.Get<string?>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#nullable restore
#else
        public string TemplateId
        {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.SynchronizationJob"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.SynchronizationJob CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.SynchronizationJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bulkUpload", n => { BulkUpload = n.GetObjectValue<global::Microsoft.Graph.Models.BulkUpload>(global::Microsoft.Graph.Models.BulkUpload.CreateFromDiscriminatorValue); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::Microsoft.Graph.Models.SynchronizationSchedule>(global::Microsoft.Graph.Models.SynchronizationSchedule.CreateFromDiscriminatorValue); } },
                { "schema", n => { Schema = n.GetObjectValue<global::Microsoft.Graph.Models.SynchronizationSchema>(global::Microsoft.Graph.Models.SynchronizationSchema.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetObjectValue<global::Microsoft.Graph.Models.SynchronizationStatus>(global::Microsoft.Graph.Models.SynchronizationStatus.CreateFromDiscriminatorValue); } },
                { "synchronizationJobSettings", n => { SynchronizationJobSettings = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValuePair>(global::Microsoft.Graph.Models.KeyValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templateId", n => { TemplateId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.BulkUpload>("bulkUpload", BulkUpload);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SynchronizationSchedule>("schedule", Schedule);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SynchronizationSchema>("schema", Schema);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.SynchronizationStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.KeyValuePair>("synchronizationJobSettings", SynchronizationJobSettings);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}
#pragma warning restore CS0618
