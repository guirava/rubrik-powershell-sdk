// HelpContentSnippetsFilterInitiator.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:01.
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
    public enum HelpContentSnippetsFilterInitiator
    {
        [EnumMember(Value = "DEBUG")]
        DEBUG,

        [EnumMember(Value = "INITIATOR_UNSPECIFIED")]
        INITIATOR_UNSPECIFIED,

        [EnumMember(Value = "RECOMMENDATION")]
        RECOMMENDATION,

        [EnumMember(Value = "USER")]
        USER


    } // enum HelpContentSnippetsFilterInitiator

} // namespace Rubrik.SecurityCloud.Types