// AgentStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:07.
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
    #region AgentStatus
    public class AgentStatus: IFragment
    {
        #region members
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }

        //      C# -> AgentConnectionStatus? AgentStatusField
        // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
        [JsonProperty("agentStatus")]
        public AgentConnectionStatus? AgentStatusField { get; set; }

        #endregion

    #region methods

    public AgentStatus Set(
        System.String? DisconnectReason = null,
        AgentConnectionStatus? AgentStatusField = null
    ) 
    {
        if ( DisconnectReason != null ) {
            this.DisconnectReason = DisconnectReason;
        }
        if ( AgentStatusField != null ) {
            this.AgentStatusField = AgentStatusField;
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
            //      C# -> System.String? DisconnectReason
            // GraphQL -> disconnectReason: String (scalar)
            if (this.DisconnectReason != null)
            {
                 s += ind + "disconnectReason\n";

            }
            //      C# -> AgentConnectionStatus? AgentStatusField
            // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
            if (this.AgentStatusField != null)
            {
                 s += ind + "agentStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DisconnectReason
            // GraphQL -> disconnectReason: String (scalar)
            if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason$"))
            {
                this.DisconnectReason = new System.String("FETCH");
            }
            //      C# -> AgentConnectionStatus? AgentStatusField
            // GraphQL -> agentStatus: AgentConnectionStatus! (enum)
            if (this.AgentStatusField == null && Exploration.Includes(parent + ".agentStatus$"))
            {
                this.AgentStatusField = new AgentConnectionStatus();
            }
        }


    #endregion

    } // class AgentStatus
    #endregion

    public static class ListAgentStatusExtensions
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
            this List<AgentStatus> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AgentStatus> list, 
            String parent = "")
        {
            var item = new AgentStatus();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types