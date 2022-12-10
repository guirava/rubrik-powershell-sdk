// TriggerExocomputeHealthCheckReply.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:23.
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
    #region TriggerExocomputeHealthCheckReply
    public class TriggerExocomputeHealthCheckReply: IFragment
    {
        #region members
        //      C# -> System.String? HealthCheckJobId
        // GraphQL -> healthCheckJobId: String! (scalar)
        [JsonProperty("healthCheckJobId")]
        public System.String? HealthCheckJobId { get; set; }

        #endregion

    #region methods

    public TriggerExocomputeHealthCheckReply Set(
        System.String? HealthCheckJobId = null
    ) 
    {
        if ( HealthCheckJobId != null ) {
            this.HealthCheckJobId = HealthCheckJobId;
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
            //      C# -> System.String? HealthCheckJobId
            // GraphQL -> healthCheckJobId: String! (scalar)
            if (this.HealthCheckJobId != null)
            {
                 s += ind + "healthCheckJobId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HealthCheckJobId
            // GraphQL -> healthCheckJobId: String! (scalar)
            if (this.HealthCheckJobId == null && Exploration.Includes(parent + ".healthCheckJobId$"))
            {
                this.HealthCheckJobId = new System.String("FETCH");
            }
        }


    #endregion

    } // class TriggerExocomputeHealthCheckReply
    #endregion

    public static class ListTriggerExocomputeHealthCheckReplyExtensions
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
            this List<TriggerExocomputeHealthCheckReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TriggerExocomputeHealthCheckReply> list, 
            String parent = "")
        {
            var item = new TriggerExocomputeHealthCheckReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types