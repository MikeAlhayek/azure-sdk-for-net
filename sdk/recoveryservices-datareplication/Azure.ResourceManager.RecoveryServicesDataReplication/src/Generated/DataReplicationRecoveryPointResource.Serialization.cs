// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    public partial class DataReplicationRecoveryPointResource : IJsonModel<DataReplicationRecoveryPointData>
    {
        void IJsonModel<DataReplicationRecoveryPointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationRecoveryPointData>)Data).Write(writer, options);

        DataReplicationRecoveryPointData IJsonModel<DataReplicationRecoveryPointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataReplicationRecoveryPointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataReplicationRecoveryPointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataReplicationRecoveryPointData>(Data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        DataReplicationRecoveryPointData IPersistableModel<DataReplicationRecoveryPointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataReplicationRecoveryPointData>(data, options, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);

        string IPersistableModel<DataReplicationRecoveryPointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataReplicationRecoveryPointData>)Data).GetFormatFromOptions(options);
    }
}
