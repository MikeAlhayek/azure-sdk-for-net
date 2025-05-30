// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupVaultProperties : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupVaultProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataProtectionBackupVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupVaultProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MonitoringSettings))
            {
                writer.WritePropertyName("monitoringSettings"u8);
                writer.WriteObjectValue(MonitoringSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceMoveState))
            {
                writer.WritePropertyName("resourceMoveState"u8);
                writer.WriteStringValue(ResourceMoveState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceMoveDetails))
            {
                writer.WritePropertyName("resourceMoveDetails"u8);
                writer.WriteObjectValue(ResourceMoveDetails, options);
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings, options);
            }
            writer.WritePropertyName("storageSettings"u8);
            writer.WriteStartArray();
            foreach (var item in StorageSettings)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(IsVaultProtectedByResourceGuard))
            {
                writer.WritePropertyName("isVaultProtectedByResourceGuard"u8);
                writer.WriteBooleanValue(IsVaultProtectedByResourceGuard.Value);
            }
            if (Optional.IsDefined(FeatureSettings))
            {
                writer.WritePropertyName("featureSettings"u8);
                writer.WriteObjectValue(FeatureSettings, options);
            }
            if (options.Format != "W" && Optional.IsDefined(SecureScore))
            {
                writer.WritePropertyName("secureScore"u8);
                writer.WriteStringValue(SecureScore.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(BcdrSecurityLevel))
            {
                writer.WritePropertyName("bcdrSecurityLevel"u8);
                writer.WriteStringValue(BcdrSecurityLevel.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ResourceGuardOperationRequests))
            {
                writer.WritePropertyName("resourceGuardOperationRequests"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceGuardOperationRequests)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ReplicatedRegions))
            {
                writer.WritePropertyName("replicatedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in ReplicatedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        DataProtectionBackupVaultProperties IJsonModel<DataProtectionBackupVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupVaultProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupVaultProperties(document.RootElement, options);
        }

        internal static DataProtectionBackupVaultProperties DeserializeDataProtectionBackupVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitoringSettings monitoringSettings = default;
            DataProtectionBackupProvisioningState? provisioningState = default;
            BackupVaultResourceMoveState? resourceMoveState = default;
            BackupVaultResourceMoveDetails resourceMoveDetails = default;
            BackupVaultSecuritySettings securitySettings = default;
            IList<DataProtectionBackupStorageSetting> storageSettings = default;
            bool? isVaultProtectedByResourceGuard = default;
            BackupVaultFeatureSettings featureSettings = default;
            BackupVaultSecureScoreLevel? secureScore = default;
            BcdrSecurityLevel? bcdrSecurityLevel = default;
            IList<string> resourceGuardOperationRequests = default;
            IList<AzureLocation> replicatedRegions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monitoringSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSettings = MonitoringSettings.DeserializeMonitoringSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataProtectionBackupProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceMoveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMoveState = new BackupVaultResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceMoveDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceMoveDetails = BackupVaultResourceMoveDetails.DeserializeBackupVaultResourceMoveDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySettings = BackupVaultSecuritySettings.DeserializeBackupVaultSecuritySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storageSettings"u8))
                {
                    List<DataProtectionBackupStorageSetting> array = new List<DataProtectionBackupStorageSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataProtectionBackupStorageSetting.DeserializeDataProtectionBackupStorageSetting(item, options));
                    }
                    storageSettings = array;
                    continue;
                }
                if (property.NameEquals("isVaultProtectedByResourceGuard"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVaultProtectedByResourceGuard = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("featureSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featureSettings = BackupVaultFeatureSettings.DeserializeBackupVaultFeatureSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secureScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureScore = new BackupVaultSecureScoreLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bcdrSecurityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bcdrSecurityLevel = new BcdrSecurityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceGuardOperationRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    resourceGuardOperationRequests = array;
                    continue;
                }
                if (property.NameEquals("replicatedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    replicatedRegions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataProtectionBackupVaultProperties(
                monitoringSettings,
                provisioningState,
                resourceMoveState,
                resourceMoveDetails,
                securitySettings,
                storageSettings,
                isVaultProtectedByResourceGuard,
                featureSettings,
                secureScore,
                bcdrSecurityLevel,
                resourceGuardOperationRequests ?? new ChangeTrackingList<string>(),
                replicatedRegions ?? new ChangeTrackingList<AzureLocation>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProtectionBackupVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDataProtectionBackupContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupVaultProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DataProtectionBackupVaultProperties IPersistableModel<DataProtectionBackupVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDataProtectionBackupVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupVaultProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
