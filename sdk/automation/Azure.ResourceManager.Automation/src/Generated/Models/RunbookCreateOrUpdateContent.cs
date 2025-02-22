// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update runbook operation. </summary>
    public partial class RunbookCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of RunbookCreateOrUpdateContent. </summary>
        /// <param name="runbookType"> Gets or sets the type of the runbook. </param>
        public RunbookCreateOrUpdateContent(RunbookTypeEnum runbookType)
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            RunbookType = runbookType;
        }

        /// <summary> Gets or sets the name of the resource. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the location of the resource. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets verbose log option. </summary>
        public bool? LogVerbose { get; set; }
        /// <summary> Gets or sets progress log option. </summary>
        public bool? LogProgress { get; set; }
        /// <summary> Gets or sets the type of the runbook. </summary>
        public RunbookTypeEnum RunbookType { get; }
        /// <summary> Gets or sets the draft runbook properties. </summary>
        public RunbookDraft Draft { get; set; }
        /// <summary> Gets or sets the published runbook content link. </summary>
        public ContentLink PublishContentLink { get; set; }
        /// <summary> Gets or sets the description of the runbook. </summary>
        public string Description { get; set; }
        /// <summary> Gets or sets the activity-level tracing options of the runbook. </summary>
        public int? LogActivityTrace { get; set; }
    }
}
