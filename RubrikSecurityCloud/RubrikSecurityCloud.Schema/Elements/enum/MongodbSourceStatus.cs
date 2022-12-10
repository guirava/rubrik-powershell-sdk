// MongodbSourceStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:44.
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
    public enum MongodbSourceStatus
    {
        [EnumMember(Value = "ADDING")]
        ADDING,

        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "UNKNOWN_SYSTEM_STATUS")]
        UNKNOWN_SYSTEM_STATUS


    } // enum MongodbSourceStatus

} // namespace Rubrik.SecurityCloud.Types