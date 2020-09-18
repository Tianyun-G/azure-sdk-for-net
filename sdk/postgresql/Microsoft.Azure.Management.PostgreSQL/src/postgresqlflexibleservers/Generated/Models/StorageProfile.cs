// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Storage Profile properties of a server
    /// </summary>
    public partial class StorageProfile
    {
        /// <summary>
        /// Initializes a new instance of the StorageProfile class.
        /// </summary>
        public StorageProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageProfile class.
        /// </summary>
        /// <param name="backupRetentionDays">Backup retention days for the
        /// server.</param>
        /// <param name="storageMB">Max storage allowed for a server.</param>
        public StorageProfile(int? backupRetentionDays = default(int?), int? storageMB = default(int?))
        {
            BackupRetentionDays = backupRetentionDays;
            StorageMB = storageMB;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup retention days for the server.
        /// </summary>
        [JsonProperty(PropertyName = "backupRetentionDays")]
        public int? BackupRetentionDays { get; set; }

        /// <summary>
        /// Gets or sets max storage allowed for a server.
        /// </summary>
        [JsonProperty(PropertyName = "storageMB")]
        public int? StorageMB { get; set; }

    }
}