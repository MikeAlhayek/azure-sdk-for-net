// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementProductResource : IJsonModel<ApiManagementProductData>
    {
        void IJsonModel<ApiManagementProductData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementProductData>)Data).Write(writer, options);

        ApiManagementProductData IJsonModel<ApiManagementProductData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementProductData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementProductData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ApiManagementProductData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        ApiManagementProductData IPersistableModel<ApiManagementProductData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementProductData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<ApiManagementProductData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementProductData>)Data).GetFormatFromOptions(options);
    }
}
