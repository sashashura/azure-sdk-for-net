// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class KikChannelProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("userName");
            writer.WriteStringValue(UserName);
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey");
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(IsValidated))
            {
                writer.WritePropertyName("isValidated");
                writer.WriteBooleanValue(IsValidated.Value);
            }
            writer.WritePropertyName("isEnabled");
            writer.WriteBooleanValue(IsEnabled);
            writer.WriteEndObject();
        }

        internal static KikChannelProperties DeserializeKikChannelProperties(JsonElement element)
        {
            string userName = default;
            Optional<string> apiKey = default;
            Optional<bool> isValidated = default;
            bool isEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userName"))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiKey"))
                {
                    apiKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isValidated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isValidated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isEnabled"))
                {
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new KikChannelProperties(userName, apiKey.Value, Optional.ToNullable(isValidated), isEnabled);
        }
    }
}
