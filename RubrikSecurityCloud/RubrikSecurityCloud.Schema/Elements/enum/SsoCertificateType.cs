// SsoCertificateType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
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
    public enum SsoCertificateType
    {
        [EnumMember(Value = "CERTIFICATE_TYPE_UNSPECIFIED")]
        CERTIFICATE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "ENCRYPTION")]
        ENCRYPTION,

        [EnumMember(Value = "SIGNING")]
        SIGNING


    } // enum SsoCertificateType

} // namespace Rubrik.SecurityCloud.Types