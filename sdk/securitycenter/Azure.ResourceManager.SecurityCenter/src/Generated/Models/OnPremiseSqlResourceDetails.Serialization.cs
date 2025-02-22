// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class OnPremiseSqlResourceDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("serverName");
            writer.WriteStringValue(ServerName);
            writer.WritePropertyName("databaseName");
            writer.WriteStringValue(DatabaseName);
            writer.WritePropertyName("workspaceId");
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("vmuuid");
            writer.WriteStringValue(VmUuid);
            writer.WritePropertyName("sourceComputerId");
            writer.WriteStringValue(SourceComputerId);
            writer.WritePropertyName("machineName");
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("source");
            writer.WriteStringValue(Source.ToString());
            writer.WriteEndObject();
        }

        internal static OnPremiseSqlResourceDetails DeserializeOnPremiseSqlResourceDetails(JsonElement element)
        {
            string serverName = default;
            string databaseName = default;
            string workspaceId = default;
            Guid vmuuid = default;
            string sourceComputerId = default;
            string machineName = default;
            Source source = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serverName"))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmuuid"))
                {
                    vmuuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sourceComputerId"))
                {
                    sourceComputerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    source = new Source(property.Value.GetString());
                    continue;
                }
            }
            return new OnPremiseSqlResourceDetails(source, workspaceId, vmuuid, sourceComputerId, machineName, serverName, databaseName);
        }
    }
}
