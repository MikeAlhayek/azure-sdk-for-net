// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageActions.Models
{
    public partial class StorageTaskPreviewBlobProperties : IUtf8JsonSerializable, IJsonModel<StorageTaskPreviewBlobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageTaskPreviewBlobProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StorageTaskPreviewBlobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskPreviewBlobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskPreviewBlobProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartArray();
                foreach (var item in Properties)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(MatchedBlock))
            {
                writer.WritePropertyName("matchedBlock"u8);
                writer.WriteStringValue(MatchedBlock.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        StorageTaskPreviewBlobProperties IJsonModel<StorageTaskPreviewBlobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskPreviewBlobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageTaskPreviewBlobProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTaskPreviewBlobProperties(document.RootElement, options);
        }

        internal static StorageTaskPreviewBlobProperties DeserializeStorageTaskPreviewBlobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<StorageTaskPreviewKeyValueProperties> properties = default;
            IList<StorageTaskPreviewKeyValueProperties> metadata = default;
            IList<StorageTaskPreviewKeyValueProperties> tags = default;
            MatchedBlockName? matchedBlock = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageTaskPreviewKeyValueProperties> array = new List<StorageTaskPreviewKeyValueProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageTaskPreviewKeyValueProperties.DeserializeStorageTaskPreviewKeyValueProperties(item, options));
                    }
                    properties = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageTaskPreviewKeyValueProperties> array = new List<StorageTaskPreviewKeyValueProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageTaskPreviewKeyValueProperties.DeserializeStorageTaskPreviewKeyValueProperties(item, options));
                    }
                    metadata = array;
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageTaskPreviewKeyValueProperties> array = new List<StorageTaskPreviewKeyValueProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageTaskPreviewKeyValueProperties.DeserializeStorageTaskPreviewKeyValueProperties(item, options));
                    }
                    tags = array;
                    continue;
                }
                if (property.NameEquals("matchedBlock"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchedBlock = new MatchedBlockName(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new StorageTaskPreviewBlobProperties(
                name,
                properties ?? new ChangeTrackingList<StorageTaskPreviewKeyValueProperties>(),
                metadata ?? new ChangeTrackingList<StorageTaskPreviewKeyValueProperties>(),
                tags ?? new ChangeTrackingList<StorageTaskPreviewKeyValueProperties>(),
                matchedBlock,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageTaskPreviewBlobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskPreviewBlobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageActionsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(StorageTaskPreviewBlobProperties)} does not support writing '{options.Format}' format.");
            }
        }

        StorageTaskPreviewBlobProperties IPersistableModel<StorageTaskPreviewBlobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageTaskPreviewBlobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeStorageTaskPreviewBlobProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageTaskPreviewBlobProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageTaskPreviewBlobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
