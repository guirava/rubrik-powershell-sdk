// MssqlMissedRecoverableRangeError.cs
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
    #region MssqlMissedRecoverableRangeError
    public class MssqlMissedRecoverableRangeError: BaseType
    {
        #region members

        //      C# -> System.String? EventMessage
        // GraphQL -> eventMessage: String (scalar)
        [JsonProperty("eventMessage")]
        public System.String? EventMessage { get; set; }

        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        [JsonProperty("eventSeriesId")]
        public System.String? EventSeriesId { get; set; }

        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        [JsonProperty("time")]
        public DateTime? Time { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MssqlMissedRecoverableRangeError";
    }

    public MssqlMissedRecoverableRangeError Set(
        System.String? EventMessage = null,
        System.String? EventSeriesId = null,
        DateTime? Time = null
    ) 
    {
        if ( EventMessage != null ) {
            this.EventMessage = EventMessage;
        }
        if ( EventSeriesId != null ) {
            this.EventSeriesId = EventSeriesId;
        }
        if ( Time != null ) {
            this.Time = Time;
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
        //      C# -> System.String? EventMessage
        // GraphQL -> eventMessage: String (scalar)
        if (this.EventMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventMessage\n" ;
            } else {
                s += ind + "eventMessage\n" ;
            }
        }
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        if (this.EventSeriesId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "eventSeriesId\n" ;
            } else {
                s += ind + "eventSeriesId\n" ;
            }
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (this.Time != null) {
            if (conf.Flat) {
                s += conf.Prefix + "time\n" ;
            } else {
                s += ind + "time\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? EventMessage
        // GraphQL -> eventMessage: String (scalar)
        if (ec.Includes("eventMessage",true))
        {
            if(this.EventMessage == null) {

                this.EventMessage = "FETCH";

            } else {


            }
        }
        else if (this.EventMessage != null && ec.Excludes("eventMessage",true))
        {
            this.EventMessage = null;
        }
        //      C# -> System.String? EventSeriesId
        // GraphQL -> eventSeriesId: String (scalar)
        if (ec.Includes("eventSeriesId",true))
        {
            if(this.EventSeriesId == null) {

                this.EventSeriesId = "FETCH";

            } else {


            }
        }
        else if (this.EventSeriesId != null && ec.Excludes("eventSeriesId",true))
        {
            this.EventSeriesId = null;
        }
        //      C# -> DateTime? Time
        // GraphQL -> time: DateTime (scalar)
        if (ec.Includes("time",true))
        {
            if(this.Time == null) {

                this.Time = new DateTime();

            } else {


            }
        }
        else if (this.Time != null && ec.Excludes("time",true))
        {
            this.Time = null;
        }
    }


    #endregion

    } // class MssqlMissedRecoverableRangeError
    
    #endregion

    public static class ListMssqlMissedRecoverableRangeErrorExtensions
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
            this List<MssqlMissedRecoverableRangeError> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<MssqlMissedRecoverableRangeError> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MssqlMissedRecoverableRangeError> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlMissedRecoverableRangeError());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlMissedRecoverableRangeError> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types