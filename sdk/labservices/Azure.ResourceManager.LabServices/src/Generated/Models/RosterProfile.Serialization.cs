// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class RosterProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveDirectoryGroupId))
            {
                writer.WritePropertyName("activeDirectoryGroupId");
                writer.WriteStringValue(ActiveDirectoryGroupId);
            }
            if (Optional.IsDefined(LtiContextId))
            {
                writer.WritePropertyName("ltiContextId");
                writer.WriteStringValue(LtiContextId);
            }
            if (Optional.IsDefined(LmsInstance))
            {
                writer.WritePropertyName("lmsInstance");
                writer.WriteStringValue(LmsInstance);
            }
            if (Optional.IsDefined(LtiClientId))
            {
                writer.WritePropertyName("ltiClientId");
                writer.WriteStringValue(LtiClientId);
            }
            if (Optional.IsDefined(LtiRosterEndpoint))
            {
                writer.WritePropertyName("ltiRosterEndpoint");
                writer.WriteStringValue(LtiRosterEndpoint);
            }
            writer.WriteEndObject();
        }

        internal static RosterProfile DeserializeRosterProfile(JsonElement element)
        {
            Optional<string> activeDirectoryGroupId = default;
            Optional<string> ltiContextId = default;
            Optional<string> lmsInstance = default;
            Optional<string> ltiClientId = default;
            Optional<string> ltiRosterEndpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryGroupId"))
                {
                    activeDirectoryGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiContextId"))
                {
                    ltiContextId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lmsInstance"))
                {
                    lmsInstance = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiClientId"))
                {
                    ltiClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ltiRosterEndpoint"))
                {
                    ltiRosterEndpoint = property.Value.GetString();
                    continue;
                }
            }
            return new RosterProfile(activeDirectoryGroupId.Value, ltiContextId.Value, lmsInstance.Value, ltiClientId.Value, ltiRosterEndpoint.Value);
        }
    }
}
