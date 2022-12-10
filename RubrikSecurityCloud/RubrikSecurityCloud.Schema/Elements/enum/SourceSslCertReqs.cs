// SourceSslCertReqs.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:16.
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
    public enum SourceSslCertReqs
    {
        [EnumMember(Value = "SOURCE_SSL_CERT_REQS_NONE")]
        SOURCE_SSL_CERT_REQS_NONE,

        [EnumMember(Value = "SOURCE_SSL_CERT_REQS_OPTIONAL")]
        SOURCE_SSL_CERT_REQS_OPTIONAL,

        [EnumMember(Value = "SOURCE_SSL_CERT_REQS_REQUIRED")]
        SOURCE_SSL_CERT_REQS_REQUIRED


    } // enum SourceSslCertReqs

} // namespace Rubrik.SecurityCloud.Types