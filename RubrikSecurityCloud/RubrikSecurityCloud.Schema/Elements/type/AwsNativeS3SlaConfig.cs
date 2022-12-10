// AwsNativeS3SlaConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:03.
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
    #region AwsNativeS3SlaConfig
    public class AwsNativeS3SlaConfig: IFragment
    {
        #region members
        //      C# -> System.Int32? ContinuousBackupRetentionInDays
        // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
        [JsonProperty("continuousBackupRetentionInDays")]
        public System.Int32? ContinuousBackupRetentionInDays { get; set; }

        #endregion

    #region methods

    public AwsNativeS3SlaConfig Set(
        System.Int32? ContinuousBackupRetentionInDays = null
    ) 
    {
        if ( ContinuousBackupRetentionInDays != null ) {
            this.ContinuousBackupRetentionInDays = ContinuousBackupRetentionInDays;
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
            //      C# -> System.Int32? ContinuousBackupRetentionInDays
            // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
            if (this.ContinuousBackupRetentionInDays != null)
            {
                 s += ind + "continuousBackupRetentionInDays\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? ContinuousBackupRetentionInDays
            // GraphQL -> continuousBackupRetentionInDays: Int! (scalar)
            if (this.ContinuousBackupRetentionInDays == null && Exploration.Includes(parent + ".continuousBackupRetentionInDays$"))
            {
                this.ContinuousBackupRetentionInDays = new System.Int32();
            }
        }


    #endregion

    } // class AwsNativeS3SlaConfig
    #endregion

    public static class ListAwsNativeS3SlaConfigExtensions
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
            this List<AwsNativeS3SlaConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AwsNativeS3SlaConfig> list, 
            String parent = "")
        {
            var item = new AwsNativeS3SlaConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types