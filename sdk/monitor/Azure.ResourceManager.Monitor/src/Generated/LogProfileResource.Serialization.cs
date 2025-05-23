// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Monitor
{
    public partial class LogProfileResource : IJsonModel<LogProfileData>
    {
        void IJsonModel<LogProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LogProfileData>)Data).Write(writer, options);

        LogProfileData IJsonModel<LogProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LogProfileData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LogProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<LogProfileData>(Data, options, AzureResourceManagerMonitorContext.Default);

        LogProfileData IPersistableModel<LogProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LogProfileData>(data, options, AzureResourceManagerMonitorContext.Default);

        string IPersistableModel<LogProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LogProfileData>)Data).GetFormatFromOptions(options);
    }
}
