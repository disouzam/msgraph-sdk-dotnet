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
    public partial class Synchronization : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Performs synchronization by periodically running in the background, polling for changes in one directory, and pushing them to another directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SynchronizationJob>? Jobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SynchronizationJob>?>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SynchronizationJob> Jobs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SynchronizationJob>>("jobs"); }
            set { BackingStore?.Set("jobs", value); }
        }
#endif
        /// <summary>Represents a collection of credentials to access provisioned cloud applications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair>? Secrets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair>?>("secrets"); }
            set { BackingStore?.Set("secrets", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair> Secrets
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair>>("secrets"); }
            set { BackingStore?.Set("secrets", value); }
        }
#endif
        /// <summary>Preconfigured synchronization settings for a particular application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SynchronizationTemplate>? Templates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SynchronizationTemplate>?>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SynchronizationTemplate> Templates
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SynchronizationTemplate>>("templates"); }
            set { BackingStore?.Set("templates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.Synchronization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.Synchronization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.Synchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "jobs", n => { Jobs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SynchronizationJob>(global::Microsoft.Graph.Models.SynchronizationJob.CreateFromDiscriminatorValue)?.AsList(); } },
                { "secrets", n => { Secrets = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair>(global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templates", n => { Templates = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SynchronizationTemplate>(global::Microsoft.Graph.Models.SynchronizationTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SynchronizationJob>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SynchronizationSecretKeyStringValuePair>("secrets", Secrets);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SynchronizationTemplate>("templates", Templates);
        }
    }
}
#pragma warning restore CS0618
