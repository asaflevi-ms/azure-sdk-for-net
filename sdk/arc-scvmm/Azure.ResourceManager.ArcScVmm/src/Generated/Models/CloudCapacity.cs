// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Cloud Capacity model. </summary>
    public partial class CloudCapacity
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

        /// <summary> Initializes a new instance of <see cref="CloudCapacity"/>. </summary>
        internal CloudCapacity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudCapacity"/>. </summary>
        /// <param name="cpuCount"> CPUCount specifies the maximum number of CPUs that can be allocated in the cloud. </param>
        /// <param name="memoryMB"> MemoryMB specifies a memory usage limit in megabytes. </param>
        /// <param name="vmCount"> VMCount gives the max number of VMs that can be deployed in the cloud. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudCapacity(long? cpuCount, long? memoryMB, long? vmCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CpuCount = cpuCount;
            MemoryMB = memoryMB;
            VmCount = vmCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> CPUCount specifies the maximum number of CPUs that can be allocated in the cloud. </summary>
        public long? CpuCount { get; }
        /// <summary> MemoryMB specifies a memory usage limit in megabytes. </summary>
        public long? MemoryMB { get; }
        /// <summary> VMCount gives the max number of VMs that can be deployed in the cloud. </summary>
        public long? VmCount { get; }
    }
}
