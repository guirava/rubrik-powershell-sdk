// AzureCloudAccountTenantWithExoConfigs.cs
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
    #region AzureCloudAccountTenantWithExoConfigs
    public class AzureCloudAccountTenantWithExoConfigs: BaseType
    {
        #region members

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.Boolean? IsAppRubrikManaged
        // GraphQL -> isAppRubrikManaged: Boolean! (scalar)
        [JsonProperty("isAppRubrikManaged")]
        public System.Boolean? IsAppRubrikManaged { get; set; }

        //      C# -> System.String? RubrikId
        // GraphQL -> rubrikId: String! (scalar)
        [JsonProperty("rubrikId")]
        public System.String? RubrikId { get; set; }

        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        [JsonProperty("subscriptionCount")]
        public System.Int32? SubscriptionCount { get; set; }

        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        [JsonProperty("subscriptions")]
        public List<AzureSubscriptionWithExoConfigs>? Subscriptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountTenantWithExoConfigs";
    }

    public AzureCloudAccountTenantWithExoConfigs Set(
        AzureCloudType? CloudType = null,
        System.String? AppName = null,
        System.String? ClientId = null,
        System.String? DomainName = null,
        System.Boolean? IsAppRubrikManaged = null,
        System.String? RubrikId = null,
        System.Int32? SubscriptionCount = null,
        List<AzureSubscriptionWithExoConfigs>? Subscriptions = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( IsAppRubrikManaged != null ) {
            this.IsAppRubrikManaged = IsAppRubrikManaged;
        }
        if ( RubrikId != null ) {
            this.RubrikId = RubrikId;
        }
        if ( SubscriptionCount != null ) {
            this.SubscriptionCount = SubscriptionCount;
        }
        if ( Subscriptions != null ) {
            this.Subscriptions = Subscriptions;
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
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "appName\n" ;
            } else {
                s += ind + "appName\n" ;
            }
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clientId\n" ;
            } else {
                s += ind + "clientId\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.Boolean? IsAppRubrikManaged
        // GraphQL -> isAppRubrikManaged: Boolean! (scalar)
        if (this.IsAppRubrikManaged != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAppRubrikManaged\n" ;
            } else {
                s += ind + "isAppRubrikManaged\n" ;
            }
        }
        //      C# -> System.String? RubrikId
        // GraphQL -> rubrikId: String! (scalar)
        if (this.RubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikId\n" ;
            } else {
                s += ind + "rubrikId\n" ;
            }
        }
        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        if (this.SubscriptionCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionCount\n" ;
            } else {
                s += ind + "subscriptionCount\n" ;
            }
        }
        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        if (this.Subscriptions != null) {
            var fspec = this.Subscriptions.AsFieldSpec(conf.Child("subscriptions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "subscriptions {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new AzureCloudType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (ec.Includes("appName",true))
        {
            if(this.AppName == null) {

                this.AppName = "FETCH";

            } else {


            }
        }
        else if (this.AppName != null && ec.Excludes("appName",true))
        {
            this.AppName = null;
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (ec.Includes("clientId",true))
        {
            if(this.ClientId == null) {

                this.ClientId = "FETCH";

            } else {


            }
        }
        else if (this.ClientId != null && ec.Excludes("clientId",true))
        {
            this.ClientId = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.Boolean? IsAppRubrikManaged
        // GraphQL -> isAppRubrikManaged: Boolean! (scalar)
        if (ec.Includes("isAppRubrikManaged",true))
        {
            if(this.IsAppRubrikManaged == null) {

                this.IsAppRubrikManaged = true;

            } else {


            }
        }
        else if (this.IsAppRubrikManaged != null && ec.Excludes("isAppRubrikManaged",true))
        {
            this.IsAppRubrikManaged = null;
        }
        //      C# -> System.String? RubrikId
        // GraphQL -> rubrikId: String! (scalar)
        if (ec.Includes("rubrikId",true))
        {
            if(this.RubrikId == null) {

                this.RubrikId = "FETCH";

            } else {


            }
        }
        else if (this.RubrikId != null && ec.Excludes("rubrikId",true))
        {
            this.RubrikId = null;
        }
        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        if (ec.Includes("subscriptionCount",true))
        {
            if(this.SubscriptionCount == null) {

                this.SubscriptionCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SubscriptionCount != null && ec.Excludes("subscriptionCount",true))
        {
            this.SubscriptionCount = null;
        }
        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        if (ec.Includes("subscriptions",false))
        {
            if(this.Subscriptions == null) {

                this.Subscriptions = new List<AzureSubscriptionWithExoConfigs>();
                this.Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("subscriptions"));

            } else {

                this.Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("subscriptions"));

            }
        }
        else if (this.Subscriptions != null && ec.Excludes("subscriptions",false))
        {
            this.Subscriptions = null;
        }
    }


    #endregion

    } // class AzureCloudAccountTenantWithExoConfigs
    
    #endregion

    public static class ListAzureCloudAccountTenantWithExoConfigsExtensions
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
            this List<AzureCloudAccountTenantWithExoConfigs> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountTenantWithExoConfigs> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountTenantWithExoConfigs> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountTenantWithExoConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountTenantWithExoConfigs> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types