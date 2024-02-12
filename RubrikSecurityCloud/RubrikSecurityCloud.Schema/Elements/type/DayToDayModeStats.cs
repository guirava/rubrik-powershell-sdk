// DayToDayModeStats.cs
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
    #region DayToDayModeStats
    public class DayToDayModeStats: BaseType
    {
        #region members

        //      C# -> System.Int32? NumFullsRemaining
        // GraphQL -> numFullsRemaining: Int! (scalar)
        [JsonProperty("numFullsRemaining")]
        public System.Int32? NumFullsRemaining { get; set; }

        //      C# -> System.Int32? TotalProtectedCount
        // GraphQL -> totalProtectedCount: Int! (scalar)
        [JsonProperty("totalProtectedCount")]
        public System.Int32? TotalProtectedCount { get; set; }

        //      C# -> ComplianceState? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceState (type)
        [JsonProperty("complianceStatus")]
        public ComplianceState? ComplianceStatus { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DayToDayModeStats";
    }

    public DayToDayModeStats Set(
        System.Int32? NumFullsRemaining = null,
        System.Int32? TotalProtectedCount = null,
        ComplianceState? ComplianceStatus = null
    ) 
    {
        if ( NumFullsRemaining != null ) {
            this.NumFullsRemaining = NumFullsRemaining;
        }
        if ( TotalProtectedCount != null ) {
            this.TotalProtectedCount = TotalProtectedCount;
        }
        if ( ComplianceStatus != null ) {
            this.ComplianceStatus = ComplianceStatus;
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
        //      C# -> System.Int32? NumFullsRemaining
        // GraphQL -> numFullsRemaining: Int! (scalar)
        if (this.NumFullsRemaining != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numFullsRemaining\n" ;
            } else {
                s += ind + "numFullsRemaining\n" ;
            }
        }
        //      C# -> System.Int32? TotalProtectedCount
        // GraphQL -> totalProtectedCount: Int! (scalar)
        if (this.TotalProtectedCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalProtectedCount\n" ;
            } else {
                s += ind + "totalProtectedCount\n" ;
            }
        }
        //      C# -> ComplianceState? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceState (type)
        if (this.ComplianceStatus != null) {
            var fspec = this.ComplianceStatus.AsFieldSpec(conf.Child("complianceStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "complianceStatus {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? NumFullsRemaining
        // GraphQL -> numFullsRemaining: Int! (scalar)
        if (ec.Includes("numFullsRemaining",true))
        {
            if(this.NumFullsRemaining == null) {

                this.NumFullsRemaining = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumFullsRemaining != null && ec.Excludes("numFullsRemaining",true))
        {
            this.NumFullsRemaining = null;
        }
        //      C# -> System.Int32? TotalProtectedCount
        // GraphQL -> totalProtectedCount: Int! (scalar)
        if (ec.Includes("totalProtectedCount",true))
        {
            if(this.TotalProtectedCount == null) {

                this.TotalProtectedCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalProtectedCount != null && ec.Excludes("totalProtectedCount",true))
        {
            this.TotalProtectedCount = null;
        }
        //      C# -> ComplianceState? ComplianceStatus
        // GraphQL -> complianceStatus: ComplianceState (type)
        if (ec.Includes("complianceStatus",false))
        {
            if(this.ComplianceStatus == null) {

                this.ComplianceStatus = new ComplianceState();
                this.ComplianceStatus.ApplyExploratoryFieldSpec(ec.NewChild("complianceStatus"));

            } else {

                this.ComplianceStatus.ApplyExploratoryFieldSpec(ec.NewChild("complianceStatus"));

            }
        }
        else if (this.ComplianceStatus != null && ec.Excludes("complianceStatus",false))
        {
            this.ComplianceStatus = null;
        }
    }


    #endregion

    } // class DayToDayModeStats
    
    #endregion

    public static class ListDayToDayModeStatsExtensions
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
            this List<DayToDayModeStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DayToDayModeStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DayToDayModeStats> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DayToDayModeStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DayToDayModeStats> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types