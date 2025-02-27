// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _automationAccountClientDiagnostics;
        private AutomationAccountRestOperations _automationAccountRestClient;
        private ClientDiagnostics _deletedAutomationAccountsClientDiagnostics;
        private DeletedAutomationAccountsRestOperations _deletedAutomationAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AutomationAccountClientDiagnostics => _automationAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automation", AutomationAccountResource.ResourceType.Namespace, Diagnostics);
        private AutomationAccountRestOperations AutomationAccountRestClient => _automationAccountRestClient ??= new AutomationAccountRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(AutomationAccountResource.ResourceType));
        private ClientDiagnostics deletedAutomationAccountsClientDiagnostics => _deletedAutomationAccountsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Automation", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DeletedAutomationAccountsRestOperations deletedAutomationAccountsRestClient => _deletedAutomationAccountsRestClient ??= new DeletedAutomationAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/automationAccounts
        /// Operation Id: AutomationAccount_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomationAccountResource> GetAutomationAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutomationAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AutomationAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountResource(Client, AutomationAccountData.DeserializeAutomationAccountData(e)), AutomationAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAutomationAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/automationAccounts
        /// Operation Id: AutomationAccount_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomationAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomationAccountResource> GetAutomationAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => AutomationAccountRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => AutomationAccountRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AutomationAccountResource(Client, AutomationAccountData.DeserializeAutomationAccountData(e)), AutomationAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetAutomationAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve deleted automation account.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/deletedAutomationAccounts
        /// Operation Id: deletedAutomationAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeletedAutomationAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DeletedAutomationAccount> GetDeletedAutomationAccountsBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => deletedAutomationAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, DeletedAutomationAccount.DeserializeDeletedAutomationAccount, deletedAutomationAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedAutomationAccountsBySubscription", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve deleted automation account.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Automation/deletedAutomationAccounts
        /// Operation Id: deletedAutomationAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeletedAutomationAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DeletedAutomationAccount> GetDeletedAutomationAccountsBySubscription(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => deletedAutomationAccountsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, DeletedAutomationAccount.DeserializeDeletedAutomationAccount, deletedAutomationAccountsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedAutomationAccountsBySubscription", "value", null, cancellationToken);
        }
    }
}
