// TargetMappingQueryFilterField.cs
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
    public enum TargetMappingQueryFilterField
    {
        [EnumMember(Value = "ARCHIVAL_GROUP_ID")]
        ARCHIVAL_GROUP_ID,

        [EnumMember(Value = "ARCHIVAL_GROUP_TYPE")]
        ARCHIVAL_GROUP_TYPE,

        [EnumMember(Value = "ARCHIVAL_LOCATION_TYPE")]
        ARCHIVAL_LOCATION_TYPE,

        [EnumMember(Value = "CLOUD_ACCOUNT_ID")]
        CLOUD_ACCOUNT_ID,

        [EnumMember(Value = "CLOUD_NATIVE_USE_CASE")]
        CLOUD_NATIVE_USE_CASE,

        [EnumMember(Value = "EXCLUDE_ARCHIVAL_LOCATION_TYPE")]
        EXCLUDE_ARCHIVAL_LOCATION_TYPE,

        [EnumMember(Value = "EXCLUDE_GROUP_TYPE")]
        EXCLUDE_GROUP_TYPE,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum TargetMappingQueryFilterField

} // namespace Rubrik.SecurityCloud.Types