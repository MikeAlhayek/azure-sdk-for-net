// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Compute
{
    public partial class GalleryResource : IJsonModel<GalleryData>
    {
        void IJsonModel<GalleryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GalleryData>)Data).Write(writer, options);

        GalleryData IJsonModel<GalleryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GalleryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GalleryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<GalleryData>(Data, options, AzureResourceManagerComputeContext.Default);

        GalleryData IPersistableModel<GalleryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GalleryData>(data, options, AzureResourceManagerComputeContext.Default);

        string IPersistableModel<GalleryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GalleryData>)Data).GetFormatFromOptions(options);
    }
}
