// AwsAccountStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:08.
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
    public enum AwsAccountStatus
    {
        [EnumMember(Value = "ADDED")]
        ADDED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "DELETION_FAILED")]
        DELETION_FAILED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "REFRESHED")]
        REFRESHED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "REFRESH_FAILED")]
        REFRESH_FAILED


    } // enum AwsAccountStatus

} // namespace Rubrik.SecurityCloud.Types