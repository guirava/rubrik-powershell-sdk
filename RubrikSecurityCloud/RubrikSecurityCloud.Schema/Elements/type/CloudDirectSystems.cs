// CloudDirectSystems.cs
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
    #region CloudDirectSystems
    public class CloudDirectSystems: BaseType
    {
        #region members

        //      C# -> List<System.String>? Systems
        // GraphQL -> systems: [String!]! (scalar)
        [JsonProperty("systems")]
        public List<System.String>? Systems { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectSystems";
    }

    public CloudDirectSystems Set(
        List<System.String>? Systems = null
    ) 
    {
        if ( Systems != null ) {
            this.Systems = Systems;
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
        //      C# -> List<System.String>? Systems
        // GraphQL -> systems: [String!]! (scalar)
        if (this.Systems != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systems\n" ;
            } else {
                s += ind + "systems\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? Systems
        // GraphQL -> systems: [String!]! (scalar)
        if (ec.Includes("systems",true))
        {
            if(this.Systems == null) {

                this.Systems = new List<System.String>();

            } else {


            }
        }
        else if (this.Systems != null && ec.Excludes("systems",true))
        {
            this.Systems = null;
        }
    }


    #endregion

    } // class CloudDirectSystems
    
    #endregion

    public static class ListCloudDirectSystemsExtensions
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
            this List<CloudDirectSystems> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CloudDirectSystems> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectSystems> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectSystems());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectSystems> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types