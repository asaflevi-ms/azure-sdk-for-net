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

namespace Azure.ResourceManager.ApplicationInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="WebTestResource"/> and their operations.
    /// Each <see cref="WebTestResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="WebTestCollection"/> instance call the GetWebTests method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class WebTestCollection : ArmCollection, IEnumerable<WebTestResource>, IAsyncEnumerable<WebTestResource>
    {
        private readonly ClientDiagnostics _webTestClientDiagnostics;
        private readonly WebTestsRestOperations _webTestRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebTestCollection"/> class for mocking. </summary>
        protected WebTestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebTestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebTestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webTestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApplicationInsights", WebTestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebTestResource.ResourceType, out string webTestApiVersion);
            _webTestRestClient = new WebTestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webTestApiVersion);
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
        /// Creates or updates an Application Insights web test definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="data"> Properties that need to be specified to create or update an Application Insights web test definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WebTestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string webTestName, WebTestData data, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webTestRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, webTestName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ApplicationInsightsArmOperation<WebTestResource>(Response.FromValue(new WebTestResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an Application Insights web test definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="data"> Properties that need to be specified to create or update an Application Insights web test definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WebTestResource> CreateOrUpdate(WaitUntil waitUntil, string webTestName, WebTestData data, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webTestRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, webTestName, data, cancellationToken);
                var operation = new ApplicationInsightsArmOperation<WebTestResource>(Response.FromValue(new WebTestResource(Client, response), response.GetRawResponse()));
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
        /// Get a specific Application Insights web test definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        public virtual async Task<Response<WebTestResource>> GetAsync(string webTestName, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.Get");
            scope.Start();
            try
            {
                var response = await _webTestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, webTestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebTestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a specific Application Insights web test definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        public virtual Response<WebTestResource> Get(string webTestName, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.Get");
            scope.Start();
            try
            {
                var response = _webTestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, webTestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebTestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all Application Insights web tests defined for the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebTestResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebTestResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webTestRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webTestRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WebTestResource(Client, WebTestData.DeserializeWebTestData(e)), _webTestClientDiagnostics, Pipeline, "WebTestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all Application Insights web tests defined for the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_ListByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebTestResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebTestResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webTestRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webTestRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WebTestResource(Client, WebTestData.DeserializeWebTestData(e)), _webTestClientDiagnostics, Pipeline, "WebTestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string webTestName, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webTestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, webTestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        public virtual Response<bool> Exists(string webTestName, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.Exists");
            scope.Start();
            try
            {
                var response = _webTestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, webTestName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        public virtual async Task<NullableResponse<WebTestResource>> GetIfExistsAsync(string webTestName, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webTestRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, webTestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<WebTestResource>(response.GetRawResponse());
                return Response.FromValue(new WebTestResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/webtests/{webTestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebTests_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-06-15</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="WebTestResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="webTestName"> The name of the Application Insights WebTest resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="webTestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="webTestName"/> is null. </exception>
        public virtual NullableResponse<WebTestResource> GetIfExists(string webTestName, CancellationToken cancellationToken = default)
        {
            if (webTestName == null)
            {
                throw new ArgumentNullException(nameof(webTestName));
            }
            if (webTestName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(webTestName));
            }

            using var scope = _webTestClientDiagnostics.CreateScope("WebTestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webTestRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, webTestName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<WebTestResource>(response.GetRawResponse());
                return Response.FromValue(new WebTestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebTestResource> IEnumerable<WebTestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebTestResource> IAsyncEnumerable<WebTestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
