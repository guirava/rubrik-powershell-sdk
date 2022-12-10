// TimeSeriesResult.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:30.
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
    #region TimeSeriesResult
    public class TimeSeriesResult: IFragment
    {
        #region members
        //      C# -> System.Int64? Count
        // GraphQL -> count: Long! (scalar)
        [JsonProperty("count")]
        public System.Int64? Count { get; set; }

        //      C# -> System.String? Timestamp
        // GraphQL -> timestamp: String! (scalar)
        [JsonProperty("timestamp")]
        public System.String? Timestamp { get; set; }

        #endregion

    #region methods

    public TimeSeriesResult Set(
        System.Int64? Count = null,
        System.String? Timestamp = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Timestamp != null ) {
            this.Timestamp = Timestamp;
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
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.String? Timestamp
            // GraphQL -> timestamp: String! (scalar)
            if (this.Timestamp != null)
            {
                 s += ind + "timestamp\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int64? Count
            // GraphQL -> count: Long! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int64();
            }
            //      C# -> System.String? Timestamp
            // GraphQL -> timestamp: String! (scalar)
            if (this.Timestamp == null && Exploration.Includes(parent + ".timestamp$"))
            {
                this.Timestamp = new System.String("FETCH");
            }
        }


    #endregion

    } // class TimeSeriesResult
    #endregion

    public static class ListTimeSeriesResultExtensions
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
            this List<TimeSeriesResult> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TimeSeriesResult> list, 
            String parent = "")
        {
            var item = new TimeSeriesResult();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types