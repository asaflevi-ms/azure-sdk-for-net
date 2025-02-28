// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.VoiceServices;

namespace Azure.ResourceManager.VoiceServices.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableVoiceServicesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableVoiceServicesResourceGroupResource"/> class for mocking. </summary>
        protected MockableVoiceServicesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableVoiceServicesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableVoiceServicesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of VoiceServicesCommunicationsGatewayResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of VoiceServicesCommunicationsGatewayResources and their operations over a VoiceServicesCommunicationsGatewayResource. </returns>
        public virtual VoiceServicesCommunicationsGatewayCollection GetVoiceServicesCommunicationsGateways()
        {
            return GetCachedClient(client => new VoiceServicesCommunicationsGatewayCollection(client, Id));
        }

        /// <summary>
        /// Get a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesCommunicationsGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<VoiceServicesCommunicationsGatewayResource>> GetVoiceServicesCommunicationsGatewayAsync(string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            return await GetVoiceServicesCommunicationsGateways().GetAsync(communicationsGatewayName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a CommunicationsGateway
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.VoiceServices/communicationsGateways/{communicationsGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommunicationsGateways_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="VoiceServicesCommunicationsGatewayResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="communicationsGatewayName"> Unique identifier for this deployment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="communicationsGatewayName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="communicationsGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<VoiceServicesCommunicationsGatewayResource> GetVoiceServicesCommunicationsGateway(string communicationsGatewayName, CancellationToken cancellationToken = default)
        {
            return GetVoiceServicesCommunicationsGateways().Get(communicationsGatewayName, cancellationToken);
        }
    }
}
