// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArmResourceDefinitionResourceElementTemplateDetails : IUtf8JsonSerializable, IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                writer.WriteObjectValue(Configuration, options);
            }
        }

        ArmResourceDefinitionResourceElementTemplateDetails IJsonModel<ArmResourceDefinitionResourceElementTemplateDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmResourceDefinitionResourceElementTemplateDetails(document.RootElement, options);
        }

        internal static ArmResourceDefinitionResourceElementTemplateDetails DeserializeArmResourceDefinitionResourceElementTemplateDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmResourceDefinitionResourceElementTemplate configuration = default;
            string name = default;
            Type type = default;
            DependsOnProfile dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ArmResourceDefinitionResourceElementTemplate.DeserializeArmResourceDefinitionResourceElementTemplate(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new Type(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmResourceDefinitionResourceElementTemplateDetails(name, type, dependsOnProfile, serializedAdditionalRawData, configuration);
        }

        BinaryData IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support writing '{options.Format}' format.");
            }
        }

        ArmResourceDefinitionResourceElementTemplateDetails IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeArmResourceDefinitionResourceElementTemplateDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmResourceDefinitionResourceElementTemplateDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmResourceDefinitionResourceElementTemplateDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
