// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The description of the DigitalTwins service. </summary>
    public partial class DigitalTwinsDescriptionPatch
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

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsDescriptionPatch"/>. </summary>
        public DigitalTwinsDescriptionPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsDescriptionPatch"/>. </summary>
        /// <param name="tags"> Instance patch properties. </param>
        /// <param name="identity"> The managed identity for the DigitalTwinsInstance. </param>
        /// <param name="properties"> Properties for the DigitalTwinsInstance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsDescriptionPatch(IDictionary<string, string> tags, ManagedServiceIdentity identity, DigitalTwinsPatchProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Identity = identity;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Instance patch properties. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> The managed identity for the DigitalTwinsInstance. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Properties for the DigitalTwinsInstance. </summary>
        internal DigitalTwinsPatchProperties Properties { get; set; }
        /// <summary> Public network access for the DigitalTwinsInstance. </summary>
        public DigitalTwinsPublicNetworkAccess? DigitalTwinsPatchPublicNetworkAccess
        {
            get => Properties is null ? default : Properties.PublicNetworkAccess;
            set
            {
                if (Properties is null)
                    Properties = new DigitalTwinsPatchProperties();
                Properties.PublicNetworkAccess = value;
            }
        }
    }
}
