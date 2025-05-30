// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotChannelRegenerateKeysContent : IUtf8JsonSerializable, IJsonModel<BotChannelRegenerateKeysContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotChannelRegenerateKeysContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BotChannelRegenerateKeysContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelRegenerateKeysContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelRegenerateKeysContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("siteName"u8);
            writer.WriteStringValue(SiteName);
            writer.WritePropertyName("key"u8);
            writer.WriteStringValue(Key.ToSerialString());
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

        BotChannelRegenerateKeysContent IJsonModel<BotChannelRegenerateKeysContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelRegenerateKeysContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelRegenerateKeysContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotChannelRegenerateKeysContent(document.RootElement, options);
        }

        internal static BotChannelRegenerateKeysContent DeserializeBotChannelRegenerateKeysContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string siteName = default;
            BotServiceKey key = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("siteName"u8))
                {
                    siteName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString().ToBotServiceKey();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BotChannelRegenerateKeysContent(siteName, key, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotChannelRegenerateKeysContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelRegenerateKeysContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerBotServiceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BotChannelRegenerateKeysContent)} does not support writing '{options.Format}' format.");
            }
        }

        BotChannelRegenerateKeysContent IPersistableModel<BotChannelRegenerateKeysContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelRegenerateKeysContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBotChannelRegenerateKeysContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotChannelRegenerateKeysContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotChannelRegenerateKeysContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
