// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the Asset Endpoint Profile properties. </summary>
    public partial class DeviceRegistryAssetEndpointProfileProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryAssetEndpointProfileProperties"/>. </summary>
        /// <param name="targetAddress"> The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration. </param>
        /// <param name="endpointProfileType"> Defines the configuration for the connector type that is being used with the endpoint profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetAddress"/> or <paramref name="endpointProfileType"/> is null. </exception>
        public DeviceRegistryAssetEndpointProfileProperties(Uri targetAddress, string endpointProfileType)
        {
            Argument.AssertNotNull(targetAddress, nameof(targetAddress));
            Argument.AssertNotNull(endpointProfileType, nameof(endpointProfileType));

            TargetAddress = targetAddress;
            EndpointProfileType = endpointProfileType;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryAssetEndpointProfileProperties"/>. </summary>
        /// <param name="uuid"> Globally unique, immutable, non-reusable id. </param>
        /// <param name="targetAddress"> The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration. </param>
        /// <param name="endpointProfileType"> Defines the configuration for the connector type that is being used with the endpoint profile. </param>
        /// <param name="authentication"> Defines the client authentication mechanism to the server. </param>
        /// <param name="additionalConfiguration"> Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF). </param>
        /// <param name="discoveredAssetEndpointProfileRef"> Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery flow. Discovered asset endpoint profile name must be provided. </param>
        /// <param name="status"> Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceRegistryAssetEndpointProfileProperties(string uuid, Uri targetAddress, string endpointProfileType, DeviceRegistryAuthentication authentication, string additionalConfiguration, string discoveredAssetEndpointProfileRef, AssetEndpointProfileStatus status, DeviceRegistryProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uuid = uuid;
            TargetAddress = targetAddress;
            EndpointProfileType = endpointProfileType;
            Authentication = authentication;
            AdditionalConfiguration = additionalConfiguration;
            DiscoveredAssetEndpointProfileRef = discoveredAssetEndpointProfileRef;
            Status = status;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceRegistryAssetEndpointProfileProperties"/> for deserialization. </summary>
        internal DeviceRegistryAssetEndpointProfileProperties()
        {
        }

        /// <summary> Globally unique, immutable, non-reusable id. </summary>
        public string Uuid { get; }
        /// <summary> The local valid URI specifying the network address/DNS name of a southbound device. The scheme part of the targetAddress URI specifies the type of the device. The additionalConfiguration field holds further connector type specific configuration. </summary>
        public Uri TargetAddress { get; set; }
        /// <summary> Defines the configuration for the connector type that is being used with the endpoint profile. </summary>
        public string EndpointProfileType { get; set; }
        /// <summary> Defines the client authentication mechanism to the server. </summary>
        public DeviceRegistryAuthentication Authentication { get; set; }
        /// <summary> Stringified JSON that contains connectivity type specific further configuration (e.g. OPC UA, Modbus, ONVIF). </summary>
        public string AdditionalConfiguration { get; set; }
        /// <summary> Reference to a discovered asset endpoint profile. Populated only if the asset endpoint profile has been created from discovery flow. Discovered asset endpoint profile name must be provided. </summary>
        public string DiscoveredAssetEndpointProfileRef { get; set; }
        /// <summary> Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources. </summary>
        internal AssetEndpointProfileStatus Status { get; }
        /// <summary> Array object to transfer and persist errors that originate from the Edge. </summary>
        public IReadOnlyList<AssetEndpointProfileStatusError> StatusErrors
        {
            get => Status?.Errors;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public DeviceRegistryProvisioningState? ProvisioningState { get; }
    }
}
