// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingEndpointDetail : IUtf8JsonSerializable, IJsonModel<LoadTestingEndpointDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadTestingEndpointDetail>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LoadTestingEndpointDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingEndpointDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestingEndpointDetail)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
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

        LoadTestingEndpointDetail IJsonModel<LoadTestingEndpointDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingEndpointDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestingEndpointDetail)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestingEndpointDetail(document.RootElement, options);
        }

        internal static LoadTestingEndpointDetail DeserializeLoadTestingEndpointDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? port = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LoadTestingEndpointDetail(port, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadTestingEndpointDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingEndpointDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLoadTestingContext.Default);
                default:
                    throw new FormatException($"The model {nameof(LoadTestingEndpointDetail)} does not support writing '{options.Format}' format.");
            }
        }

        LoadTestingEndpointDetail IPersistableModel<LoadTestingEndpointDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingEndpointDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeLoadTestingEndpointDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadTestingEndpointDetail)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadTestingEndpointDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
