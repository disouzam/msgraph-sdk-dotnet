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
    public partial class CountryNamedLocation : global::Microsoft.Graph.Models.NamedLocation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of countries and/or regions in two-letter format specified by ISO 3166-2. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CountriesAndRegions
        {
            get { return BackingStore?.Get<List<string>?>("countriesAndRegions"); }
            set { BackingStore?.Set("countriesAndRegions", value); }
        }
#nullable restore
#else
        public List<string> CountriesAndRegions
        {
            get { return BackingStore?.Get<List<string>>("countriesAndRegions"); }
            set { BackingStore?.Set("countriesAndRegions", value); }
        }
#endif
        /// <summary>Determines what method is used to decide which country the user is located in. Possible values are clientIpAddress(default) and authenticatorAppGps. Note: authenticatorAppGps is not yet supported in the Microsoft Cloud for US Government.</summary>
        public global::Microsoft.Graph.Models.CountryLookupMethodType? CountryLookupMethod
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.CountryLookupMethodType?>("countryLookupMethod"); }
            set { BackingStore?.Set("countryLookupMethod", value); }
        }
        /// <summary>true if IP addresses that don&apos;t map to a country or region should be included in the named location. Optional. Default value is false.</summary>
        public bool? IncludeUnknownCountriesAndRegions
        {
            get { return BackingStore?.Get<bool?>("includeUnknownCountriesAndRegions"); }
            set { BackingStore?.Set("includeUnknownCountriesAndRegions", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.CountryNamedLocation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.CountryNamedLocation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.CountryNamedLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "countriesAndRegions", n => { CountriesAndRegions = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "countryLookupMethod", n => { CountryLookupMethod = n.GetEnumValue<global::Microsoft.Graph.Models.CountryLookupMethodType>(); } },
                { "includeUnknownCountriesAndRegions", n => { IncludeUnknownCountriesAndRegions = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("countriesAndRegions", CountriesAndRegions);
            writer.WriteEnumValue<global::Microsoft.Graph.Models.CountryLookupMethodType>("countryLookupMethod", CountryLookupMethod);
            writer.WriteBoolValue("includeUnknownCountriesAndRegions", IncludeUnknownCountriesAndRegions);
        }
    }
}
#pragma warning restore CS0618
