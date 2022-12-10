// HashType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:39.
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
    public enum HashType
    {
        [EnumMember(Value = "HASH_TYPE_M_D5")]
        HASH_TYPE_M_D5,

        [EnumMember(Value = "HASH_TYPE_SH_A1")]
        HASH_TYPE_SH_A1,

        [EnumMember(Value = "HASH_TYPE_SH_A256")]
        HASH_TYPE_SH_A256


    } // enum HashType

} // namespace Rubrik.SecurityCloud.Types