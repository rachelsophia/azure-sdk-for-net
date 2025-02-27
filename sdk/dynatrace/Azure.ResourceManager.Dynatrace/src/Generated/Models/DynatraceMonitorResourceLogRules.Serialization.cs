// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorResourceLogRules : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SendAadLogs))
            {
                writer.WritePropertyName("sendAadLogs");
                writer.WriteStringValue(SendAadLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendSubscriptionLogs))
            {
                writer.WritePropertyName("sendSubscriptionLogs");
                writer.WriteStringValue(SendSubscriptionLogs.Value.ToString());
            }
            if (Optional.IsDefined(SendActivityLogs))
            {
                writer.WritePropertyName("sendActivityLogs");
                writer.WriteStringValue(SendActivityLogs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FilteringTags))
            {
                writer.WritePropertyName("filteringTags");
                writer.WriteStartArray();
                foreach (var item in FilteringTags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DynatraceMonitorResourceLogRules DeserializeDynatraceMonitorResourceLogRules(JsonElement element)
        {
            Optional<AadLogsSendingStatus> sendAadLogs = default;
            Optional<SubscriptionLogsSendingStatus> sendSubscriptionLogs = default;
            Optional<ActivityLogsSendingStatus> sendActivityLogs = default;
            Optional<IList<DynatraceMonitorResourceFilteringTag>> filteringTags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sendAadLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendAadLogs = new AadLogsSendingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendSubscriptionLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendSubscriptionLogs = new SubscriptionLogsSendingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendActivityLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendActivityLogs = new ActivityLogsSendingStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filteringTags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DynatraceMonitorResourceFilteringTag> array = new List<DynatraceMonitorResourceFilteringTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DynatraceMonitorResourceFilteringTag.DeserializeDynatraceMonitorResourceFilteringTag(item));
                    }
                    filteringTags = array;
                    continue;
                }
            }
            return new DynatraceMonitorResourceLogRules(Optional.ToNullable(sendAadLogs), Optional.ToNullable(sendSubscriptionLogs), Optional.ToNullable(sendActivityLogs), Optional.ToList(filteringTags));
        }
    }
}
