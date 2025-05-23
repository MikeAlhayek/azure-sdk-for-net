// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class HttpMessageDiagnostic : IUtf8JsonSerializable, IJsonModel<HttpMessageDiagnostic>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HttpMessageDiagnostic>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HttpMessageDiagnostic>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpMessageDiagnostic>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HttpMessageDiagnostic)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteObjectValue(Body, options);
            }
            if (Optional.IsDefined(DataMasking))
            {
                writer.WritePropertyName("dataMasking"u8);
                writer.WriteObjectValue(DataMasking, options);
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

        HttpMessageDiagnostic IJsonModel<HttpMessageDiagnostic>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpMessageDiagnostic>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HttpMessageDiagnostic)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpMessageDiagnostic(document.RootElement, options);
        }

        internal static HttpMessageDiagnostic DeserializeHttpMessageDiagnostic(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> headers = default;
            BodyDiagnosticSettings body = default;
            DataMasking dataMasking = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("body"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    body = BodyDiagnosticSettings.DeserializeBodyDiagnosticSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataMasking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataMasking = DataMasking.DeserializeDataMasking(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HttpMessageDiagnostic(headers ?? new ChangeTrackingList<string>(), body, dataMasking, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Headers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  headers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Headers))
                {
                    if (Headers.Any())
                    {
                        builder.Append("  headers: ");
                        builder.AppendLine("[");
                        foreach (var item in Headers)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("BodyBytes", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  body: ");
                builder.AppendLine("{");
                builder.Append("    bytes: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Body))
                {
                    builder.Append("  body: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Body, options, 2, false, "  body: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataMasking), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dataMasking: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DataMasking))
                {
                    builder.Append("  dataMasking: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DataMasking, options, 2, false, "  dataMasking: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<HttpMessageDiagnostic>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpMessageDiagnostic>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(HttpMessageDiagnostic)} does not support writing '{options.Format}' format.");
            }
        }

        HttpMessageDiagnostic IPersistableModel<HttpMessageDiagnostic>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HttpMessageDiagnostic>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHttpMessageDiagnostic(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HttpMessageDiagnostic)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HttpMessageDiagnostic>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
