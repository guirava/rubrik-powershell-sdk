// GatewayInfo.cs
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
    #region GatewayInfo
    public class GatewayInfo: BaseType
    {
        #region members

        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> List<System.Int32>? Ports
        // GraphQL -> ports: [Int!]! (scalar)
        [JsonProperty("ports")]
        public List<System.Int32>? Ports { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GatewayInfo";
    }

    public GatewayInfo Set(
        System.String? Address = null,
        List<System.Int32>? Ports = null
    ) 
    {
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Ports != null ) {
            this.Ports = Ports;
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
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            if (conf.Flat) {
                s += conf.Prefix + "address\n" ;
            } else {
                s += ind + "address\n" ;
            }
        }
        //      C# -> List<System.Int32>? Ports
        // GraphQL -> ports: [Int!]! (scalar)
        if (this.Ports != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ports\n" ;
            } else {
                s += ind + "ports\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (ec.Includes("address",true))
        {
            if(this.Address == null) {

                this.Address = "FETCH";

            } else {


            }
        }
        else if (this.Address != null && ec.Excludes("address",true))
        {
            this.Address = null;
        }
        //      C# -> List<System.Int32>? Ports
        // GraphQL -> ports: [Int!]! (scalar)
        if (ec.Includes("ports",true))
        {
            if(this.Ports == null) {

                this.Ports = new List<System.Int32>();

            } else {


            }
        }
        else if (this.Ports != null && ec.Excludes("ports",true))
        {
            this.Ports = null;
        }
    }


    #endregion

    } // class GatewayInfo
    
    #endregion

    public static class ListGatewayInfoExtensions
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
            this List<GatewayInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GatewayInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GatewayInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GatewayInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GatewayInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types