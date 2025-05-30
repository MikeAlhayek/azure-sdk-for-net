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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridJsonInputSchemaMapping : IUtf8JsonSerializable, IJsonModel<EventGridJsonInputSchemaMapping>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridJsonInputSchemaMapping>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridJsonInputSchemaMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteObjectValue(Id, options);
            }
            if (Optional.IsDefined(Topic))
            {
                writer.WritePropertyName("topic"u8);
                writer.WriteObjectValue(Topic, options);
            }
            if (Optional.IsDefined(EventTime))
            {
                writer.WritePropertyName("eventTime"u8);
                writer.WriteObjectValue(EventTime, options);
            }
            if (Optional.IsDefined(EventType))
            {
                writer.WritePropertyName("eventType"u8);
                writer.WriteObjectValue(EventType, options);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteObjectValue(Subject, options);
            }
            if (Optional.IsDefined(DataVersion))
            {
                writer.WritePropertyName("dataVersion"u8);
                writer.WriteObjectValue(DataVersion, options);
            }
            writer.WriteEndObject();
        }

        EventGridJsonInputSchemaMapping IJsonModel<EventGridJsonInputSchemaMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridJsonInputSchemaMapping(document.RootElement, options);
        }

        internal static EventGridJsonInputSchemaMapping DeserializeEventGridJsonInputSchemaMapping(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InputSchemaMappingType inputSchemaMappingType = default;
            JsonField id = default;
            JsonField topic = default;
            JsonField eventTime = default;
            JsonFieldWithDefault eventType = default;
            JsonFieldWithDefault subject = default;
            JsonFieldWithDefault dataVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inputSchemaMappingType"u8))
                {
                    inputSchemaMappingType = new InputSchemaMappingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("id"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            id = JsonField.DeserializeJsonField(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("topic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            topic = JsonField.DeserializeJsonField(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventTime = JsonField.DeserializeJsonField(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("eventType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventType = JsonFieldWithDefault.DeserializeJsonFieldWithDefault(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("subject"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subject = JsonFieldWithDefault.DeserializeJsonFieldWithDefault(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dataVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataVersion = JsonFieldWithDefault.DeserializeJsonFieldWithDefault(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventGridJsonInputSchemaMapping(
                inputSchemaMappingType,
                serializedAdditionalRawData,
                id,
                topic,
                eventTime,
                eventType,
                subject,
                dataVersion);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InputSchemaMappingType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  inputSchemaMappingType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  inputSchemaMappingType: ");
                builder.AppendLine($"'{InputSchemaMappingType.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("IdSourceField", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    id: ");
                builder.AppendLine("{");
                builder.AppendLine("      id: {");
                builder.Append("        sourceField: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("    id: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Id, options, 4, false, "    id: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("TopicSourceField", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    topic: ");
                builder.AppendLine("{");
                builder.AppendLine("      topic: {");
                builder.Append("        sourceField: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Topic))
                {
                    builder.Append("    topic: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Topic, options, 4, false, "    topic: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("EventTimeSourceField", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    eventTime: ");
                builder.AppendLine("{");
                builder.AppendLine("      eventTime: {");
                builder.Append("        sourceField: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(EventTime))
                {
                    builder.Append("    eventTime: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EventTime, options, 4, false, "    eventTime: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    eventType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EventType))
                {
                    builder.Append("    eventType: ");
                    BicepSerializationHelpers.AppendChildObject(builder, EventType, options, 4, false, "    eventType: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Subject), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    subject: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Subject))
                {
                    builder.Append("    subject: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Subject, options, 4, false, "    subject: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DataVersion), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    dataVersion: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DataVersion))
                {
                    builder.Append("    dataVersion: ");
                    BicepSerializationHelpers.AppendChildObject(builder, DataVersion, options, 4, false, "    dataVersion: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventGridJsonInputSchemaMapping>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerEventGridContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridJsonInputSchemaMapping IPersistableModel<EventGridJsonInputSchemaMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridJsonInputSchemaMapping>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEventGridJsonInputSchemaMapping(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridJsonInputSchemaMapping)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridJsonInputSchemaMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
