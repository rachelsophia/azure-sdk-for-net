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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="MediaServicesAccountResource" /> and their operations.
    /// Each <see cref="MediaServicesAccountResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="MediaServicesAccountCollection" /> instance call the GetMediaServicesAccounts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class MediaServicesAccountCollection : ArmCollection, IEnumerable<MediaServicesAccountResource>, IAsyncEnumerable<MediaServicesAccountResource>
    {
        private readonly ClientDiagnostics _mediaServicesAccountMediaservicesClientDiagnostics;
        private readonly MediaservicesRestOperations _mediaServicesAccountMediaservicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MediaServicesAccountCollection"/> class for mocking. </summary>
        protected MediaServicesAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MediaServicesAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MediaServicesAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mediaServicesAccountMediaservicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", MediaServicesAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MediaServicesAccountResource.ResourceType, out string mediaServicesAccountMediaservicesApiVersion);
            _mediaServicesAccountMediaservicesRestClient = new MediaservicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mediaServicesAccountMediaservicesApiVersion);
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
        /// Creates or updates a Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MediaServicesAccountResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string accountName, MediaServicesAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaServicesAccountMediaservicesClientDiagnostics.CreateScope("MediaServicesAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mediaServicesAccountMediaservicesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<MediaServicesAccountResource>(new MediaServicesAccountOperationSource(Client), _mediaServicesAccountMediaservicesClientDiagnostics, Pipeline, _mediaServicesAccountMediaservicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MediaServicesAccountResource> CreateOrUpdate(WaitUntil waitUntil, string accountName, MediaServicesAccountData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _mediaServicesAccountMediaservicesClientDiagnostics.CreateScope("MediaServicesAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mediaServicesAccountMediaservicesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, accountName, data, cancellationToken);
                var operation = new MediaArmOperation<MediaServicesAccountResource>(new MediaServicesAccountOperationSource(Client), _mediaServicesAccountMediaservicesClientDiagnostics, Pipeline, _mediaServicesAccountMediaservicesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, accountName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get the details of a Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_Get
        /// </summary>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<MediaServicesAccountResource>> GetAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _mediaServicesAccountMediaservicesClientDiagnostics.CreateScope("MediaServicesAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _mediaServicesAccountMediaservicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaServicesAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Media Services account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_Get
        /// </summary>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<MediaServicesAccountResource> Get(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _mediaServicesAccountMediaservicesClientDiagnostics.CreateScope("MediaServicesAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _mediaServicesAccountMediaservicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MediaServicesAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Media Services accounts in the resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices
        /// Operation Id: Mediaservices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MediaServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MediaServicesAccountResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaServicesAccountMediaservicesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaServicesAccountMediaservicesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MediaServicesAccountResource(Client, MediaServicesAccountData.DeserializeMediaServicesAccountData(e)), _mediaServicesAccountMediaservicesClientDiagnostics, Pipeline, "MediaServicesAccountCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// List Media Services accounts in the resource group
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices
        /// Operation Id: Mediaservices_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MediaServicesAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MediaServicesAccountResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _mediaServicesAccountMediaservicesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _mediaServicesAccountMediaservicesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MediaServicesAccountResource(Client, MediaServicesAccountData.DeserializeMediaServicesAccountData(e)), _mediaServicesAccountMediaservicesClientDiagnostics, Pipeline, "MediaServicesAccountCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_Get
        /// </summary>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _mediaServicesAccountMediaservicesClientDiagnostics.CreateScope("MediaServicesAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _mediaServicesAccountMediaservicesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaservices/{accountName}
        /// Operation Id: Mediaservices_Get
        /// </summary>
        /// <param name="accountName"> The Media Services account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _mediaServicesAccountMediaservicesClientDiagnostics.CreateScope("MediaServicesAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _mediaServicesAccountMediaservicesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, accountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MediaServicesAccountResource> IEnumerable<MediaServicesAccountResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MediaServicesAccountResource> IAsyncEnumerable<MediaServicesAccountResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
