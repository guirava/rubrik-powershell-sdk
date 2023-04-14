// ShareExportIdPair.cs
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
    #region ShareExportIdPair
    public class ShareExportIdPair: IFragment
    {
        #region members
        //      C# -> System.Int32? ExportId
        // GraphQL -> exportId: Int! (scalar)
        [JsonProperty("exportId")]
        public System.Int32? ExportId { get; set; }

        //      C# -> System.String? Share
        // GraphQL -> share: String! (scalar)
        [JsonProperty("share")]
        public System.String? Share { get; set; }

        #endregion

    #region methods

    public ShareExportIdPair Set(
        System.Int32? ExportId = null,
        System.String? Share = null
    ) 
    {
        if ( ExportId != null ) {
            this.ExportId = ExportId;
        }
        if ( Share != null ) {
            this.Share = Share;
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
            //      C# -> System.Int32? ExportId
            // GraphQL -> exportId: Int! (scalar)
            if (this.ExportId != null)
            {
                 s += ind + "exportId\n";

            }
            //      C# -> System.String? Share
            // GraphQL -> share: String! (scalar)
            if (this.Share != null)
            {
                 s += ind + "share\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? ExportId
            // GraphQL -> exportId: Int! (scalar)
            if (this.ExportId == null && Exploration.Includes(parent + ".exportId$"))
            {
                this.ExportId = new System.Int32();
            }
            //      C# -> System.String? Share
            // GraphQL -> share: String! (scalar)
            if (this.Share == null && Exploration.Includes(parent + ".share$"))
            {
                this.Share = new System.String("FETCH");
            }
        }


    #endregion

    } // class ShareExportIdPair
    #endregion

    public static class ListShareExportIdPairExtensions
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
            this List<ShareExportIdPair> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ShareExportIdPair> list, 
            String parent = "")
        {
            var item = new ShareExportIdPair();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types