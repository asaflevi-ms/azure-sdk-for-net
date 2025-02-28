// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesBackup;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmResourceFeatureSupportResult : IUtf8JsonSerializable, IJsonModel<VmResourceFeatureSupportResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmResourceFeatureSupportResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmResourceFeatureSupportResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmResourceFeatureSupportResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SupportStatus))
            {
                writer.WritePropertyName("supportStatus"u8);
                writer.WriteStringValue(SupportStatus.Value.ToString());
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

        VmResourceFeatureSupportResult IJsonModel<VmResourceFeatureSupportResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmResourceFeatureSupportResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmResourceFeatureSupportResult(document.RootElement, options);
        }

        internal static VmResourceFeatureSupportResult DeserializeVmResourceFeatureSupportResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VmResourceFeatureSupportStatus? supportStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportStatus = new VmResourceFeatureSupportStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VmResourceFeatureSupportResult(supportStatus, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmResourceFeatureSupportResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmResourceFeatureSupportResult)} does not support '{options.Format}' format.");
            }
        }

        VmResourceFeatureSupportResult IPersistableModel<VmResourceFeatureSupportResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmResourceFeatureSupportResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmResourceFeatureSupportResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmResourceFeatureSupportResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmResourceFeatureSupportResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
