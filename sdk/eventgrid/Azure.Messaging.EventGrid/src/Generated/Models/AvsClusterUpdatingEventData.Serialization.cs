// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AvsClusterUpdatingEventDataConverter))]
    public partial class AvsClusterUpdatingEventData
    {
        internal static AvsClusterUpdatingEventData DeserializeAvsClusterUpdatingEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            IReadOnlyList<string> addedHostNames = default;
            IReadOnlyList<string> removedHostNames = default;
            IReadOnlyList<string> inMaintenanceHostNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addedHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addedHostNames = array;
                    continue;
                }
                if (property.NameEquals("removedHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    removedHostNames = array;
                    continue;
                }
                if (property.NameEquals("inMaintenanceHostNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inMaintenanceHostNames = array;
                    continue;
                }
            }
            return new AvsClusterUpdatingEventData(operationId, addedHostNames ?? new ChangeTrackingList<string>(), removedHostNames ?? new ChangeTrackingList<string>(), inMaintenanceHostNames ?? new ChangeTrackingList<string>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AvsClusterUpdatingEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAvsClusterUpdatingEventData(document.RootElement);
        }

        internal partial class AvsClusterUpdatingEventDataConverter : JsonConverter<AvsClusterUpdatingEventData>
        {
            public override void Write(Utf8JsonWriter writer, AvsClusterUpdatingEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override AvsClusterUpdatingEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAvsClusterUpdatingEventData(document.RootElement);
            }
        }
    }
}
