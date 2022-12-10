// ProductState.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:31.
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
    public enum ProductState
    {
        [EnumMember(Value = "ACTIVATION_FAILED")]
        ACTIVATION_FAILED,

        [EnumMember(Value = "ACTIVATION_PENDING")]
        ACTIVATION_PENDING,

        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "DISABLED")]
        DISABLED,

        [EnumMember(Value = "DISABLE_FAILED")]
        DISABLE_FAILED,

        [EnumMember(Value = "DISABLE_PENDING")]
        DISABLE_PENDING,

        [EnumMember(Value = "EXPIRATION_PENDING")]
        EXPIRATION_PENDING,

        [EnumMember(Value = "EXPIRED")]
        EXPIRED,

        [EnumMember(Value = "UNSPECIFIED_STATE")]
        UNSPECIFIED_STATE


    } // enum ProductState

} // namespace Rubrik.SecurityCloud.Types