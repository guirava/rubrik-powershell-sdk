// StartAzureCloudAccountOauthReply.cs
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
    #region StartAzureCloudAccountOauthReply
    public class StartAzureCloudAccountOauthReply: IFragment
    {
        #region members
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? SessionId
        // GraphQL -> sessionId: String! (scalar)
        [JsonProperty("sessionId")]
        public System.String? SessionId { get; set; }

        #endregion

    #region methods

    public StartAzureCloudAccountOauthReply Set(
        System.String? ClientId = null,
        System.String? SessionId = null
    ) 
    {
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( SessionId != null ) {
            this.SessionId = SessionId;
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
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId != null)
            {
                 s += ind + "clientId\n";

            }
            //      C# -> System.String? SessionId
            // GraphQL -> sessionId: String! (scalar)
            if (this.SessionId != null)
            {
                 s += ind + "sessionId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ClientId
            // GraphQL -> clientId: String! (scalar)
            if (this.ClientId == null && Exploration.Includes(parent + ".clientId$"))
            {
                this.ClientId = new System.String("FETCH");
            }
            //      C# -> System.String? SessionId
            // GraphQL -> sessionId: String! (scalar)
            if (this.SessionId == null && Exploration.Includes(parent + ".sessionId$"))
            {
                this.SessionId = new System.String("FETCH");
            }
        }


    #endregion

    } // class StartAzureCloudAccountOauthReply
    #endregion

    public static class ListStartAzureCloudAccountOauthReplyExtensions
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
            this List<StartAzureCloudAccountOauthReply> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<StartAzureCloudAccountOauthReply> list, 
            String parent = "")
        {
            var item = new StartAzureCloudAccountOauthReply();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types