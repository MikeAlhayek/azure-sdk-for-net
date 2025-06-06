// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    public partial class NotificationHubNetworkAcls : IUtf8JsonSerializable, IJsonModel<NotificationHubNetworkAcls>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationHubNetworkAcls>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NotificationHubNetworkAcls>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubNetworkAcls)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkRule))
            {
                writer.WritePropertyName("publicNetworkRule"u8);
                writer.WriteObjectValue(PublicNetworkRule, options);
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

        NotificationHubNetworkAcls IJsonModel<NotificationHubNetworkAcls>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationHubNetworkAcls)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubNetworkAcls(document.RootElement, options);
        }

        internal static NotificationHubNetworkAcls DeserializeNotificationHubNetworkAcls(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<NotificationHubIPRule> ipRules = default;
            PublicInternetAuthorizationRule publicNetworkRule = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationHubIPRule> array = new List<NotificationHubIPRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationHubIPRule.DeserializeNotificationHubIPRule(item, options));
                    }
                    ipRules = array;
                    continue;
                }
                if (property.NameEquals("publicNetworkRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkRule = PublicInternetAuthorizationRule.DeserializePublicInternetAuthorizationRule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NotificationHubNetworkAcls(ipRules ?? new ChangeTrackingList<NotificationHubIPRule>(), publicNetworkRule, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationHubNetworkAcls>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNotificationHubsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(NotificationHubNetworkAcls)} does not support writing '{options.Format}' format.");
            }
        }

        NotificationHubNetworkAcls IPersistableModel<NotificationHubNetworkAcls>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationHubNetworkAcls>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeNotificationHubNetworkAcls(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationHubNetworkAcls)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationHubNetworkAcls>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
