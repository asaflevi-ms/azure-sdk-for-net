// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class SingletonPartitionSchemeDescription : IUtf8JsonSerializable, IJsonModel<SingletonPartitionSchemeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SingletonPartitionSchemeDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SingletonPartitionSchemeDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        SingletonPartitionSchemeDescription IJsonModel<SingletonPartitionSchemeDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSingletonPartitionSchemeDescription(document.RootElement, options);
        }

        internal static SingletonPartitionSchemeDescription DeserializeSingletonPartitionSchemeDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ApplicationPartitionScheme partitionScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new ApplicationPartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SingletonPartitionSchemeDescription(partitionScheme, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SingletonPartitionSchemeDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support '{options.Format}' format.");
            }
        }

        SingletonPartitionSchemeDescription IPersistableModel<SingletonPartitionSchemeDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SingletonPartitionSchemeDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSingletonPartitionSchemeDescription(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SingletonPartitionSchemeDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SingletonPartitionSchemeDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
