// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class DefenderForContainersAwsOfferingCloudWatchToKinesis : IUtf8JsonSerializable, IJsonModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingCloudWatchToKinesis)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        DefenderForContainersAwsOfferingCloudWatchToKinesis IJsonModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingCloudWatchToKinesis)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(document.RootElement, options);
        }

        internal static DefenderForContainersAwsOfferingCloudWatchToKinesis DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string cloudRoleArn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForContainersAwsOfferingCloudWatchToKinesis(cloudRoleArn, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingCloudWatchToKinesis)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForContainersAwsOfferingCloudWatchToKinesis IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDefenderForContainersAwsOfferingCloudWatchToKinesis(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersAwsOfferingCloudWatchToKinesis)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForContainersAwsOfferingCloudWatchToKinesis>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
