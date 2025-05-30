// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerGroupEncryptionProperties : IUtf8JsonSerializable, IJsonModel<ContainerGroupEncryptionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupEncryptionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerGroupEncryptionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupEncryptionProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("vaultBaseUrl"u8);
            writer.WriteStringValue(VaultBaseUri.AbsoluteUri);
            writer.WritePropertyName("keyName"u8);
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVersion"u8);
            writer.WriteStringValue(KeyVersion);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteStringValue(Identity);
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

        ContainerGroupEncryptionProperties IJsonModel<ContainerGroupEncryptionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupEncryptionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupEncryptionProperties(document.RootElement, options);
        }

        internal static ContainerGroupEncryptionProperties DeserializeContainerGroupEncryptionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri vaultBaseUrl = default;
            string keyName = default;
            string keyVersion = default;
            string identity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultBaseUrl"u8))
                {
                    vaultBaseUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerGroupEncryptionProperties(vaultBaseUrl, keyName, keyVersion, identity, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerGroupEncryptionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerInstanceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupEncryptionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerGroupEncryptionProperties IPersistableModel<ContainerGroupEncryptionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupEncryptionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerGroupEncryptionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupEncryptionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupEncryptionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
