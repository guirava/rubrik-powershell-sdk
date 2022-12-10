// ReplicationPairsQuerySortByField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:23.
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
    public enum ReplicationPairsQuerySortByField
    {
        [EnumMember(Value = "CURRENT_THROTTLE_LIMIT")]
        CURRENT_THROTTLE_LIMIT,

        [EnumMember(Value = "FAILED_TASKS")]
        FAILED_TASKS,

        [EnumMember(Value = "RUNNING_TASKS")]
        RUNNING_TASKS,

        [EnumMember(Value = "SOURCE_CLUSTER_NAME")]
        SOURCE_CLUSTER_NAME,

        [EnumMember(Value = "STATUS")]
        STATUS,

        [EnumMember(Value = "STORAGE")]
        STORAGE,

        [EnumMember(Value = "TARGET_CLUSTER_NAME")]
        TARGET_CLUSTER_NAME


    } // enum ReplicationPairsQuerySortByField

} // namespace Rubrik.SecurityCloud.Types