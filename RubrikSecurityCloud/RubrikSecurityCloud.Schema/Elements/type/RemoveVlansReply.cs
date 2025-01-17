// RemoveVlansReply.cs
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
    #region RemoveVlansReply
    public class RemoveVlansReply: BaseType
    {
        #region members

        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        [JsonProperty("failureVlanIds")]
        public List<System.Int32>? FailureVlanIds { get; set; }

        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        [JsonProperty("successVlanIds")]
        public List<System.Int32>? SuccessVlanIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RemoveVlansReply";
    }

    public RemoveVlansReply Set(
        List<System.Int32>? FailureVlanIds = null,
        List<System.Int32>? SuccessVlanIds = null
    ) 
    {
        if ( FailureVlanIds != null ) {
            this.FailureVlanIds = FailureVlanIds;
        }
        if ( SuccessVlanIds != null ) {
            this.SuccessVlanIds = SuccessVlanIds;
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
        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        if (this.FailureVlanIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "failureVlanIds\n" ;
            } else {
                s += ind + "failureVlanIds\n" ;
            }
        }
        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        if (this.SuccessVlanIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "successVlanIds\n" ;
            } else {
                s += ind + "successVlanIds\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.Int32>? FailureVlanIds
        // GraphQL -> failureVlanIds: [Int!]! (scalar)
        if (ec.Includes("failureVlanIds",true))
        {
            if(this.FailureVlanIds == null) {

                this.FailureVlanIds = new List<System.Int32>();

            } else {


            }
        }
        else if (this.FailureVlanIds != null && ec.Excludes("failureVlanIds",true))
        {
            this.FailureVlanIds = null;
        }
        //      C# -> List<System.Int32>? SuccessVlanIds
        // GraphQL -> successVlanIds: [Int!]! (scalar)
        if (ec.Includes("successVlanIds",true))
        {
            if(this.SuccessVlanIds == null) {

                this.SuccessVlanIds = new List<System.Int32>();

            } else {


            }
        }
        else if (this.SuccessVlanIds != null && ec.Excludes("successVlanIds",true))
        {
            this.SuccessVlanIds = null;
        }
    }


    #endregion

    } // class RemoveVlansReply
    
    #endregion

    public static class ListRemoveVlansReplyExtensions
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
            this List<RemoveVlansReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RemoveVlansReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RemoveVlansReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RemoveVlansReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RemoveVlansReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types