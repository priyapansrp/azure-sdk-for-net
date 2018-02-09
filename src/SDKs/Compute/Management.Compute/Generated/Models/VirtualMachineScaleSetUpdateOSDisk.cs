// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes virtual machine scale set operating system disk Update
    /// Object. This should be used for Updating VMSS OS Disk.
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateOSDisk
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateOSDisk class.
        /// </summary>
        public VirtualMachineScaleSetUpdateOSDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateOSDisk class.
        /// </summary>
        /// <param name="caching">The caching type. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="writeAcceleratorEnabled">Specifies whether
        /// writeAccelerator should be enabled or disabled on the disk.</param>
        /// <param name="image">The Source User Image VirtualHardDisk. This
        /// VirtualHardDisk will be copied before using it to attach to the
        /// Virtual Machine. If SourceImage is provided, the destination
        /// VirtualHardDisk should not exist.</param>
        /// <param name="vhdContainers">The list of virtual hard disk container
        /// uris.</param>
        /// <param name="managedDisk">The managed disk parameters.</param>
        public VirtualMachineScaleSetUpdateOSDisk(CachingTypes? caching = default(CachingTypes?), bool? writeAcceleratorEnabled = default(bool?), VirtualHardDisk image = default(VirtualHardDisk), IList<string> vhdContainers = default(IList<string>), VirtualMachineScaleSetManagedDiskParameters managedDisk = default(VirtualMachineScaleSetManagedDiskParameters))
        {
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            Image = image;
            VhdContainers = vhdContainers;
            ManagedDisk = managedDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the caching type. Possible values include: 'None',
        /// 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets specifies whether writeAccelerator should be enabled
        /// or disabled on the disk.
        /// </summary>
        [JsonProperty(PropertyName = "writeAcceleratorEnabled")]
        public bool? WriteAcceleratorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the Source User Image VirtualHardDisk. This
        /// VirtualHardDisk will be copied before using it to attach to the
        /// Virtual Machine. If SourceImage is provided, the destination
        /// VirtualHardDisk should not exist.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets the list of virtual hard disk container uris.
        /// </summary>
        [JsonProperty(PropertyName = "vhdContainers")]
        public IList<string> VhdContainers { get; set; }

        /// <summary>
        /// Gets or sets the managed disk parameters.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public VirtualMachineScaleSetManagedDiskParameters ManagedDisk { get; set; }

    }
}