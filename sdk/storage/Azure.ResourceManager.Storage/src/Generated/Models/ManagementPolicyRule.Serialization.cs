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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicyRule : IUtf8JsonSerializable, IJsonModel<ManagementPolicyRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementPolicyRule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagementPolicyRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyRule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuleType.ToString());
            writer.WritePropertyName("definition"u8);
            writer.WriteObjectValue(Definition, options);
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

        ManagementPolicyRule IJsonModel<ManagementPolicyRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementPolicyRule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementPolicyRule(document.RootElement, options);
        }

        internal static ManagementPolicyRule DeserializeManagementPolicyRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            string name = default;
            ManagementPolicyRuleType type = default;
            ManagementPolicyDefinition definition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ManagementPolicyRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = ManagementPolicyDefinition.DeserializeManagementPolicyDefinition(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagementPolicyRule(enabled, name, type, definition, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("  enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RuleType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{RuleType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Definition), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  definition: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Definition))
                {
                    builder.Append("  definition: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Definition, options, 2, false, "  definition: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagementPolicyRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerStorageContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyRule)} does not support writing '{options.Format}' format.");
            }
        }

        ManagementPolicyRule IPersistableModel<ManagementPolicyRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagementPolicyRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementPolicyRule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementPolicyRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
