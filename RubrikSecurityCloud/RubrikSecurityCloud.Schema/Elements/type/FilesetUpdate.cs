// FilesetUpdate.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region FilesetUpdate
    public class FilesetUpdate: BaseType
    {
        #region members

        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        [JsonProperty("forceFull")]
        public System.Boolean? ForceFull { get; set; }

        //      C# -> List<System.Int32>? ForceFullPartitionIds
        // GraphQL -> forceFullPartitionIds: [Int!]! (scalar)
        [JsonProperty("forceFullPartitionIds")]
        public List<System.Int32>? ForceFullPartitionIds { get; set; }

        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForFullBackup")]
        public System.String? SnapMirrorLabelForFullBackup { get; set; }

        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        [JsonProperty("snapMirrorLabelForIncrementalBackup")]
        public System.String? SnapMirrorLabelForIncrementalBackup { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "FilesetUpdate";
    }

    public FilesetUpdate Set(
        System.String? ConfiguredSlaDomainId = null,
        System.Boolean? ForceFull = null,
        List<System.Int32>? ForceFullPartitionIds = null,
        System.String? SnapMirrorLabelForFullBackup = null,
        System.String? SnapMirrorLabelForIncrementalBackup = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( ForceFull != null ) {
            this.ForceFull = ForceFull;
        }
        if ( ForceFullPartitionIds != null ) {
            this.ForceFullPartitionIds = ForceFullPartitionIds;
        }
        if ( SnapMirrorLabelForFullBackup != null ) {
            this.SnapMirrorLabelForFullBackup = SnapMirrorLabelForFullBackup;
        }
        if ( SnapMirrorLabelForIncrementalBackup != null ) {
            this.SnapMirrorLabelForIncrementalBackup = SnapMirrorLabelForIncrementalBackup;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (this.ConfiguredSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "configuredSlaDomainId\n" ;
            } else {
                s += ind + "configuredSlaDomainId\n" ;
            }
        }
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        if (this.ForceFull != null) {
            if (conf.Flat) {
                s += conf.Prefix + "forceFull\n" ;
            } else {
                s += ind + "forceFull\n" ;
            }
        }
        //      C# -> List<System.Int32>? ForceFullPartitionIds
        // GraphQL -> forceFullPartitionIds: [Int!]! (scalar)
        if (this.ForceFullPartitionIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "forceFullPartitionIds\n" ;
            } else {
                s += ind + "forceFullPartitionIds\n" ;
            }
        }
        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        if (this.SnapMirrorLabelForFullBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapMirrorLabelForFullBackup\n" ;
            } else {
                s += ind + "snapMirrorLabelForFullBackup\n" ;
            }
        }
        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        if (this.SnapMirrorLabelForIncrementalBackup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapMirrorLabelForIncrementalBackup\n" ;
            } else {
                s += ind + "snapMirrorLabelForIncrementalBackup\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        if (ec.Includes("configuredSlaDomainId",true))
        {
            if(this.ConfiguredSlaDomainId == null) {

                this.ConfiguredSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.ConfiguredSlaDomainId != null && ec.Excludes("configuredSlaDomainId",true))
        {
            this.ConfiguredSlaDomainId = null;
        }
        //      C# -> System.Boolean? ForceFull
        // GraphQL -> forceFull: Boolean (scalar)
        if (ec.Includes("forceFull",true))
        {
            if(this.ForceFull == null) {

                this.ForceFull = true;

            } else {


            }
        }
        else if (this.ForceFull != null && ec.Excludes("forceFull",true))
        {
            this.ForceFull = null;
        }
        //      C# -> List<System.Int32>? ForceFullPartitionIds
        // GraphQL -> forceFullPartitionIds: [Int!]! (scalar)
        if (ec.Includes("forceFullPartitionIds",true))
        {
            if(this.ForceFullPartitionIds == null) {

                this.ForceFullPartitionIds = new List<System.Int32>();

            } else {


            }
        }
        else if (this.ForceFullPartitionIds != null && ec.Excludes("forceFullPartitionIds",true))
        {
            this.ForceFullPartitionIds = null;
        }
        //      C# -> System.String? SnapMirrorLabelForFullBackup
        // GraphQL -> snapMirrorLabelForFullBackup: String (scalar)
        if (ec.Includes("snapMirrorLabelForFullBackup",true))
        {
            if(this.SnapMirrorLabelForFullBackup == null) {

                this.SnapMirrorLabelForFullBackup = "FETCH";

            } else {


            }
        }
        else if (this.SnapMirrorLabelForFullBackup != null && ec.Excludes("snapMirrorLabelForFullBackup",true))
        {
            this.SnapMirrorLabelForFullBackup = null;
        }
        //      C# -> System.String? SnapMirrorLabelForIncrementalBackup
        // GraphQL -> snapMirrorLabelForIncrementalBackup: String (scalar)
        if (ec.Includes("snapMirrorLabelForIncrementalBackup",true))
        {
            if(this.SnapMirrorLabelForIncrementalBackup == null) {

                this.SnapMirrorLabelForIncrementalBackup = "FETCH";

            } else {


            }
        }
        else if (this.SnapMirrorLabelForIncrementalBackup != null && ec.Excludes("snapMirrorLabelForIncrementalBackup",true))
        {
            this.SnapMirrorLabelForIncrementalBackup = null;
        }
    }


    #endregion

    } // class FilesetUpdate
    
    #endregion

    public static class ListFilesetUpdateExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<FilesetUpdate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<FilesetUpdate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<FilesetUpdate> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new FilesetUpdate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<FilesetUpdate> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types