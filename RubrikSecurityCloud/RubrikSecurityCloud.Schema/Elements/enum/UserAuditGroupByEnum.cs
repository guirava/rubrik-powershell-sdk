// UserAuditGroupByEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:37.
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
    public enum UserAuditGroupByEnum
    {
        [EnumMember(Value = "Cluster")]
        CLUSTER,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "Day")]
        DAY,

        [EnumMember(Value = "Hour")]
        HOUR,

        [EnumMember(Value = "Month")]
        MONTH,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "Quarter")]
        QUARTER,

        [EnumMember(Value = "UserAuditStatus")]
        USER_AUDIT_STATUS,

        [EnumMember(Value = "UserAuditType")]
        USER_AUDIT_TYPE,

        [EnumMember(Value = "Week")]
        WEEK,

        [EnumMember(Value = "Year")]
        YEAR


    } // enum UserAuditGroupByEnum

} // namespace Rubrik.SecurityCloud.Types