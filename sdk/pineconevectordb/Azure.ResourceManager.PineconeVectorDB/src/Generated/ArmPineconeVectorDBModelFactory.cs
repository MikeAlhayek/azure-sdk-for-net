// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PineconeVectorDB.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmPineconeVectorDBModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="PineconeVectorDB.PineconeVectorDBOrganizationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <returns> A new <see cref="PineconeVectorDB.PineconeVectorDBOrganizationData"/> instance for mocking. </returns>
        public static PineconeVectorDBOrganizationData PineconeVectorDBOrganizationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, PineconeVectorDBOrganizationProperties properties = null, ManagedServiceIdentity identity = null)
        {
            tags ??= new Dictionary<string, string>();

            return new PineconeVectorDBOrganizationData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                identity,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PineconeVectorDBOrganizationProperties"/>. </summary>
        /// <param name="marketplace"> Marketplace details of the resource. </param>
        /// <param name="user"> Details of the user. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="partnerDisplayName"> partner properties. </param>
        /// <param name="singleSignOnProperties"> Single sign-on properties. </param>
        /// <returns> A new <see cref="Models.PineconeVectorDBOrganizationProperties"/> instance for mocking. </returns>
        public static PineconeVectorDBOrganizationProperties PineconeVectorDBOrganizationProperties(PineconeVectorDBMarketplaceDetails marketplace = null, PineconeVectorDBUserDetails user = null, PineconeVectorDBProvisioningState? provisioningState = null, string partnerDisplayName = null, PineconeVectorDBSingleSignOnPropertiesV2 singleSignOnProperties = null)
        {
            return new PineconeVectorDBOrganizationProperties(
                marketplace,
                user,
                provisioningState,
                partnerDisplayName != null ? new PineconeVectorDBPartnerProperties(partnerDisplayName, serializedAdditionalRawData: null) : null,
                singleSignOnProperties,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.PineconeVectorDBMarketplaceDetails"/>. </summary>
        /// <param name="subscriptionId"> Azure subscription id for the the marketplace offer is purchased from. </param>
        /// <param name="subscriptionStatus"> Marketplace subscription status. </param>
        /// <param name="offerDetails"> Offer details for the marketplace that is selected by the user. </param>
        /// <returns> A new <see cref="Models.PineconeVectorDBMarketplaceDetails"/> instance for mocking. </returns>
        public static PineconeVectorDBMarketplaceDetails PineconeVectorDBMarketplaceDetails(string subscriptionId = null, PineconeVectorDBMarketplaceSubscriptionStatus? subscriptionStatus = null, PineconeVectorDBOfferDetails offerDetails = null)
        {
            return new PineconeVectorDBMarketplaceDetails(subscriptionId, subscriptionStatus, offerDetails, serializedAdditionalRawData: null);
        }
    }
}
