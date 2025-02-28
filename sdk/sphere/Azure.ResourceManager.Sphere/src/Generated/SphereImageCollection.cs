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

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing a collection of <see cref="SphereImageResource"/> and their operations.
    /// Each <see cref="SphereImageResource"/> in the collection will belong to the same instance of <see cref="SphereCatalogResource"/>.
    /// To get a <see cref="SphereImageCollection"/> instance call the GetSphereImages method from an instance of <see cref="SphereCatalogResource"/>.
    /// </summary>
    public partial class SphereImageCollection : ArmCollection, IEnumerable<SphereImageResource>, IAsyncEnumerable<SphereImageResource>
    {
        private readonly ClientDiagnostics _sphereImageImagesClientDiagnostics;
        private readonly ImagesRestOperations _sphereImageImagesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SphereImageCollection"/> class for mocking. </summary>
        protected SphereImageCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SphereImageCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SphereImageCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sphereImageImagesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sphere", SphereImageResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SphereImageResource.ResourceType, out string sphereImageImagesApiVersion);
            _sphereImageImagesRestClient = new ImagesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sphereImageImagesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SphereCatalogResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SphereCatalogResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SphereImageResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string imageName, SphereImageData data, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sphereImageImagesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SphereArmOperation<SphereImageResource>(new SphereImageOperationSource(Client), _sphereImageImagesClientDiagnostics, Pipeline, _sphereImageImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SphereImageResource> CreateOrUpdate(WaitUntil waitUntil, string imageName, SphereImageData data, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sphereImageImagesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, data, cancellationToken);
                var operation = new SphereArmOperation<SphereImageResource>(new SphereImageOperationSource(Client), _sphereImageImagesClientDiagnostics, Pipeline, _sphereImageImagesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get a Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<SphereImageResource>> GetAsync(string imageName, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.Get");
            scope.Start();
            try
            {
                var response = await _sphereImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Image
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<SphereImageResource> Get(string imageName, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.Get");
            scope.Start();
            try
            {
                var response = _sphereImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SphereImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Image resources by Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_ListByCatalog</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SphereImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SphereImageResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereImageImagesRestClient.CreateListByCatalogRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereImageImagesRestClient.CreateListByCatalogNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SphereImageResource(Client, SphereImageData.DeserializeSphereImageData(e)), _sphereImageImagesClientDiagnostics, Pipeline, "SphereImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Image resources by Catalog
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_ListByCatalog</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filter the result list using the given expression. </param>
        /// <param name="top"> The number of result items to return. </param>
        /// <param name="skip"> The number of result items to skip. </param>
        /// <param name="maxpagesize"> The maximum number of result items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SphereImageResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SphereImageResource> GetAll(string filter = null, int? top = null, int? skip = null, int? maxpagesize = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sphereImageImagesRestClient.CreateListByCatalogRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sphereImageImagesRestClient.CreateListByCatalogNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip, pageSizeHint);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SphereImageResource(Client, SphereImageData.DeserializeSphereImageData(e)), _sphereImageImagesClientDiagnostics, Pipeline, "SphereImageCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string imageName, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sphereImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual Response<bool> Exists(string imageName, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.Exists");
            scope.Start();
            try
            {
                var response = _sphereImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual async Task<NullableResponse<SphereImageResource>> GetIfExistsAsync(string imageName, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sphereImageImagesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SphereImageResource>(response.GetRawResponse());
                return Response.FromValue(new SphereImageResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AzureSphere/catalogs/{catalogName}/images/{imageName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Images_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SphereImageResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="imageName"> Image name. Use .default for image creation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public virtual NullableResponse<SphereImageResource> GetIfExists(string imageName, CancellationToken cancellationToken = default)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (imageName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(imageName));
            }

            using var scope = _sphereImageImagesClientDiagnostics.CreateScope("SphereImageCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sphereImageImagesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, imageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SphereImageResource>(response.GetRawResponse());
                return Response.FromValue(new SphereImageResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SphereImageResource> IEnumerable<SphereImageResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SphereImageResource> IAsyncEnumerable<SphereImageResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
