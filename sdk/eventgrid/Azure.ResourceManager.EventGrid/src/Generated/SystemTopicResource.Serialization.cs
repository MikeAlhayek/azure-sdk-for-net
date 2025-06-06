// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class SystemTopicResource : IJsonModel<SystemTopicData>
    {
        void IJsonModel<SystemTopicData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SystemTopicData>)Data).Write(writer, options);

        SystemTopicData IJsonModel<SystemTopicData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SystemTopicData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SystemTopicData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SystemTopicData>(Data, options, AzureResourceManagerEventGridContext.Default);

        SystemTopicData IPersistableModel<SystemTopicData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SystemTopicData>(data, options, AzureResourceManagerEventGridContext.Default);

        string IPersistableModel<SystemTopicData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SystemTopicData>)Data).GetFormatFromOptions(options);
    }
}
