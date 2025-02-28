// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.BotService
{
    /// <summary>
    /// A class representing a collection of <see cref="BotConnectionSettingResource"/> and their operations.
    /// Each <see cref="BotConnectionSettingResource"/> in the collection will belong to the same instance of <see cref="BotResource"/>.
    /// To get a <see cref="BotConnectionSettingCollection"/> instance call the GetBotConnectionSettings method from an instance of <see cref="BotResource"/>.
    /// </summary>
    public partial class BotConnectionSettingCollection : ArmCollection, IEnumerable<BotConnectionSettingResource>, IAsyncEnumerable<BotConnectionSettingResource>
    {
        private readonly ClientDiagnostics _botConnectionSettingBotConnectionClientDiagnostics;
        private readonly BotConnectionRestOperations _botConnectionSettingBotConnectionRestClient;

        /// <summary> Initializes a new instance of the <see cref="BotConnectionSettingCollection"/> class for mocking. </summary>
        protected BotConnectionSettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BotConnectionSettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BotConnectionSettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _botConnectionSettingBotConnectionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.BotService", BotConnectionSettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BotConnectionSettingResource.ResourceType, out string botConnectionSettingBotConnectionApiVersion);
            _botConnectionSettingBotConnectionRestClient = new BotConnectionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, botConnectionSettingBotConnectionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BotResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BotResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Register a new Auth Connection for a Bot Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="data"> The parameters to provide for creating the Connection Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BotConnectionSettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectionName, BotConnectionSettingData data, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _botConnectionSettingBotConnectionRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new BotServiceArmOperation<BotConnectionSettingResource>(Response.FromValue(new BotConnectionSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Register a new Auth Connection for a Bot Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="data"> The parameters to provide for creating the Connection Setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BotConnectionSettingResource> CreateOrUpdate(WaitUntil waitUntil, string connectionName, BotConnectionSettingData data, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _botConnectionSettingBotConnectionRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, data, cancellationToken);
                var operation = new BotServiceArmOperation<BotConnectionSettingResource>(Response.FromValue(new BotConnectionSettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Connection Setting registration for a Bot Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<BotConnectionSettingResource>> GetAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _botConnectionSettingBotConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BotConnectionSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Connection Setting registration for a Bot Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<BotConnectionSettingResource> Get(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.Get");
            scope.Start();
            try
            {
                var response = _botConnectionSettingBotConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BotConnectionSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns all the Connection Settings registered to a particular BotService resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_ListByBotService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BotConnectionSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BotConnectionSettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _botConnectionSettingBotConnectionRestClient.CreateListByBotServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _botConnectionSettingBotConnectionRestClient.CreateListByBotServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BotConnectionSettingResource(Client, BotConnectionSettingData.DeserializeBotConnectionSettingData(e)), _botConnectionSettingBotConnectionClientDiagnostics, Pipeline, "BotConnectionSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the Connection Settings registered to a particular BotService resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_ListByBotService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BotConnectionSettingResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BotConnectionSettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _botConnectionSettingBotConnectionRestClient.CreateListByBotServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _botConnectionSettingBotConnectionRestClient.CreateListByBotServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BotConnectionSettingResource(Client, BotConnectionSettingData.DeserializeBotConnectionSettingData(e)), _botConnectionSettingBotConnectionClientDiagnostics, Pipeline, "BotConnectionSettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _botConnectionSettingBotConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _botConnectionSettingBotConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<BotConnectionSettingResource>> GetIfExistsAsync(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _botConnectionSettingBotConnectionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BotConnectionSettingResource>(response.GetRawResponse());
                return Response.FromValue(new BotConnectionSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}/connections/{connectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BotConnectionSettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="connectionName"> The name of the Bot Service Connection Setting resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionName"/> is null. </exception>
        public virtual NullableResponse<BotConnectionSettingResource> GetIfExists(string connectionName, CancellationToken cancellationToken = default)
        {
            if (connectionName == null)
            {
                throw new ArgumentNullException(nameof(connectionName));
            }
            if (connectionName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(connectionName));
            }

            using var scope = _botConnectionSettingBotConnectionClientDiagnostics.CreateScope("BotConnectionSettingCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _botConnectionSettingBotConnectionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BotConnectionSettingResource>(response.GetRawResponse());
                return Response.FromValue(new BotConnectionSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BotConnectionSettingResource> IEnumerable<BotConnectionSettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BotConnectionSettingResource> IAsyncEnumerable<BotConnectionSettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
