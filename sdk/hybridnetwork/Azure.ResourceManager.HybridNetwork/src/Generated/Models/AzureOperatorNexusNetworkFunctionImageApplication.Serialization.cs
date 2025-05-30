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
    public partial class AzureOperatorNexusNetworkFunctionImageApplication : IUtf8JsonSerializable, IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(ArtifactProfile))
            {
                writer.WritePropertyName("artifactProfile"u8);
                writer.WriteObjectValue(ArtifactProfile, options);
            }
            if (Optional.IsDefined(DeployParametersMappingRuleProfile))
            {
                writer.WritePropertyName("deployParametersMappingRuleProfile"u8);
                writer.WriteObjectValue(DeployParametersMappingRuleProfile, options);
            }
        }

        AzureOperatorNexusNetworkFunctionImageApplication IJsonModel<AzureOperatorNexusNetworkFunctionImageApplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureOperatorNexusNetworkFunctionImageApplication(document.RootElement, options);
        }

        internal static AzureOperatorNexusNetworkFunctionImageApplication DeserializeAzureOperatorNexusNetworkFunctionImageApplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureOperatorNexusImageArtifactProfile artifactProfile = default;
            AzureOperatorNexusImageDeployMappingRuleProfile deployParametersMappingRuleProfile = default;
            AzureOperatorNexusArtifactType artifactType = default;
            string name = default;
            DependsOnProfile dependsOnProfile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactProfile = AzureOperatorNexusImageArtifactProfile.DeserializeAzureOperatorNexusImageArtifactProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deployParametersMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deployParametersMappingRuleProfile = AzureOperatorNexusImageDeployMappingRuleProfile.DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureOperatorNexusArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
            return new AzureOperatorNexusNetworkFunctionImageApplication(
                name,
                dependsOnProfile,
                serializedAdditionalRawData,
                artifactType,
                artifactProfile,
                deployParametersMappingRuleProfile);
        }

        BinaryData IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support writing '{options.Format}' format.");
            }
        }

        AzureOperatorNexusNetworkFunctionImageApplication IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureOperatorNexusNetworkFunctionImageApplication(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureOperatorNexusNetworkFunctionImageApplication)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureOperatorNexusNetworkFunctionImageApplication>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
