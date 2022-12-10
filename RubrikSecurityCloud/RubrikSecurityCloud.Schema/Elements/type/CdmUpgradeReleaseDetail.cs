// CdmUpgradeReleaseDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:11.
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
    #region CdmUpgradeReleaseDetail
    public class CdmUpgradeReleaseDetail: IFragment
    {
        #region members
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? GaReleaseDate
        // GraphQL -> gaReleaseDate: String! (scalar)
        [JsonProperty("gaReleaseDate")]
        public System.String? GaReleaseDate { get; set; }

        //      C# -> System.Boolean? IsRecommended
        // GraphQL -> isRecommended: Boolean! (scalar)
        [JsonProperty("isRecommended")]
        public System.Boolean? IsRecommended { get; set; }

        //      C# -> System.Boolean? IsUpgradable
        // GraphQL -> isUpgradable: Boolean! (scalar)
        [JsonProperty("isUpgradable")]
        public System.Boolean? IsUpgradable { get; set; }

        //      C# -> System.String? Md5Sum
        // GraphQL -> md5Sum: String! (scalar)
        [JsonProperty("md5Sum")]
        public System.String? Md5Sum { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ReleaseDate
        // GraphQL -> releaseDate: String! (scalar)
        [JsonProperty("releaseDate")]
        public System.String? ReleaseDate { get; set; }

        //      C# -> System.String? ReleaseNotesLink
        // GraphQL -> releaseNotesLink: String! (scalar)
        [JsonProperty("releaseNotesLink")]
        public System.String? ReleaseNotesLink { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? TarDownloadLink
        // GraphQL -> tarDownloadLink: String! (scalar)
        [JsonProperty("tarDownloadLink")]
        public System.String? TarDownloadLink { get; set; }

        //      C# -> AdoptionStatus? AdoptionStatus
        // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
        [JsonProperty("adoptionStatus")]
        public AdoptionStatus? AdoptionStatus { get; set; }

        #endregion

    #region methods

    public CdmUpgradeReleaseDetail Set(
        System.String? Description = null,
        System.String? GaReleaseDate = null,
        System.Boolean? IsRecommended = null,
        System.Boolean? IsUpgradable = null,
        System.String? Md5Sum = null,
        System.String? Name = null,
        System.String? ReleaseDate = null,
        System.String? ReleaseNotesLink = null,
        System.Int64? Size = null,
        System.String? TarDownloadLink = null,
        AdoptionStatus? AdoptionStatus = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( GaReleaseDate != null ) {
            this.GaReleaseDate = GaReleaseDate;
        }
        if ( IsRecommended != null ) {
            this.IsRecommended = IsRecommended;
        }
        if ( IsUpgradable != null ) {
            this.IsUpgradable = IsUpgradable;
        }
        if ( Md5Sum != null ) {
            this.Md5Sum = Md5Sum;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ReleaseDate != null ) {
            this.ReleaseDate = ReleaseDate;
        }
        if ( ReleaseNotesLink != null ) {
            this.ReleaseNotesLink = ReleaseNotesLink;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( TarDownloadLink != null ) {
            this.TarDownloadLink = TarDownloadLink;
        }
        if ( AdoptionStatus != null ) {
            this.AdoptionStatus = AdoptionStatus;
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
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description != null)
            {
                 s += ind + "description\n";

            }
            //      C# -> System.String? GaReleaseDate
            // GraphQL -> gaReleaseDate: String! (scalar)
            if (this.GaReleaseDate != null)
            {
                 s += ind + "gaReleaseDate\n";

            }
            //      C# -> System.Boolean? IsRecommended
            // GraphQL -> isRecommended: Boolean! (scalar)
            if (this.IsRecommended != null)
            {
                 s += ind + "isRecommended\n";

            }
            //      C# -> System.Boolean? IsUpgradable
            // GraphQL -> isUpgradable: Boolean! (scalar)
            if (this.IsUpgradable != null)
            {
                 s += ind + "isUpgradable\n";

            }
            //      C# -> System.String? Md5Sum
            // GraphQL -> md5Sum: String! (scalar)
            if (this.Md5Sum != null)
            {
                 s += ind + "md5Sum\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ReleaseDate
            // GraphQL -> releaseDate: String! (scalar)
            if (this.ReleaseDate != null)
            {
                 s += ind + "releaseDate\n";

            }
            //      C# -> System.String? ReleaseNotesLink
            // GraphQL -> releaseNotesLink: String! (scalar)
            if (this.ReleaseNotesLink != null)
            {
                 s += ind + "releaseNotesLink\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? TarDownloadLink
            // GraphQL -> tarDownloadLink: String! (scalar)
            if (this.TarDownloadLink != null)
            {
                 s += ind + "tarDownloadLink\n";

            }
            //      C# -> AdoptionStatus? AdoptionStatus
            // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
            if (this.AdoptionStatus != null)
            {
                 s += ind + "adoptionStatus\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Description
            // GraphQL -> description: String! (scalar)
            if (this.Description == null && Exploration.Includes(parent + ".description$"))
            {
                this.Description = new System.String("FETCH");
            }
            //      C# -> System.String? GaReleaseDate
            // GraphQL -> gaReleaseDate: String! (scalar)
            if (this.GaReleaseDate == null && Exploration.Includes(parent + ".gaReleaseDate$"))
            {
                this.GaReleaseDate = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsRecommended
            // GraphQL -> isRecommended: Boolean! (scalar)
            if (this.IsRecommended == null && Exploration.Includes(parent + ".isRecommended$"))
            {
                this.IsRecommended = new System.Boolean();
            }
            //      C# -> System.Boolean? IsUpgradable
            // GraphQL -> isUpgradable: Boolean! (scalar)
            if (this.IsUpgradable == null && Exploration.Includes(parent + ".isUpgradable$"))
            {
                this.IsUpgradable = new System.Boolean();
            }
            //      C# -> System.String? Md5Sum
            // GraphQL -> md5Sum: String! (scalar)
            if (this.Md5Sum == null && Exploration.Includes(parent + ".md5Sum$"))
            {
                this.Md5Sum = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ReleaseDate
            // GraphQL -> releaseDate: String! (scalar)
            if (this.ReleaseDate == null && Exploration.Includes(parent + ".releaseDate$"))
            {
                this.ReleaseDate = new System.String("FETCH");
            }
            //      C# -> System.String? ReleaseNotesLink
            // GraphQL -> releaseNotesLink: String! (scalar)
            if (this.ReleaseNotesLink == null && Exploration.Includes(parent + ".releaseNotesLink$"))
            {
                this.ReleaseNotesLink = new System.String("FETCH");
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? TarDownloadLink
            // GraphQL -> tarDownloadLink: String! (scalar)
            if (this.TarDownloadLink == null && Exploration.Includes(parent + ".tarDownloadLink$"))
            {
                this.TarDownloadLink = new System.String("FETCH");
            }
            //      C# -> AdoptionStatus? AdoptionStatus
            // GraphQL -> adoptionStatus: AdoptionStatus! (enum)
            if (this.AdoptionStatus == null && Exploration.Includes(parent + ".adoptionStatus$"))
            {
                this.AdoptionStatus = new AdoptionStatus();
            }
        }


    #endregion

    } // class CdmUpgradeReleaseDetail
    #endregion

    public static class ListCdmUpgradeReleaseDetailExtensions
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
            this List<CdmUpgradeReleaseDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmUpgradeReleaseDetail> list, 
            String parent = "")
        {
            var item = new CdmUpgradeReleaseDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types