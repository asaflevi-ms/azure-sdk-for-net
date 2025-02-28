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

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SupportTicketCommunication along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SupportTicketCommunicationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSupportTicketCommunicationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionSupportTicketResource"/> using the GetSupportTicketCommunication method.
    /// </summary>
    public partial class SupportTicketCommunicationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportTicketCommunicationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="supportTicketName"> The supportTicketName. </param>
        /// <param name="communicationName"> The communicationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string supportTicketName, string communicationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supportTicketCommunicationCommunicationsClientDiagnostics;
        private readonly CommunicationsRestOperations _supportTicketCommunicationCommunicationsRestClient;
        private readonly SupportTicketCommunicationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/supportTickets/communications";

        /// <summary> Initializes a new instance of the <see cref="SupportTicketCommunicationResource"/> class for mocking. </summary>
        protected SupportTicketCommunicationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketCommunicationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportTicketCommunicationResource(ArmClient client, SupportTicketCommunicationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketCommunicationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportTicketCommunicationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketCommunicationCommunicationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supportTicketCommunicationCommunicationsApiVersion);
            _supportTicketCommunicationCommunicationsRestClient = new CommunicationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketCommunicationCommunicationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportTicketCommunicationData Data
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

        /// <summary>
        /// Returns communication details for a support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportTicketCommunicationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationResource.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketCommunicationCommunicationsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketCommunicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns communication details for a support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportTicketCommunicationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationResource.Get");
            scope.Start();
            try
            {
                var response = _supportTicketCommunicationCommunicationsRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketCommunicationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Adds a new customer communication to an Azure support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Communication object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SupportTicketCommunicationResource>> UpdateAsync(WaitUntil waitUntil, SupportTicketCommunicationData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationResource.Update");
            scope.Start();
            try
            {
                var response = await _supportTicketCommunicationCommunicationsRestClient.CreateAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SupportArmOperation<SupportTicketCommunicationResource>(new SupportTicketCommunicationOperationSource(Client), _supportTicketCommunicationCommunicationsClientDiagnostics, Pipeline, _supportTicketCommunicationCommunicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Adds a new customer communication to an Azure support ticket.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/communications/{communicationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Communications_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketCommunicationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Communication object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SupportTicketCommunicationResource> Update(WaitUntil waitUntil, SupportTicketCommunicationData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _supportTicketCommunicationCommunicationsClientDiagnostics.CreateScope("SupportTicketCommunicationResource.Update");
            scope.Start();
            try
            {
                var response = _supportTicketCommunicationCommunicationsRestClient.Create(Id.SubscriptionId, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SupportArmOperation<SupportTicketCommunicationResource>(new SupportTicketCommunicationOperationSource(Client), _supportTicketCommunicationCommunicationsClientDiagnostics, Pipeline, _supportTicketCommunicationCommunicationsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
