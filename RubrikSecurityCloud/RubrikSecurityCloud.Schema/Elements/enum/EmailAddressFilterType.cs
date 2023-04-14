// EmailAddressFilterType.cs
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
    public enum EmailAddressFilterType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "FROM")]
        FROM,

        [EnumMember(Value = "TO")]
        TO


    } // enum EmailAddressFilterType

} // namespace Rubrik.SecurityCloud.Types