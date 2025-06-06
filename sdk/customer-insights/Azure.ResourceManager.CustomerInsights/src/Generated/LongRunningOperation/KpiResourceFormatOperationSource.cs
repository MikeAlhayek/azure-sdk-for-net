// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights
{
    internal class KpiResourceFormatOperationSource : IOperationSource<KpiResourceFormatResource>
    {
        private readonly ArmClient _client;

        internal KpiResourceFormatOperationSource(ArmClient client)
        {
            _client = client;
        }

        KpiResourceFormatResource IOperationSource<KpiResourceFormatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<KpiResourceFormatData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCustomerInsightsContext.Default);
            return new KpiResourceFormatResource(_client, data);
        }

        async ValueTask<KpiResourceFormatResource> IOperationSource<KpiResourceFormatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<KpiResourceFormatData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCustomerInsightsContext.Default);
            return await Task.FromResult(new KpiResourceFormatResource(_client, data)).ConfigureAwait(false);
        }
    }
}
