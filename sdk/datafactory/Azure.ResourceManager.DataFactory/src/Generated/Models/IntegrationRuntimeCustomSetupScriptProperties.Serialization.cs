// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class IntegrationRuntimeCustomSetupScriptProperties : IUtf8JsonSerializable, IJsonModel<IntegrationRuntimeCustomSetupScriptProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IntegrationRuntimeCustomSetupScriptProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IntegrationRuntimeCustomSetupScriptProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeCustomSetupScriptProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BlobContainerUri))
            {
                writer.WritePropertyName("blobContainerUri"u8);
                writer.WriteStringValue(BlobContainerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SasToken))
            {
                writer.WritePropertyName("sasToken"u8);
                JsonSerializer.Serialize(writer, SasToken);
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

        IntegrationRuntimeCustomSetupScriptProperties IJsonModel<IntegrationRuntimeCustomSetupScriptProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IntegrationRuntimeCustomSetupScriptProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationRuntimeCustomSetupScriptProperties(document.RootElement, options);
        }

        internal static IntegrationRuntimeCustomSetupScriptProperties DeserializeIntegrationRuntimeCustomSetupScriptProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri blobContainerUri = default;
            DataFactorySecretString sasToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobContainerUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobContainerUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sasToken = JsonSerializer.Deserialize<DataFactorySecretString>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IntegrationRuntimeCustomSetupScriptProperties(blobContainerUri, sasToken, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataFactoryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeCustomSetupScriptProperties)} does not support writing '{options.Format}' format.");
            }
        }

        IntegrationRuntimeCustomSetupScriptProperties IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIntegrationRuntimeCustomSetupScriptProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IntegrationRuntimeCustomSetupScriptProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IntegrationRuntimeCustomSetupScriptProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
