// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownSamplingAlgorithm))]
    public partial class SamplingAlgorithm : IUtf8JsonSerializable, IJsonModel<SamplingAlgorithm>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SamplingAlgorithm>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SamplingAlgorithm>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SamplingAlgorithm)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("samplingAlgorithmType"u8);
            writer.WriteStringValue(SamplingAlgorithmType.ToString());
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

        SamplingAlgorithm IJsonModel<SamplingAlgorithm>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SamplingAlgorithm)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSamplingAlgorithm(document.RootElement, options);
        }

        internal static SamplingAlgorithm DeserializeSamplingAlgorithm(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("samplingAlgorithmType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Bayesian": return BayesianSamplingAlgorithm.DeserializeBayesianSamplingAlgorithm(element, options);
                    case "Grid": return GridSamplingAlgorithm.DeserializeGridSamplingAlgorithm(element, options);
                    case "Random": return RandomSamplingAlgorithm.DeserializeRandomSamplingAlgorithm(element, options);
                }
            }
            return UnknownSamplingAlgorithm.DeserializeUnknownSamplingAlgorithm(element, options);
        }

        BinaryData IPersistableModel<SamplingAlgorithm>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SamplingAlgorithm)} does not support '{options.Format}' format.");
            }
        }

        SamplingAlgorithm IPersistableModel<SamplingAlgorithm>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SamplingAlgorithm>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSamplingAlgorithm(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SamplingAlgorithm)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SamplingAlgorithm>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
