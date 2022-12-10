// TaskchainState.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:54.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum TaskchainState
    {
        [EnumMember(Value = "CANCELED")]
        CANCELED,

        [EnumMember(Value = "CANCELING")]
        CANCELING,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "READY")]
        READY,

        [EnumMember(Value = "RUNNING")]
        RUNNING,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED,

        [EnumMember(Value = "UNDOING")]
        UNDOING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TaskchainState

} // namespace Rubrik.SecurityCloud.Types