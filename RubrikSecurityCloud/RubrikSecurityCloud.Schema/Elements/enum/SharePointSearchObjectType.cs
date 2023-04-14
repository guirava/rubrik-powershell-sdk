// SharePointSearchObjectType.cs
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
    public enum SharePointSearchObjectType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "LIBRARY")]
        LIBRARY,

        [EnumMember(Value = "LIST")]
        LIST,

        [EnumMember(Value = "OBJECT_UNSPECIFIED")]
        OBJECT_UNSPECIFIED,

        [EnumMember(Value = "SITE")]
        SITE,

        [EnumMember(Value = "WEBPART")]
        WEBPART


    } // enum SharePointSearchObjectType

} // namespace Rubrik.SecurityCloud.Types