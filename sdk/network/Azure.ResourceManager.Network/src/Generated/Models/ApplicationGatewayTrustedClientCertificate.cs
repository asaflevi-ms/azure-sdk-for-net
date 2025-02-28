// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Trusted client certificates of an application gateway. </summary>
    public partial class ApplicationGatewayTrustedClientCertificate : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayTrustedClientCertificate"/>. </summary>
        public ApplicationGatewayTrustedClientCertificate()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayTrustedClientCertificate"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="data"> Certificate public data. </param>
        /// <param name="validatedCertData"> Validated certificate data. </param>
        /// <param name="clientCertIssuerDN"> Distinguished name of client certificate issuer. </param>
        /// <param name="provisioningState"> The provisioning state of the trusted client certificate resource. </param>
        internal ApplicationGatewayTrustedClientCertificate(ResourceIdentifier id, string name, ResourceType? resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ETag? etag, BinaryData data, BinaryData validatedCertData, string clientCertIssuerDN, NetworkProvisioningState? provisioningState) : base(id, name, resourceType, serializedAdditionalRawData)
        {
            ETag = etag;
            Data = data;
            ValidatedCertData = validatedCertData;
            ClientCertIssuerDN = clientCertIssuerDN;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary>
        /// Certificate public data.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData Data { get; set; }
        /// <summary>
        /// Validated certificate data.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData ValidatedCertData { get; }
        /// <summary> Distinguished name of client certificate issuer. </summary>
        public string ClientCertIssuerDN { get; }
        /// <summary> The provisioning state of the trusted client certificate resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
