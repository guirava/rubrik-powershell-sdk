// CrawlStatusEnum.cs
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
    public enum CrawlStatusEnum
    {
        [EnumMember(Value = "COMPLETE")]
        COMPLETE,

        [EnumMember(Value = "COMPLETE_WITH_FAIL")]
        COMPLETE_WITH_FAIL,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "IN_PROGRESS_WITH_FAIL")]
        IN_PROGRESS_WITH_FAIL


    } // enum CrawlStatusEnum

} // namespace Rubrik.SecurityCloud.Types