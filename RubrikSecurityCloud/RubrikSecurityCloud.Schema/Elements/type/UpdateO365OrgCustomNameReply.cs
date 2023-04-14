// UpdateO365OrgCustomNameReply.cs
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
    #region UpdateO365OrgCustomNameReply
    public class UpdateO365OrgCustomNameReply: IFragment
    {
        #region members
        //      C# -> System.String? CustomName
        // GraphQL -> customName: String! (scalar)
        [JsonProperty("customName")]
        public System.String? CustomName { get; set; }

        //      C# -> System.String? OrgUuid
        // GraphQL -> orgUuid: UUID! (scalar)
        [JsonProperty("orgUuid")]
        public System.String? OrgUuid { get; set; }

        #endregion

    #region methods

    public UpdateO365OrgCustomNameReply Set(
        System.String? CustomName = null,
        System.String? OrgUuid = null
    ) 
    {
        if ( CustomName != null ) {
            this.CustomName = CustomName;
        }
        if ( OrgUuid != null ) {
            this.OrgUuid = OrgUuid;
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
            //      C# -> System.String? CustomName
            // GraphQL -> customName: String! (scalar)
            if (this.CustomName != null)
            {
                 s += ind + "customName\n";

            }
            //      C# -> System.String? OrgUuid
            // GraphQL -> orgUuid: UUID! (scalar)
            if (this.OrgUuid != null)
            {
                 s += ind + "orgUuid\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CustomName
            // GraphQL -> customName: String! (scalar)
            if (this.CustomName == null && Exploration.Includes(parent + ".customName$"))
            {
                this.CustomName = new System.String("FETCH");
            }
            //      C# -> System.String? OrgUuid
            // GraphQL -> orgUuid: UUID! (scalar)
            if (this.OrgUuid == null && Exploration.Includes(parent + ".orgUuid$"))
            {
                this.OrgUuid = new System.String("FETCH");
            }
        }


    #endregion

    } // class UpdateO365OrgCustomNameReply
    #endregion

    public static class ListUpdateO365OrgCustomNameReplyExtensions
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
            this List<UpdateO365OrgCustomNameReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<UpdateO365OrgCustomNameReply> list, 
            String parent = "")
        {
            var item = new UpdateO365OrgCustomNameReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types