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

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlVirtualNetworkRuleResource" /> and their operations.
    /// Each <see cref="PostgreSqlVirtualNetworkRuleResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlServerResource" />.
    /// To get a <see cref="PostgreSqlVirtualNetworkRuleCollection" /> instance call the GetPostgreSqlVirtualNetworkRules method from an instance of <see cref="PostgreSqlServerResource" />.
    /// </summary>
    public partial class PostgreSqlVirtualNetworkRuleCollection : ArmCollection, IEnumerable<PostgreSqlVirtualNetworkRuleResource>, IAsyncEnumerable<PostgreSqlVirtualNetworkRuleResource>
    {
        private readonly ClientDiagnostics _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics;
        private readonly VirtualNetworkRulesRestOperations _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlVirtualNetworkRuleCollection"/> class for mocking. </summary>
        protected PostgreSqlVirtualNetworkRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlVirtualNetworkRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlVirtualNetworkRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", PostgreSqlVirtualNetworkRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlVirtualNetworkRuleResource.ResourceType, out string postgreSqlVirtualNetworkRuleVirtualNetworkRulesApiVersion);
            _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient = new VirtualNetworkRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlVirtualNetworkRuleVirtualNetworkRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an existing virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="data"> The requested virtual Network Rule Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlVirtualNetworkRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkRuleName, PostgreSqlVirtualNetworkRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("PostgreSqlVirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<PostgreSqlVirtualNetworkRuleResource>(new PostgreSqlVirtualNetworkRuleOperationSource(Client), _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an existing virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="data"> The requested virtual Network Rule Resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlVirtualNetworkRuleResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkRuleName, PostgreSqlVirtualNetworkRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("PostgreSqlVirtualNetworkRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data, cancellationToken);
                var operation = new PostgreSqlArmOperation<PostgreSqlVirtualNetworkRuleResource>(new PostgreSqlVirtualNetworkRuleOperationSource(Client), _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<PostgreSqlVirtualNetworkRuleResource>> GetAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("PostgreSqlVirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlVirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a virtual network rule.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<PostgreSqlVirtualNetworkRuleResource> Get(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("PostgreSqlVirtualNetworkRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlVirtualNetworkRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of virtual network rules in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules
        /// Operation Id: VirtualNetworkRules_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlVirtualNetworkRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlVirtualNetworkRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlVirtualNetworkRuleResource(Client, PostgreSqlVirtualNetworkRuleData.DeserializePostgreSqlVirtualNetworkRuleData(e)), _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, "PostgreSqlVirtualNetworkRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of virtual network rules in a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules
        /// Operation Id: VirtualNetworkRules_ListByServer
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlVirtualNetworkRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlVirtualNetworkRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlVirtualNetworkRuleResource(Client, PostgreSqlVirtualNetworkRuleData.DeserializePostgreSqlVirtualNetworkRuleData(e)), _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics, Pipeline, "PostgreSqlVirtualNetworkRuleCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("PostgreSqlVirtualNetworkRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/virtualNetworkRules/{virtualNetworkRuleName}
        /// Operation Id: VirtualNetworkRules_Get
        /// </summary>
        /// <param name="virtualNetworkRuleName"> The name of the virtual network rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkRuleName, nameof(virtualNetworkRuleName));

            using var scope = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesClientDiagnostics.CreateScope("PostgreSqlVirtualNetworkRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlVirtualNetworkRuleVirtualNetworkRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, virtualNetworkRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlVirtualNetworkRuleResource> IEnumerable<PostgreSqlVirtualNetworkRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlVirtualNetworkRuleResource> IAsyncEnumerable<PostgreSqlVirtualNetworkRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
