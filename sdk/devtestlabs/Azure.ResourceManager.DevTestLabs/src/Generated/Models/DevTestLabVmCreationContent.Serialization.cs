// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabVmCreationContent : IUtf8JsonSerializable, IJsonModel<DevTestLabVmCreationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabVmCreationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabVmCreationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmCreationContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BulkCreationParameters))
            {
                writer.WritePropertyName("bulkCreationParameters"u8);
                writer.WriteObjectValue(BulkCreationParameters, options);
            }
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsDefined(OwnerObjectId))
            {
                writer.WritePropertyName("ownerObjectId"u8);
                writer.WriteStringValue(OwnerObjectId);
            }
            if (Optional.IsDefined(OwnerUserPrincipalName))
            {
                writer.WritePropertyName("ownerUserPrincipalName"u8);
                writer.WriteStringValue(OwnerUserPrincipalName);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(CustomImageId))
            {
                writer.WritePropertyName("customImageId"u8);
                writer.WriteStringValue(CustomImageId);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size"u8);
                writer.WriteStringValue(Size);
            }
            if (Optional.IsDefined(UserName))
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (Optional.IsDefined(SshKey))
            {
                writer.WritePropertyName("sshKey"u8);
                writer.WriteStringValue(SshKey);
            }
            if (Optional.IsDefined(IsAuthenticationWithSshKey))
            {
                writer.WritePropertyName("isAuthenticationWithSshKey"u8);
                writer.WriteBooleanValue(IsAuthenticationWithSshKey.Value);
            }
            if (Optional.IsDefined(LabSubnetName))
            {
                writer.WritePropertyName("labSubnetName"u8);
                writer.WriteStringValue(LabSubnetName);
            }
            if (Optional.IsDefined(LabVirtualNetworkId))
            {
                writer.WritePropertyName("labVirtualNetworkId"u8);
                writer.WriteStringValue(LabVirtualNetworkId);
            }
            if (Optional.IsDefined(DisallowPublicIPAddress))
            {
                writer.WritePropertyName("disallowPublicIpAddress"u8);
                writer.WriteBooleanValue(DisallowPublicIPAddress.Value);
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference"u8);
                writer.WriteObjectValue(GalleryImageReference, options);
            }
            if (Optional.IsDefined(PlanId))
            {
                writer.WritePropertyName("planId"u8);
                writer.WriteStringValue(PlanId);
            }
            if (Optional.IsDefined(NetworkInterface))
            {
                writer.WritePropertyName("networkInterface"u8);
                writer.WriteObjectValue(NetworkInterface, options);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Optional.IsDefined(AllowClaim))
            {
                writer.WritePropertyName("allowClaim"u8);
                writer.WriteBooleanValue(AllowClaim.Value);
            }
            if (Optional.IsDefined(StorageType))
            {
                writer.WritePropertyName("storageType"u8);
                writer.WriteStringValue(StorageType);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(DataDiskParameters))
            {
                writer.WritePropertyName("dataDiskParameters"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScheduleParameters))
            {
                writer.WritePropertyName("scheduleParameters"u8);
                writer.WriteStartArray();
                foreach (var item in ScheduleParameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        DevTestLabVmCreationContent IJsonModel<DevTestLabVmCreationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmCreationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabVmCreationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabVmCreationContent(document.RootElement, options);
        }

        internal static DevTestLabVmCreationContent DeserializeDevTestLabVmCreationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AzureLocation? location = default;
            IDictionary<string, string> tags = default;
            BulkCreationParameters bulkCreationParameters = default;
            string notes = default;
            string ownerObjectId = default;
            string ownerUserPrincipalName = default;
            DateTimeOffset? createdDate = default;
            string customImageId = default;
            string size = default;
            string userName = default;
            string password = default;
            string sshKey = default;
            bool? isAuthenticationWithSshKey = default;
            string labSubnetName = default;
            ResourceIdentifier labVirtualNetworkId = default;
            bool? disallowPublicIPAddress = default;
            IList<DevTestLabArtifactInstallInfo> artifacts = default;
            DevTestLabGalleryImageReference galleryImageReference = default;
            string planId = default;
            DevTestLabNetworkInterface networkInterface = default;
            DateTimeOffset? expirationDate = default;
            bool? allowClaim = default;
            string storageType = default;
            string environmentId = default;
            IList<DevTestLabDataDiskProperties> dataDiskParameters = default;
            IList<DevTestLabScheduleCreationParameter> scheduleParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("bulkCreationParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bulkCreationParameters = BulkCreationParameters.DeserializeBulkCreationParameters(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerObjectId"u8))
                        {
                            ownerObjectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ownerUserPrincipalName"u8))
                        {
                            ownerUserPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("customImageId"u8))
                        {
                            customImageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sshKey"u8))
                        {
                            sshKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isAuthenticationWithSshKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAuthenticationWithSshKey = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("labSubnetName"u8))
                        {
                            labSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("labVirtualNetworkId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labVirtualNetworkId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disallowPublicIpAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disallowPublicIPAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabArtifactInstallInfo> array = new List<DevTestLabArtifactInstallInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabArtifactInstallInfo.DeserializeDevTestLabArtifactInstallInfo(item, options));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("galleryImageReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            galleryImageReference = DevTestLabGalleryImageReference.DeserializeDevTestLabGalleryImageReference(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("planId"u8))
                        {
                            planId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkInterface"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkInterface = DevTestLabNetworkInterface.DeserializeDevTestLabNetworkInterface(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("expirationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("allowClaim"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowClaim = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("storageType"u8))
                        {
                            storageType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("environmentId"u8))
                        {
                            environmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataDiskParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabDataDiskProperties> array = new List<DevTestLabDataDiskProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabDataDiskProperties.DeserializeDevTestLabDataDiskProperties(item, options));
                            }
                            dataDiskParameters = array;
                            continue;
                        }
                        if (property0.NameEquals("scheduleParameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabScheduleCreationParameter> array = new List<DevTestLabScheduleCreationParameter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabScheduleCreationParameter.DeserializeDevTestLabScheduleCreationParameter(item, options));
                            }
                            scheduleParameters = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabVmCreationContent(
                name,
                location,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                bulkCreationParameters,
                notes,
                ownerObjectId,
                ownerUserPrincipalName,
                createdDate,
                customImageId,
                size,
                userName,
                password,
                sshKey,
                isAuthenticationWithSshKey,
                labSubnetName,
                labVirtualNetworkId,
                disallowPublicIPAddress,
                artifacts ?? new ChangeTrackingList<DevTestLabArtifactInstallInfo>(),
                galleryImageReference,
                planId,
                networkInterface,
                expirationDate,
                allowClaim,
                storageType,
                environmentId,
                dataDiskParameters ?? new ChangeTrackingList<DevTestLabDataDiskProperties>(),
                scheduleParameters ?? new ChangeTrackingList<DevTestLabScheduleCreationParameter>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabVmCreationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevTestLabsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmCreationContent)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabVmCreationContent IPersistableModel<DevTestLabVmCreationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabVmCreationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabVmCreationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabVmCreationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabVmCreationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
