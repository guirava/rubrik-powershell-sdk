// SlaUpgrade.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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
    #region SlaUpgrade
    public class SlaUpgrade: IFragment
    {
        #region members
        //      C# -> System.String? Msg
        // GraphQL -> msg: String! (scalar)
        [JsonProperty("msg")]
        public System.String? Msg { get; set; }

        //      C# -> System.String? TaskchainId
        // GraphQL -> taskchainId: String! (scalar)
        [JsonProperty("taskchainId")]
        public System.String? TaskchainId { get; set; }

        //      C# -> SlaMigrationStatus? Status
        // GraphQL -> status: SlaMigrationStatus! (enum)
        [JsonProperty("status")]
        public SlaMigrationStatus? Status { get; set; }

        #endregion

    #region methods

    public SlaUpgrade Set(
        System.String? Msg = null,
        System.String? TaskchainId = null,
        SlaMigrationStatus? Status = null
    ) 
    {
        if ( Msg != null ) {
            this.Msg = Msg;
        }
        if ( TaskchainId != null ) {
            this.TaskchainId = TaskchainId;
        }
        if ( Status != null ) {
            this.Status = Status;
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
            //      C# -> System.String? Msg
            // GraphQL -> msg: String! (scalar)
            if (this.Msg != null)
            {
                 s += ind + "msg\n";

            }
            //      C# -> System.String? TaskchainId
            // GraphQL -> taskchainId: String! (scalar)
            if (this.TaskchainId != null)
            {
                 s += ind + "taskchainId\n";

            }
            //      C# -> SlaMigrationStatus? Status
            // GraphQL -> status: SlaMigrationStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Msg
            // GraphQL -> msg: String! (scalar)
            if (this.Msg == null && Exploration.Includes(parent + ".msg$"))
            {
                this.Msg = new System.String("FETCH");
            }
            //      C# -> System.String? TaskchainId
            // GraphQL -> taskchainId: String! (scalar)
            if (this.TaskchainId == null && Exploration.Includes(parent + ".taskchainId$"))
            {
                this.TaskchainId = new System.String("FETCH");
            }
            //      C# -> SlaMigrationStatus? Status
            // GraphQL -> status: SlaMigrationStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new SlaMigrationStatus();
            }
        }


    #endregion

    } // class SlaUpgrade
    #endregion

    public static class ListSlaUpgradeExtensions
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
            this List<SlaUpgrade> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaUpgrade> list, 
            String parent = "")
        {
            var item = new SlaUpgrade();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types