// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Peering;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The properties that define a Log Analytics Workspace. </summary>
    public partial class PeeringLogAnalyticsWorkspaceProperties
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

        /// <summary> Initializes a new instance of <see cref="PeeringLogAnalyticsWorkspaceProperties"/>. </summary>
        public PeeringLogAnalyticsWorkspaceProperties()
        {
            ConnectedAgents = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="PeeringLogAnalyticsWorkspaceProperties"/>. </summary>
        /// <param name="workspaceId"> The Workspace ID. </param>
        /// <param name="key"> The Workspace Key. </param>
        /// <param name="connectedAgents"> The list of connected agents. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringLogAnalyticsWorkspaceProperties(string workspaceId, string key, IReadOnlyList<string> connectedAgents, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            WorkspaceId = workspaceId;
            Key = key;
            ConnectedAgents = connectedAgents;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Workspace ID. </summary>
        public string WorkspaceId { get; }
        /// <summary> The Workspace Key. </summary>
        public string Key { get; }
        /// <summary> The list of connected agents. </summary>
        public IReadOnlyList<string> ConnectedAgents { get; }
    }
}
