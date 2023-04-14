// GuestOsType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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
    public enum GuestOsType
    {
        [EnumMember(Value = "LINUX")]
        LINUX,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "WINDOWS")]
        WINDOWS


    } // enum GuestOsType

} // namespace Rubrik.SecurityCloud.Types