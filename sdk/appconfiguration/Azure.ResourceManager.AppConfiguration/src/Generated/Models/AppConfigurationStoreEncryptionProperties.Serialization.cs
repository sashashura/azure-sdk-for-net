// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppConfiguration.Models
{
    internal partial class AppConfigurationStoreEncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVaultProperties))
            {
                if (KeyVaultProperties != null)
                {
                    writer.WritePropertyName("keyVaultProperties");
                    writer.WriteObjectValue(KeyVaultProperties);
                }
                else
                {
                    writer.WriteNull("keyVaultProperties");
                }
            }
            writer.WriteEndObject();
        }

        internal static AppConfigurationStoreEncryptionProperties DeserializeAppConfigurationStoreEncryptionProperties(JsonElement element)
        {
            Optional<AppConfigurationKeyVaultProperties> keyVaultProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyVaultProperties = null;
                        continue;
                    }
                    keyVaultProperties = AppConfigurationKeyVaultProperties.DeserializeAppConfigurationKeyVaultProperties(property.Value);
                    continue;
                }
            }
            return new AppConfigurationStoreEncryptionProperties(keyVaultProperties.Value);
        }
    }
}
