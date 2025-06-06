// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnGatewayPacketCaptureStopContent : IUtf8JsonSerializable, IJsonModel<VpnGatewayPacketCaptureStopContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnGatewayPacketCaptureStopContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VpnGatewayPacketCaptureStopContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStopContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStopContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SasUri))
            {
                writer.WritePropertyName("sasUrl"u8);
                writer.WriteStringValue(SasUri.AbsoluteUri);
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

        VpnGatewayPacketCaptureStopContent IJsonModel<VpnGatewayPacketCaptureStopContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStopContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStopContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnGatewayPacketCaptureStopContent(document.RootElement, options);
        }

        internal static VpnGatewayPacketCaptureStopContent DeserializeVpnGatewayPacketCaptureStopContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri sasUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sasUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VpnGatewayPacketCaptureStopContent(sasUrl, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnGatewayPacketCaptureStopContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStopContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStopContent)} does not support writing '{options.Format}' format.");
            }
        }

        VpnGatewayPacketCaptureStopContent IPersistableModel<VpnGatewayPacketCaptureStopContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnGatewayPacketCaptureStopContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVpnGatewayPacketCaptureStopContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnGatewayPacketCaptureStopContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnGatewayPacketCaptureStopContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
