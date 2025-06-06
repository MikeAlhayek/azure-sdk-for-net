// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class RuleManagementEventDataSource : IUtf8JsonSerializable, IJsonModel<RuleManagementEventDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RuleManagementEventDataSource>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RuleManagementEventDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleManagementEventDataSource)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(EventName))
            {
                writer.WritePropertyName("eventName"u8);
                writer.WriteStringValue(EventName);
            }
            if (Optional.IsDefined(EventSource))
            {
                writer.WritePropertyName("eventSource"u8);
                writer.WriteStringValue(EventSource);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level);
            }
            if (Optional.IsDefined(OperationName))
            {
                writer.WritePropertyName("operationName"u8);
                writer.WriteStringValue(OperationName);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(ResourceProviderName))
            {
                writer.WritePropertyName("resourceProviderName"u8);
                writer.WriteStringValue(ResourceProviderName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SubStatus))
            {
                writer.WritePropertyName("subStatus"u8);
                writer.WriteStringValue(SubStatus);
            }
            if (Optional.IsDefined(Claims))
            {
                writer.WritePropertyName("claims"u8);
                writer.WriteObjectValue(Claims, options);
            }
        }

        RuleManagementEventDataSource IJsonModel<RuleManagementEventDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RuleManagementEventDataSource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRuleManagementEventDataSource(document.RootElement, options);
        }

        internal static RuleManagementEventDataSource DeserializeRuleManagementEventDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string eventName = default;
            string eventSource = default;
            string level = default;
            string operationName = default;
            string resourceGroupName = default;
            string resourceProviderName = default;
            string status = default;
            string subStatus = default;
            RuleManagementEventClaimsDataSource claims = default;
            string odataType = default;
            ResourceIdentifier resourceUri = default;
            ResourceIdentifier legacyResourceId = default;
            string resourceLocation = default;
            string metricNamespace = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventName"u8))
                {
                    eventName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eventSource"u8))
                {
                    eventSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    level = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProviderName"u8))
                {
                    resourceProviderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subStatus"u8))
                {
                    subStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    claims = RuleManagementEventClaimsDataSource.DeserializeRuleManagementEventClaimsDataSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceUri = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("legacyResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    legacyResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    resourceLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricNamespace"u8))
                {
                    metricNamespace = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RuleManagementEventDataSource(
                odataType,
                resourceUri,
                legacyResourceId,
                resourceLocation,
                metricNamespace,
                serializedAdditionalRawData,
                eventName,
                eventSource,
                level,
                operationName,
                resourceGroupName,
                resourceProviderName,
                status,
                subStatus,
                claims);
        }

        BinaryData IPersistableModel<RuleManagementEventDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(RuleManagementEventDataSource)} does not support writing '{options.Format}' format.");
            }
        }

        RuleManagementEventDataSource IPersistableModel<RuleManagementEventDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RuleManagementEventDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeRuleManagementEventDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RuleManagementEventDataSource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RuleManagementEventDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
