// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceTagOperationLinkResource : IJsonModel<TagOperationLinkContractData>
    {
        void IJsonModel<TagOperationLinkContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<TagOperationLinkContractData>)Data).Write(writer, options);

        TagOperationLinkContractData IJsonModel<TagOperationLinkContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<TagOperationLinkContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<TagOperationLinkContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<TagOperationLinkContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        TagOperationLinkContractData IPersistableModel<TagOperationLinkContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<TagOperationLinkContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<TagOperationLinkContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<TagOperationLinkContractData>)Data).GetFormatFromOptions(options);
    }
}
