// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsIncidentTaskResource : IJsonModel<SecurityInsightsIncidentTaskData>
    {
        void IJsonModel<SecurityInsightsIncidentTaskData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsIncidentTaskData>)Data).Write(writer, options);

        SecurityInsightsIncidentTaskData IJsonModel<SecurityInsightsIncidentTaskData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsIncidentTaskData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsIncidentTaskData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SecurityInsightsIncidentTaskData>(Data, options, AzureResourceManagerSecurityInsightsContext.Default);

        SecurityInsightsIncidentTaskData IPersistableModel<SecurityInsightsIncidentTaskData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsIncidentTaskData>(data, options, AzureResourceManagerSecurityInsightsContext.Default);

        string IPersistableModel<SecurityInsightsIncidentTaskData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsIncidentTaskData>)Data).GetFormatFromOptions(options);
    }
}
