// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryDiskEncryptionKeyInfo : IUtf8JsonSerializable, IJsonModel<SiteRecoveryDiskEncryptionKeyInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryDiskEncryptionKeyInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryDiskEncryptionKeyInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDiskEncryptionKeyInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SecretIdentifier))
            {
                writer.WritePropertyName("secretIdentifier"u8);
                writer.WriteStringValue(SecretIdentifier);
            }
            if (Optional.IsDefined(KeyVaultResourceArmId))
            {
                writer.WritePropertyName("keyVaultResourceArmId"u8);
                writer.WriteStringValue(KeyVaultResourceArmId);
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

        SiteRecoveryDiskEncryptionKeyInfo IJsonModel<SiteRecoveryDiskEncryptionKeyInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryDiskEncryptionKeyInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryDiskEncryptionKeyInfo(document.RootElement, options);
        }

        internal static SiteRecoveryDiskEncryptionKeyInfo DeserializeSiteRecoveryDiskEncryptionKeyInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string secretIdentifier = default;
            ResourceIdentifier keyVaultResourceArmId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secretIdentifier"u8))
                {
                    secretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultResourceArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultResourceArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryDiskEncryptionKeyInfo(secretIdentifier, keyVaultResourceArmId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDiskEncryptionKeyInfo)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryDiskEncryptionKeyInfo IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryDiskEncryptionKeyInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryDiskEncryptionKeyInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryDiskEncryptionKeyInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
