// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class GetSettingNonComplianceReportPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The filter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Filter
        {
            get { return BackingStore?.Get<string?>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
#nullable restore
#else
        public string Filter
        {
            get { return BackingStore?.Get<string>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
#endif
        /// <summary>The groupBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupBy
        {
            get { return BackingStore?.Get<List<string>?>("groupBy"); }
            set { BackingStore?.Set("groupBy", value); }
        }
#nullable restore
#else
        public List<string> GroupBy
        {
            get { return BackingStore?.Get<List<string>>("groupBy"); }
            set { BackingStore?.Set("groupBy", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The orderBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? OrderBy
        {
            get { return BackingStore?.Get<List<string>?>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
#nullable restore
#else
        public List<string> OrderBy
        {
            get { return BackingStore?.Get<List<string>>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
#endif
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Search
        {
            get { return BackingStore?.Get<string?>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#nullable restore
#else
        public string Search
        {
            get { return BackingStore?.Get<string>("search"); }
            set { BackingStore?.Set("search", value); }
        }
#endif
        /// <summary>The select property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Select
        {
            get { return BackingStore?.Get<List<string>?>("select"); }
            set { BackingStore?.Set("select", value); }
        }
#nullable restore
#else
        public List<string> Select
        {
            get { return BackingStore?.Get<List<string>>("select"); }
            set { BackingStore?.Set("select", value); }
        }
#endif
        /// <summary>The sessionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionId
        {
            get { return BackingStore?.Get<string?>("sessionId"); }
            set { BackingStore?.Set("sessionId", value); }
        }
#nullable restore
#else
        public string SessionId
        {
            get { return BackingStore?.Get<string>("sessionId"); }
            set { BackingStore?.Set("sessionId", value); }
        }
#endif
        /// <summary>The skip property</summary>
        public int? Skip
        {
            get { return BackingStore?.Get<int?>("skip"); }
            set { BackingStore?.Set("skip", value); }
        }
        /// <summary>The top property</summary>
        public int? Top
        {
            get { return BackingStore?.Get<int?>("top"); }
            set { BackingStore?.Set("top", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportPostRequestBody"/> and sets the default values.
        /// </summary>
        public GetSettingNonComplianceReportPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.DeviceManagement.Reports.GetSettingNonComplianceReport.GetSettingNonComplianceReportPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "filter", n => { Filter = n.GetStringValue(); } },
                { "groupBy", n => { GroupBy = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "search", n => { Search = n.GetStringValue(); } },
                { "select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "sessionId", n => { SessionId = n.GetStringValue(); } },
                { "skip", n => { Skip = n.GetIntValue(); } },
                { "top", n => { Top = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("filter", Filter);
            writer.WriteCollectionOfPrimitiveValues<string>("groupBy", GroupBy);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("search", Search);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteIntValue("skip", Skip);
            writer.WriteIntValue("top", Top);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
