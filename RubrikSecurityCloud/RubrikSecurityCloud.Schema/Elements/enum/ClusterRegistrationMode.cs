// ClusterRegistrationMode.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:20.
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
    public enum ClusterRegistrationMode
    {
        [EnumMember(Value = "HYBRID")]
        HYBRID,

        [EnumMember(Value = "LEGACY")]
        LEGACY,

        [EnumMember(Value = "LIFE_OF_DEVICE")]
        LIFE_OF_DEVICE,

        [EnumMember(Value = "NOT_REGISTERED")]
        NOT_REGISTERED


    } // enum ClusterRegistrationMode

} // namespace Rubrik.SecurityCloud.Types