// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentWhatIfProperties : IUtf8JsonSerializable, IJsonModel<ArmDeploymentWhatIfProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentWhatIfProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ArmDeploymentWhatIfProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(WhatIfSettings))
            {
                writer.WritePropertyName("whatIfSettings"u8);
                writer.WriteObjectValue(WhatIfSettings, options);
            }
        }

        ArmDeploymentWhatIfProperties IJsonModel<ArmDeploymentWhatIfProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentWhatIfProperties(document.RootElement, options);
        }

        internal static ArmDeploymentWhatIfProperties DeserializeArmDeploymentWhatIfProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmDeploymentWhatIfSettings whatIfSettings = default;
            BinaryData template = default;
            ArmDeploymentTemplateLink templateLink = default;
            BinaryData parameters = default;
            ArmDeploymentParametersLink parametersLink = default;
            ArmDeploymentMode mode = default;
            DebugSetting debugSetting = default;
            ErrorDeployment onErrorDeployment = default;
            ExpressionEvaluationOptions expressionEvaluationOptions = default;
            ValidationLevel? validationLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("whatIfSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    whatIfSettings = ArmDeploymentWhatIfSettings.DeserializeArmDeploymentWhatIfSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("template"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    template = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("templateLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateLink = ArmDeploymentTemplateLink.DeserializeArmDeploymentTemplateLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("parametersLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parametersLink = ArmDeploymentParametersLink.DeserializeArmDeploymentParametersLink(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = property.Value.GetString().ToArmDeploymentMode();
                    continue;
                }
                if (property.NameEquals("debugSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    debugSetting = DebugSetting.DeserializeDebugSetting(property.Value, options);
                    continue;
                }
                if (property.NameEquals("onErrorDeployment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onErrorDeployment = ErrorDeployment.DeserializeErrorDeployment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("expressionEvaluationOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expressionEvaluationOptions = ExpressionEvaluationOptions.DeserializeExpressionEvaluationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("validationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationLevel = new ValidationLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ArmDeploymentWhatIfProperties(
                template,
                templateLink,
                parameters,
                parametersLink,
                mode,
                debugSetting,
                onErrorDeployment,
                expressionEvaluationOptions,
                validationLevel,
                serializedAdditionalRawData,
                whatIfSettings);
        }

        BinaryData IPersistableModel<ArmDeploymentWhatIfProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourcesContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ArmDeploymentWhatIfProperties IPersistableModel<ArmDeploymentWhatIfProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentWhatIfProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeArmDeploymentWhatIfProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentWhatIfProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmDeploymentWhatIfProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
