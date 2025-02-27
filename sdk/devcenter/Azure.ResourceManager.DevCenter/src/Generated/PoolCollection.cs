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

namespace Azure.ResourceManager.DevCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="PoolResource" /> and their operations.
    /// Each <see cref="PoolResource" /> in the collection will belong to the same instance of <see cref="ProjectResource" />.
    /// To get a <see cref="PoolCollection" /> instance call the GetPools method from an instance of <see cref="ProjectResource" />.
    /// </summary>
    public partial class PoolCollection : ArmCollection, IEnumerable<PoolResource>, IAsyncEnumerable<PoolResource>
    {
        private readonly ClientDiagnostics _poolClientDiagnostics;
        private readonly PoolsRestOperations _poolRestClient;

        /// <summary> Initializes a new instance of the <see cref="PoolCollection"/> class for mocking. </summary>
        protected PoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _poolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DevCenter", PoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PoolResource.ResourceType, out string poolApiVersion);
            _poolRestClient = new PoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, poolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProjectResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProjectResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a machine pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}
        /// Operation Id: Pools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="data"> Represents a machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string poolName, PoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _poolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DevCenterArmOperation<PoolResource>(new PoolOperationSource(Client), _poolClientDiagnostics, Pipeline, _poolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a machine pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}
        /// Operation Id: Pools_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="data"> Represents a machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PoolResource> CreateOrUpdate(WaitUntil waitUntil, string poolName, PoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _poolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data, cancellationToken);
                var operation = new DevCenterArmOperation<PoolResource>(new PoolOperationSource(Client), _poolClientDiagnostics, Pipeline, _poolRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a machine pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}
        /// Operation Id: Pools_Get
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<PoolResource>> GetAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _poolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a machine pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}
        /// Operation Id: Pools_Get
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<PoolResource> Get(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Get");
            scope.Start();
            try
            {
                var response = _poolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists pools for a project
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools
        /// Operation Id: Pools_ListByProject
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PoolResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _poolRestClient.CreateListByProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _poolRestClient.CreateListByProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PoolResource(Client, PoolData.DeserializePoolData(e)), _poolClientDiagnostics, Pipeline, "PoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists pools for a project
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools
        /// Operation Id: Pools_ListByProject
        /// </summary>
        /// <param name="top"> The maximum number of resources to return from the operation. Example: &apos;$top=10&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PoolResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _poolRestClient.CreateListByProjectRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _poolRestClient.CreateListByProjectNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PoolResource(Client, PoolData.DeserializePoolData(e)), _poolClientDiagnostics, Pipeline, "PoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}
        /// Operation Id: Pools_Get
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _poolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DevCenter/projects/{projectName}/pools/{poolName}
        /// Operation Id: Pools_Get
        /// </summary>
        /// <param name="poolName"> Name of the pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="poolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="poolName"/> is null. </exception>
        public virtual Response<bool> Exists(string poolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(poolName, nameof(poolName));

            using var scope = _poolClientDiagnostics.CreateScope("PoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _poolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, poolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PoolResource> IEnumerable<PoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PoolResource> IAsyncEnumerable<PoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
