// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the update module operation. </summary>
    public partial class AutomationAccountPython2PackagePatch
    {
        /// <summary> Initializes a new instance of AutomationAccountPython2PackagePatch. </summary>
        public AutomationAccountPython2PackagePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Gets or sets the tags attached to the resource. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
