// K8sClusterProtoType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:27.
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
    public enum K8sClusterProtoType
    {
        [EnumMember(Value = "AWS")]
        AWS,

        [EnumMember(Value = "AZURE")]
        AZURE,

        [EnumMember(Value = "GCP")]
        GCP,

        [EnumMember(Value = "ON_PREM")]
        ON_PREM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum K8sClusterProtoType

} // namespace Rubrik.SecurityCloud.Types