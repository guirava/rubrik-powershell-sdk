// ScriptErrorAction.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:30.
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
    public enum ScriptErrorAction
    {
        [EnumMember(Value = "SCRIPT_ERROR_ACTION_ABORT")]
        SCRIPT_ERROR_ACTION_ABORT,

        [EnumMember(Value = "SCRIPT_ERROR_ACTION_CONTINUE")]
        SCRIPT_ERROR_ACTION_CONTINUE


    } // enum ScriptErrorAction

} // namespace Rubrik.SecurityCloud.Types