// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CustomTaskExtensionCalloutData : global::Microsoft.Graph.Models.CustomExtensionData, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.User? Subject
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.User Subject
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.User>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The task property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskObject? Task
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject?>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskObject Task
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#endif
        /// <summary>The taskProcessingresult property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult? TaskProcessingresult
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult?>("taskProcessingresult"); }
            set { BackingStore?.Set("taskProcessingresult", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult TaskProcessingresult
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>("taskProcessingresult"); }
            set { BackingStore?.Set("taskProcessingresult", value); }
        }
#endif
        /// <summary>The workflow property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.IdentityGovernance.Workflow? Workflow
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.Workflow?>("workflow"); }
            set { BackingStore?.Set("workflow", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.IdentityGovernance.Workflow Workflow
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.IdentityGovernance.Workflow>("workflow"); }
            set { BackingStore?.Set("workflow", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCalloutData"/> and sets the default values.
        /// </summary>
        public CustomTaskExtensionCalloutData() : base()
        {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtensionCalloutData";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCalloutData"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCalloutData CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.IdentityGovernance.CustomTaskExtensionCalloutData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "subject", n => { Subject = n.GetObjectValue<global::Microsoft.Graph.Models.User>(global::Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                { "task", n => { Task = n.GetObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject>(global::Microsoft.Graph.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
                { "taskProcessingresult", n => { TaskProcessingresult = n.GetObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>(global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult.CreateFromDiscriminatorValue); } },
                { "workflow", n => { Workflow = n.GetObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.Workflow>(global::Microsoft.Graph.Models.IdentityGovernance.Workflow.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.User>("subject", Subject);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskObject>("task", Task);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.TaskProcessingResult>("taskProcessingresult", TaskProcessingresult);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.IdentityGovernance.Workflow>("workflow", Workflow);
        }
    }
}
#pragma warning restore CS0618
