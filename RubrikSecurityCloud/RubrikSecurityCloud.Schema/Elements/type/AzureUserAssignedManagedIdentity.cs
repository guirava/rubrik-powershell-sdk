// AzureUserAssignedManagedIdentity.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:25.
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
    #region AzureUserAssignedManagedIdentity
    public class AzureUserAssignedManagedIdentity: IFragment
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? PrincipalId
        // GraphQL -> principalId: String! (scalar)
        [JsonProperty("principalId")]
        public System.String? PrincipalId { get; set; }

        #endregion

    #region methods

    public AzureUserAssignedManagedIdentity Set(
        System.String? Name = null,
        System.String? NativeId = null,
        System.String? PrincipalId = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( PrincipalId != null ) {
            this.PrincipalId = PrincipalId;
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId != null)
            {
                 s += ind + "nativeId\n";

            }
            //      C# -> System.String? PrincipalId
            // GraphQL -> principalId: String! (scalar)
            if (this.PrincipalId != null)
            {
                 s += ind + "principalId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? NativeId
            // GraphQL -> nativeId: String! (scalar)
            if (this.NativeId == null && Exploration.Includes(parent + ".nativeId$"))
            {
                this.NativeId = new System.String("FETCH");
            }
            //      C# -> System.String? PrincipalId
            // GraphQL -> principalId: String! (scalar)
            if (this.PrincipalId == null && Exploration.Includes(parent + ".principalId$"))
            {
                this.PrincipalId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AzureUserAssignedManagedIdentity
    #endregion

    public static class ListAzureUserAssignedManagedIdentityExtensions
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
            this List<AzureUserAssignedManagedIdentity> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AzureUserAssignedManagedIdentity> list, 
            String parent = "")
        {
            var item = new AzureUserAssignedManagedIdentity();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types