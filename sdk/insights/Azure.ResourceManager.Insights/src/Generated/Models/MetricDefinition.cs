// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Metric definition class specifies the metadata for a metric. </summary>
    public partial class MetricDefinition
    {
        /// <summary> Initializes a new instance of MetricDefinition. </summary>
        internal MetricDefinition()
        {
            SupportedAggregationTypes = new ChangeTrackingList<AggregationType>();
            MetricAvailabilities = new ChangeTrackingList<MetricAvailability>();
            Dimensions = new ChangeTrackingList<LocalizableString>();
        }

        /// <summary> Initializes a new instance of MetricDefinition. </summary>
        /// <param name="isDimensionRequired"> Flag to indicate whether the dimension is required. </param>
        /// <param name="resourceId"> the resource identifier of the resource that emitted the metric. </param>
        /// <param name="namespace"> the namespace the metric belongs to. </param>
        /// <param name="name"> the name and the display name of the metric, i.e. it is a localizable string. </param>
        /// <param name="unit"> the unit of the metric. </param>
        /// <param name="primaryAggregationType"> the primary aggregation type value defining how to use the values for display. </param>
        /// <param name="supportedAggregationTypes"> the collection of what aggregation types are supported. </param>
        /// <param name="metricAvailabilities"> the collection of what aggregation intervals are available to be queried. </param>
        /// <param name="id"> the resource identifier of the metric definition. </param>
        /// <param name="dimensions"> the name and the display name of the dimension, i.e. it is a localizable string. </param>
        internal MetricDefinition(bool? isDimensionRequired, string resourceId, string @namespace, LocalizableString name, Unit? unit, AggregationType? primaryAggregationType, IReadOnlyList<AggregationType> supportedAggregationTypes, IReadOnlyList<MetricAvailability> metricAvailabilities, string id, IReadOnlyList<LocalizableString> dimensions)
        {
            IsDimensionRequired = isDimensionRequired;
            ResourceId = resourceId;
            Namespace = @namespace;
            Name = name;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            SupportedAggregationTypes = supportedAggregationTypes;
            MetricAvailabilities = metricAvailabilities;
            Id = id;
            Dimensions = dimensions;
        }

        /// <summary> Flag to indicate whether the dimension is required. </summary>
        public bool? IsDimensionRequired { get; }
        /// <summary> the resource identifier of the resource that emitted the metric. </summary>
        public string ResourceId { get; }
        /// <summary> the namespace the metric belongs to. </summary>
        public string Namespace { get; }
        /// <summary> the name and the display name of the metric, i.e. it is a localizable string. </summary>
        public LocalizableString Name { get; }
        /// <summary> the unit of the metric. </summary>
        public Unit? Unit { get; }
        /// <summary> the primary aggregation type value defining how to use the values for display. </summary>
        public AggregationType? PrimaryAggregationType { get; }
        /// <summary> the collection of what aggregation types are supported. </summary>
        public IReadOnlyList<AggregationType> SupportedAggregationTypes { get; }
        /// <summary> the collection of what aggregation intervals are available to be queried. </summary>
        public IReadOnlyList<MetricAvailability> MetricAvailabilities { get; }
        /// <summary> the resource identifier of the metric definition. </summary>
        public string Id { get; }
        /// <summary> the name and the display name of the dimension, i.e. it is a localizable string. </summary>
        public IReadOnlyList<LocalizableString> Dimensions { get; }
    }
}