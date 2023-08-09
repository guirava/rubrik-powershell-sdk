// AwsRscAccountDetails.cs
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
    #region AwsRscAccountDetails
    public class AwsRscAccountDetails: BaseType
    {
        #region members

        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        [JsonProperty("awsCloudAccountId")]
        public System.String? AwsCloudAccountId { get; set; }

        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        [JsonProperty("awsNativeId")]
        public System.String? AwsNativeId { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsRscAccountDetails";
    }

    public AwsRscAccountDetails Set(
        System.String? AwsCloudAccountId = null,
        System.String? AwsNativeId = null,
        System.String? Message = null
    ) 
    {
        if ( AwsCloudAccountId != null ) {
            this.AwsCloudAccountId = AwsCloudAccountId;
        }
        if ( AwsNativeId != null ) {
            this.AwsNativeId = AwsNativeId;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        if (this.AwsCloudAccountId != null) {
            s += ind + "awsCloudAccountId\n" ;
        }
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId != null) {
            s += ind + "awsNativeId\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? AwsCloudAccountId
        // GraphQL -> awsCloudAccountId: String! (scalar)
        if (this.AwsCloudAccountId == null && Exploration.Includes(parent + ".awsCloudAccountId", true))
        {
            this.AwsCloudAccountId = "FETCH";
        }
        //      C# -> System.String? AwsNativeId
        // GraphQL -> awsNativeId: String! (scalar)
        if (this.AwsNativeId == null && Exploration.Includes(parent + ".awsNativeId", true))
        {
            this.AwsNativeId = "FETCH";
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = "FETCH";
        }
    }


    #endregion

    } // class AwsRscAccountDetails
    
    #endregion

    public static class ListAwsRscAccountDetailsExtensions
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
            this List<AwsRscAccountDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsRscAccountDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsRscAccountDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types