// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class RegulatoryComplianceAssessmentResource : IJsonModel<RegulatoryComplianceAssessmentData>
    {
        void IJsonModel<RegulatoryComplianceAssessmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RegulatoryComplianceAssessmentData>)Data).Write(writer, options);

        RegulatoryComplianceAssessmentData IJsonModel<RegulatoryComplianceAssessmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RegulatoryComplianceAssessmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RegulatoryComplianceAssessmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<RegulatoryComplianceAssessmentData>(Data, options, AzureResourceManagerSecurityCenterContext.Default);

        RegulatoryComplianceAssessmentData IPersistableModel<RegulatoryComplianceAssessmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RegulatoryComplianceAssessmentData>(data, options, AzureResourceManagerSecurityCenterContext.Default);

        string IPersistableModel<RegulatoryComplianceAssessmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RegulatoryComplianceAssessmentData>)Data).GetFormatFromOptions(options);
    }
}
