// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> IP configuration for virtual network gateway. </summary>
    public partial class VirtualNetworkGatewayIPConfiguration : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayIPConfiguration"/>. </summary>
        public VirtualNetworkGatewayIPConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VirtualNetworkGatewayIPConfiguration"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnet"> The reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference to the public IP resource. </param>
        /// <param name="privateIPAddress"> Private IP Address for this gateway. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual network gateway IP configuration resource. </param>
        internal VirtualNetworkGatewayIPConfiguration(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, NetworkIPAllocationMethod? privateIPAllocationMethod, WritableSubResource subnet, WritableSubResource publicIPAddress, string privateIPAddress, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            PrivateIPAddress = privateIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The private IP address allocation method. </summary>
        public NetworkIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> The reference to the public IP resource. </summary>
        internal WritableSubResource PublicIPAddress { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PublicIPAddressId
        {
            get => PublicIPAddress is null ? default : PublicIPAddress.Id;
            set
            {
                if (PublicIPAddress is null)
                    PublicIPAddress = new WritableSubResource();
                PublicIPAddress.Id = value;
            }
        }

        /// <summary> Private IP Address for this gateway. </summary>
        public string PrivateIPAddress { get; }
        /// <summary> The provisioning state of the virtual network gateway IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
