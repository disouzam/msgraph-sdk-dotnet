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
    public partial class AuditLogRoot : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The directoryAudits property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.DirectoryAudit>? DirectoryAudits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryAudit>?>("directoryAudits"); }
            set { BackingStore?.Set("directoryAudits", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.DirectoryAudit> DirectoryAudits
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.DirectoryAudit>>("directoryAudits"); }
            set { BackingStore?.Set("directoryAudits", value); }
        }
#endif
        /// <summary>The provisioning property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.ProvisioningObjectSummary>? Provisioning
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ProvisioningObjectSummary>?>("provisioning"); }
            set { BackingStore?.Set("provisioning", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.ProvisioningObjectSummary> Provisioning
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.ProvisioningObjectSummary>>("provisioning"); }
            set { BackingStore?.Set("provisioning", value); }
        }
#endif
        /// <summary>The signIns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.SignIn>? SignIns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SignIn>?>("signIns"); }
            set { BackingStore?.Set("signIns", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.SignIn> SignIns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.SignIn>>("signIns"); }
            set { BackingStore?.Set("signIns", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AuditLogRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AuditLogRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AuditLogRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "directoryAudits", n => { DirectoryAudits = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryAudit>(global::Microsoft.Graph.Models.DirectoryAudit.CreateFromDiscriminatorValue)?.AsList(); } },
                { "provisioning", n => { Provisioning = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.ProvisioningObjectSummary>(global::Microsoft.Graph.Models.ProvisioningObjectSummary.CreateFromDiscriminatorValue)?.AsList(); } },
                { "signIns", n => { SignIns = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.SignIn>(global::Microsoft.Graph.Models.SignIn.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.DirectoryAudit>("directoryAudits", DirectoryAudits);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.ProvisioningObjectSummary>("provisioning", Provisioning);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.SignIn>("signIns", SignIns);
        }
    }
}
#pragma warning restore CS0618
