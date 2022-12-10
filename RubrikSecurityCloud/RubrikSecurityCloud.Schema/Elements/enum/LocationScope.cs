// LocationScope.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    public enum LocationScope
    {
        [EnumMember(Value = "GLOBAL")]
        GLOBAL,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum LocationScope

} // namespace Rubrik.SecurityCloud.Types