// SupportTunnelInfo.cs
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
    #region SupportTunnelInfo
    public class SupportTunnelInfo: BaseType
    {
        #region members

        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        [JsonProperty("enabledTime")]
        public DateTime? EnabledTime { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        [JsonProperty("inactivityTimeoutInSeconds")]
        public System.Int64? InactivityTimeoutInSeconds { get; set; }

        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        [JsonProperty("isTunnelEnabled")]
        public System.Boolean? IsTunnelEnabled { get; set; }

        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        [JsonProperty("lastActivityTime")]
        public DateTime? LastActivityTime { get; set; }

        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        [JsonProperty("port")]
        public System.Int64? Port { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SupportTunnelInfo";
    }

    public SupportTunnelInfo Set(
        DateTime? EnabledTime = null,
        System.String? ErrorMessage = null,
        System.Int64? InactivityTimeoutInSeconds = null,
        System.Boolean? IsTunnelEnabled = null,
        DateTime? LastActivityTime = null,
        System.Int64? Port = null
    ) 
    {
        if ( EnabledTime != null ) {
            this.EnabledTime = EnabledTime;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( InactivityTimeoutInSeconds != null ) {
            this.InactivityTimeoutInSeconds = InactivityTimeoutInSeconds;
        }
        if ( IsTunnelEnabled != null ) {
            this.IsTunnelEnabled = IsTunnelEnabled;
        }
        if ( LastActivityTime != null ) {
            this.LastActivityTime = LastActivityTime;
        }
        if ( Port != null ) {
            this.Port = Port;
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
        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        if (this.EnabledTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enabledTime\n" ;
            } else {
                s += ind + "enabledTime\n" ;
            }
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (this.ErrorMessage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "errorMessage\n" ;
            } else {
                s += ind + "errorMessage\n" ;
            }
        }
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        if (this.InactivityTimeoutInSeconds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "inactivityTimeoutInSeconds\n" ;
            } else {
                s += ind + "inactivityTimeoutInSeconds\n" ;
            }
        }
        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        if (this.IsTunnelEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isTunnelEnabled\n" ;
            } else {
                s += ind + "isTunnelEnabled\n" ;
            }
        }
        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        if (this.LastActivityTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastActivityTime\n" ;
            } else {
                s += ind + "lastActivityTime\n" ;
            }
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        if (this.Port != null) {
            if (conf.Flat) {
                s += conf.Prefix + "port\n" ;
            } else {
                s += ind + "port\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EnabledTime
        // GraphQL -> enabledTime: DateTime (scalar)
        if (ec.Includes("enabledTime",true))
        {
            if(this.EnabledTime == null) {

                this.EnabledTime = new DateTime();

            } else {


            }
        }
        else if (this.EnabledTime != null && ec.Excludes("enabledTime",true))
        {
            this.EnabledTime = null;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String (scalar)
        if (ec.Includes("errorMessage",true))
        {
            if(this.ErrorMessage == null) {

                this.ErrorMessage = "FETCH";

            } else {


            }
        }
        else if (this.ErrorMessage != null && ec.Excludes("errorMessage",true))
        {
            this.ErrorMessage = null;
        }
        //      C# -> System.Int64? InactivityTimeoutInSeconds
        // GraphQL -> inactivityTimeoutInSeconds: Long (scalar)
        if (ec.Includes("inactivityTimeoutInSeconds",true))
        {
            if(this.InactivityTimeoutInSeconds == null) {

                this.InactivityTimeoutInSeconds = new System.Int64();

            } else {


            }
        }
        else if (this.InactivityTimeoutInSeconds != null && ec.Excludes("inactivityTimeoutInSeconds",true))
        {
            this.InactivityTimeoutInSeconds = null;
        }
        //      C# -> System.Boolean? IsTunnelEnabled
        // GraphQL -> isTunnelEnabled: Boolean! (scalar)
        if (ec.Includes("isTunnelEnabled",true))
        {
            if(this.IsTunnelEnabled == null) {

                this.IsTunnelEnabled = true;

            } else {


            }
        }
        else if (this.IsTunnelEnabled != null && ec.Excludes("isTunnelEnabled",true))
        {
            this.IsTunnelEnabled = null;
        }
        //      C# -> DateTime? LastActivityTime
        // GraphQL -> lastActivityTime: DateTime (scalar)
        if (ec.Includes("lastActivityTime",true))
        {
            if(this.LastActivityTime == null) {

                this.LastActivityTime = new DateTime();

            } else {


            }
        }
        else if (this.LastActivityTime != null && ec.Excludes("lastActivityTime",true))
        {
            this.LastActivityTime = null;
        }
        //      C# -> System.Int64? Port
        // GraphQL -> port: Long (scalar)
        if (ec.Includes("port",true))
        {
            if(this.Port == null) {

                this.Port = new System.Int64();

            } else {


            }
        }
        else if (this.Port != null && ec.Excludes("port",true))
        {
            this.Port = null;
        }
    }


    #endregion

    } // class SupportTunnelInfo
    
    #endregion

    public static class ListSupportTunnelInfoExtensions
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
            this List<SupportTunnelInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<SupportTunnelInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SupportTunnelInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SupportTunnelInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SupportTunnelInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types