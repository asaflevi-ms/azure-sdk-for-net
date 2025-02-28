// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The AdaptiveNetworkHardeningEnforceContent. </summary>
    public partial class AdaptiveNetworkHardeningEnforceContent
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

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningEnforceContent"/>. </summary>
        /// <param name="rules"> The rules to enforce. </param>
        /// <param name="networkSecurityGroups"> The Azure resource IDs of the effective network security groups that will be updated with the created security rules from the Adaptive Network Hardening rules. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="rules"/> or <paramref name="networkSecurityGroups"/> is null. </exception>
        public AdaptiveNetworkHardeningEnforceContent(IEnumerable<RecommendedSecurityRule> rules, IEnumerable<string> networkSecurityGroups)
        {
            if (rules == null)
            {
                throw new ArgumentNullException(nameof(rules));
            }
            if (networkSecurityGroups == null)
            {
                throw new ArgumentNullException(nameof(networkSecurityGroups));
            }

            Rules = rules.ToList();
            NetworkSecurityGroups = networkSecurityGroups.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningEnforceContent"/>. </summary>
        /// <param name="rules"> The rules to enforce. </param>
        /// <param name="networkSecurityGroups"> The Azure resource IDs of the effective network security groups that will be updated with the created security rules from the Adaptive Network Hardening rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdaptiveNetworkHardeningEnforceContent(IList<RecommendedSecurityRule> rules, IList<string> networkSecurityGroups, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rules = rules;
            NetworkSecurityGroups = networkSecurityGroups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningEnforceContent"/> for deserialization. </summary>
        internal AdaptiveNetworkHardeningEnforceContent()
        {
        }

        /// <summary> The rules to enforce. </summary>
        public IList<RecommendedSecurityRule> Rules { get; }
        /// <summary> The Azure resource IDs of the effective network security groups that will be updated with the created security rules from the Adaptive Network Hardening rules. </summary>
        public IList<string> NetworkSecurityGroups { get; }
    }
}
