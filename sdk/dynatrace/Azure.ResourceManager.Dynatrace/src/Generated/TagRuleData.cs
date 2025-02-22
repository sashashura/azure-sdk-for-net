// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Dynatrace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary> A class representing the TagRule data model. </summary>
    public partial class TagRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of TagRuleData. </summary>
        public TagRuleData()
        {
        }

        /// <summary> Initializes a new instance of TagRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRules"> Set of rules for sending metrics for the Monitor resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        internal TagRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, LogRules logRules, MetricRules metricRules, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            LogRules = logRules;
            MetricRules = metricRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public LogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        internal MetricRules MetricRules { get; set; }
        /// <summary> List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags. </summary>
        public IList<FilteringTag> MetricRulesFilteringTags
        {
            get
            {
                if (MetricRules is null)
                    MetricRules = new MetricRules();
                return MetricRules.FilteringTags;
            }
        }

        /// <summary> Provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
