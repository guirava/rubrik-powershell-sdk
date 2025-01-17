// OptionGroup.cs
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
    #region OptionGroup
    public class OptionGroup: BaseType
    {
        #region members

        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        [JsonProperty("arn")]
        public System.String? Arn { get; set; }

        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        [JsonProperty("engine")]
        public System.String? Engine { get; set; }

        //      C# -> System.String? MajorEngineVersion
        // GraphQL -> majorEngineVersion: String! (scalar)
        [JsonProperty("majorEngineVersion")]
        public System.String? MajorEngineVersion { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OptionGroup";
    }

    public OptionGroup Set(
        System.String? Arn = null,
        System.String? Engine = null,
        System.String? MajorEngineVersion = null,
        System.String? Name = null,
        System.String? VpcId = null
    ) 
    {
        if ( Arn != null ) {
            this.Arn = Arn;
        }
        if ( Engine != null ) {
            this.Engine = Engine;
        }
        if ( MajorEngineVersion != null ) {
            this.MajorEngineVersion = MajorEngineVersion;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
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
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (this.Arn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "arn\n" ;
            } else {
                s += ind + "arn\n" ;
            }
        }
        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        if (this.Engine != null) {
            if (conf.Flat) {
                s += conf.Prefix + "engine\n" ;
            } else {
                s += ind + "engine\n" ;
            }
        }
        //      C# -> System.String? MajorEngineVersion
        // GraphQL -> majorEngineVersion: String! (scalar)
        if (this.MajorEngineVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "majorEngineVersion\n" ;
            } else {
                s += ind + "majorEngineVersion\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vpcId\n" ;
            } else {
                s += ind + "vpcId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Arn
        // GraphQL -> arn: String! (scalar)
        if (ec.Includes("arn",true))
        {
            if(this.Arn == null) {

                this.Arn = "FETCH";

            } else {


            }
        }
        else if (this.Arn != null && ec.Excludes("arn",true))
        {
            this.Arn = null;
        }
        //      C# -> System.String? Engine
        // GraphQL -> engine: String! (scalar)
        if (ec.Includes("engine",true))
        {
            if(this.Engine == null) {

                this.Engine = "FETCH";

            } else {


            }
        }
        else if (this.Engine != null && ec.Excludes("engine",true))
        {
            this.Engine = null;
        }
        //      C# -> System.String? MajorEngineVersion
        // GraphQL -> majorEngineVersion: String! (scalar)
        if (ec.Includes("majorEngineVersion",true))
        {
            if(this.MajorEngineVersion == null) {

                this.MajorEngineVersion = "FETCH";

            } else {


            }
        }
        else if (this.MajorEngineVersion != null && ec.Excludes("majorEngineVersion",true))
        {
            this.MajorEngineVersion = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (ec.Includes("vpcId",true))
        {
            if(this.VpcId == null) {

                this.VpcId = "FETCH";

            } else {


            }
        }
        else if (this.VpcId != null && ec.Excludes("vpcId",true))
        {
            this.VpcId = null;
        }
    }


    #endregion

    } // class OptionGroup
    
    #endregion

    public static class ListOptionGroupExtensions
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
            this List<OptionGroup> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<OptionGroup> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OptionGroup> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OptionGroup());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OptionGroup> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types