// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class OpenApiManagedAuthDetails : IUtf8JsonSerializable, IJsonModel<OpenApiManagedAuthDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenApiManagedAuthDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenApiManagedAuthDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiManagedAuthDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiManagedAuthDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("security_scheme"u8);
            writer.WriteObjectValue(SecurityScheme, options);
        }

        OpenApiManagedAuthDetails IJsonModel<OpenApiManagedAuthDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiManagedAuthDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiManagedAuthDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenApiManagedAuthDetails(document.RootElement, options);
        }

        internal static OpenApiManagedAuthDetails DeserializeOpenApiManagedAuthDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OpenApiManagedSecurityScheme securityScheme = default;
            OpenApiAuthType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("security_scheme"u8))
                {
                    securityScheme = OpenApiManagedSecurityScheme.DeserializeOpenApiManagedSecurityScheme(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new OpenApiAuthType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenApiManagedAuthDetails(type, serializedAdditionalRawData, securityScheme);
        }

        BinaryData IPersistableModel<OpenApiManagedAuthDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiManagedAuthDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIProjectsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OpenApiManagedAuthDetails)} does not support writing '{options.Format}' format.");
            }
        }

        OpenApiManagedAuthDetails IPersistableModel<OpenApiManagedAuthDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiManagedAuthDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOpenApiManagedAuthDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenApiManagedAuthDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenApiManagedAuthDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new OpenApiManagedAuthDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeOpenApiManagedAuthDetails(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
