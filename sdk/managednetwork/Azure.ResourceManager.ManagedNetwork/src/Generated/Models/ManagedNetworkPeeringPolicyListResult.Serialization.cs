// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetwork.Models
{
    internal partial class ManagedNetworkPeeringPolicyListResult : IUtf8JsonSerializable, IJsonModel<ManagedNetworkPeeringPolicyListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedNetworkPeeringPolicyListResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedNetworkPeeringPolicyListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkPeeringPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedNetworkPeeringPolicyListResult)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        ManagedNetworkPeeringPolicyListResult IJsonModel<ManagedNetworkPeeringPolicyListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkPeeringPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedNetworkPeeringPolicyListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedNetworkPeeringPolicyListResult(document.RootElement, options);
        }

        internal static ManagedNetworkPeeringPolicyListResult DeserializeManagedNetworkPeeringPolicyListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ManagedNetworkPeeringPolicyData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedNetworkPeeringPolicyData> array = new List<ManagedNetworkPeeringPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedNetworkPeeringPolicyData.DeserializeManagedNetworkPeeringPolicyData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedNetworkPeeringPolicyListResult(value ?? new ChangeTrackingList<ManagedNetworkPeeringPolicyData>(), nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedNetworkPeeringPolicyListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkPeeringPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerManagedNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ManagedNetworkPeeringPolicyListResult)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedNetworkPeeringPolicyListResult IPersistableModel<ManagedNetworkPeeringPolicyListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedNetworkPeeringPolicyListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedNetworkPeeringPolicyListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedNetworkPeeringPolicyListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedNetworkPeeringPolicyListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
