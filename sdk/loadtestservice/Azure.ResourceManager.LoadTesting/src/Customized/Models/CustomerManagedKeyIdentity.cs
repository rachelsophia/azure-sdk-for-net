// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using Azure.Core;

[assembly: CodeGenSuppressType("CustomerManagedKeyIdentity")]
namespace Azure.ResourceManager.LoadTesting.Models
{
    /// <summary> All identity configuration for Customer-managed key settings defining which identity should be used to auth to Key Vault. </summary>
    public partial class CustomerManagedKeyIdentity
    {
        /// <summary> Initializes a new instance of CustomerManagedKeyIdentity. </summary>
        public CustomerManagedKeyIdentity()
        {
        }

        /// <summary> Initializes a new instance of CustomerManagedKeyIdentity. </summary>
        /// <param name="identityType"> Managed identity type to use for accessing encryption key Url. </param>
        /// <param name="resourceId"> user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. </param>
        internal CustomerManagedKeyIdentity(CustomerManagedKeyIdentityType? identityType, ResourceIdentifier resourceId)
        {
            IdentityType = identityType;
            ResourceId = resourceId;
        }

        /// <summary> Managed identity type to use for accessing encryption key Url. </summary>
        public CustomerManagedKeyIdentityType? IdentityType { get; set; }
        /// <summary> user assigned identity to use for accessing key encryption key Url. Ex: /subscriptions/fa5fc227-a624-475e-b696-cdd604c735bc/resourceGroups/&lt;resource group&gt;/providers/Microsoft.ManagedIdentity/userAssignedIdentities/myId. </summary>
        public ResourceIdentifier ResourceId { get; set; }
    }
}
