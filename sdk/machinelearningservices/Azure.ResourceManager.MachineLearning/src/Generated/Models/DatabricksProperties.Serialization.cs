// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DatabricksProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabricksAccessToken))
            {
                writer.WritePropertyName("databricksAccessToken");
                writer.WriteStringValue(DatabricksAccessToken);
            }
            if (Optional.IsDefined(WorkspaceUri))
            {
                writer.WritePropertyName("workspaceUrl");
                writer.WriteStringValue(WorkspaceUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static DatabricksProperties DeserializeDatabricksProperties(JsonElement element)
        {
            Optional<string> databricksAccessToken = default;
            Optional<Uri> workspaceUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databricksAccessToken"))
                {
                    databricksAccessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        workspaceUrl = null;
                        continue;
                    }
                    workspaceUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new DatabricksProperties(databricksAccessToken.Value, workspaceUrl.Value);
        }
    }
}
