// RoleStatus.cs
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
    #region RoleStatus
    public class RoleStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasRole
        // GraphQL -> hasRole: Boolean! (scalar)
        [JsonProperty("hasRole")]
        public System.Boolean? HasRole { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RoleStatus";
    }

    public RoleStatus Set(
        System.Boolean? HasRole = null
    ) 
    {
        if ( HasRole != null ) {
            this.HasRole = HasRole;
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
        //      C# -> System.Boolean? HasRole
        // GraphQL -> hasRole: Boolean! (scalar)
        if (this.HasRole != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasRole\n" ;
            } else {
                s += ind + "hasRole\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasRole
        // GraphQL -> hasRole: Boolean! (scalar)
        if (ec.Includes("hasRole",true))
        {
            if(this.HasRole == null) {

                this.HasRole = true;

            } else {


            }
        }
        else if (this.HasRole != null && ec.Excludes("hasRole",true))
        {
            this.HasRole = null;
        }
    }


    #endregion

    } // class RoleStatus
    
    #endregion

    public static class ListRoleStatusExtensions
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
            this List<RoleStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<RoleStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RoleStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RoleStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RoleStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types