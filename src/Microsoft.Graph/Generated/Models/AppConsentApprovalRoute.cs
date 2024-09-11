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
    public partial class AppConsentApprovalRoute : global::Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of appConsentRequest objects representing apps for which admin consent has been requested by one or more users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Models.AppConsentRequest>? AppConsentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AppConsentRequest>?>("appConsentRequests"); }
            set { BackingStore?.Set("appConsentRequests", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Models.AppConsentRequest> AppConsentRequests
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Models.AppConsentRequest>>("appConsentRequests"); }
            set { BackingStore?.Set("appConsentRequests", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.AppConsentApprovalRoute"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.AppConsentApprovalRoute CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.AppConsentApprovalRoute();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appConsentRequests", n => { AppConsentRequests = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Models.AppConsentRequest>(global::Microsoft.Graph.Models.AppConsentRequest.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Models.AppConsentRequest>("appConsentRequests", AppConsentRequests);
        }
    }
}
#pragma warning restore CS0618
