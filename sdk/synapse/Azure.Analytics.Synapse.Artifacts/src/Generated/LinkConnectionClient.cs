// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The LinkConnection service client. </summary>
    public partial class LinkConnectionClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal LinkConnectionRestClient RestClient { get; }

        /// <summary> Initializes a new instance of LinkConnectionClient for mocking. </summary>
        protected LinkConnectionClient()
        {
        }

        /// <summary> Initializes a new instance of LinkConnectionClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public LinkConnectionClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new LinkConnectionRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of LinkConnectionClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example https://myworkspace.dev.azuresynapse.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal LinkConnectionClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new LinkConnectionRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates or updates a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="linkConnection"> Link connection resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkConnectionResource>> CreateOrUpdateAsync(string linkConnectionName, LinkConnectionResource linkConnection, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(linkConnectionName, linkConnection, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="linkConnection"> Link connection resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkConnectionResource> CreateOrUpdate(string linkConnectionName, LinkConnectionResource linkConnection, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(linkConnectionName, linkConnection, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkConnectionResource>> GetAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkConnectionResource> Get(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Edit tables for a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="editTablesRequest"> Edit tables request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EditTablesAsync(string linkConnectionName, EditTablesRequest editTablesRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.EditTables");
            scope.Start();
            try
            {
                return await RestClient.EditTablesAsync(linkConnectionName, editTablesRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Edit tables for a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="editTablesRequest"> Edit tables request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EditTables(string linkConnectionName, EditTablesRequest editTablesRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.EditTables");
            scope.Start();
            try
            {
                return RestClient.EditTables(linkConnectionName, editTablesRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Start a link connection. It may take a few minutes from Starting to Running, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Start");
            scope.Start();
            try
            {
                return await RestClient.StartAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Start a link connection. It may take a few minutes from Starting to Running, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Start(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Start");
            scope.Start();
            try
            {
                return RestClient.Start(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stop a link connection. It may take a few minutes from Stopping to stopped, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StopAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Stop");
            scope.Start();
            try
            {
                return await RestClient.StopAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stop a link connection. It may take a few minutes from Stopping to stopped, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Stop");
            scope.Start();
            try
            {
                return RestClient.Stop(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the detailed status of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkConnectionDetailedStatus>> GetDetailedStatusAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.GetDetailedStatus");
            scope.Start();
            try
            {
                return await RestClient.GetDetailedStatusAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the detailed status of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkConnectionDetailedStatus> GetDetailedStatus(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.GetDetailedStatus");
            scope.Start();
            try
            {
                return RestClient.GetDetailedStatus(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List the link tables of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkTableListResponse>> ListLinkTablesAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.ListLinkTables");
            scope.Start();
            try
            {
                return await RestClient.ListLinkTablesAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List the link tables of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkTableListResponse> ListLinkTables(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.ListLinkTables");
            scope.Start();
            try
            {
                return RestClient.ListLinkTables(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the link table status of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="queryTableStatusRequest"> Query table status request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<LinkConnectionQueryTableStatus>> QueryTableStatusAsync(string linkConnectionName, QueryTableStatusRequest queryTableStatusRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.QueryTableStatus");
            scope.Start();
            try
            {
                return await RestClient.QueryTableStatusAsync(linkConnectionName, queryTableStatusRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query the link table status of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="queryTableStatusRequest"> Query table status request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LinkConnectionQueryTableStatus> QueryTableStatus(string linkConnectionName, QueryTableStatusRequest queryTableStatusRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.QueryTableStatus");
            scope.Start();
            try
            {
                return RestClient.QueryTableStatus(linkConnectionName, queryTableStatusRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update landing zone credential of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="updateLandingZoneCredentialRequest"> update landing zone credential request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateLandingZoneCredentialAsync(string linkConnectionName, UpdateLandingZoneCredential updateLandingZoneCredentialRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.UpdateLandingZoneCredential");
            scope.Start();
            try
            {
                return await RestClient.UpdateLandingZoneCredentialAsync(linkConnectionName, updateLandingZoneCredentialRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update landing zone credential of a link connection. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="updateLandingZoneCredentialRequest"> update landing zone credential request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateLandingZoneCredential(string linkConnectionName, UpdateLandingZoneCredential updateLandingZoneCredentialRequest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.UpdateLandingZoneCredential");
            scope.Start();
            try
            {
                return RestClient.UpdateLandingZoneCredential(linkConnectionName, updateLandingZoneCredentialRequest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Pause a link connection. It may take a few minutes from Pausing to Paused, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> PauseAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Pause");
            scope.Start();
            try
            {
                return await RestClient.PauseAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Pause a link connection. It may take a few minutes from Pausing to Paused, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Pause(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Pause");
            scope.Start();
            try
            {
                return RestClient.Pause(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resume a link connection. It may take a few minutes from Resuming to Running, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> ResumeAsync(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Resume");
            scope.Start();
            try
            {
                return await RestClient.ResumeAsync(linkConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resume a link connection. It may take a few minutes from Resuming to Running, monitor the status with LinkConnection_GetDetailedStatus. </summary>
        /// <param name="linkConnectionName"> The link connection name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Resume(string linkConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("LinkConnectionClient.Resume");
            scope.Start();
            try
            {
                return RestClient.Resume(linkConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List link connections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<LinkConnectionResource> ListByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListByWorkspaceNextPageRequest(nextLink);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, LinkConnectionResource.DeserializeLinkConnectionResource, _clientDiagnostics, _pipeline, "LinkConnectionClient.ListByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> List link connections. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<LinkConnectionResource> ListByWorkspace(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListByWorkspaceNextPageRequest(nextLink);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, LinkConnectionResource.DeserializeLinkConnectionResource, _clientDiagnostics, _pipeline, "LinkConnectionClient.ListByWorkspace", "value", "nextLink", cancellationToken);
        }
    }
}
