// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GovernanceAssignmentAdditionalInfo : IUtf8JsonSerializable, IJsonModel<GovernanceAssignmentAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GovernanceAssignmentAdditionalInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GovernanceAssignmentAdditionalInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceAssignmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TicketNumber))
            {
                writer.WritePropertyName("ticketNumber"u8);
                writer.WriteNumberValue(TicketNumber.Value);
            }
            if (Optional.IsDefined(TicketLink))
            {
                writer.WritePropertyName("ticketLink"u8);
                writer.WriteStringValue(TicketLink);
            }
            if (Optional.IsDefined(TicketStatus))
            {
                writer.WritePropertyName("ticketStatus"u8);
                writer.WriteStringValue(TicketStatus);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        GovernanceAssignmentAdditionalInfo IJsonModel<GovernanceAssignmentAdditionalInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceAssignmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceAssignmentAdditionalInfo(document.RootElement, options);
        }

        internal static GovernanceAssignmentAdditionalInfo DeserializeGovernanceAssignmentAdditionalInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? ticketNumber = default;
            string ticketLink = default;
            string ticketStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ticketNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ticketNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ticketLink"u8))
                {
                    ticketLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketStatus"u8))
                {
                    ticketStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GovernanceAssignmentAdditionalInfo(ticketNumber, ticketLink, ticketStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GovernanceAssignmentAdditionalInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceAssignmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{options.Format}' format.");
            }
        }

        GovernanceAssignmentAdditionalInfo IPersistableModel<GovernanceAssignmentAdditionalInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GovernanceAssignmentAdditionalInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGovernanceAssignmentAdditionalInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GovernanceAssignmentAdditionalInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
