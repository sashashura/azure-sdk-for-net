// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    internal partial class UnknownPlacementPolicyProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(PolicyType.ToString());
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            writer.WriteEndObject();
        }

        internal static UnknownPlacementPolicyProperties DeserializeUnknownPlacementPolicyProperties(JsonElement element)
        {
            PlacementPolicyType type = default;
            Optional<PlacementPolicyState> state = default;
            Optional<string> displayName = default;
            Optional<PlacementPolicyProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new PlacementPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new PlacementPolicyState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new PlacementPolicyProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownPlacementPolicyProperties(type, Optional.ToNullable(state), displayName.Value, Optional.ToNullable(provisioningState));
        }
    }
}
