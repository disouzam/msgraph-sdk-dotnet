// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>TV content rating labels in Australia</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum RatingAustraliaTelevisionType
    {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The P classification is intended for preschoolers</summary>
        [EnumMember(Value = "preschoolers")]
        Preschoolers,
        /// <summary>The C classification is intended for children under 14</summary>
        [EnumMember(Value = "children")]
        Children,
        /// <summary>The G classification is suitable for all ages</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PG classification is recommended for young viewers</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The M classification is recommended for viewers over 15</summary>
        [EnumMember(Value = "mature")]
        Mature,
        /// <summary>The MA15+ classification is not suitable for viewers under 15</summary>
        [EnumMember(Value = "agesAbove15")]
        AgesAbove15,
        /// <summary>The AV15+ classification is not suitable for viewers under 15, adult violence-specific</summary>
        [EnumMember(Value = "agesAbove15AdultViolence")]
        AgesAbove15AdultViolence,
    }
}
