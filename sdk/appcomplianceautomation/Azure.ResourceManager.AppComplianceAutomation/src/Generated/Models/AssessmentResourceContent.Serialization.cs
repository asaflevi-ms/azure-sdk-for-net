// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class AssessmentResourceContent : IUtf8JsonSerializable, IJsonModel<AssessmentResourceContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssessmentResourceContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssessmentResourceContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentResourceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssessmentResourceContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceStatus))
            {
                writer.WritePropertyName("resourceStatus"u8);
                writer.WriteStringValue(ResourceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (options.Format != "W" && Optional.IsDefined(StatusChangeDate))
            {
                writer.WritePropertyName("statusChangeDate"u8);
                writer.WriteStringValue(StatusChangeDate);
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

        AssessmentResourceContent IJsonModel<AssessmentResourceContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentResourceContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssessmentResourceContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssessmentResourceContent(document.RootElement, options);
        }

        internal static AssessmentResourceContent DeserializeAssessmentResourceContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string resourceId = default;
            ResourceStatus? resourceStatus = default;
            string reason = default;
            string statusChangeDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceStatus = new ResourceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusChangeDate"u8))
                {
                    statusChangeDate = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AssessmentResourceContent(resourceId, resourceStatus, reason, statusChangeDate, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssessmentResourceContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentResourceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssessmentResourceContent)} does not support '{options.Format}' format.");
            }
        }

        AssessmentResourceContent IPersistableModel<AssessmentResourceContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssessmentResourceContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssessmentResourceContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssessmentResourceContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssessmentResourceContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
