// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Azure-SSIS integration runtime outbound network dependency endpoints. </summary>
    internal partial class SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult
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

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult"/>. </summary>
        internal SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult()
        {
            Value = new ChangeTrackingList<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult"/>. </summary>
        /// <param name="value"> The list of outbound network dependency endpoints. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpointListResult(IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of outbound network dependency endpoints. </summary>
        public IReadOnlyList<SynapseIntegrationRuntimeOutboundNetworkDependenciesCategoryEndpoint> Value { get; }
    }
}
