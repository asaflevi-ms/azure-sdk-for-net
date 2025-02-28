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
    [PersistableModelProxy(typeof(UnknownConfigurationGroupValuePropertiesFormat))]
    public partial class ConfigurationGroupValuePropertiesFormat : IUtf8JsonSerializable, IJsonModel<ConfigurationGroupValuePropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfigurationGroupValuePropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfigurationGroupValuePropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (options.Format != "W" && Optional.IsDefined(PublisherScope))
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaName))
            {
                writer.WritePropertyName("configurationGroupSchemaName"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaName);
            }
            if (options.Format != "W" && Optional.IsDefined(ConfigurationGroupSchemaOfferingLocation))
            {
                writer.WritePropertyName("configurationGroupSchemaOfferingLocation"u8);
                writer.WriteStringValue(ConfigurationGroupSchemaOfferingLocation);
            }
            if (Optional.IsDefined(ConfigurationGroupSchemaResourceReference))
            {
                writer.WritePropertyName("configurationGroupSchemaResourceReference"u8);
                writer.WriteObjectValue(ConfigurationGroupSchemaResourceReference);
            }
            writer.WritePropertyName("configurationType"u8);
            writer.WriteStringValue(ConfigurationType.ToString());
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

        ConfigurationGroupValuePropertiesFormat IJsonModel<ConfigurationGroupValuePropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
        }

        internal static ConfigurationGroupValuePropertiesFormat DeserializeConfigurationGroupValuePropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("configurationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Open": return ConfigurationValueWithoutSecrets.DeserializeConfigurationValueWithoutSecrets(element, options);
                    case "Secret": return ConfigurationValueWithSecrets.DeserializeConfigurationValueWithSecrets(element, options);
                }
            }
            return UnknownConfigurationGroupValuePropertiesFormat.DeserializeUnknownConfigurationGroupValuePropertiesFormat(element, options);
        }

        BinaryData IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        ConfigurationGroupValuePropertiesFormat IPersistableModel<ConfigurationGroupValuePropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfigurationGroupValuePropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfigurationGroupValuePropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfigurationGroupValuePropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfigurationGroupValuePropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
