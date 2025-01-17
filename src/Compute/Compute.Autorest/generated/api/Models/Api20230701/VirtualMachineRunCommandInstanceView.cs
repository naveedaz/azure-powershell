// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Extensions;

    /// <summary>The instance view of a virtual machine run command.</summary>
    public partial class VirtualMachineRunCommandInstanceView :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IVirtualMachineRunCommandInstanceView,
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IVirtualMachineRunCommandInstanceViewInternal
    {

        /// <summary>Backing field for <see cref="EndTime" /> property.</summary>
        private global::System.DateTime? _endTime;

        /// <summary>Script end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public global::System.DateTime? EndTime { get => this._endTime; set => this._endTime = value; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private string _error;

        /// <summary>Script error stream.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Error { get => this._error; set => this._error = value; }

        /// <summary>Backing field for <see cref="ExecutionMessage" /> property.</summary>
        private string _executionMessage;

        /// <summary>Communicate script configuration errors or execution messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string ExecutionMessage { get => this._executionMessage; set => this._executionMessage = value; }

        /// <summary>Backing field for <see cref="ExecutionState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ExecutionState? _executionState;

        /// <summary>Script execution status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ExecutionState? ExecutionState { get => this._executionState; set => this._executionState = value; }

        /// <summary>Backing field for <see cref="ExitCode" /> property.</summary>
        private int? _exitCode;

        /// <summary>Exit code returned from script execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public int? ExitCode { get => this._exitCode; set => this._exitCode = value; }

        /// <summary>Backing field for <see cref="Output" /> property.</summary>
        private string _output;

        /// <summary>Script output stream.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public string Output { get => this._output; set => this._output = value; }

        /// <summary>Backing field for <see cref="StartTime" /> property.</summary>
        private global::System.DateTime? _startTime;

        /// <summary>Script start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public global::System.DateTime? StartTime { get => this._startTime; set => this._startTime = value; }

        /// <summary>Backing field for <see cref="Statuses" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IInstanceViewStatus[] _statuses;

        /// <summary>The resource status information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Origin(Microsoft.Azure.PowerShell.Cmdlets.Compute.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IInstanceViewStatus[] Statuses { get => this._statuses; set => this._statuses = value; }

        /// <summary>Creates an new <see cref="VirtualMachineRunCommandInstanceView" /> instance.</summary>
        public VirtualMachineRunCommandInstanceView()
        {

        }
    }
    /// The instance view of a virtual machine run command.
    public partial interface IVirtualMachineRunCommandInstanceView :
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.IJsonSerializable
    {
        /// <summary>Script end time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script end time.",
        SerializedName = @"endTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Script error stream.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script error stream.",
        SerializedName = @"error",
        PossibleTypes = new [] { typeof(string) })]
        string Error { get; set; }
        /// <summary>Communicate script configuration errors or execution messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Communicate script configuration errors or execution messages.",
        SerializedName = @"executionMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ExecutionMessage { get; set; }
        /// <summary>Script execution status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script execution status.",
        SerializedName = @"executionState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ExecutionState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ExecutionState? ExecutionState { get; set; }
        /// <summary>Exit code returned from script execution.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Exit code returned from script execution.",
        SerializedName = @"exitCode",
        PossibleTypes = new [] { typeof(int) })]
        int? ExitCode { get; set; }
        /// <summary>Script output stream.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script output stream.",
        SerializedName = @"output",
        PossibleTypes = new [] { typeof(string) })]
        string Output { get; set; }
        /// <summary>Script start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Script start time.",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The resource status information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource status information.",
        SerializedName = @"statuses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IInstanceViewStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IInstanceViewStatus[] Statuses { get; set; }

    }
    /// The instance view of a virtual machine run command.
    internal partial interface IVirtualMachineRunCommandInstanceViewInternal

    {
        /// <summary>Script end time.</summary>
        global::System.DateTime? EndTime { get; set; }
        /// <summary>Script error stream.</summary>
        string Error { get; set; }
        /// <summary>Communicate script configuration errors or execution messages.</summary>
        string ExecutionMessage { get; set; }
        /// <summary>Script execution status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Support.ExecutionState? ExecutionState { get; set; }
        /// <summary>Exit code returned from script execution.</summary>
        int? ExitCode { get; set; }
        /// <summary>Script output stream.</summary>
        string Output { get; set; }
        /// <summary>Script start time.</summary>
        global::System.DateTime? StartTime { get; set; }
        /// <summary>The resource status information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IInstanceViewStatus[] Statuses { get; set; }

    }
}