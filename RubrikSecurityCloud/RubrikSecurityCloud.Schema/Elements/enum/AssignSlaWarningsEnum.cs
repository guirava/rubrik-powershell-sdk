// AssignSlaWarningsEnum.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum AssignSlaWarningsEnum
    {
        [EnumMember(Value = "ARCHIVAL_CONFIGURATION_NOT_RESPECTED")]
        ARCHIVAL_CONFIGURATION_NOT_RESPECTED,

        [EnumMember(Value = "ARCHIVAL_LOCATION_NOT_SPECIFIED")]
        ARCHIVAL_LOCATION_NOT_SPECIFIED,

        [EnumMember(Value = "ARCHIVAL_LOCATION_NOT_SYNCED_ON_CLUSTER_WARNING")]
        ARCHIVAL_LOCATION_NOT_SYNCED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "AWS_ARCHIVAL_NOT_SUPPORTED_FOR_GOVCLOUD_OBJECTS")]
        AWS_ARCHIVAL_NOT_SUPPORTED_FOR_GOVCLOUD_OBJECTS,

        [EnumMember(Value = "AWS_ARCHIVAL_TIERING_NOT_SUPPORTED_ON_CLUSTER_WARNING")]
        AWS_ARCHIVAL_TIERING_NOT_SUPPORTED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "AWS_CROSS_ACCOUNT_REPLICATION_CONFIG_WARNING")]
        AWS_CROSS_ACCOUNT_REPLICATION_CONFIG_WARNING,

        [EnumMember(Value = "AWS_RDS_LOG_BACKUP_CONFIG_WARNING")]
        AWS_RDS_LOG_BACKUP_CONFIG_WARNING,

        [EnumMember(Value = "AWS_REPLICATION_REGION_VALIDATION")]
        AWS_REPLICATION_REGION_VALIDATION,

        [EnumMember(Value = "AZURE_ARCHIVAL_TIERING_NOT_SUPPORTED_ON_CLUSTER_WARNING")]
        AZURE_ARCHIVAL_TIERING_NOT_SUPPORTED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "AZURE_BLOB_EXCLUSIVE_SLA_ASSIGNMENT_WARNING")]
        AZURE_BLOB_EXCLUSIVE_SLA_ASSIGNMENT_WARNING,

        [EnumMember(Value = "AZURE_FULL_SNAPSHOTS")]
        AZURE_FULL_SNAPSHOTS,

        [EnumMember(Value = "AZURE_NATIONAL_PUBLIC_REPLICATION_NOT_SUPPORTED")]
        AZURE_NATIONAL_PUBLIC_REPLICATION_NOT_SUPPORTED,

        [EnumMember(Value = "AZURE_SQL_DATABASE_NATIVE_BACKUP_INCOMPATIBLE_SLA_WARNING")]
        AZURE_SQL_DATABASE_NATIVE_BACKUP_INCOMPATIBLE_SLA_WARNING,

        [EnumMember(Value = "AZURE_SQL_DATABASE_PITR_WINDOW_WARNING")]
        AZURE_SQL_DATABASE_PITR_WINDOW_WARNING,

        [EnumMember(Value = "BACKUP_WINDOWS_NOT_RESPECTED")]
        BACKUP_WINDOWS_NOT_RESPECTED,

        [EnumMember(Value = "CDP_LOG_RETENTION_NOT_SUPPORTED_ON_CLUSTER_WARNING")]
        CDP_LOG_RETENTION_NOT_SUPPORTED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "CLOUD_REPLICATION_LOCATION_N0T_SYNCED_ON_CLUSTER_WARNING")]
        CLOUD_REPLICATION_LOCATION_N0T_SYNCED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "CROSS_REGION_ARCHIVAL")]
        CROSS_REGION_ARCHIVAL,

        [EnumMember(Value = "DIFFERENTIAL_BACKUP_FREQUENCY_NOT_RESPECTED")]
        DIFFERENTIAL_BACKUP_FREQUENCY_NOT_RESPECTED,

        [EnumMember(Value = "INCREMENTAL_BACKUP_FREQUENCY_NOT_RESPECTED")]
        INCREMENTAL_BACKUP_FREQUENCY_NOT_RESPECTED,

        [EnumMember(Value = "INSTANT_ARCHIVAL_ACCOUNT_LEVEL_DISK_SIZE_WARNING")]
        INSTANT_ARCHIVAL_ACCOUNT_LEVEL_DISK_SIZE_WARNING,

        [EnumMember(Value = "INSTANT_ARCHIVAL_DISK_SIZE_WARNING")]
        INSTANT_ARCHIVAL_DISK_SIZE_WARNING,

        [EnumMember(Value = "MINUTE_LEVEL_CONFIGURATION_NOT_RESPECTED")]
        MINUTE_LEVEL_CONFIGURATION_NOT_RESPECTED,

        [EnumMember(Value = "MULTIPLE_ARCHIVAL_OR_SELECTIVE_FREQ_NOT_SUPPORTED_WARNING")]
        MULTIPLE_ARCHIVAL_OR_SELECTIVE_FREQ_NOT_SUPPORTED_WARNING,

        [EnumMember(Value = "NON_NOSQL_SLA_NOT_SUPPORTED_ON_NOSQL_CLUSTER_WARNING")]
        NON_NOSQL_SLA_NOT_SUPPORTED_ON_NOSQL_CLUSTER_WARNING,

        [EnumMember(Value = "NOSQL_SLA_NOT_SUPPORTED_ON_CDM_CLUSTER_WARNING")]
        NOSQL_SLA_NOT_SUPPORTED_ON_CDM_CLUSTER_WARNING,

        [EnumMember(Value = "NO_WARNING")]
        NO_WARNING,

        [EnumMember(Value = "REMOTE_CONFIGURATION_NOT_RESPECTED")]
        REMOTE_CONFIGURATION_NOT_RESPECTED,

        [EnumMember(Value = "REPLICATION_CONFIGURATION_NOT_RESPECTED")]
        REPLICATION_CONFIGURATION_NOT_RESPECTED,

        [EnumMember(Value = "REPLICATION_SETUP_NOT_COMPLETE_ON_CLUSTER_WARNING")]
        REPLICATION_SETUP_NOT_COMPLETE_ON_CLUSTER_WARNING,

        [EnumMember(Value = "REPLICATION_TARGET_SAME_AS_SOURCE")]
        REPLICATION_TARGET_SAME_AS_SOURCE,

        [EnumMember(Value = "RETENTION_LOCK_CONFIG_NOT_ENABLED_ON_CLUSTER_WARNING")]
        RETENTION_LOCK_CONFIG_NOT_ENABLED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "RETENTION_LOCK_CONSTRAINTS_NOT_RESPECTED")]
        RETENTION_LOCK_CONSTRAINTS_NOT_RESPECTED,

        [EnumMember(Value = "RETENTION_LOCK_NOT_SUPPORTED_WARNING")]
        RETENTION_LOCK_NOT_SUPPORTED_WARNING,

        [EnumMember(Value = "SAP_HANA_ARCHIVAL_NOT_SUPPORTED_WARNING")]
        SAP_HANA_ARCHIVAL_NOT_SUPPORTED_WARNING,

        [EnumMember(Value = "SAP_HANA_CASCADED_ARCHIVAL_NOT_SUPPORTED_ON_CLUSTER_WARNING")]
        SAP_HANA_CASCADED_ARCHIVAL_NOT_SUPPORTED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "SAP_HANA_CHANGE_RETENTION_NOT_SUPPORTED_WARNING")]
        SAP_HANA_CHANGE_RETENTION_NOT_SUPPORTED_WARNING,

        [EnumMember(Value = "SAP_HANA_RETENTION_LOCK_NOT_SUPPORTED_ON_CLUSTER_WARNING")]
        SAP_HANA_RETENTION_LOCK_NOT_SUPPORTED_ON_CLUSTER_WARNING,

        [EnumMember(Value = "SLA_NOT_SYNCED")]
        SLA_NOT_SYNCED,

        [EnumMember(Value = "SNAPSHOTS_MAY_EXPIRE")]
        SNAPSHOTS_MAY_EXPIRE,

        [EnumMember(Value = "STATIC_RETENTION_NOT_SUPPORTED_WARNING")]
        STATIC_RETENTION_NOT_SUPPORTED_WARNING,

        [EnumMember(Value = "UNSUPPORTED_RCV_REGION")]
        UNSUPPORTED_RCV_REGION


    } // enum AssignSlaWarningsEnum

} // namespace RubrikSecurityCloud.Types