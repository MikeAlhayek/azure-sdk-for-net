// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TwitterRegistration : IUtf8JsonSerializable, IJsonModel<TwitterRegistration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TwitterRegistration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<TwitterRegistration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TwitterRegistration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ConsumerKey))
            {
                writer.WritePropertyName("consumerKey"u8);
                writer.WriteStringValue(ConsumerKey);
            }
            if (Optional.IsDefined(ConsumerSecretSettingName))
            {
                writer.WritePropertyName("consumerSecretSettingName"u8);
                writer.WriteStringValue(ConsumerSecretSettingName);
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

        TwitterRegistration IJsonModel<TwitterRegistration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TwitterRegistration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTwitterRegistration(document.RootElement, options);
        }

        internal static TwitterRegistration DeserializeTwitterRegistration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string consumerKey = default;
            string consumerSecretSettingName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consumerKey"u8))
                {
                    consumerKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("consumerSecretSettingName"u8))
                {
                    consumerSecretSettingName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new TwitterRegistration(consumerKey, consumerSecretSettingName, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConsumerKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  consumerKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConsumerKey))
                {
                    builder.Append("  consumerKey: ");
                    if (ConsumerKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConsumerKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConsumerKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ConsumerSecretSettingName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  consumerSecretSettingName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ConsumerSecretSettingName))
                {
                    builder.Append("  consumerSecretSettingName: ");
                    if (ConsumerSecretSettingName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ConsumerSecretSettingName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ConsumerSecretSettingName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<TwitterRegistration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(TwitterRegistration)} does not support writing '{options.Format}' format.");
            }
        }

        TwitterRegistration IPersistableModel<TwitterRegistration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TwitterRegistration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeTwitterRegistration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TwitterRegistration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<TwitterRegistration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
