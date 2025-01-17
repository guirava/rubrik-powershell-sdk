// MssqlDbReplicaAvailabilityInfo.cs
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
    #region MssqlDbReplicaAvailabilityInfo
    public class MssqlDbReplicaAvailabilityInfo: BaseType
    {
        #region members

        //      C# -> MssqlDbReplicaAvailabilityInfoRole? Role
        // GraphQL -> role: MssqlDbReplicaAvailabilityInfoRole! (enum)
        [JsonProperty("role")]
        public MssqlDbReplicaAvailabilityInfoRole? Role { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlDbReplicaAvailabilityInfo";
    }

    public MssqlDbReplicaAvailabilityInfo Set(
        MssqlDbReplicaAvailabilityInfoRole? Role = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
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
        //      C# -> MssqlDbReplicaAvailabilityInfoRole? Role
        // GraphQL -> role: MssqlDbReplicaAvailabilityInfoRole! (enum)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MssqlDbReplicaAvailabilityInfoRole? Role
        // GraphQL -> role: MssqlDbReplicaAvailabilityInfoRole! (enum)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = new MssqlDbReplicaAvailabilityInfoRole();

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
    }


    #endregion

    } // class MssqlDbReplicaAvailabilityInfo
    
    #endregion

    public static class ListMssqlDbReplicaAvailabilityInfoExtensions
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
            this List<MssqlDbReplicaAvailabilityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlDbReplicaAvailabilityInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDbReplicaAvailabilityInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDbReplicaAvailabilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDbReplicaAvailabilityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types