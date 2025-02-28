// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecurityCenterPricing along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecurityCenterPricingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecurityCenterPricingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSecurityCenterPricing method.
    /// </summary>
    public partial class SecurityCenterPricingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityCenterPricingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="pricingName"> The pricingName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string pricingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityCenterPricingPricingsClientDiagnostics;
        private readonly PricingsRestOperations _securityCenterPricingPricingsRestClient;
        private readonly SecurityCenterPricingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/pricings";

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterPricingResource"/> class for mocking. </summary>
        protected SecurityCenterPricingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterPricingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityCenterPricingResource(ArmClient client, SecurityCenterPricingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityCenterPricingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityCenterPricingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityCenterPricingPricingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityCenterPricingPricingsApiVersion);
            _securityCenterPricingPricingsRestClient = new PricingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityCenterPricingPricingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityCenterPricingData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SecurityOperatorResources in the SecurityCenterPricing. </summary>
        /// <returns> An object representing collection of SecurityOperatorResources and their operations over a SecurityOperatorResource. </returns>
        public virtual SecurityOperatorCollection GetSecurityOperators()
        {
            return GetCachedClient(client => new SecurityOperatorCollection(client, Id));
        }

        /// <summary>
        /// Get a specific security operator for the requested scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}/securityOperators/{securityOperatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityOperators_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityOperatorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityOperatorName"> name of the securityOperator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityOperatorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="securityOperatorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SecurityOperatorResource>> GetSecurityOperatorAsync(string securityOperatorName, CancellationToken cancellationToken = default)
        {
            return await GetSecurityOperators().GetAsync(securityOperatorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a specific security operator for the requested scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}/securityOperators/{securityOperatorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SecurityOperators_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityOperatorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityOperatorName"> name of the securityOperator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="securityOperatorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="securityOperatorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SecurityOperatorResource> GetSecurityOperator(string securityOperatorName, CancellationToken cancellationToken = default)
        {
            return GetSecurityOperators().Get(securityOperatorName, cancellationToken);
        }

        /// <summary>
        /// Gets a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityCenterPricingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityCenterPricingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingResource.Get");
            scope.Start();
            try
            {
                var response = await _securityCenterPricingPricingsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterPricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityCenterPricingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityCenterPricingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingResource.Get");
            scope.Start();
            try
            {
                var response = _securityCenterPricingPricingsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityCenterPricingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityCenterPricingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Pricing object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityCenterPricingResource>> UpdateAsync(WaitUntil waitUntil, SecurityCenterPricingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingResource.Update");
            scope.Start();
            try
            {
                var response = await _securityCenterPricingPricingsRestClient.UpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecurityCenterPricingResource>(Response.FromValue(new SecurityCenterPricingResource(Client, response), response.GetRawResponse()));
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
        /// Updates a provided Microsoft Defender for Cloud pricing configuration in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/pricings/{pricingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Pricings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityCenterPricingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Pricing object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityCenterPricingResource> Update(WaitUntil waitUntil, SecurityCenterPricingData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _securityCenterPricingPricingsClientDiagnostics.CreateScope("SecurityCenterPricingResource.Update");
            scope.Start();
            try
            {
                var response = _securityCenterPricingPricingsRestClient.Update(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecurityCenterPricingResource>(Response.FromValue(new SecurityCenterPricingResource(Client, response), response.GetRawResponse()));
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
    }
}
