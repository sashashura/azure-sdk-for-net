// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class UnknownFormatBasicProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("filenamePattern");
            writer.WriteStringValue(FilenamePattern);
            writer.WriteEndObject();
        }

        internal static UnknownFormatBasicProperties DeserializeUnknownFormatBasicProperties(JsonElement element)
        {
            string odataType = default;
            string filenamePattern = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filenamePattern"))
                {
                    filenamePattern = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownFormatBasicProperties(odataType, filenamePattern);
        }
    }
}
