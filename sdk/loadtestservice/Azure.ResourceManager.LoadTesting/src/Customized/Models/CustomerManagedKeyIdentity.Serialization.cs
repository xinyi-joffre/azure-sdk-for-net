// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class CustomerManagedKeyIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(IdentityType.Value.ToString());
            }
            if (Optional.IsDefined(ResourceId))
            {
                if (ResourceId != null)
                {
                    writer.WritePropertyName("resourceId");
                    writer.WriteStringValue(ResourceId);
                }
                else
                {
                    writer.WriteNull("resourceId");
                }
            }
            else
            {
                writer.WriteNull("resourceId");
            }
            writer.WriteEndObject();
        }

        internal static CustomerManagedKeyIdentity DeserializeCustomerManagedKeyIdentity(JsonElement element)
        {
            Optional<CustomerManagedKeyIdentityType> type = default;
            Optional<ResourceIdentifier> resourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new CustomerManagedKeyIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceId = null;
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new CustomerManagedKeyIdentity(Optional.ToNullable(type), resourceId.Value);
        }
    }
}
