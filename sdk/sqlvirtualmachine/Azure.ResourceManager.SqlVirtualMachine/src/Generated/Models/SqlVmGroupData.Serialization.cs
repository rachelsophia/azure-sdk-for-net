// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SqlVirtualMachine.Models;

namespace Azure.ResourceManager.SqlVirtualMachine
{
    public partial class SqlVmGroupData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlImageOffer))
            {
                writer.WritePropertyName("sqlImageOffer");
                writer.WriteStringValue(SqlImageOffer);
            }
            if (Optional.IsDefined(SqlImageSku))
            {
                writer.WritePropertyName("sqlImageSku");
                writer.WriteStringValue(SqlImageSku.Value.ToString());
            }
            if (Optional.IsDefined(WindowsServerFailoverClusterDomainProfile))
            {
                writer.WritePropertyName("wsfcDomainProfile");
                writer.WriteObjectValue(WindowsServerFailoverClusterDomainProfile);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlVmGroupData DeserializeSqlVmGroupData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            Optional<string> sqlImageOffer = default;
            Optional<SqlVmGroupImageSku> sqlImageSku = default;
            Optional<SqlVmGroupScaleType> scaleType = default;
            Optional<SqlVmClusterManagerType> clusterManagerType = default;
            Optional<SqlVmClusterConfiguration> clusterConfiguration = default;
            Optional<WindowsServerFailoverClusterDomainProfile> windowsServerFailoverClusterDomainProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sqlImageOffer"))
                        {
                            sqlImageOffer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sqlImageSku"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            sqlImageSku = new SqlVmGroupImageSku(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scaleType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            scaleType = new SqlVmGroupScaleType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterManagerType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterManagerType = new SqlVmClusterManagerType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clusterConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterConfiguration = new SqlVmClusterConfiguration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("wsfcDomainProfile"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            windowsServerFailoverClusterDomainProfile = WindowsServerFailoverClusterDomainProfile.DeserializeWindowsServerFailoverClusterDomainProfile(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlVmGroupData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, provisioningState.Value, sqlImageOffer.Value, Optional.ToNullable(sqlImageSku), Optional.ToNullable(scaleType), Optional.ToNullable(clusterManagerType), Optional.ToNullable(clusterConfiguration), windowsServerFailoverClusterDomainProfile.Value);
        }
    }
}
