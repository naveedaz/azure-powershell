// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PowerShell;

    /// <summary>The properties for updating a source based trigger.</summary>
    [System.ComponentModel.TypeConverter(typeof(SourceTriggerUpdateParametersTypeConverter))]
    public partial class SourceTriggerUpdateParameters
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SourceTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SourceTriggerUpdateParameters(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SourceTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SourceTriggerUpdateParameters(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SourceTriggerUpdateParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SourceTriggerUpdateParameters" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SourceTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SourceTriggerUpdateParameters(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceRepository"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepository = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceUpdateParameters) content.GetValueForProperty("SourceRepository",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepository, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SourceUpdateParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceTriggerEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceTriggerEvent = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceTriggerEvent[]) content.GetValueForProperty("SourceTriggerEvent",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceTriggerEvent, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceTriggerEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceTriggerEvent.CreateFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus.CreateFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("SourceRepositorySourceControlAuthProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlAuthProperty = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAuthInfoUpdateParameters) content.GetValueForProperty("SourceRepositorySourceControlAuthProperty",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlAuthProperty, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AuthInfoUpdateParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceRepositorySourceControlType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceControlType?) content.GetValueForProperty("SourceRepositorySourceControlType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceControlType.CreateFrom);
            }
            if (content.Contains("SourceRepositoryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryUrl = (string) content.GetValueForProperty("SourceRepositoryUrl",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SourceRepositoryBranch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryBranch = (string) content.GetValueForProperty("SourceRepositoryBranch",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryBranch, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyTokenType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyTokenType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType?) content.GetValueForProperty("SourceControlAuthPropertyTokenType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyTokenType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType.CreateFrom);
            }
            if (content.Contains("SourceControlAuthPropertyToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyToken = (string) content.GetValueForProperty("SourceControlAuthPropertyToken",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyToken, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyRefreshToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyRefreshToken = (string) content.GetValueForProperty("SourceControlAuthPropertyRefreshToken",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyRefreshToken, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyScope = (string) content.GetValueForProperty("SourceControlAuthPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyScope, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyExpiresIn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyExpiresIn = (int?) content.GetValueForProperty("SourceControlAuthPropertyExpiresIn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyExpiresIn, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SourceTriggerUpdateParameters"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SourceTriggerUpdateParameters(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SourceRepository"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepository = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceUpdateParameters) content.GetValueForProperty("SourceRepository",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepository, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.SourceUpdateParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceTriggerEvent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceTriggerEvent = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceTriggerEvent[]) content.GetValueForProperty("SourceTriggerEvent",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceTriggerEvent, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceTriggerEvent>(__y, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceTriggerEvent.CreateFrom));
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TriggerStatus.CreateFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("SourceRepositorySourceControlAuthProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlAuthProperty = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.IAuthInfoUpdateParameters) content.GetValueForProperty("SourceRepositorySourceControlAuthProperty",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlAuthProperty, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.AuthInfoUpdateParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("SourceRepositorySourceControlType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceControlType?) content.GetValueForProperty("SourceRepositorySourceControlType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositorySourceControlType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.SourceControlType.CreateFrom);
            }
            if (content.Contains("SourceRepositoryUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryUrl = (string) content.GetValueForProperty("SourceRepositoryUrl",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryUrl, global::System.Convert.ToString);
            }
            if (content.Contains("SourceRepositoryBranch"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryBranch = (string) content.GetValueForProperty("SourceRepositoryBranch",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceRepositoryBranch, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyTokenType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyTokenType = (Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType?) content.GetValueForProperty("SourceControlAuthPropertyTokenType",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyTokenType, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.TokenType.CreateFrom);
            }
            if (content.Contains("SourceControlAuthPropertyToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyToken = (string) content.GetValueForProperty("SourceControlAuthPropertyToken",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyToken, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyRefreshToken"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyRefreshToken = (string) content.GetValueForProperty("SourceControlAuthPropertyRefreshToken",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyRefreshToken, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyScope = (string) content.GetValueForProperty("SourceControlAuthPropertyScope",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyScope, global::System.Convert.ToString);
            }
            if (content.Contains("SourceControlAuthPropertyExpiresIn"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyExpiresIn = (int?) content.GetValueForProperty("SourceControlAuthPropertyExpiresIn",((Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api20190601Preview.ISourceTriggerUpdateParametersInternal)this).SourceControlAuthPropertyExpiresIn, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The properties for updating a source based trigger.
    [System.ComponentModel.TypeConverter(typeof(SourceTriggerUpdateParametersTypeConverter))]
    public partial interface ISourceTriggerUpdateParameters

    {

    }
}