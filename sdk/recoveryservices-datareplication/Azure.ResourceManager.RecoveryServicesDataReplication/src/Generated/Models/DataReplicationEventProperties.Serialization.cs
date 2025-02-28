// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesDataReplication;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationEventProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationEventProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationEventProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataReplicationEventProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationEventProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceName))
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (options.Format != "W" && Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteStringValue(EventType);
            }
            if (options.Format != "W" && Optional.IsDefined(EventName))
            {
                writer.WritePropertyName("eventName"u8);
                writer.WriteStringValue(EventName);
            }
            if (options.Format != "W" && Optional.IsDefined(OccurredOn))
            {
                writer.WritePropertyName("timeOfOccurrence"u8);
                writer.WriteStringValue(OccurredOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties);
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

        DataReplicationEventProperties IJsonModel<DataReplicationEventProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEventProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationEventProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationEventProperties(document.RootElement, options);
        }

        internal static DataReplicationEventProperties DeserializeDataReplicationEventProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceType? resourceType = default;
            string resourceName = default;
            string eventType = default;
            string eventName = default;
            DateTimeOffset? timeOfOccurrence = default;
            string severity = default;
            string description = default;
            string correlationId = default;
            IReadOnlyList<DataReplicationHealthErrorInfo> healthErrors = default;
            EventModelCustomProperties customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    eventType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventName"u8))
                {
                    eventName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeOfOccurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeOfOccurrence = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("severity"u8))
                {
                    severity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationHealthErrorInfo> array = new List<DataReplicationHealthErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationHealthErrorInfo.DeserializeDataReplicationHealthErrorInfo(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = EventModelCustomProperties.DeserializeEventModelCustomProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataReplicationEventProperties(
                resourceType,
                resourceName,
                eventType,
                eventName,
                timeOfOccurrence,
                severity,
                description,
                correlationId,
                healthErrors ?? new ChangeTrackingList<DataReplicationHealthErrorInfo>(),
                customProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataReplicationEventProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataReplicationEventProperties)} does not support '{options.Format}' format.");
            }
        }

        DataReplicationEventProperties IPersistableModel<DataReplicationEventProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationEventProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataReplicationEventProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataReplicationEventProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataReplicationEventProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
