// VsphereDatacenterPhysicalChildTypeEdge.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:05.
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
    #region VsphereDatacenterPhysicalChildTypeEdge
    public class VsphereDatacenterPhysicalChildTypeEdge: IFragment
    {
        #region members
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }

        //      C# -> VsphereDatacenterPhysicalChildType? Node
        // GraphQL -> node: VsphereDatacenterPhysicalChildType! (interface)
        [JsonProperty("node")]
        public VsphereDatacenterPhysicalChildType? Node { get; set; }

        #endregion

    #region methods

    public VsphereDatacenterPhysicalChildTypeEdge Set(
        System.String? Cursor = null,
        VsphereDatacenterPhysicalChildType? Node = null
    ) 
    {
        if ( Cursor != null ) {
            this.Cursor = Cursor;
        }
        if ( Node != null ) {
            this.Node = Node;
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
            //      C# -> System.String? Cursor
            // GraphQL -> cursor: String! (scalar)
            if (this.Cursor != null)
            {
                 s += ind + "cursor\n";

            }
                        //      C# -> VsphereDatacenterPhysicalChildType? Node
            // GraphQL -> node: VsphereDatacenterPhysicalChildType! (interface)
            if (this.Node != null)
            {
                s += ind + "node\n";
                s += ind + "{\n";

                string typename = this.Node.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.Node.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Cursor
            // GraphQL -> cursor: String! (scalar)
            if (this.Cursor == null && Exploration.Includes(parent + ".cursor$"))
            {
                this.Cursor = new System.String("FETCH");
            }
            //      C# -> VsphereDatacenterPhysicalChildType? Node
            // GraphQL -> node: VsphereDatacenterPhysicalChildType! (interface)
            if (this.Node == null && Exploration.Includes(parent + ".node"))
            {
                this.Node = (VsphereDatacenterPhysicalChildType)InterfaceHelper.CreateInstanceOfFirstType(typeof(VsphereDatacenterPhysicalChildType));
                this.Node.ApplyExploratoryFragment(parent + ".node");
            }
        }


    #endregion

    } // class VsphereDatacenterPhysicalChildTypeEdge
    #endregion

    public static class ListVsphereDatacenterPhysicalChildTypeEdgeExtensions
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
            this List<VsphereDatacenterPhysicalChildTypeEdge> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VsphereDatacenterPhysicalChildTypeEdge> list, 
            String parent = "")
        {
            var item = new VsphereDatacenterPhysicalChildTypeEdge();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types