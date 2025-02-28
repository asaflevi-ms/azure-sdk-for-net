// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class NamespaceTopicEventSubscriptionPatch : IUtf8JsonSerializable, IJsonModel<NamespaceTopicEventSubscriptionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NamespaceTopicEventSubscriptionPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NamespaceTopicEventSubscriptionPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeliveryConfiguration))
            {
                writer.WritePropertyName("deliveryConfiguration"u8);
                writer.WriteObjectValue(DeliveryConfiguration);
            }
            if (Optional.IsDefined(EventDeliverySchema))
            {
                writer.WritePropertyName("eventDeliverySchema"u8);
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (Optional.IsDefined(FiltersConfiguration))
            {
                writer.WritePropertyName("filtersConfiguration"u8);
                writer.WriteObjectValue(FiltersConfiguration);
            }
            writer.WriteEndObject();
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

        NamespaceTopicEventSubscriptionPatch IJsonModel<NamespaceTopicEventSubscriptionPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNamespaceTopicEventSubscriptionPatch(document.RootElement, options);
        }

        internal static NamespaceTopicEventSubscriptionPatch DeserializeNamespaceTopicEventSubscriptionPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DeliveryConfiguration deliveryConfiguration = default;
            DeliverySchema? eventDeliverySchema = default;
            FiltersConfiguration filtersConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("deliveryConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deliveryConfiguration = DeliveryConfiguration.DeserializeDeliveryConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventDeliverySchema"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventDeliverySchema = new DeliverySchema(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("filtersConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filtersConfiguration = FiltersConfiguration.DeserializeFiltersConfiguration(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NamespaceTopicEventSubscriptionPatch(deliveryConfiguration, eventDeliverySchema, filtersConfiguration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NamespaceTopicEventSubscriptionPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionPatch)} does not support '{options.Format}' format.");
            }
        }

        NamespaceTopicEventSubscriptionPatch IPersistableModel<NamespaceTopicEventSubscriptionPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NamespaceTopicEventSubscriptionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNamespaceTopicEventSubscriptionPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NamespaceTopicEventSubscriptionPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NamespaceTopicEventSubscriptionPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
