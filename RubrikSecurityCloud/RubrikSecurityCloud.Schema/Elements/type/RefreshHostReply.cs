// RefreshHostReply.cs
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
    #region RefreshHostReply
    public class RefreshHostReply: BaseType
    {
        #region members

        //      C# -> HostDetail? Output
        // GraphQL -> output: HostDetail (type)
        [JsonProperty("output")]
        public HostDetail? Output { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RefreshHostReply";
    }

    public RefreshHostReply Set(
        HostDetail? Output = null
    ) 
    {
        if ( Output != null ) {
            this.Output = Output;
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
        //      C# -> HostDetail? Output
        // GraphQL -> output: HostDetail (type)
        if (this.Output != null) {
            var fspec = this.Output.AsFieldSpec(conf.Child("output"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "output {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostDetail? Output
        // GraphQL -> output: HostDetail (type)
        if (ec.Includes("output",false))
        {
            if(this.Output == null) {

                this.Output = new HostDetail();
                this.Output.ApplyExploratoryFieldSpec(ec.NewChild("output"));

            } else {

                this.Output.ApplyExploratoryFieldSpec(ec.NewChild("output"));

            }
        }
        else if (this.Output != null && ec.Excludes("output",false))
        {
            this.Output = null;
        }
    }


    #endregion

    } // class RefreshHostReply
    
    #endregion

    public static class ListRefreshHostReplyExtensions
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
            this List<RefreshHostReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RefreshHostReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RefreshHostReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RefreshHostReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RefreshHostReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types