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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing a collection of <see cref="RecoveryPlanResource" /> and their operations.
    /// Each <see cref="RecoveryPlanResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RecoveryPlanCollection" /> instance call the GetRecoveryPlans method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RecoveryPlanCollection : ArmCollection, IEnumerable<RecoveryPlanResource>, IAsyncEnumerable<RecoveryPlanResource>
    {
        private readonly ClientDiagnostics _recoveryPlanReplicationRecoveryPlansClientDiagnostics;
        private readonly ReplicationRecoveryPlansRestOperations _recoveryPlanReplicationRecoveryPlansRestClient;
        private readonly string _resourceName;

        /// <summary> Initializes a new instance of the <see cref="RecoveryPlanCollection"/> class for mocking. </summary>
        protected RecoveryPlanCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RecoveryPlanCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="resourceName"> The name of the recovery services vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        internal RecoveryPlanCollection(ArmClient client, ResourceIdentifier id, string resourceName) : base(client, id)
        {
            _resourceName = resourceName;
            _recoveryPlanReplicationRecoveryPlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesSiteRecovery", RecoveryPlanResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RecoveryPlanResource.ResourceType, out string recoveryPlanReplicationRecoveryPlansApiVersion);
            _recoveryPlanReplicationRecoveryPlansRestClient = new ReplicationRecoveryPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, recoveryPlanReplicationRecoveryPlansApiVersion);
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
        /// The operation to create a recovery plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}
        /// Operation Id: ReplicationRecoveryPlans_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="recoveryPlanName"> Recovery plan name. </param>
        /// <param name="content"> Recovery Plan creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RecoveryPlanResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string recoveryPlanName, RecoveryPlanCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _recoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("RecoveryPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _recoveryPlanReplicationRecoveryPlansRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<RecoveryPlanResource>(new RecoveryPlanOperationSource(Client), _recoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, _recoveryPlanReplicationRecoveryPlansRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create a recovery plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}
        /// Operation Id: ReplicationRecoveryPlans_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="recoveryPlanName"> Recovery plan name. </param>
        /// <param name="content"> Recovery Plan creation input. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RecoveryPlanResource> CreateOrUpdate(WaitUntil waitUntil, string recoveryPlanName, RecoveryPlanCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _recoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("RecoveryPlanCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _recoveryPlanReplicationRecoveryPlansRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content, cancellationToken);
                var operation = new RecoveryServicesSiteRecoveryArmOperation<RecoveryPlanResource>(new RecoveryPlanOperationSource(Client), _recoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, _recoveryPlanReplicationRecoveryPlansRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the details of the recovery plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}
        /// Operation Id: ReplicationRecoveryPlans_Get
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual async Task<Response<RecoveryPlanResource>> GetAsync(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _recoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("RecoveryPlanCollection.Get");
            scope.Start();
            try
            {
                var response = await _recoveryPlanReplicationRecoveryPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoveryPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the recovery plan.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}
        /// Operation Id: ReplicationRecoveryPlans_Get
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual Response<RecoveryPlanResource> Get(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _recoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("RecoveryPlanCollection.Get");
            scope.Start();
            try
            {
                var response = _recoveryPlanReplicationRecoveryPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RecoveryPlanResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the recovery plans in the vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans
        /// Operation Id: ReplicationRecoveryPlans_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RecoveryPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RecoveryPlanResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoveryPlanReplicationRecoveryPlansRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoveryPlanReplicationRecoveryPlansRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RecoveryPlanResource(Client, RecoveryPlanData.DeserializeRecoveryPlanData(e)), _recoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, "RecoveryPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the recovery plans in the vault.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans
        /// Operation Id: ReplicationRecoveryPlans_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RecoveryPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RecoveryPlanResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _recoveryPlanReplicationRecoveryPlansRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _recoveryPlanReplicationRecoveryPlansRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, _resourceName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RecoveryPlanResource(Client, RecoveryPlanData.DeserializeRecoveryPlanData(e)), _recoveryPlanReplicationRecoveryPlansClientDiagnostics, Pipeline, "RecoveryPlanCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}
        /// Operation Id: ReplicationRecoveryPlans_Get
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _recoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("RecoveryPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = await _recoveryPlanReplicationRecoveryPlansRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{resourceName}/replicationRecoveryPlans/{recoveryPlanName}
        /// Operation Id: ReplicationRecoveryPlans_Get
        /// </summary>
        /// <param name="recoveryPlanName"> Name of the recovery plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="recoveryPlanName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="recoveryPlanName"/> is null. </exception>
        public virtual Response<bool> Exists(string recoveryPlanName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(recoveryPlanName, nameof(recoveryPlanName));

            using var scope = _recoveryPlanReplicationRecoveryPlansClientDiagnostics.CreateScope("RecoveryPlanCollection.Exists");
            scope.Start();
            try
            {
                var response = _recoveryPlanReplicationRecoveryPlansRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, _resourceName, recoveryPlanName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RecoveryPlanResource> IEnumerable<RecoveryPlanResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RecoveryPlanResource> IAsyncEnumerable<RecoveryPlanResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
