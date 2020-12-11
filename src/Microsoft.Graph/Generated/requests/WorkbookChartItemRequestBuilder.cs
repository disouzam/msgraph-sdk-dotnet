// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartItemRequestBuilder.
    /// </summary>
    public partial class WorkbookChartItemRequestBuilder : BaseFunctionMethodRequestBuilder<IWorkbookChartItemRequest>, IWorkbookChartItemRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookChartItemRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="name">A name parameter for the OData method call.</param>
        public WorkbookChartItemRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string name)
            : base(requestUrl, client)
        {
            this.SetParameter("name", name, true);
            this.SetFunctionParameters();            
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookChartItemRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookChartItemRequest(functionUrl, this.Client, options);

            return request;
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartAddRequestBuilder.
        /// </summary>
        /// <param name="type">A type parameter for the OData method call.</param>
        /// <param name="seriesBy">A seriesBy parameter for the OData method call.</param>
        /// <param name="sourceData">A sourceData parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartAddRequestBuilder"/>.</returns>
        public IWorkbookChartAddRequestBuilder Add(
            string type,
            string seriesBy,
            Newtonsoft.Json.Linq.JToken sourceData)
        {
            return new WorkbookChartAddRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.add"),
                this.Client,
                type,
                seriesBy,
                sourceData);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartCountRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartCountRequestBuilder"/>.</returns>
        public IWorkbookChartCountRequestBuilder Count()
        {
            return new WorkbookChartCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartImageRequestBuilder.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartImageRequestBuilder"/>.</returns>
        public IWorkbookChartImageRequestBuilder Image()
        {
            return new WorkbookChartImageRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.image"),
                this.Client);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartItemRequestBuilder.
        /// </summary>
        /// <param name="name">A name parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartItemRequestBuilder"/>.</returns>
        public IWorkbookChartItemRequestBuilder Item(
            string name)
        {
            return new WorkbookChartItemRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.item"),
                this.Client,
                name);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartItemAtRequestBuilder.
        /// </summary>
        /// <param name="index">A index parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartItemAtRequestBuilder"/>.</returns>
        public IWorkbookChartItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookChartItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartSetDataRequestBuilder.
        /// </summary>
        /// <param name="seriesBy">A seriesBy parameter for the OData method call.</param>
        /// <param name="sourceData">A sourceData parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartSetDataRequestBuilder"/>.</returns>
        public IWorkbookChartSetDataRequestBuilder SetData(
            string seriesBy,
            Newtonsoft.Json.Linq.JToken sourceData)
        {
            return new WorkbookChartSetDataRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setData"),
                this.Client,
                seriesBy,
                sourceData);
        }
        /// <summary>
        /// Gets the request builder for WorkbookChartSetPositionRequestBuilder.
        /// </summary>
        /// <param name="startCell">A startCell parameter for the OData method call.</param>
        /// <param name="endCell">A endCell parameter for the OData method call.</param>
        /// <returns>The <see cref="IWorkbookChartSetPositionRequestBuilder"/>.</returns>
        public IWorkbookChartSetPositionRequestBuilder SetPosition(
            Newtonsoft.Json.Linq.JToken startCell,
            Newtonsoft.Json.Linq.JToken endCell)
        {
            return new WorkbookChartSetPositionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.setPosition"),
                this.Client,
                startCell,
                endCell);
        }
        /// <summary>
        /// Gets the request builder for Axes.
        /// Represents chart axes. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartAxesRequestBuilder"/>.</returns>
        public IWorkbookChartAxesRequestBuilder Axes
        {
            get
            {
                return new WorkbookChartAxesRequestBuilder(this.AppendSegmentToRequestUrl("axes"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for DataLabels.
        /// Represents the datalabels on the chart. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartDataLabelsRequestBuilder"/>.</returns>
        public IWorkbookChartDataLabelsRequestBuilder DataLabels
        {
            get
            {
                return new WorkbookChartDataLabelsRequestBuilder(this.AppendSegmentToRequestUrl("dataLabels"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Format.
        /// Encapsulates the format properties for the chart area. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartAreaFormatRequestBuilder"/>.</returns>
        public IWorkbookChartAreaFormatRequestBuilder Format
        {
            get
            {
                return new WorkbookChartAreaFormatRequestBuilder(this.AppendSegmentToRequestUrl("format"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Legend.
        /// Represents the legend for the chart. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartLegendRequestBuilder"/>.</returns>
        public IWorkbookChartLegendRequestBuilder Legend
        {
            get
            {
                return new WorkbookChartLegendRequestBuilder(this.AppendSegmentToRequestUrl("legend"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Series.
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartSeriesRequestBuilder"/>.</returns>
        public IWorkbookChartSeriesRequestBuilder Series
        {
            get
            {
                return new WorkbookChartSeriesRequestBuilder(this.AppendSegmentToRequestUrl("series"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Title.
        /// Represents the title of the specified chart, including the text, visibility, position and formating of the title. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartTitleRequestBuilder"/>.</returns>
        public IWorkbookChartTitleRequestBuilder Title
        {
            get
            {
                return new WorkbookChartTitleRequestBuilder(this.AppendSegmentToRequestUrl("title"), this.Client);
            }
        }
        /// <summary>
        /// Gets the request builder for Worksheet.
        /// The worksheet containing the current chart. Read-only.
        /// </summary>
        /// <returns>The <see cref="IWorkbookWorksheetRequestBuilder"/>.</returns>
        public IWorkbookWorksheetRequestBuilder Worksheet
        {
            get
            {
                return new WorkbookWorksheetRequestBuilder(this.AppendSegmentToRequestUrl("worksheet"), this.Client);
            }
        }
    }
}
