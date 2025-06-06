// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.NetworkCloud.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Azure.ResourceManager.NetworkCloud.Tests.ScenarioTests
{
    public class AgentPoolTests : NetworkCloudManagementTestBase
    {
        public AgentPoolTests  (bool isAsync, RecordedTestMode mode) : base(isAsync, mode) {}
        public AgentPoolTests (bool isAsync) : base(isAsync) {}

        [Test, MaxTime(1800000)]
        [RecordedTest]
        public async Task AgentPool()
        {
            string agentPoolName = Recording.GenerateAssetName("systemPool");
            ResourceIdentifier agentPoolId = NetworkCloudAgentPoolResource.CreateResourceIdentifier(TestEnvironment.SubscriptionId, TestEnvironment.KubernetesClusterRG, TestEnvironment.KubernetesClusterName, agentPoolName);
            NetworkCloudAgentPoolResource agentPool = Client.GetNetworkCloudAgentPoolResource(agentPoolId);

            NetworkCloudKubernetesClusterResource kubernetesCluster = Client.GetNetworkCloudKubernetesClusterResource(TestEnvironment.KubernetesClusterId);
            kubernetesCluster = await kubernetesCluster.GetAsync();
            NetworkCloudAgentPoolCollection collection = kubernetesCluster.GetNetworkCloudAgentPools();

            // Create
            NetworkCloudAgentPoolData data = new NetworkCloudAgentPoolData
            (TestEnvironment.Location, 1, NetworkCloudAgentPoolMode.System, TestEnvironment.VMImage)
            {
                ExtendedLocation = kubernetesCluster.Data.ExtendedLocation,
                AdministratorConfiguration = new AdministratorConfiguration()
                {
                    AdminUsername = "azure",
                    SshPublicKeys =
                    {
                    new NetworkCloudSshPublicKey("ssh-rsa REDACTED")
                    },
                },
                AgentOptions = new NetworkCloudAgentConfiguration(12)
                {
                    HugepagesSize = HugepagesSize.TwoM,
                    HugepagesCount = 2
                },
                UpgradeMaxSurge = "1",
                Tags =
                {
                    [ "key1" ] = "value1",
                    [ "key2" ] = "value2",
                },
                AttachedNetworkConfiguration = new AttachedNetworkConfiguration()
                {
                    L3Networks =
                    {
                        new L3NetworkAttachmentConfiguration(new ResourceIdentifier(TestEnvironment.L3NAttachmentId))
                        {
                            IpamEnabled = L3NetworkConfigurationIpamEnabled.False,
                            PluginType = KubernetesPluginType.Sriov,
                        }
                    }
                }
            };

            // Create
            ArmOperation<NetworkCloudAgentPoolResource> createResult = await collection.CreateOrUpdateAsync(WaitUntil.Completed, agentPoolName, data);
            Assert.AreEqual(agentPoolName, createResult.Value.Data.Name);

            // Get
            var getResult = await agentPool.GetAsync();
            Assert.AreEqual(agentPoolName, getResult.Value.Data.Name);

            // List
            var listByKubernetesCluster = new List<NetworkCloudAgentPoolResource>();
            await foreach (NetworkCloudAgentPoolResource item in collection.GetAllAsync())
            {
                listByKubernetesCluster.Add(item);
            }
            Assert.IsNotEmpty(listByKubernetesCluster);

            // Update
            NetworkCloudAgentPoolPatch patch = new NetworkCloudAgentPoolPatch()
            {
                Tags =
                {
                    ["key1"] = "newvalue1",
                    ["key2"] = "newvalue2",
                }
            };
            ArmOperation<NetworkCloudAgentPoolResource> updateResult = await agentPool.UpdateAsync(WaitUntil.Completed, patch);
            Assert.AreEqual(patch.Tags, updateResult.Value.Data.Tags);

            // Delete
            var deleteResult = await agentPool.DeleteAsync(WaitUntil.Completed, CancellationToken.None);
            Assert.IsTrue(deleteResult.HasCompleted);
        }
    }
}
