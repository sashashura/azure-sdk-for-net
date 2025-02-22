// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents OfficeIRM (Microsoft Insider Risk Management) requirements check request. </summary>
    public partial class OfficeIRMCheckRequirements : DataConnectorsCheckRequirements
    {
        /// <summary> Initializes a new instance of OfficeIRMCheckRequirements. </summary>
        public OfficeIRMCheckRequirements()
        {
            Kind = DataConnectorKind.OfficeIRM;
        }

        /// <summary> The tenant id to connect to, and get the data from. </summary>
        public Guid? TenantId { get; set; }
    }
}
