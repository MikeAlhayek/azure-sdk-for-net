// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid
{
    internal class NamespaceTopicOperationSource : IOperationSource<NamespaceTopicResource>
    {
        private readonly ArmClient _client;

        internal NamespaceTopicOperationSource(ArmClient client)
        {
            _client = client;
        }

        NamespaceTopicResource IOperationSource<NamespaceTopicResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NamespaceTopicData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerEventGridContext.Default);
            return new NamespaceTopicResource(_client, data);
        }

        async ValueTask<NamespaceTopicResource> IOperationSource<NamespaceTopicResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<NamespaceTopicData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerEventGridContext.Default);
            return await Task.FromResult(new NamespaceTopicResource(_client, data)).ConfigureAwait(false);
        }
    }
}
