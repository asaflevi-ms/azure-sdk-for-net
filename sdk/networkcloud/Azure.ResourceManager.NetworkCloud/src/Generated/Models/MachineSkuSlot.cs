// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> MachineSkuSlot represents a single SKU and rack slot associated with the machine. </summary>
    public partial class MachineSkuSlot
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineSkuSlot"/>. </summary>
        internal MachineSkuSlot()
        {
            Disks = new ChangeTrackingList<MachineDisk>();
            NetworkInterfaces = new ChangeTrackingList<NetworkCloudNetworkInterface>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineSkuSlot"/>. </summary>
        /// <param name="rackSlot"> The position in the rack for the machine. </param>
        /// <param name="bootstrapProtocol"> The type of bootstrap protocol used. </param>
        /// <param name="cpuCores"> The count of CPU cores for this machine. </param>
        /// <param name="cpuSockets"> The count of CPU sockets for this machine. </param>
        /// <param name="disks"> The list of disks. </param>
        /// <param name="generation"> The generation of the architecture. </param>
        /// <param name="hardwareVersion"> The hardware version of the machine. </param>
        /// <param name="memoryCapacityGB"> The maximum amount of memory in GB. </param>
        /// <param name="model"> The model of the machine. </param>
        /// <param name="networkInterfaces"> The list of network interfaces. </param>
        /// <param name="totalThreads"> The count of SMT and physical core threads for this machine. </param>
        /// <param name="vendor"> The make of the machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineSkuSlot(long? rackSlot, BootstrapProtocol? bootstrapProtocol, long? cpuCores, long? cpuSockets, IReadOnlyList<MachineDisk> disks, string generation, string hardwareVersion, long? memoryCapacityGB, string model, IReadOnlyList<NetworkCloudNetworkInterface> networkInterfaces, long? totalThreads, string vendor, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RackSlot = rackSlot;
            BootstrapProtocol = bootstrapProtocol;
            CpuCores = cpuCores;
            CpuSockets = cpuSockets;
            Disks = disks;
            Generation = generation;
            HardwareVersion = hardwareVersion;
            MemoryCapacityGB = memoryCapacityGB;
            Model = model;
            NetworkInterfaces = networkInterfaces;
            TotalThreads = totalThreads;
            Vendor = vendor;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The position in the rack for the machine. </summary>
        public long? RackSlot { get; }
        /// <summary> The type of bootstrap protocol used. </summary>
        public BootstrapProtocol? BootstrapProtocol { get; }
        /// <summary> The count of CPU cores for this machine. </summary>
        public long? CpuCores { get; }
        /// <summary> The count of CPU sockets for this machine. </summary>
        public long? CpuSockets { get; }
        /// <summary> The list of disks. </summary>
        public IReadOnlyList<MachineDisk> Disks { get; }
        /// <summary> The generation of the architecture. </summary>
        public string Generation { get; }
        /// <summary> The hardware version of the machine. </summary>
        public string HardwareVersion { get; }
        /// <summary> The maximum amount of memory in GB. </summary>
        public long? MemoryCapacityGB { get; }
        /// <summary> The model of the machine. </summary>
        public string Model { get; }
        /// <summary> The list of network interfaces. </summary>
        public IReadOnlyList<NetworkCloudNetworkInterface> NetworkInterfaces { get; }
        /// <summary> The count of SMT and physical core threads for this machine. </summary>
        public long? TotalThreads { get; }
        /// <summary> The make of the machine. </summary>
        public string Vendor { get; }
    }
}
