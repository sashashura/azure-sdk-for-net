// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary>
    /// Azure Data Factory nested object which serves as a compute resource for activities.
    /// Please note <see cref="IntegrationRuntimeDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
    /// </summary>
    public partial class IntegrationRuntimeDefinition
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeDefinition. </summary>
        public IntegrationRuntimeDefinition()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeDefinition. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal IntegrationRuntimeDefinition(IntegrationRuntimeType runtimeType, string description, IDictionary<string, BinaryData> additionalProperties)
        {
            RuntimeType = runtimeType;
            Description = description;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of integration runtime. </summary>
        internal IntegrationRuntimeType RuntimeType { get; set; }
        /// <summary> Integration runtime description. </summary>
        public string Description { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
