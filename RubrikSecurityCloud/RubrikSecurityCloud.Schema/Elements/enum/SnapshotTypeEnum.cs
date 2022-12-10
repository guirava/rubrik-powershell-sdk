// SnapshotTypeEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
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
    public enum SnapshotTypeEnum
    {
        [EnumMember(Value = "DOWNLOADED")]
        DOWNLOADED,

        [EnumMember(Value = "ON_DEMAND")]
        ON_DEMAND,

        [EnumMember(Value = "SCHEDULED")]
        SCHEDULED


    } // enum SnapshotTypeEnum

} // namespace Rubrik.SecurityCloud.Types