// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("formatType");
            writer.WriteStringValue(FormatType.ToString());
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter");
                writer.WriteStringValue(ColumnDelimiter);
            }
            if (Optional.IsDefined(AcceptLanguage))
            {
                writer.WritePropertyName("acceptLanguage");
                writer.WriteStringValue(AcceptLanguage);
            }
            if (Optional.IsDefined(QuoteCharacter))
            {
                writer.WritePropertyName("quoteCharacter");
                writer.WriteStringValue(QuoteCharacter);
            }
            if (Optional.IsDefined(QuoteEscapeCharacter))
            {
                writer.WritePropertyName("quoteEscapeCharacter");
                writer.WriteStringValue(QuoteEscapeCharacter);
            }
            if (Optional.IsDefined(ArraySeparator))
            {
                writer.WritePropertyName("arraySeparator");
                writer.WriteStringValue(ArraySeparator);
            }
            writer.WriteEndObject();
        }

        internal static ConnectorMappingFormat DeserializeConnectorMappingFormat(JsonElement element)
        {
            FormatType formatType = default;
            Optional<string> columnDelimiter = default;
            Optional<string> acceptLanguage = default;
            Optional<string> quoteCharacter = default;
            Optional<string> quoteEscapeCharacter = default;
            Optional<string> arraySeparator = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatType"))
                {
                    formatType = new FormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("columnDelimiter"))
                {
                    columnDelimiter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceptLanguage"))
                {
                    acceptLanguage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quoteCharacter"))
                {
                    quoteCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quoteEscapeCharacter"))
                {
                    quoteEscapeCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arraySeparator"))
                {
                    arraySeparator = property.Value.GetString();
                    continue;
                }
            }
            return new ConnectorMappingFormat(formatType, columnDelimiter.Value, acceptLanguage.Value, quoteCharacter.Value, quoteEscapeCharacter.Value, arraySeparator.Value);
        }
    }
}
