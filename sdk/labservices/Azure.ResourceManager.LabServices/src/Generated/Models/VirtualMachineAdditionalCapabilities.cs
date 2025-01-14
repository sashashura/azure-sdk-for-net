// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The additional capabilities for a lab VM. </summary>
    internal partial class VirtualMachineAdditionalCapabilities
    {
        /// <summary> Initializes a new instance of VirtualMachineAdditionalCapabilities. </summary>
        public VirtualMachineAdditionalCapabilities()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineAdditionalCapabilities. </summary>
        /// <param name="installGpuDrivers"> Flag to pre-install dedicated GPU drivers. </param>
        internal VirtualMachineAdditionalCapabilities(EnableState? installGpuDrivers)
        {
            InstallGpuDrivers = installGpuDrivers;
        }

        /// <summary> Flag to pre-install dedicated GPU drivers. </summary>
        public EnableState? InstallGpuDrivers { get; set; }
    }
}
