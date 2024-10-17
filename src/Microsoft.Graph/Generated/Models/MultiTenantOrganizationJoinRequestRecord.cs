// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class MultiTenantOrganizationJoinRequestRecord : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Tenant ID of the Microsoft Entra tenant that added a tenant to the multitenant organization. To reset a failed join request, set addedByTenantId to 00000000-0000-0000-0000-000000000000. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddedByTenantId
        {
            get { return BackingStore?.Get<string?>("addedByTenantId"); }
            set { BackingStore?.Set("addedByTenantId", value); }
        }
#nullable restore
#else
        public string AddedByTenantId
        {
            get { return BackingStore?.Get<string>("addedByTenantId"); }
            set { BackingStore?.Set("addedByTenantId", value); }
        }
#endif
        /// <summary>State of the tenant in the multitenant organization. The possible values are: pending, active, removed, unknownFutureValue. Tenants in the pending state must join the multitenant organization to participate in the multitenant organization. Tenants in the active state can participate in the multitenant organization. Tenants in the removed state are in the process of being removed from the multitenant organization. Read-only.</summary>
        public global::Microsoft.Graph.Models.MultiTenantOrganizationMemberState? MemberState
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MultiTenantOrganizationMemberState?>("memberState"); }
            set { BackingStore?.Set("memberState", value); }
        }
        /// <summary>Role of the tenant in the multitenant organization. The possible values are: owner, member (default), unknownFutureValue. Tenants with the owner role can manage the multitenant organization. There can be multiple tenants with the owner role in a multitenant organization. Tenants with the member role can participate in a multitenant organization.</summary>
        public global::Microsoft.Graph.Models.MultiTenantOrganizationMemberRole? Role
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MultiTenantOrganizationMemberRole?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
        /// <summary>Details of the processing status for a tenant joining a multitenant organization. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails? TransitionDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails?>("transitionDetails"); }
            set { BackingStore?.Set("transitionDetails", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails TransitionDetails
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails>("transitionDetails"); }
            set { BackingStore?.Set("transitionDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestRecord"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestRecord CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addedByTenantId", n => { AddedByTenantId = n.GetStringValue(); } },
                { "memberState", n => { MemberState = n.GetEnumValue<global::Microsoft.Graph.Models.MultiTenantOrganizationMemberState>(); } },
                { "role", n => { Role = n.GetEnumValue<global::Microsoft.Graph.Models.MultiTenantOrganizationMemberRole>(); } },
                { "transitionDetails", n => { TransitionDetails = n.GetObjectValue<global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails>(global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("addedByTenantId", AddedByTenantId);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.MultiTenantOrganizationMemberState>("memberState", MemberState);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.MultiTenantOrganizationMemberRole>("role", Role);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails>("transitionDetails", TransitionDetails);
        }
    }
}
#pragma warning restore CS0618
