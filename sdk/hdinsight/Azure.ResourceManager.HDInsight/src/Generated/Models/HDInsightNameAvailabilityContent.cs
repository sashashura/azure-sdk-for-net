// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The request spec of checking name availability. </summary>
    public partial class HDInsightNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of HDInsightNameAvailabilityContent. </summary>
        public HDInsightNameAvailabilityContent()
        {
        }

        /// <summary> The resource name. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public ResourceType? ResourceType { get; set; }
    }
}
