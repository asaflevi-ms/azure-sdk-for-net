// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMage Azure V2 input to update replication protected item. </summary>
    public partial class A2AUpdateReplicationProtectedItemContent : UpdateReplicationProtectedItemProviderContent
    {
        /// <summary> Initializes a new instance of <see cref="A2AUpdateReplicationProtectedItemContent"/>. </summary>
        public A2AUpdateReplicationProtectedItemContent()
        {
            ManagedDiskUpdateDetails = new ChangeTrackingList<A2AVmManagedDiskUpdateDetails>();
            InstanceType = "A2A";
        }

        /// <summary> Initializes a new instance of <see cref="A2AUpdateReplicationProtectedItemContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="recoveryCloudServiceId"> The target cloud service ARM Id (for V1). </param>
        /// <param name="recoveryResourceGroupId"> The target resource group ARM Id (for V2). </param>
        /// <param name="managedDiskUpdateDetails"> Managed disk update details. </param>
        /// <param name="recoveryBootDiagStorageAccountId"> The boot diagnostic storage account. </param>
        /// <param name="diskEncryptionInfo"> The recovery os disk encryption information. </param>
        /// <param name="tfoAzureVmName"> The user given name for Test Failover VM. </param>
        /// <param name="recoveryProximityPlacementGroupId"> The recovery proximity placement group Id. </param>
        /// <param name="recoveryVirtualMachineScaleSetId"> The recovery virtual machine scale set Id. </param>
        /// <param name="recoveryCapacityReservationGroupId"> The recovery capacity reservation group Id. </param>
        internal A2AUpdateReplicationProtectedItemContent(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string recoveryCloudServiceId, ResourceIdentifier recoveryResourceGroupId, IList<A2AVmManagedDiskUpdateDetails> managedDiskUpdateDetails, ResourceIdentifier recoveryBootDiagStorageAccountId, SiteRecoveryDiskEncryptionInfo diskEncryptionInfo, string tfoAzureVmName, ResourceIdentifier recoveryProximityPlacementGroupId, ResourceIdentifier recoveryVirtualMachineScaleSetId, ResourceIdentifier recoveryCapacityReservationGroupId) : base(instanceType, serializedAdditionalRawData)
        {
            RecoveryCloudServiceId = recoveryCloudServiceId;
            RecoveryResourceGroupId = recoveryResourceGroupId;
            ManagedDiskUpdateDetails = managedDiskUpdateDetails;
            RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            DiskEncryptionInfo = diskEncryptionInfo;
            TfoAzureVmName = tfoAzureVmName;
            RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            RecoveryVirtualMachineScaleSetId = recoveryVirtualMachineScaleSetId;
            RecoveryCapacityReservationGroupId = recoveryCapacityReservationGroupId;
            InstanceType = instanceType ?? "A2A";
        }

        /// <summary> The target cloud service ARM Id (for V1). </summary>
        public string RecoveryCloudServiceId { get; set; }
        /// <summary> The target resource group ARM Id (for V2). </summary>
        public ResourceIdentifier RecoveryResourceGroupId { get; set; }
        /// <summary> Managed disk update details. </summary>
        public IList<A2AVmManagedDiskUpdateDetails> ManagedDiskUpdateDetails { get; }
        /// <summary> The boot diagnostic storage account. </summary>
        public ResourceIdentifier RecoveryBootDiagStorageAccountId { get; set; }
        /// <summary> The recovery os disk encryption information. </summary>
        public SiteRecoveryDiskEncryptionInfo DiskEncryptionInfo { get; set; }
        /// <summary> The user given name for Test Failover VM. </summary>
        public string TfoAzureVmName { get; set; }
        /// <summary> The recovery proximity placement group Id. </summary>
        public ResourceIdentifier RecoveryProximityPlacementGroupId { get; set; }
        /// <summary> The recovery virtual machine scale set Id. </summary>
        public ResourceIdentifier RecoveryVirtualMachineScaleSetId { get; set; }
        /// <summary> The recovery capacity reservation group Id. </summary>
        public ResourceIdentifier RecoveryCapacityReservationGroupId { get; set; }
    }
}
