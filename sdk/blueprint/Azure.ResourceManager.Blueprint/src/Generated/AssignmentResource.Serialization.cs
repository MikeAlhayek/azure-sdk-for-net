// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Blueprint
{
    public partial class AssignmentResource : IJsonModel<AssignmentData>
    {
        void IJsonModel<AssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AssignmentData>)Data).Write(writer, options);

        AssignmentData IJsonModel<AssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AssignmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AssignmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AssignmentData>(Data, options, AzureResourceManagerBlueprintContext.Default);

        AssignmentData IPersistableModel<AssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AssignmentData>(data, options, AzureResourceManagerBlueprintContext.Default);

        string IPersistableModel<AssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AssignmentData>)Data).GetFormatFromOptions(options);
    }
}
