// NutanixClusterLogicalChildTypeEdge.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region NutanixClusterLogicalChildTypeEdge
    public class NutanixClusterLogicalChildTypeEdge: BaseType
    {
        #region members

        //      C# -> NutanixClusterLogicalChildType? Node
        // GraphQL -> node: NutanixClusterLogicalChildType! (interface)
        [JsonProperty("node")]
        public NutanixClusterLogicalChildType? Node { get; set; }

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixClusterLogicalChildTypeEdge";
    }

    public NutanixClusterLogicalChildTypeEdge Set(
        NutanixClusterLogicalChildType? Node = null,
        System.String? Cursor = null
    ) 
    {
        if ( Node != null ) {
            this.Node = Node;
        }
        if ( Cursor != null ) {
            this.Cursor = Cursor;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> NutanixClusterLogicalChildType? Node
        // GraphQL -> node: NutanixClusterLogicalChildType! (interface)
        if (this.Node != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Node).AsFieldSpec(conf.Child("node"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "node {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cursor\n" ;
            } else {
                s += ind + "cursor\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NutanixClusterLogicalChildType? Node
        // GraphQL -> node: NutanixClusterLogicalChildType! (interface)
        if (ec.Includes("node",false))
        {
            if(this.Node == null) {

                var impls = new List<NutanixClusterLogicalChildType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("node"));
                this.Node = (NutanixClusterLogicalChildType)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<NutanixClusterLogicalChildType>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("node"));
                this.Node = (NutanixClusterLogicalChildType)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Node != null && ec.Excludes("node",false))
        {
            this.Node = null;
        }
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (ec.Includes("cursor",true))
        {
            if(this.Cursor == null) {

                this.Cursor = "FETCH";

            } else {


            }
        }
        else if (this.Cursor != null && ec.Excludes("cursor",true))
        {
            this.Cursor = null;
        }
    }


    #endregion

    } // class NutanixClusterLogicalChildTypeEdge
    
    #endregion

    public static class ListNutanixClusterLogicalChildTypeEdgeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<NutanixClusterLogicalChildTypeEdge> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NutanixClusterLogicalChildTypeEdge> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixClusterLogicalChildTypeEdge> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixClusterLogicalChildTypeEdge());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixClusterLogicalChildTypeEdge> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types