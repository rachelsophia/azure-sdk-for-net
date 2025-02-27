// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataLakeStore;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal partial class DataLakeStoreVirtualNetworkRuleListResult
    {
        internal static DataLakeStoreVirtualNetworkRuleListResult DeserializeDataLakeStoreVirtualNetworkRuleListResult(JsonElement element)
        {
            Optional<IReadOnlyList<DataLakeStoreVirtualNetworkRuleData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DataLakeStoreVirtualNetworkRuleData> array = new List<DataLakeStoreVirtualNetworkRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataLakeStoreVirtualNetworkRuleData.DeserializeDataLakeStoreVirtualNetworkRuleData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DataLakeStoreVirtualNetworkRuleListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
