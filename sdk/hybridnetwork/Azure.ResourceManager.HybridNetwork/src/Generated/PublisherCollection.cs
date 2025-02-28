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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="PublisherResource"/> and their operations.
    /// Each <see cref="PublisherResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="PublisherCollection"/> instance call the GetPublishers method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class PublisherCollection : ArmCollection, IEnumerable<PublisherResource>, IAsyncEnumerable<PublisherResource>
    {
        private readonly ClientDiagnostics _publisherClientDiagnostics;
        private readonly PublishersRestOperations _publisherRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublisherCollection"/> class for mocking. </summary>
        protected PublisherCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublisherCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublisherCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publisherClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridNetwork", PublisherResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublisherResource.ResourceType, out string publisherApiVersion);
            _publisherRestClient = new PublishersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publisherApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a publisher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="data"> Parameters supplied to the create publisher operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PublisherResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string publisherName, PublisherData data, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, publisherName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridNetworkArmOperation<PublisherResource>(new PublisherOperationSource(Client), _publisherClientDiagnostics, Pipeline, _publisherRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publisherName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a publisher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="data"> Parameters supplied to the create publisher operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PublisherResource> CreateOrUpdate(WaitUntil waitUntil, string publisherName, PublisherData data, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _publisherRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, publisherName, data, cancellationToken);
                var operation = new HybridNetworkArmOperation<PublisherResource>(new PublisherOperationSource(Client), _publisherClientDiagnostics, Pipeline, _publisherRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, publisherName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets information about the specified publisher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<Response<PublisherResource>> GetAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Get");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publisherName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified publisher.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual Response<PublisherResource> Get(string publisherName, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Get");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publisherName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the publishers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PublisherResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PublisherResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the publishers in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PublisherResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PublisherResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _publisherRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _publisherRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PublisherResource(Client, PublisherData.DeserializePublisherData(e)), _publisherClientDiagnostics, Pipeline, "PublisherCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual Response<bool> Exists(string publisherName, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.Exists");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publisherName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual async Task<NullableResponse<PublisherResource>> GetIfExistsAsync(string publisherName, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _publisherRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, publisherName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PublisherResource>(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridNetwork/publishers/{publisherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Publishers_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PublisherResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="publisherName"> The name of the publisher. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="publisherName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="publisherName"/> is null. </exception>
        public virtual NullableResponse<PublisherResource> GetIfExists(string publisherName, CancellationToken cancellationToken = default)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }
            if (publisherName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(publisherName));
            }

            using var scope = _publisherClientDiagnostics.CreateScope("PublisherCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publisherRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, publisherName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PublisherResource>(response.GetRawResponse());
                return Response.FromValue(new PublisherResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PublisherResource> IEnumerable<PublisherResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PublisherResource> IAsyncEnumerable<PublisherResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
