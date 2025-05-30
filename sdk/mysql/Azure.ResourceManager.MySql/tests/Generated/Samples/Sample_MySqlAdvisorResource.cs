// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlAdvisorResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_AdvisorsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/AdvisorsGet.json
            // this example is just showing the usage of "Advisors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlAdvisorResource created on azure
            // for more information of creating MySqlAdvisorResource, please refer to the document of MySqlAdvisorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            string advisorName = "Index";
            ResourceIdentifier mySqlAdvisorResourceId = MySqlAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advisorName);
            MySqlAdvisorResource mySqlAdvisor = client.GetMySqlAdvisorResource(mySqlAdvisorResourceId);

            // invoke the operation
            MySqlAdvisorResource result = await mySqlAdvisor.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlAdvisorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateRecommendedActionSession_RecommendedActionSessionCreate()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/RecommendedActionSessionCreate.json
            // this example is just showing the usage of "CreateRecommendedActionSession" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlAdvisorResource created on azure
            // for more information of creating MySqlAdvisorResource, please refer to the document of MySqlAdvisorResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            string advisorName = "Index";
            ResourceIdentifier mySqlAdvisorResourceId = MySqlAdvisorResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, advisorName);
            MySqlAdvisorResource mySqlAdvisor = client.GetMySqlAdvisorResource(mySqlAdvisorResourceId);

            // invoke the operation
            string databaseName = "someDatabaseName";
            await mySqlAdvisor.CreateRecommendedActionSessionAsync(WaitUntil.Completed, databaseName);

            Console.WriteLine("Succeeded");
        }
    }
}
