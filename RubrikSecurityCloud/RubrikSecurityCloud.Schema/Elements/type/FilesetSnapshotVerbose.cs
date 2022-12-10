// FilesetSnapshotVerbose.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:33.
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
    #region FilesetSnapshotVerbose
    public class FilesetSnapshotVerbose: IFragment
    {
        #region members
        //      C# -> System.Boolean? HasFingerprint
        // GraphQL -> hasFingerprint: Boolean! (scalar)
        [JsonProperty("hasFingerprint")]
        public System.Boolean? HasFingerprint { get; set; }

        //      C# -> List<System.String>? PartitionPaths
        // GraphQL -> partitionPaths: [String!]! (scalar)
        [JsonProperty("partitionPaths")]
        public List<System.String>? PartitionPaths { get; set; }

        #endregion

    #region methods

    public FilesetSnapshotVerbose Set(
        System.Boolean? HasFingerprint = null,
        List<System.String>? PartitionPaths = null
    ) 
    {
        if ( HasFingerprint != null ) {
            this.HasFingerprint = HasFingerprint;
        }
        if ( PartitionPaths != null ) {
            this.PartitionPaths = PartitionPaths;
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
            //      C# -> System.Boolean? HasFingerprint
            // GraphQL -> hasFingerprint: Boolean! (scalar)
            if (this.HasFingerprint != null)
            {
                 s += ind + "hasFingerprint\n";

            }
            //      C# -> List<System.String>? PartitionPaths
            // GraphQL -> partitionPaths: [String!]! (scalar)
            if (this.PartitionPaths != null)
            {
                 s += ind + "partitionPaths\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? HasFingerprint
            // GraphQL -> hasFingerprint: Boolean! (scalar)
            if (this.HasFingerprint == null && Exploration.Includes(parent + ".hasFingerprint$"))
            {
                this.HasFingerprint = new System.Boolean();
            }
            //      C# -> List<System.String>? PartitionPaths
            // GraphQL -> partitionPaths: [String!]! (scalar)
            if (this.PartitionPaths == null && Exploration.Includes(parent + ".partitionPaths$"))
            {
                this.PartitionPaths = new List<System.String>();
            }
        }


    #endregion

    } // class FilesetSnapshotVerbose
    #endregion

    public static class ListFilesetSnapshotVerboseExtensions
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
            this List<FilesetSnapshotVerbose> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetSnapshotVerbose> list, 
            String parent = "")
        {
            var item = new FilesetSnapshotVerbose();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types