// AsyncJobStatusJobId.cs
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
    #region AsyncJobStatusJobId
    public class AsyncJobStatusJobId: IFragment
    {
        #region members
        //      C# -> System.String? JobId
        // GraphQL -> jobId: String! (scalar)
        [JsonProperty("jobId")]
        public System.String? JobId { get; set; }

        //      C# -> System.String? RubrikObjectId
        // GraphQL -> rubrikObjectId: String! (scalar)
        [JsonProperty("rubrikObjectId")]
        public System.String? RubrikObjectId { get; set; }

        #endregion

    #region methods

    public AsyncJobStatusJobId Set(
        System.String? JobId = null,
        System.String? RubrikObjectId = null
    ) 
    {
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( RubrikObjectId != null ) {
            this.RubrikObjectId = RubrikObjectId;
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
            //      C# -> System.String? JobId
            // GraphQL -> jobId: String! (scalar)
            if (this.JobId != null)
            {
                 s += ind + "jobId\n";

            }
            //      C# -> System.String? RubrikObjectId
            // GraphQL -> rubrikObjectId: String! (scalar)
            if (this.RubrikObjectId != null)
            {
                 s += ind + "rubrikObjectId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? JobId
            // GraphQL -> jobId: String! (scalar)
            if (this.JobId == null && Exploration.Includes(parent + ".jobId$"))
            {
                this.JobId = new System.String("FETCH");
            }
            //      C# -> System.String? RubrikObjectId
            // GraphQL -> rubrikObjectId: String! (scalar)
            if (this.RubrikObjectId == null && Exploration.Includes(parent + ".rubrikObjectId$"))
            {
                this.RubrikObjectId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AsyncJobStatusJobId
    #endregion

    public static class ListAsyncJobStatusJobIdExtensions
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
            this List<AsyncJobStatusJobId> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AsyncJobStatusJobId> list, 
            String parent = "")
        {
            var item = new AsyncJobStatusJobId();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types