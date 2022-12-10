// ConnectionStatusType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    public enum ConnectionStatusType
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED


    } // enum ConnectionStatusType

} // namespace Rubrik.SecurityCloud.Types