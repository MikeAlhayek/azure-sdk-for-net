// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Billing.Models
{
    public partial class InvoiceSectionWithCreateSubPermission : IUtf8JsonSerializable, IJsonModel<InvoiceSectionWithCreateSubPermission>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InvoiceSectionWithCreateSubPermission>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InvoiceSectionWithCreateSubPermission>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InvoiceSectionWithCreateSubPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InvoiceSectionWithCreateSubPermission)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(BillingProfileDisplayName))
            {
                writer.WritePropertyName("billingProfileDisplayName"u8);
                writer.WriteStringValue(BillingProfileDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileId))
            {
                writer.WritePropertyName("billingProfileId"u8);
                writer.WriteStringValue(BillingProfileId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileSystemId))
            {
                writer.WritePropertyName("billingProfileSystemId"u8);
                writer.WriteStringValue(BillingProfileSystemId);
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileStatus))
            {
                writer.WritePropertyName("billingProfileStatus"u8);
                writer.WriteStringValue(BillingProfileStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileStatusReasonCode))
            {
                writer.WritePropertyName("billingProfileStatusReasonCode"u8);
                writer.WriteStringValue(BillingProfileStatusReasonCode.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BillingProfileSpendingLimit))
            {
                writer.WritePropertyName("billingProfileSpendingLimit"u8);
                writer.WriteStringValue(BillingProfileSpendingLimit.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(EnabledAzurePlans))
            {
                writer.WritePropertyName("enabledAzurePlans"u8);
                writer.WriteStartArray();
                foreach (var item in EnabledAzurePlans)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionDisplayName))
            {
                writer.WritePropertyName("invoiceSectionDisplayName"u8);
                writer.WriteStringValue(InvoiceSectionDisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionId))
            {
                writer.WritePropertyName("invoiceSectionId"u8);
                writer.WriteStringValue(InvoiceSectionId);
            }
            if (options.Format != "W" && Optional.IsDefined(InvoiceSectionSystemId))
            {
                writer.WritePropertyName("invoiceSectionSystemId"u8);
                writer.WriteStringValue(InvoiceSectionSystemId);
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

        InvoiceSectionWithCreateSubPermission IJsonModel<InvoiceSectionWithCreateSubPermission>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InvoiceSectionWithCreateSubPermission>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InvoiceSectionWithCreateSubPermission)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInvoiceSectionWithCreateSubPermission(document.RootElement, options);
        }

        internal static InvoiceSectionWithCreateSubPermission DeserializeInvoiceSectionWithCreateSubPermission(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string billingProfileDisplayName = default;
            ResourceIdentifier billingProfileId = default;
            string billingProfileSystemId = default;
            BillingProfileStatus? billingProfileStatus = default;
            BillingProfileStatusReasonCode? billingProfileStatusReasonCode = default;
            BillingSpendingLimit? billingProfileSpendingLimit = default;
            IReadOnlyList<BillingAzurePlan> enabledAzurePlans = default;
            string invoiceSectionDisplayName = default;
            ResourceIdentifier invoiceSectionId = default;
            string invoiceSectionSystemId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingProfileDisplayName"u8))
                {
                    billingProfileDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingProfileId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfileId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfileSystemId"u8))
                {
                    billingProfileSystemId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("billingProfileStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfileStatus = new BillingProfileStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfileStatusReasonCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfileStatusReasonCode = new BillingProfileStatusReasonCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfileSpendingLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingProfileSpendingLimit = new BillingSpendingLimit(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enabledAzurePlans"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingAzurePlan> array = new List<BillingAzurePlan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingAzurePlan.DeserializeBillingAzurePlan(item, options));
                    }
                    enabledAzurePlans = array;
                    continue;
                }
                if (property.NameEquals("invoiceSectionDisplayName"u8))
                {
                    invoiceSectionDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("invoiceSectionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invoiceSectionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("invoiceSectionSystemId"u8))
                {
                    invoiceSectionSystemId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InvoiceSectionWithCreateSubPermission(
                billingProfileDisplayName,
                billingProfileId,
                billingProfileSystemId,
                billingProfileStatus,
                billingProfileStatusReasonCode,
                billingProfileSpendingLimit,
                enabledAzurePlans ?? new ChangeTrackingList<BillingAzurePlan>(),
                invoiceSectionDisplayName,
                invoiceSectionId,
                invoiceSectionSystemId,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileDisplayName))
                {
                    builder.Append("  billingProfileDisplayName: ");
                    if (BillingProfileDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingProfileDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingProfileDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileId))
                {
                    builder.Append("  billingProfileId: ");
                    builder.AppendLine($"'{BillingProfileId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileSystemId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileSystemId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileSystemId))
                {
                    builder.Append("  billingProfileSystemId: ");
                    if (BillingProfileSystemId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{BillingProfileSystemId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{BillingProfileSystemId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileStatus), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileStatus: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileStatus))
                {
                    builder.Append("  billingProfileStatus: ");
                    builder.AppendLine($"'{BillingProfileStatus.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileStatusReasonCode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileStatusReasonCode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileStatusReasonCode))
                {
                    builder.Append("  billingProfileStatusReasonCode: ");
                    builder.AppendLine($"'{BillingProfileStatusReasonCode.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BillingProfileSpendingLimit), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  billingProfileSpendingLimit: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(BillingProfileSpendingLimit))
                {
                    builder.Append("  billingProfileSpendingLimit: ");
                    builder.AppendLine($"'{BillingProfileSpendingLimit.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnabledAzurePlans), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabledAzurePlans: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(EnabledAzurePlans))
                {
                    if (EnabledAzurePlans.Any())
                    {
                        builder.Append("  enabledAzurePlans: ");
                        builder.AppendLine("[");
                        foreach (var item in EnabledAzurePlans)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  enabledAzurePlans: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InvoiceSectionDisplayName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  invoiceSectionDisplayName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InvoiceSectionDisplayName))
                {
                    builder.Append("  invoiceSectionDisplayName: ");
                    if (InvoiceSectionDisplayName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InvoiceSectionDisplayName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InvoiceSectionDisplayName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InvoiceSectionId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  invoiceSectionId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InvoiceSectionId))
                {
                    builder.Append("  invoiceSectionId: ");
                    builder.AppendLine($"'{InvoiceSectionId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(InvoiceSectionSystemId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  invoiceSectionSystemId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(InvoiceSectionSystemId))
                {
                    builder.Append("  invoiceSectionSystemId: ");
                    if (InvoiceSectionSystemId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{InvoiceSectionSystemId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{InvoiceSectionSystemId}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<InvoiceSectionWithCreateSubPermission>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InvoiceSectionWithCreateSubPermission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerBillingContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(InvoiceSectionWithCreateSubPermission)} does not support writing '{options.Format}' format.");
            }
        }

        InvoiceSectionWithCreateSubPermission IPersistableModel<InvoiceSectionWithCreateSubPermission>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InvoiceSectionWithCreateSubPermission>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeInvoiceSectionWithCreateSubPermission(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InvoiceSectionWithCreateSubPermission)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InvoiceSectionWithCreateSubPermission>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
