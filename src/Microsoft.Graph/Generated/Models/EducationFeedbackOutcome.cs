// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class EducationFeedbackOutcome : global::Microsoft.Graph.Models.EducationOutcome, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Teacher&apos;s written feedback to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationFeedback? Feedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationFeedback?>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationFeedback Feedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationFeedback>("feedback"); }
            set { BackingStore?.Set("feedback", value); }
        }
#endif
        /// <summary>A copy of the feedback property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Models.EducationFeedback? PublishedFeedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationFeedback?>("publishedFeedback"); }
            set { BackingStore?.Set("publishedFeedback", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Models.EducationFeedback PublishedFeedback
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Models.EducationFeedback>("publishedFeedback"); }
            set { BackingStore?.Set("publishedFeedback", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Models.EducationFeedbackOutcome"/> and sets the default values.
        /// </summary>
        public EducationFeedbackOutcome() : base()
        {
            OdataType = "#microsoft.graph.educationFeedbackOutcome";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Models.EducationFeedbackOutcome"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Models.EducationFeedbackOutcome CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Models.EducationFeedbackOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "feedback", n => { Feedback = n.GetObjectValue<global::Microsoft.Graph.Models.EducationFeedback>(global::Microsoft.Graph.Models.EducationFeedback.CreateFromDiscriminatorValue); } },
                { "publishedFeedback", n => { PublishedFeedback = n.GetObjectValue<global::Microsoft.Graph.Models.EducationFeedback>(global::Microsoft.Graph.Models.EducationFeedback.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationFeedback>("feedback", Feedback);
            writer.WriteObjectValue<global::Microsoft.Graph.Models.EducationFeedback>("publishedFeedback", PublishedFeedback);
        }
    }
}
#pragma warning restore CS0618
