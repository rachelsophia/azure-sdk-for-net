// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The managed instance virtual cores capability. </summary>
    public partial class InstancePoolVcoresCapability
    {
        /// <summary> Initializes a new instance of InstancePoolVcoresCapability. </summary>
        internal InstancePoolVcoresCapability()
        {
        }

        /// <summary> Initializes a new instance of InstancePoolVcoresCapability. </summary>
        /// <param name="name"> The virtual cores identifier. </param>
        /// <param name="value"> The virtual cores value. </param>
        /// <param name="storageLimit"> Storage limit. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal InstancePoolVcoresCapability(string name, int? value, MaxSizeCapability storageLimit, SqlCapabilityStatus? status, string reason)
        {
            Name = name;
            Value = value;
            StorageLimit = storageLimit;
            Status = status;
            Reason = reason;
        }

        /// <summary> The virtual cores identifier. </summary>
        public string Name { get; }
        /// <summary> The virtual cores value. </summary>
        public int? Value { get; }
        /// <summary> Storage limit. </summary>
        public MaxSizeCapability StorageLimit { get; }
        /// <summary> The status of the capability. </summary>
        public SqlCapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
