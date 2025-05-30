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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class FusionSubTypeSeverityFilter : IUtf8JsonSerializable, IJsonModel<FusionSubTypeSeverityFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FusionSubTypeSeverityFilter>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FusionSubTypeSeverityFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSubTypeSeverityFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FusionSubTypeSeverityFilter)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(IsSupported))
            {
                writer.WritePropertyName("isSupported"u8);
                writer.WriteBooleanValue(IsSupported.Value);
            }
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        FusionSubTypeSeverityFilter IJsonModel<FusionSubTypeSeverityFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSubTypeSeverityFilter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FusionSubTypeSeverityFilter)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFusionSubTypeSeverityFilter(document.RootElement, options);
        }

        internal static FusionSubTypeSeverityFilter DeserializeFusionSubTypeSeverityFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? isSupported = default;
            IList<FusionSubTypeSeverityFiltersItem> filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FusionSubTypeSeverityFiltersItem> array = new List<FusionSubTypeSeverityFiltersItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FusionSubTypeSeverityFiltersItem.DeserializeFusionSubTypeSeverityFiltersItem(item, options));
                    }
                    filters = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FusionSubTypeSeverityFilter(isSupported, filters ?? new ChangeTrackingList<FusionSubTypeSeverityFiltersItem>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsSupported), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isSupported: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsSupported))
                {
                    builder.Append("  isSupported: ");
                    var boolValue = IsSupported.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Filters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  filters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Filters))
                {
                    if (Filters.Any())
                    {
                        builder.Append("  filters: ");
                        builder.AppendLine("[");
                        foreach (var item in Filters)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  filters: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FusionSubTypeSeverityFilter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSubTypeSeverityFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FusionSubTypeSeverityFilter)} does not support writing '{options.Format}' format.");
            }
        }

        FusionSubTypeSeverityFilter IPersistableModel<FusionSubTypeSeverityFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FusionSubTypeSeverityFilter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFusionSubTypeSeverityFilter(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FusionSubTypeSeverityFilter)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FusionSubTypeSeverityFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
