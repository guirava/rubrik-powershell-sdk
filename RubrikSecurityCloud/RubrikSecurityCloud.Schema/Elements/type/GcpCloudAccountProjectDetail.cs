// GcpCloudAccountProjectDetail.cs
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
    #region GcpCloudAccountProjectDetail
    public class GcpCloudAccountProjectDetail: IFragment
    {
        #region members
        //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
        // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
        [JsonProperty("featureDetail")]
        public GcpCloudAccountFeatureDetail? FeatureDetail { get; set; }

        //      C# -> GcpCloudAccountProject? Project
        // GraphQL -> project: GcpCloudAccountProject (type)
        [JsonProperty("project")]
        public GcpCloudAccountProject? Project { get; set; }

        #endregion

    #region methods

    public GcpCloudAccountProjectDetail Set(
        GcpCloudAccountFeatureDetail? FeatureDetail = null,
        GcpCloudAccountProject? Project = null
    ) 
    {
        if ( FeatureDetail != null ) {
            this.FeatureDetail = FeatureDetail;
        }
        if ( Project != null ) {
            this.Project = Project;
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
            //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
            // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
            if (this.FeatureDetail != null)
            {
                 s += ind + "featureDetail\n";

                 s += ind + "{\n" + 
                 this.FeatureDetail.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> GcpCloudAccountProject? Project
            // GraphQL -> project: GcpCloudAccountProject (type)
            if (this.Project != null)
            {
                 s += ind + "project\n";

                 s += ind + "{\n" + 
                 this.Project.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> GcpCloudAccountFeatureDetail? FeatureDetail
            // GraphQL -> featureDetail: GcpCloudAccountFeatureDetail (type)
            if (this.FeatureDetail == null && Exploration.Includes(parent + ".featureDetail"))
            {
                this.FeatureDetail = new GcpCloudAccountFeatureDetail();
                this.FeatureDetail.ApplyExploratoryFragment(parent + ".featureDetail");
            }
            //      C# -> GcpCloudAccountProject? Project
            // GraphQL -> project: GcpCloudAccountProject (type)
            if (this.Project == null && Exploration.Includes(parent + ".project"))
            {
                this.Project = new GcpCloudAccountProject();
                this.Project.ApplyExploratoryFragment(parent + ".project");
            }
        }


    #endregion

    } // class GcpCloudAccountProjectDetail
    #endregion

    public static class ListGcpCloudAccountProjectDetailExtensions
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
            this List<GcpCloudAccountProjectDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpCloudAccountProjectDetail> list, 
            String parent = "")
        {
            var item = new GcpCloudAccountProjectDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types