// AwsNativeRdsInstanceSortFields.cs
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
    public enum AwsNativeRdsInstanceSortFields
    {
        [EnumMember(Value = "ASSIGNED_SLA_DOMAIN")]
        ASSIGNED_SLA_DOMAIN,

        [EnumMember(Value = "AWS_NATIVE_ACCOUNT_NAME")]
        AWS_NATIVE_ACCOUNT_NAME,

        [EnumMember(Value = "AWS_NATIVE_RDS_DB_ENGINE")]
        AWS_NATIVE_RDS_DB_ENGINE,

        [EnumMember(Value = "AWS_NATIVE_RDS_DB_INSTANCE_CLASS")]
        AWS_NATIVE_RDS_DB_INSTANCE_CLASS,

        [EnumMember(Value = "AWS_VPC_ID")]
        AWS_VPC_ID,

        [EnumMember(Value = "EFFECTIVE_SLA_DOMAIN")]
        EFFECTIVE_SLA_DOMAIN,

        [EnumMember(Value = "NAME")]
        NAME


    } // enum AwsNativeRdsInstanceSortFields

} // namespace Rubrik.SecurityCloud.Types