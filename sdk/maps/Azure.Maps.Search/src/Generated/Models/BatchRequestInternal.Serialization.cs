// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Maps.Search;

namespace Azure.Maps.Search.Models
{
    internal partial class BatchRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BatchItems))
            {
                writer.WritePropertyName("batchItems"u8);
                writer.WriteStartArray();
                foreach (var item in BatchItems)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
