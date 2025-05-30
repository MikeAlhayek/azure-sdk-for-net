// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.DependencyMap
{
    /// <summary>
    /// A class representing a collection of <see cref="DependencyMapDiscoverySourceResource"/> and their operations.
    /// Each <see cref="DependencyMapDiscoverySourceResource"/> in the collection will belong to the same instance of <see cref="DependencyMapResource"/>.
    /// To get a <see cref="DependencyMapDiscoverySourceCollection"/> instance call the GetDependencyMapDiscoverySources method from an instance of <see cref="DependencyMapResource"/>.
    /// </summary>
    public partial class DependencyMapDiscoverySourceCollection : ArmCollection, IEnumerable<DependencyMapDiscoverySourceResource>, IAsyncEnumerable<DependencyMapDiscoverySourceResource>
    {
        private readonly ClientDiagnostics _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics;
        private readonly DiscoverySourcesRestOperations _dependencyMapDiscoverySourceDiscoverySourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DependencyMapDiscoverySourceCollection"/> class for mocking. </summary>
        protected DependencyMapDiscoverySourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DependencyMapDiscoverySourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DependencyMapDiscoverySourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DependencyMap", DependencyMapDiscoverySourceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DependencyMapDiscoverySourceResource.ResourceType, out string dependencyMapDiscoverySourceDiscoverySourcesApiVersion);
            _dependencyMapDiscoverySourceDiscoverySourcesRestClient = new DiscoverySourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dependencyMapDiscoverySourceDiscoverySourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DependencyMapResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DependencyMapResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a DiscoverySourceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DependencyMapDiscoverySourceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sourceName, DependencyMapDiscoverySourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DependencyMapArmOperation<DependencyMapDiscoverySourceResource>(new DependencyMapDiscoverySourceOperationSource(Client), _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics, Pipeline, _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a DiscoverySourceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DependencyMapDiscoverySourceResource> CreateOrUpdate(WaitUntil waitUntil, string sourceName, DependencyMapDiscoverySourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, data, cancellationToken);
                var operation = new DependencyMapArmOperation<DependencyMapDiscoverySourceResource>(new DependencyMapDiscoverySourceOperationSource(Client), _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics, Pipeline, _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DiscoverySourceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> is null. </exception>
        public virtual async Task<Response<DependencyMapDiscoverySourceResource>> GetAsync(string sourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _dependencyMapDiscoverySourceDiscoverySourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DependencyMapDiscoverySourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a DiscoverySourceResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> is null. </exception>
        public virtual Response<DependencyMapDiscoverySourceResource> Get(string sourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.Get");
            scope.Start();
            try
            {
                var response = _dependencyMapDiscoverySourceDiscoverySourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DependencyMapDiscoverySourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List DiscoverySourceResource resources by MapsResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_ListByMapsResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DependencyMapDiscoverySourceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DependencyMapDiscoverySourceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateListByMapsResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateListByMapsResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DependencyMapDiscoverySourceResource(Client, DependencyMapDiscoverySourceData.DeserializeDependencyMapDiscoverySourceData(e)), _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics, Pipeline, "DependencyMapDiscoverySourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List DiscoverySourceResource resources by MapsResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_ListByMapsResource</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DependencyMapDiscoverySourceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DependencyMapDiscoverySourceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateListByMapsResourceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dependencyMapDiscoverySourceDiscoverySourcesRestClient.CreateListByMapsResourceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DependencyMapDiscoverySourceResource(Client, DependencyMapDiscoverySourceData.DeserializeDependencyMapDiscoverySourceData(e)), _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics, Pipeline, "DependencyMapDiscoverySourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dependencyMapDiscoverySourceDiscoverySourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _dependencyMapDiscoverySourceDiscoverySourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<DependencyMapDiscoverySourceResource>> GetIfExistsAsync(string sourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dependencyMapDiscoverySourceDiscoverySourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DependencyMapDiscoverySourceResource>(response.GetRawResponse());
                return Response.FromValue(new DependencyMapDiscoverySourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DependencyMap/maps/{mapName}/discoverySources/{sourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiscoverySourceResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-31-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DependencyMapDiscoverySourceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sourceName"> discovery source resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceName"/> is null. </exception>
        public virtual NullableResponse<DependencyMapDiscoverySourceResource> GetIfExists(string sourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sourceName, nameof(sourceName));

            using var scope = _dependencyMapDiscoverySourceDiscoverySourcesClientDiagnostics.CreateScope("DependencyMapDiscoverySourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dependencyMapDiscoverySourceDiscoverySourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DependencyMapDiscoverySourceResource>(response.GetRawResponse());
                return Response.FromValue(new DependencyMapDiscoverySourceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DependencyMapDiscoverySourceResource> IEnumerable<DependencyMapDiscoverySourceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DependencyMapDiscoverySourceResource> IAsyncEnumerable<DependencyMapDiscoverySourceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
