// GetMfaSettingReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region GetMfaSettingReply
    public class GetMfaSettingReply: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsTotpEnforcedGlobal
        // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
        [JsonProperty("isTotpEnforcedGlobal")]
        public System.Boolean? IsTotpEnforcedGlobal { get; set; }

        //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
        // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
        [JsonProperty("isTotpGlobalEnforceLocked")]
        public System.Boolean? IsTotpGlobalEnforceLocked { get; set; }

        //      C# -> System.Boolean? IsTotpMandatory
        // GraphQL -> isTotpMandatory: Boolean! (scalar)
        [JsonProperty("isTotpMandatory")]
        public System.Boolean? IsTotpMandatory { get; set; }

        //      C# -> DateTime? MandatoryTotpEnforcementDate
        // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
        [JsonProperty("mandatoryTotpEnforcementDate")]
        public DateTime? MandatoryTotpEnforcementDate { get; set; }

        //      C# -> System.Int32? MfaRememberHours
        // GraphQL -> mfaRememberHours: Int! (scalar)
        [JsonProperty("mfaRememberHours")]
        public System.Int32? MfaRememberHours { get; set; }

        //      C# -> System.Int32? TotpReminderHours
        // GraphQL -> totpReminderHours: Int! (scalar)
        [JsonProperty("totpReminderHours")]
        public System.Int32? TotpReminderHours { get; set; }

        #endregion

    #region methods

    public GetMfaSettingReply Set(
        System.Boolean? IsTotpEnforcedGlobal = null,
        System.Boolean? IsTotpGlobalEnforceLocked = null,
        System.Boolean? IsTotpMandatory = null,
        DateTime? MandatoryTotpEnforcementDate = null,
        System.Int32? MfaRememberHours = null,
        System.Int32? TotpReminderHours = null
    ) 
    {
        if ( IsTotpEnforcedGlobal != null ) {
            this.IsTotpEnforcedGlobal = IsTotpEnforcedGlobal;
        }
        if ( IsTotpGlobalEnforceLocked != null ) {
            this.IsTotpGlobalEnforceLocked = IsTotpGlobalEnforceLocked;
        }
        if ( IsTotpMandatory != null ) {
            this.IsTotpMandatory = IsTotpMandatory;
        }
        if ( MandatoryTotpEnforcementDate != null ) {
            this.MandatoryTotpEnforcementDate = MandatoryTotpEnforcementDate;
        }
        if ( MfaRememberHours != null ) {
            this.MfaRememberHours = MfaRememberHours;
        }
        if ( TotpReminderHours != null ) {
            this.TotpReminderHours = TotpReminderHours;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Boolean? IsTotpEnforcedGlobal
            // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
            if (this.IsTotpEnforcedGlobal != null)
            {
                 s += ind + "isTotpEnforcedGlobal\n";

            }
            //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
            // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
            if (this.IsTotpGlobalEnforceLocked != null)
            {
                 s += ind + "isTotpGlobalEnforceLocked\n";

            }
            //      C# -> System.Boolean? IsTotpMandatory
            // GraphQL -> isTotpMandatory: Boolean! (scalar)
            if (this.IsTotpMandatory != null)
            {
                 s += ind + "isTotpMandatory\n";

            }
            //      C# -> DateTime? MandatoryTotpEnforcementDate
            // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
            if (this.MandatoryTotpEnforcementDate != null)
            {
                 s += ind + "mandatoryTotpEnforcementDate\n";

            }
            //      C# -> System.Int32? MfaRememberHours
            // GraphQL -> mfaRememberHours: Int! (scalar)
            if (this.MfaRememberHours != null)
            {
                 s += ind + "mfaRememberHours\n";

            }
            //      C# -> System.Int32? TotpReminderHours
            // GraphQL -> totpReminderHours: Int! (scalar)
            if (this.TotpReminderHours != null)
            {
                 s += ind + "totpReminderHours\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsTotpEnforcedGlobal
            // GraphQL -> isTotpEnforcedGlobal: Boolean! (scalar)
            if (this.IsTotpEnforcedGlobal == null && Exploration.Includes(parent + ".isTotpEnforcedGlobal$"))
            {
                this.IsTotpEnforcedGlobal = new System.Boolean();
            }
            //      C# -> System.Boolean? IsTotpGlobalEnforceLocked
            // GraphQL -> isTotpGlobalEnforceLocked: Boolean! (scalar)
            if (this.IsTotpGlobalEnforceLocked == null && Exploration.Includes(parent + ".isTotpGlobalEnforceLocked$"))
            {
                this.IsTotpGlobalEnforceLocked = new System.Boolean();
            }
            //      C# -> System.Boolean? IsTotpMandatory
            // GraphQL -> isTotpMandatory: Boolean! (scalar)
            if (this.IsTotpMandatory == null && Exploration.Includes(parent + ".isTotpMandatory$"))
            {
                this.IsTotpMandatory = new System.Boolean();
            }
            //      C# -> DateTime? MandatoryTotpEnforcementDate
            // GraphQL -> mandatoryTotpEnforcementDate: DateTime (scalar)
            if (this.MandatoryTotpEnforcementDate == null && Exploration.Includes(parent + ".mandatoryTotpEnforcementDate$"))
            {
                this.MandatoryTotpEnforcementDate = new DateTime();
            }
            //      C# -> System.Int32? MfaRememberHours
            // GraphQL -> mfaRememberHours: Int! (scalar)
            if (this.MfaRememberHours == null && Exploration.Includes(parent + ".mfaRememberHours$"))
            {
                this.MfaRememberHours = new System.Int32();
            }
            //      C# -> System.Int32? TotpReminderHours
            // GraphQL -> totpReminderHours: Int! (scalar)
            if (this.TotpReminderHours == null && Exploration.Includes(parent + ".totpReminderHours$"))
            {
                this.TotpReminderHours = new System.Int32();
            }
        }


    #endregion

    } // class GetMfaSettingReply
    #endregion

    public static class ListGetMfaSettingReplyExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GetMfaSettingReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetMfaSettingReply> list, 
            String parent = "")
        {
            var item = new GetMfaSettingReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types