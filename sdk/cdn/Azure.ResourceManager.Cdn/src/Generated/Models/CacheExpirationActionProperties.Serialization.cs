// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CacheExpirationActionProperties : IUtf8JsonSerializable, IJsonModel<CacheExpirationActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CacheExpirationActionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CacheExpirationActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheExpirationActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CacheExpirationActionProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("cacheBehavior"u8);
            writer.WriteStringValue(CacheBehavior.ToString());
            writer.WritePropertyName("cacheType"u8);
            writer.WriteStringValue(CacheType.ToString());
            if (Optional.IsDefined(CacheDuration))
            {
                if (CacheDuration != null)
                {
                    writer.WritePropertyName("cacheDuration"u8);
                    writer.WriteStringValue(CacheDuration.Value, "c");
                }
                else
                {
                    writer.WriteNull("cacheDuration");
                }
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

        CacheExpirationActionProperties IJsonModel<CacheExpirationActionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheExpirationActionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CacheExpirationActionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCacheExpirationActionProperties(document.RootElement, options);
        }

        internal static CacheExpirationActionProperties DeserializeCacheExpirationActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CacheExpirationActionType typeName = default;
            CacheBehaviorSetting cacheBehavior = default;
            CdnCacheLevel cacheType = default;
            TimeSpan? cacheDuration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new CacheExpirationActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheBehavior"u8))
                {
                    cacheBehavior = new CacheBehaviorSetting(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheType"u8))
                {
                    cacheType = new CdnCacheLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cacheDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        cacheDuration = null;
                        continue;
                    }
                    cacheDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CacheExpirationActionProperties(typeName, cacheBehavior, cacheType, cacheDuration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CacheExpirationActionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheExpirationActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCdnContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CacheExpirationActionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        CacheExpirationActionProperties IPersistableModel<CacheExpirationActionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CacheExpirationActionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCacheExpirationActionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CacheExpirationActionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CacheExpirationActionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
