// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the NetworkFeature data model. </summary>
    public partial class NetworkFeatureData : ResourceData
    {
        /// <summary> Initializes a new instance of NetworkFeatureData. </summary>
        public NetworkFeatureData()
        {
            HybridConnections = new ChangeTrackingList<RelayServiceConnectionEntityData>();
            HybridConnectionsV2 = new ChangeTrackingList<HybridConnectionData>();
        }

        /// <summary> Initializes a new instance of NetworkFeatureData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualNetworkName"> The Virtual Network name. </param>
        /// <param name="virtualNetworkConnection"> The Virtual Network summary view. </param>
        /// <param name="hybridConnections"> The Hybrid Connections summary view. </param>
        /// <param name="hybridConnectionsV2"> The Hybrid Connection V2 (Service Bus) view. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal NetworkFeatureData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string virtualNetworkName, AppServiceVirtualNetworkProperties virtualNetworkConnection, IReadOnlyList<RelayServiceConnectionEntityData> hybridConnections, IReadOnlyList<HybridConnectionData> hybridConnectionsV2, string kind) : base(id, name, resourceType, systemData)
        {
            VirtualNetworkName = virtualNetworkName;
            VirtualNetworkConnection = virtualNetworkConnection;
            HybridConnections = hybridConnections;
            HybridConnectionsV2 = hybridConnectionsV2;
            Kind = kind;
        }

        /// <summary> The Virtual Network name. </summary>
        public string VirtualNetworkName { get; }
        /// <summary> The Virtual Network summary view. </summary>
        public AppServiceVirtualNetworkProperties VirtualNetworkConnection { get; }
        /// <summary> The Hybrid Connections summary view. </summary>
        public IReadOnlyList<RelayServiceConnectionEntityData> HybridConnections { get; }
        /// <summary> The Hybrid Connection V2 (Service Bus) view. </summary>
        public IReadOnlyList<HybridConnectionData> HybridConnectionsV2 { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
