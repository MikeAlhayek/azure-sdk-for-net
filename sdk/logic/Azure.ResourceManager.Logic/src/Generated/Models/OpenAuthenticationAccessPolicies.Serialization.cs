// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    internal partial class OpenAuthenticationAccessPolicies : IUtf8JsonSerializable, IJsonModel<OpenAuthenticationAccessPolicies>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenAuthenticationAccessPolicies>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenAuthenticationAccessPolicies>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicies)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AccessPolicies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartObject();
                foreach (var item in AccessPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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

        OpenAuthenticationAccessPolicies IJsonModel<OpenAuthenticationAccessPolicies>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicies>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicies)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAuthenticationAccessPolicies(document.RootElement, options);
        }

        internal static OpenAuthenticationAccessPolicies DeserializeOpenAuthenticationAccessPolicies(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, OpenAuthenticationAccessPolicy> policies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, OpenAuthenticationAccessPolicy> dictionary = new Dictionary<string, OpenAuthenticationAccessPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, OpenAuthenticationAccessPolicy.DeserializeOpenAuthenticationAccessPolicy(property0.Value, options));
                    }
                    policies = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenAuthenticationAccessPolicies(policies ?? new ChangeTrackingDictionary<string, OpenAuthenticationAccessPolicy>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenAuthenticationAccessPolicies>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerLogicContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicies)} does not support writing '{options.Format}' format.");
            }
        }

        OpenAuthenticationAccessPolicies IPersistableModel<OpenAuthenticationAccessPolicies>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicies>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOpenAuthenticationAccessPolicies(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicies)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenAuthenticationAccessPolicies>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
