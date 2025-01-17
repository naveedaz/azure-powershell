// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Defines whether to send email notifications about new security alerts
    /// </summary>
    public partial class SecurityContactPropertiesAlertNotifications
    {
        /// <summary>
        /// Initializes a new instance of the SecurityContactPropertiesAlertNotifications class.
        /// </summary>
        public SecurityContactPropertiesAlertNotifications()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SecurityContactPropertiesAlertNotifications class.
        /// </summary>

        /// <param name="state">Defines if email notifications will be sent about new security alerts
        /// Possible values include: 'On', 'Off'</param>

        /// <param name="minimalSeverity">Defines the minimal alert severity which will be sent as email
        /// notifications
        /// Possible values include: 'High', 'Medium', 'Low'</param>
        public SecurityContactPropertiesAlertNotifications(string state = default(string), string minimalSeverity = default(string))

        {
            this.State = state;
            this.MinimalSeverity = minimalSeverity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets defines if email notifications will be sent about new security
        /// alerts Possible values include: &#39;On&#39;, &#39;Off&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public string State {get; set; }

        /// <summary>
        /// Gets or sets defines the minimal alert severity which will be sent as email
        /// notifications Possible values include: &#39;High&#39;, &#39;Medium&#39;, &#39;Low&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minimalSeverity")]
        public string MinimalSeverity {get; set; }
    }
}