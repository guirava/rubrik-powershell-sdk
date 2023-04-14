// MongoCollectionSetDescendantTypeConnection.cs
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
    #region MongoCollectionSetDescendantTypeConnection
    public class MongoCollectionSetDescendantTypeConnection: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<MongoCollectionSetDescendantTypeEdge>? Edges
        // GraphQL -> edges: [MongoCollectionSetDescendantTypeEdge!]! (type)
        [JsonProperty("edges")]
        public List<MongoCollectionSetDescendantTypeEdge>? Edges { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        //      C# -> List<MongoCollectionSetDescendantType>? Nodes
        // GraphQL -> nodes: [MongoCollectionSetDescendantType!]! (interface)
        [JsonProperty("nodes")]
        public List<MongoCollectionSetDescendantType>? Nodes { get; set; }

        #endregion

    #region methods

    public MongoCollectionSetDescendantTypeConnection Set(
        System.Int32? Count = null,
        List<MongoCollectionSetDescendantTypeEdge>? Edges = null,
        PageInfo? PageInfo = null,
        List<MongoCollectionSetDescendantType>? Nodes = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> List<MongoCollectionSetDescendantTypeEdge>? Edges
            // GraphQL -> edges: [MongoCollectionSetDescendantTypeEdge!]! (type)
            if (this.Edges != null)
            {
                 s += ind + "edges\n";

                 s += ind + "{\n" + 
                 this.Edges.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo != null)
            {
                 s += ind + "pageInfo\n";

                 s += ind + "{\n" + 
                 this.PageInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
                        //      C# -> List<MongoCollectionSetDescendantType>? Nodes
            // GraphQL -> nodes: [MongoCollectionSetDescendantType!]! (interface)
            if (this.Nodes != null)
            {
                s += ind + "nodes\n";
                s += ind + "{\n";

                s += this.Nodes.AsFragment(indent+1) +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> List<MongoCollectionSetDescendantTypeEdge>? Edges
            // GraphQL -> edges: [MongoCollectionSetDescendantTypeEdge!]! (type)
            if (this.Edges == null && Exploration.Includes(parent + ".edges"))
            {
                this.Edges = new List<MongoCollectionSetDescendantTypeEdge>();
                this.Edges.ApplyExploratoryFragment(parent + ".edges");
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
            //      C# -> List<MongoCollectionSetDescendantType>? Nodes
            // GraphQL -> nodes: [MongoCollectionSetDescendantType!]! (interface)
            if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
            {
                this.Nodes = new List<MongoCollectionSetDescendantType>();
                this.Nodes.ApplyExploratoryFragment(parent + ".nodes");
            }
        }


    #endregion

    } // class MongoCollectionSetDescendantTypeConnection
    #endregion

    public static class ListMongoCollectionSetDescendantTypeConnectionExtensions
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
            this List<MongoCollectionSetDescendantTypeConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MongoCollectionSetDescendantTypeConnection> list, 
            String parent = "")
        {
            var item = new MongoCollectionSetDescendantTypeConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types