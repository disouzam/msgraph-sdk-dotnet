// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    [Flags]
    #pragma warning disable CS1591
    public enum ConditionalAccessGuestOrExternalUserTypes
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalGuest")]
        #pragma warning disable CS1591
        InternalGuest = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "b2bCollaborationGuest")]
        #pragma warning disable CS1591
        B2bCollaborationGuest = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "b2bCollaborationMember")]
        #pragma warning disable CS1591
        B2bCollaborationMember = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "b2bDirectConnectUser")]
        #pragma warning disable CS1591
        B2bDirectConnectUser = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "otherExternalUser")]
        #pragma warning disable CS1591
        OtherExternalUser = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "serviceProvider")]
        #pragma warning disable CS1591
        ServiceProvider = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 128,
        #pragma warning restore CS1591
    }
}
