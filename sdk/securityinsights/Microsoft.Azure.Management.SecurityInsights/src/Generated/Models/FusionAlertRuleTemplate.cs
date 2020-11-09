// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents Fusion alert rule template.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Fusion")]
    [Rest.Serialization.JsonTransformation]
    public partial class FusionAlertRuleTemplate : AlertRuleTemplate
    {
        /// <summary>
        /// Initializes a new instance of the FusionAlertRuleTemplate class.
        /// </summary>
        public FusionAlertRuleTemplate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FusionAlertRuleTemplate class.
        /// </summary>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="alertRulesCreatedByTemplateCount">the number of alert
        /// rules that were created by this template</param>
        /// <param name="createdDateUTC">The time that this alert rule template
        /// has been added.</param>
        /// <param name="description">The description of the alert rule
        /// template.</param>
        /// <param name="displayName">The display name for alert rule
        /// template.</param>
        /// <param name="requiredDataConnectors">The required data connectors
        /// for this template</param>
        /// <param name="status">The alert rule template status. Possible
        /// values include: 'Installed', 'Available', 'NotAvailable'</param>
        /// <param name="severity">The severity for alerts created by this
        /// alert rule. Possible values include: 'High', 'Medium', 'Low',
        /// 'Informational'</param>
        /// <param name="tactics">The tactics of the alert rule
        /// template</param>
        public FusionAlertRuleTemplate(string id = default(string), string name = default(string), string type = default(string), int? alertRulesCreatedByTemplateCount = default(int?), System.DateTime? createdDateUTC = default(System.DateTime?), string description = default(string), string displayName = default(string), IList<AlertRuleTemplateDataSource> requiredDataConnectors = default(IList<AlertRuleTemplateDataSource>), string status = default(string), string severity = default(string), IList<string> tactics = default(IList<string>))
            : base(id, name, type)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            CreatedDateUTC = createdDateUTC;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            Severity = severity;
            Tactics = tactics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of alert rules that were created by this
        /// template
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertRulesCreatedByTemplateCount")]
        public int? AlertRulesCreatedByTemplateCount { get; set; }

        /// <summary>
        /// Gets the time that this alert rule template has been added.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDateUTC")]
        public System.DateTime? CreatedDateUTC { get; private set; }

        /// <summary>
        /// Gets or sets the description of the alert rule template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display name for alert rule template.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the required data connectors for this template
        /// </summary>
        [JsonProperty(PropertyName = "properties.requiredDataConnectors")]
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; set; }

        /// <summary>
        /// Gets or sets the alert rule template status. Possible values
        /// include: 'Installed', 'Available', 'NotAvailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the severity for alerts created by this alert rule.
        /// Possible values include: 'High', 'Medium', 'Low', 'Informational'
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the tactics of the alert rule template
        /// </summary>
        [JsonProperty(PropertyName = "properties.tactics")]
        public IList<string> Tactics { get; set; }

    }
}