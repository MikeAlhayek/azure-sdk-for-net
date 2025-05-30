// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Type.Property.ValueTypes
{
    public partial class StringLiteralProperty : IJsonModel<StringLiteralProperty>
    {
        void IJsonModel<StringLiteralProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options) => throw null;

        StringLiteralProperty IJsonModel<StringLiteralProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        protected virtual StringLiteralProperty JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => throw null;

        BinaryData IPersistableModel<StringLiteralProperty>.Write(ModelReaderWriterOptions options) => throw null;

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options) => throw null;

        StringLiteralProperty IPersistableModel<StringLiteralProperty>.Create(BinaryData data, ModelReaderWriterOptions options) => throw null;

        protected virtual StringLiteralProperty PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options) => throw null;

        string IPersistableModel<StringLiteralProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => throw null;

        /// <param name="stringLiteralProperty"> The <see cref="StringLiteralProperty"/> to serialize into <see cref="RequestContent"/>. </param>
        public static implicit operator RequestContent(StringLiteralProperty stringLiteralProperty) => throw null;

        public static explicit operator StringLiteralProperty(Response result) => throw null;
    }
}
