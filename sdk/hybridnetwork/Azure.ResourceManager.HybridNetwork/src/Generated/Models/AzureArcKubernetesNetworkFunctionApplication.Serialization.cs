// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    [PersistableModelProxy(typeof(UnknownAzureArcKubernetesNetworkFunctionApplication))]
    public partial class AzureArcKubernetesNetworkFunctionApplication : IUtf8JsonSerializable, IJsonModel<AzureArcKubernetesNetworkFunctionApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureArcKubernetesNetworkFunctionApplication>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureArcKubernetesNetworkFunctionApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
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

        AzureArcKubernetesNetworkFunctionApplication IJsonModel<AzureArcKubernetesNetworkFunctionApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureArcKubernetesNetworkFunctionApplication(document.RootElement, options);
        }

        internal static AzureArcKubernetesNetworkFunctionApplication DeserializeAzureArcKubernetesNetworkFunctionApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("artifactType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HelmPackage": return AzureArcKubernetesHelmApplication.DeserializeAzureArcKubernetesHelmApplication(element, options);
                }
            }
            return UnknownAzureArcKubernetesNetworkFunctionApplication.DeserializeUnknownAzureArcKubernetesNetworkFunctionApplication(element, options);
        }

        BinaryData IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }
        }

        AzureArcKubernetesNetworkFunctionApplication IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureArcKubernetesNetworkFunctionApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureArcKubernetesNetworkFunctionApplication)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureArcKubernetesNetworkFunctionApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
