// BulkUpdateMssqlPropertiesOnWindowsClusterReply.cs
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
    #region BulkUpdateMssqlPropertiesOnWindowsClusterReply
    public class BulkUpdateMssqlPropertiesOnWindowsClusterReply: BaseType
    {
        #region members

        //      C# -> List<MssqlInstanceDetail>? Items
        // GraphQL -> items: [MssqlInstanceDetail!]! (type)
        [JsonProperty("items")]
        public List<MssqlInstanceDetail>? Items { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkUpdateMssqlPropertiesOnWindowsClusterReply";
    }

    public BulkUpdateMssqlPropertiesOnWindowsClusterReply Set(
        List<MssqlInstanceDetail>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
        //      C# -> List<MssqlInstanceDetail>? Items
        // GraphQL -> items: [MssqlInstanceDetail!]! (type)
        if (this.Items != null) {
            var fspec = this.Items.AsFieldSpec(conf.Child("items"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "items {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<MssqlInstanceDetail>? Items
        // GraphQL -> items: [MssqlInstanceDetail!]! (type)
        if (ec.Includes("items",false))
        {
            if(this.Items == null) {

                this.Items = new List<MssqlInstanceDetail>();
                this.Items.ApplyExploratoryFieldSpec(ec.NewChild("items"));

            } else {

                this.Items.ApplyExploratoryFieldSpec(ec.NewChild("items"));

            }
        }
        else if (this.Items != null && ec.Excludes("items",false))
        {
            this.Items = null;
        }
    }


    #endregion

    } // class BulkUpdateMssqlPropertiesOnWindowsClusterReply
    
    #endregion

    public static class ListBulkUpdateMssqlPropertiesOnWindowsClusterReplyExtensions
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
            this List<BulkUpdateMssqlPropertiesOnWindowsClusterReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<BulkUpdateMssqlPropertiesOnWindowsClusterReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkUpdateMssqlPropertiesOnWindowsClusterReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkUpdateMssqlPropertiesOnWindowsClusterReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkUpdateMssqlPropertiesOnWindowsClusterReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types