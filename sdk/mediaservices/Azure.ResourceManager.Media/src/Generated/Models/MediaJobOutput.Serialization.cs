// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaJobOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(PresetOverride))
            {
                writer.WritePropertyName("presetOverride");
                writer.WriteObjectValue(PresetOverride);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label");
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static MediaJobOutput DeserializeMediaJobOutput(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.JobOutputAsset": return MediaJobOutputAsset.DeserializeMediaJobOutputAsset(element);
                }
            }
            return UnknownJobOutput.DeserializeUnknownJobOutput(element);
        }
    }
}
