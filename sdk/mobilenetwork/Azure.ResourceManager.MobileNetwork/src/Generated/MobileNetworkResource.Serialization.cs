// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MobileNetwork
{
    public partial class MobileNetworkResource : IJsonModel<MobileNetworkData>
    {
        void IJsonModel<MobileNetworkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkData>)Data).Write(writer, options);

        MobileNetworkData IJsonModel<MobileNetworkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MobileNetworkData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MobileNetworkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MobileNetworkData>(Data, options, AzureResourceManagerMobileNetworkContext.Default);

        MobileNetworkData IPersistableModel<MobileNetworkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MobileNetworkData>(data, options, AzureResourceManagerMobileNetworkContext.Default);

        string IPersistableModel<MobileNetworkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MobileNetworkData>)Data).GetFormatFromOptions(options);
    }
}
