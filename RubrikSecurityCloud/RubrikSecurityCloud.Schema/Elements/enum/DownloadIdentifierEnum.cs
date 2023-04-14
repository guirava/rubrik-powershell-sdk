// DownloadIdentifierEnum.cs
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
    public enum DownloadIdentifierEnum
    {
        [EnumMember(Value = "ORION_THREAT_HUNT_DOWNLOAD")]
        ORION_THREAT_HUNT_DOWNLOAD,

        [EnumMember(Value = "REPORT")]
        REPORT,

        [EnumMember(Value = "SEND_NOW_EMAIL")]
        SEND_NOW_EMAIL,

        [EnumMember(Value = "SLA_WITH_REPLICATION")]
        SLA_WITH_REPLICATION,

        [EnumMember(Value = "SNAPSHOT_FILES_DOWNLOAD")]
        SNAPSHOT_FILES_DOWNLOAD,

        [EnumMember(Value = "SONAR_DOWNLOAD")]
        SONAR_DOWNLOAD


    } // enum DownloadIdentifierEnum

} // namespace Rubrik.SecurityCloud.Types