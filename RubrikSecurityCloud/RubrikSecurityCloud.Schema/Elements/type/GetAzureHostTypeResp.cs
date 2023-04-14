// GetAzureHostTypeResp.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region GetAzureHostTypeResp
    public class GetAzureHostTypeResp: IFragment
    {
        #region members
        //      C# -> AzureHostType? HostType
        // GraphQL -> hostType: AzureHostType! (enum)
        [JsonProperty("hostType")]
        public AzureHostType? HostType { get; set; }

        #endregion

    #region methods

    public GetAzureHostTypeResp Set(
        AzureHostType? HostType = null
    ) 
    {
        if ( HostType != null ) {
            this.HostType = HostType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> AzureHostType? HostType
            // GraphQL -> hostType: AzureHostType! (enum)
            if (this.HostType != null)
            {
                 s += ind + "hostType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> AzureHostType? HostType
            // GraphQL -> hostType: AzureHostType! (enum)
            if (this.HostType == null && Exploration.Includes(parent + ".hostType$"))
            {
                this.HostType = new AzureHostType();
            }
        }


    #endregion

    } // class GetAzureHostTypeResp
    #endregion

    public static class ListGetAzureHostTypeRespExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<GetAzureHostTypeResp> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GetAzureHostTypeResp> list, 
            String parent = "")
        {
            var item = new GetAzureHostTypeResp();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types