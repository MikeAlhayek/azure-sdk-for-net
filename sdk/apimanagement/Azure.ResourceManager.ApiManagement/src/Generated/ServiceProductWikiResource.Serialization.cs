// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceProductWikiResource : IJsonModel<WikiContractData>
    {
        void IJsonModel<WikiContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<WikiContractData>)Data).Write(writer, options);

        WikiContractData IJsonModel<WikiContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<WikiContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<WikiContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<WikiContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        WikiContractData IPersistableModel<WikiContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<WikiContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<WikiContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<WikiContractData>)Data).GetFormatFromOptions(options);
    }
}
