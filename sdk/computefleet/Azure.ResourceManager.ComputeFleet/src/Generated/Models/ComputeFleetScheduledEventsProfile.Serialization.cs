// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetScheduledEventsProfile : IUtf8JsonSerializable, IJsonModel<ComputeFleetScheduledEventsProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetScheduledEventsProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetScheduledEventsProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetScheduledEventsProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(TerminateNotificationProfile))
            {
                writer.WritePropertyName("terminateNotificationProfile"u8);
                writer.WriteObjectValue(TerminateNotificationProfile, options);
            }
            if (Optional.IsDefined(OSImageNotificationProfile))
            {
                writer.WritePropertyName("osImageNotificationProfile"u8);
                writer.WriteObjectValue(OSImageNotificationProfile, options);
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

        ComputeFleetScheduledEventsProfile IJsonModel<ComputeFleetScheduledEventsProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetScheduledEventsProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetScheduledEventsProfile(document.RootElement, options);
        }

        internal static ComputeFleetScheduledEventsProfile DeserializeComputeFleetScheduledEventsProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeFleetTerminateNotificationProfile terminateNotificationProfile = default;
            ComputeFleetOSImageNotificationProfile osImageNotificationProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("terminateNotificationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    terminateNotificationProfile = ComputeFleetTerminateNotificationProfile.DeserializeComputeFleetTerminateNotificationProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("osImageNotificationProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osImageNotificationProfile = ComputeFleetOSImageNotificationProfile.DeserializeComputeFleetOSImageNotificationProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetScheduledEventsProfile(terminateNotificationProfile, osImageNotificationProfile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetScheduledEventsProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeFleetContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetScheduledEventsProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetScheduledEventsProfile IPersistableModel<ComputeFleetScheduledEventsProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetScheduledEventsProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeComputeFleetScheduledEventsProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetScheduledEventsProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetScheduledEventsProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
