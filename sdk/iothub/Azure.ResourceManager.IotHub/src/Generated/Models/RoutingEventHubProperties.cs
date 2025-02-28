// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    /// <summary> The properties related to an event hub endpoint. </summary>
    public partial class RoutingEventHubProperties
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

        /// <summary> Initializes a new instance of <see cref="RoutingEventHubProperties"/>. </summary>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RoutingEventHubProperties(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingEventHubProperties"/>. </summary>
        /// <param name="id"> Id of the event hub endpoint. </param>
        /// <param name="connectionString"> The connection string of the event hub endpoint. </param>
        /// <param name="endpoint"> The url of the event hub endpoint. It must include the protocol sb://. </param>
        /// <param name="entityPath"> Event hub name on the event hub namespace. </param>
        /// <param name="authenticationType"> Method used to authenticate against the event hub endpoint. </param>
        /// <param name="identity"> Managed identity properties of routing event hub endpoint. </param>
        /// <param name="name"> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </param>
        /// <param name="subscriptionId"> The subscription identifier of the event hub endpoint. </param>
        /// <param name="resourceGroup"> The name of the resource group of the event hub endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RoutingEventHubProperties(Guid? id, string connectionString, string endpoint, string entityPath, IotHubAuthenticationType? authenticationType, ManagedIdentity identity, string name, string subscriptionId, string resourceGroup, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            ConnectionString = connectionString;
            Endpoint = endpoint;
            EntityPath = entityPath;
            AuthenticationType = authenticationType;
            Identity = identity;
            Name = name;
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RoutingEventHubProperties"/> for deserialization. </summary>
        internal RoutingEventHubProperties()
        {
        }

        /// <summary> Id of the event hub endpoint. </summary>
        public Guid? Id { get; set; }
        /// <summary> The connection string of the event hub endpoint. </summary>
        public string ConnectionString { get; set; }
        /// <summary> The url of the event hub endpoint. It must include the protocol sb://. </summary>
        public string Endpoint { get; set; }
        /// <summary> Event hub name on the event hub namespace. </summary>
        public string EntityPath { get; set; }
        /// <summary> Method used to authenticate against the event hub endpoint. </summary>
        public IotHubAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Managed identity properties of routing event hub endpoint. </summary>
        internal ManagedIdentity Identity { get; set; }
        /// <summary> The user assigned identity. </summary>
        public ResourceIdentifier UserAssignedIdentity
        {
            get => Identity is null ? default : Identity.UserAssignedIdentity;
            set
            {
                if (Identity is null)
                    Identity = new ManagedIdentity();
                Identity.UserAssignedIdentity = value;
            }
        }

        /// <summary> The name that identifies this endpoint. The name can only include alphanumeric characters, periods, underscores, hyphens and has a maximum length of 64 characters. The following names are reserved:  events, fileNotifications, $default. Endpoint names must be unique across endpoint types. </summary>
        public string Name { get; set; }
        /// <summary> The subscription identifier of the event hub endpoint. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> The name of the resource group of the event hub endpoint. </summary>
        public string ResourceGroup { get; set; }
    }
}
