// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Confluent;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ConfluentOfferDetail : IUtf8JsonSerializable, IJsonModel<ConfluentOfferDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfluentOfferDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfluentOfferDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOfferDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentOfferDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("publisherId"u8);
            writer.WriteStringValue(PublisherId);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("planId"u8);
            writer.WriteStringValue(PlanId);
            writer.WritePropertyName("planName"u8);
            writer.WriteStringValue(PlanName);
            writer.WritePropertyName("termUnit"u8);
            writer.WriteStringValue(TermUnit);
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        ConfluentOfferDetail IJsonModel<ConfluentOfferDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOfferDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentOfferDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfluentOfferDetail(document.RootElement, options);
        }

        internal static ConfluentOfferDetail DeserializeConfluentOfferDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string publisherId = default;
            string id = default;
            string planId = default;
            string planName = default;
            string termUnit = default;
            ConfluentSaaSOfferStatus? status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisherId"u8))
                {
                    publisherId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planId"u8))
                {
                    planId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planName"u8))
                {
                    planName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termUnit"u8))
                {
                    termUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ConfluentSaaSOfferStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfluentOfferDetail(
                publisherId,
                id,
                planId,
                planName,
                termUnit,
                status,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfluentOfferDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOfferDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfluentOfferDetail)} does not support '{options.Format}' format.");
            }
        }

        ConfluentOfferDetail IPersistableModel<ConfluentOfferDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOfferDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfluentOfferDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfluentOfferDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfluentOfferDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
