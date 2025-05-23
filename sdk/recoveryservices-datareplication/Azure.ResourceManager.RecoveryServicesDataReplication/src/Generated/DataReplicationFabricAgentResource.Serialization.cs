// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationFabricAgentResource : IJsonModel<DataReplicationFabricAgentData>
    {
        void IJsonModel<DataReplicationFabricAgentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationFabricAgentData>)Data).Write(writer, options);

        DataReplicationFabricAgentData IJsonModel<DataReplicationFabricAgentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationFabricAgentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataReplicationFabricAgentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataReplicationFabricAgentData>(Data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        DataReplicationFabricAgentData IPersistableModel<DataReplicationFabricAgentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataReplicationFabricAgentData>(data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        string IPersistableModel<DataReplicationFabricAgentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataReplicationFabricAgentData>)Data).GetFormatFromOptions(options);
    }
}
