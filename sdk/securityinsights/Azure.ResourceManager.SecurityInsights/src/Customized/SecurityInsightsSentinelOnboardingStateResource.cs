// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

[assembly: CodeGenSuppressType("SecurityInsightsSentinelOnboardingStateResource")]
namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A Class representing a SecurityInsightsSentinelOnboardingState along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SecurityInsightsSentinelOnboardingStateResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSecurityInsightsSentinelOnboardingStateResource method.
    /// Otherwise you can get one from its parent resource <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" /> using the GetSecurityInsightsSentinelOnboardingState method.
    /// </summary>
    public partial class SecurityInsightsSentinelOnboardingStateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecurityInsightsSentinelOnboardingStateResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sentinelOnboardingStateName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics;
        private readonly SentinelOnboardingStatesRestOperations _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient;
        private readonly SecurityInsightsSentinelOnboardingStateData _data;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsSentinelOnboardingStateResource"/> class for mocking. </summary>
        protected SecurityInsightsSentinelOnboardingStateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SecurityInsightsSentinelOnboardingStateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecurityInsightsSentinelOnboardingStateResource(ArmClient client, SecurityInsightsSentinelOnboardingStateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsSentinelOnboardingStateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecurityInsightsSentinelOnboardingStateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securityInsightsSentinelOnboardingStateSentinelOnboardingStatesApiVersion);
            _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient = new SentinelOnboardingStatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsSentinelOnboardingStateSentinelOnboardingStatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SecurityInsights/onboardingStates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecurityInsightsSentinelOnboardingStateData Data
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
        /// Get Sentinel onboarding state
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}
        /// Operation Id: SentinelOnboardingStates_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecurityInsightsSentinelOnboardingStateResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateResource.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sentinel onboarding state
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}
        /// Operation Id: SentinelOnboardingStates_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecurityInsightsSentinelOnboardingStateResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateResource.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Sentinel onboarding state
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}
        /// Operation Id: SentinelOnboardingStates_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateResource.Delete");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete Sentinel onboarding state
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}
        /// Operation Id: SentinelOnboardingStates_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateResource.Delete");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new SecurityInsightsArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create Sentinel onboarding state
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}
        /// Operation Id: SentinelOnboardingStates_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Sentinel onboarding state parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsSentinelOnboardingStateResource>> UpdateAsync(WaitUntil waitUntil, SecurityInsightsSentinelOnboardingStateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateResource.Update");
            scope.Start();
            try
            {
                var response = await _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsSentinelOnboardingStateResource>(Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response), response.GetRawResponse()));
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
        /// Create Sentinel onboarding state
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/onboardingStates/{sentinelOnboardingStateName}
        /// Operation Id: SentinelOnboardingStates_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The Sentinel onboarding state parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsSentinelOnboardingStateResource> Update(WaitUntil waitUntil, SecurityInsightsSentinelOnboardingStateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesClientDiagnostics.CreateScope("SecurityInsightsSentinelOnboardingStateResource.Update");
            scope.Start();
            try
            {
                var response = _securityInsightsSentinelOnboardingStateSentinelOnboardingStatesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new SecurityInsightsArmOperation<SecurityInsightsSentinelOnboardingStateResource>(Response.FromValue(new SecurityInsightsSentinelOnboardingStateResource(Client, response), response.GetRawResponse()));
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
