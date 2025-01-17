// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Quotas associated with a Batch region for a particular subscription.
    /// </summary>
    public partial class BatchLocationQuota
    {
        /// <summary>
        /// Initializes a new instance of the BatchLocationQuota class.
        /// </summary>
        public BatchLocationQuota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchLocationQuota class.
        /// </summary>

        /// <param name="accountQuota">The number of Batch accounts that may be created under the subscription in
        /// the specified region.
        /// </param>
        public BatchLocationQuota(int? accountQuota = default(int?))

        {
            this.AccountQuota = accountQuota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the number of Batch accounts that may be created under the
        /// subscription in the specified region.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accountQuota")]
        public int? AccountQuota {get; private set; }
    }
}