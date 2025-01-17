// NutanixBatchAsyncApiResponse.cs
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
    #region NutanixBatchAsyncApiResponse
    public class NutanixBatchAsyncApiResponse: BaseType
    {
        #region members

        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        [JsonProperty("failedRequests")]
        public List<NutanixAsyncRequestFailureSummary>? FailedRequests { get; set; }

        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        [JsonProperty("successfulRequests")]
        public List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixBatchAsyncApiResponse";
    }

    public NutanixBatchAsyncApiResponse Set(
        List<NutanixAsyncRequestFailureSummary>? FailedRequests = null,
        List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests = null
    ) 
    {
        if ( FailedRequests != null ) {
            this.FailedRequests = FailedRequests;
        }
        if ( SuccessfulRequests != null ) {
            this.SuccessfulRequests = SuccessfulRequests;
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
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        if (this.FailedRequests != null) {
            var fspec = this.FailedRequests.AsFieldSpec(conf.Child("failedRequests"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "failedRequests {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        if (this.SuccessfulRequests != null) {
            var fspec = this.SuccessfulRequests.AsFieldSpec(conf.Child("successfulRequests"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "successfulRequests {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<NutanixAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [NutanixAsyncRequestFailureSummary!]! (type)
        if (ec.Includes("failedRequests",false))
        {
            if(this.FailedRequests == null) {

                this.FailedRequests = new List<NutanixAsyncRequestFailureSummary>();
                this.FailedRequests.ApplyExploratoryFieldSpec(ec.NewChild("failedRequests"));

            } else {

                this.FailedRequests.ApplyExploratoryFieldSpec(ec.NewChild("failedRequests"));

            }
        }
        else if (this.FailedRequests != null && ec.Excludes("failedRequests",false))
        {
            this.FailedRequests = null;
        }
        //      C# -> List<NutanixAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [NutanixAsyncRequestSuccessSummary!]! (type)
        if (ec.Includes("successfulRequests",false))
        {
            if(this.SuccessfulRequests == null) {

                this.SuccessfulRequests = new List<NutanixAsyncRequestSuccessSummary>();
                this.SuccessfulRequests.ApplyExploratoryFieldSpec(ec.NewChild("successfulRequests"));

            } else {

                this.SuccessfulRequests.ApplyExploratoryFieldSpec(ec.NewChild("successfulRequests"));

            }
        }
        else if (this.SuccessfulRequests != null && ec.Excludes("successfulRequests",false))
        {
            this.SuccessfulRequests = null;
        }
    }


    #endregion

    } // class NutanixBatchAsyncApiResponse
    
    #endregion

    public static class ListNutanixBatchAsyncApiResponseExtensions
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
            this List<NutanixBatchAsyncApiResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NutanixBatchAsyncApiResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixBatchAsyncApiResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixBatchAsyncApiResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixBatchAsyncApiResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types