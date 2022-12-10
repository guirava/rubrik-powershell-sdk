// O365ServiceAccountStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    public enum O365ServiceAccountStatus
    {
        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "NOT_CONFIGURED")]
        NOT_CONFIGURED,

        [EnumMember(Value = "VALID")]
        VALID


    } // enum O365ServiceAccountStatus

} // namespace Rubrik.SecurityCloud.Types