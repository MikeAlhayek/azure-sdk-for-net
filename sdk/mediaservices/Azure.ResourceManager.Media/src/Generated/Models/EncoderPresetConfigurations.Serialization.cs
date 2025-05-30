// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class EncoderPresetConfigurations : IUtf8JsonSerializable, IJsonModel<EncoderPresetConfigurations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncoderPresetConfigurations>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EncoderPresetConfigurations>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncoderPresetConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncoderPresetConfigurations)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Complexity))
            {
                writer.WritePropertyName("complexity"u8);
                writer.WriteStringValue(Complexity.Value.ToString());
            }
            if (Optional.IsDefined(InterleaveOutput))
            {
                writer.WritePropertyName("interleaveOutput"u8);
                writer.WriteStringValue(InterleaveOutput.Value.ToString());
            }
            if (Optional.IsDefined(KeyFrameIntervalInSeconds))
            {
                writer.WritePropertyName("keyFrameIntervalInSeconds"u8);
                writer.WriteNumberValue(KeyFrameIntervalInSeconds.Value);
            }
            if (Optional.IsDefined(MaxBitrateBps))
            {
                writer.WritePropertyName("maxBitrateBps"u8);
                writer.WriteNumberValue(MaxBitrateBps.Value);
            }
            if (Optional.IsDefined(MaxHeight))
            {
                writer.WritePropertyName("maxHeight"u8);
                writer.WriteNumberValue(MaxHeight.Value);
            }
            if (Optional.IsDefined(MaxLayers))
            {
                writer.WritePropertyName("maxLayers"u8);
                writer.WriteNumberValue(MaxLayers.Value);
            }
            if (Optional.IsDefined(MinBitrateBps))
            {
                writer.WritePropertyName("minBitrateBps"u8);
                writer.WriteNumberValue(MinBitrateBps.Value);
            }
            if (Optional.IsDefined(MinHeight))
            {
                writer.WritePropertyName("minHeight"u8);
                writer.WriteNumberValue(MinHeight.Value);
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

        EncoderPresetConfigurations IJsonModel<EncoderPresetConfigurations>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncoderPresetConfigurations>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EncoderPresetConfigurations)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncoderPresetConfigurations(document.RootElement, options);
        }

        internal static EncoderPresetConfigurations DeserializeEncoderPresetConfigurations(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EncodingComplexity? complexity = default;
            InterleaveOutput? interleaveOutput = default;
            float? keyFrameIntervalInSeconds = default;
            int? maxBitrateBps = default;
            int? maxHeight = default;
            int? maxLayers = default;
            int? minBitrateBps = default;
            int? minHeight = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complexity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complexity = new EncodingComplexity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("interleaveOutput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    interleaveOutput = new InterleaveOutput(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyFrameIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyFrameIntervalInSeconds = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("maxBitrateBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBitrateBps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxHeight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxHeight = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxLayers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxLayers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBitrateBps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBitrateBps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minHeight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minHeight = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EncoderPresetConfigurations(
                complexity,
                interleaveOutput,
                keyFrameIntervalInSeconds,
                maxBitrateBps,
                maxHeight,
                maxLayers,
                minBitrateBps,
                minHeight,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EncoderPresetConfigurations>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncoderPresetConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMediaContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EncoderPresetConfigurations)} does not support writing '{options.Format}' format.");
            }
        }

        EncoderPresetConfigurations IPersistableModel<EncoderPresetConfigurations>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EncoderPresetConfigurations>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEncoderPresetConfigurations(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EncoderPresetConfigurations)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EncoderPresetConfigurations>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
