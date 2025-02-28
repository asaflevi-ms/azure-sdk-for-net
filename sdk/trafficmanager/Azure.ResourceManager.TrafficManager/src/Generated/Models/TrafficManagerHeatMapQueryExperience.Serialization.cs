// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.TrafficManager;

namespace Azure.ResourceManager.TrafficManager.Models
{
    public partial class TrafficManagerHeatMapQueryExperience : IUtf8JsonSerializable, IJsonModel<TrafficManagerHeatMapQueryExperience>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TrafficManagerHeatMapQueryExperience>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TrafficManagerHeatMapQueryExperience>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapQueryExperience>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerHeatMapQueryExperience)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpointId"u8);
            writer.WriteNumberValue(EndpointId);
            writer.WritePropertyName("queryCount"u8);
            writer.WriteNumberValue(QueryCount);
            if (Optional.IsDefined(Latency))
            {
                writer.WritePropertyName("latency"u8);
                writer.WriteNumberValue(Latency.Value);
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

        TrafficManagerHeatMapQueryExperience IJsonModel<TrafficManagerHeatMapQueryExperience>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapQueryExperience>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TrafficManagerHeatMapQueryExperience)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTrafficManagerHeatMapQueryExperience(document.RootElement, options);
        }

        internal static TrafficManagerHeatMapQueryExperience DeserializeTrafficManagerHeatMapQueryExperience(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int endpointId = default;
            int queryCount = default;
            double? latency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointId"u8))
                {
                    endpointId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("queryCount"u8))
                {
                    queryCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("latency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latency = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TrafficManagerHeatMapQueryExperience(endpointId, queryCount, latency, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TrafficManagerHeatMapQueryExperience>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapQueryExperience>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerHeatMapQueryExperience)} does not support '{options.Format}' format.");
            }
        }

        TrafficManagerHeatMapQueryExperience IPersistableModel<TrafficManagerHeatMapQueryExperience>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TrafficManagerHeatMapQueryExperience>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTrafficManagerHeatMapQueryExperience(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TrafficManagerHeatMapQueryExperience)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TrafficManagerHeatMapQueryExperience>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
