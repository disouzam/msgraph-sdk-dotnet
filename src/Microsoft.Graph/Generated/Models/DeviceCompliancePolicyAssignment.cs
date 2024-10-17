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
    /// Device compliance policy assignment.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceCompliancePolicyAssignment : global::Microsoft.Graph.Models.Entity, IParsable
    {
        /// <summary>Target for the compliance policy assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget? Target
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget Target
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.DeviceCompliancePolicyAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.DeviceCompliancePolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.DeviceCompliancePolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "target", n => { Target = n.GetObjectValue<global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget>(global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
#pragma warning restore CS0618
