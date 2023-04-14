// NodeStatusListResponse.cs
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
    #region NodeStatusListResponse
    public class NodeStatusListResponse: IFragment
    {
        #region members
        //      C# -> System.Boolean? HasMore
        // GraphQL -> hasMore: Boolean (scalar)
        [JsonProperty("hasMore")]
        public System.Boolean? HasMore { get; set; }

        //      C# -> System.Int64? Total
        // GraphQL -> total: Long (scalar)
        [JsonProperty("total")]
        public System.Int64? Total { get; set; }

        //      C# -> List<NodeStatus>? Data
        // GraphQL -> data: [NodeStatus!]! (type)
        [JsonProperty("data")]
        public List<NodeStatus>? Data { get; set; }

        #endregion

    #region methods

    public NodeStatusListResponse Set(
        System.Boolean? HasMore = null,
        System.Int64? Total = null,
        List<NodeStatus>? Data = null
    ) 
    {
        if ( HasMore != null ) {
            this.HasMore = HasMore;
        }
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Data != null ) {
            this.Data = Data;
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
            //      C# -> System.Boolean? HasMore
            // GraphQL -> hasMore: Boolean (scalar)
            if (this.HasMore != null)
            {
                 s += ind + "hasMore\n";

            }
            //      C# -> System.Int64? Total
            // GraphQL -> total: Long (scalar)
            if (this.Total != null)
            {
                 s += ind + "total\n";

            }
            //      C# -> List<NodeStatus>? Data
            // GraphQL -> data: [NodeStatus!]! (type)
            if (this.Data != null)
            {
                 s += ind + "data\n";

                 s += ind + "{\n" + 
                 this.Data.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? HasMore
            // GraphQL -> hasMore: Boolean (scalar)
            if (this.HasMore == null && Exploration.Includes(parent + ".hasMore$"))
            {
                this.HasMore = new System.Boolean();
            }
            //      C# -> System.Int64? Total
            // GraphQL -> total: Long (scalar)
            if (this.Total == null && Exploration.Includes(parent + ".total$"))
            {
                this.Total = new System.Int64();
            }
            //      C# -> List<NodeStatus>? Data
            // GraphQL -> data: [NodeStatus!]! (type)
            if (this.Data == null && Exploration.Includes(parent + ".data"))
            {
                this.Data = new List<NodeStatus>();
                this.Data.ApplyExploratoryFragment(parent + ".data");
            }
        }


    #endregion

    } // class NodeStatusListResponse
    #endregion

    public static class ListNodeStatusListResponseExtensions
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
            this List<NodeStatusListResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NodeStatusListResponse> list, 
            String parent = "")
        {
            var item = new NodeStatusListResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types