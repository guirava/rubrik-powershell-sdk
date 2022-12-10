// VappVmNetworkConnection.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region VappVmNetworkConnection
    public class VappVmNetworkConnection: IFragment
    {
        #region members
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.Boolean? IsConnected
        // GraphQL -> isConnected: Boolean! (scalar)
        [JsonProperty("isConnected")]
        public System.Boolean? IsConnected { get; set; }

        //      C# -> System.String? MacAddress
        // GraphQL -> macAddress: String (scalar)
        [JsonProperty("macAddress")]
        public System.String? MacAddress { get; set; }

        //      C# -> System.String? NetworkAdapterType
        // GraphQL -> networkAdapterType: String (scalar)
        [JsonProperty("networkAdapterType")]
        public System.String? NetworkAdapterType { get; set; }

        //      C# -> System.Int32? NicIndex
        // GraphQL -> nicIndex: Int! (scalar)
        [JsonProperty("nicIndex")]
        public System.Int32? NicIndex { get; set; }

        //      C# -> System.String? VappNetworkName
        // GraphQL -> vappNetworkName: String (scalar)
        [JsonProperty("vappNetworkName")]
        public System.String? VappNetworkName { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        //      C# -> VappVmIpAddressingMode? AddressingMode
        // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
        [JsonProperty("addressingMode")]
        public VappVmIpAddressingMode? AddressingMode { get; set; }

        #endregion

    #region methods

    public VappVmNetworkConnection Set(
        System.String? IpAddress = null,
        System.Boolean? IsConnected = null,
        System.String? MacAddress = null,
        System.String? NetworkAdapterType = null,
        System.Int32? NicIndex = null,
        System.String? VappNetworkName = null,
        PageInfo? PageInfo = null,
        VappVmIpAddressingMode? AddressingMode = null
    ) 
    {
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( IsConnected != null ) {
            this.IsConnected = IsConnected;
        }
        if ( MacAddress != null ) {
            this.MacAddress = MacAddress;
        }
        if ( NetworkAdapterType != null ) {
            this.NetworkAdapterType = NetworkAdapterType;
        }
        if ( NicIndex != null ) {
            this.NicIndex = NicIndex;
        }
        if ( VappNetworkName != null ) {
            this.VappNetworkName = VappNetworkName;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
        }
        if ( AddressingMode != null ) {
            this.AddressingMode = AddressingMode;
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
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String (scalar)
            if (this.IpAddress != null)
            {
                 s += ind + "ipAddress\n";

            }
            //      C# -> System.Boolean? IsConnected
            // GraphQL -> isConnected: Boolean! (scalar)
            if (this.IsConnected != null)
            {
                 s += ind + "isConnected\n";

            }
            //      C# -> System.String? MacAddress
            // GraphQL -> macAddress: String (scalar)
            if (this.MacAddress != null)
            {
                 s += ind + "macAddress\n";

            }
            //      C# -> System.String? NetworkAdapterType
            // GraphQL -> networkAdapterType: String (scalar)
            if (this.NetworkAdapterType != null)
            {
                 s += ind + "networkAdapterType\n";

            }
            //      C# -> System.Int32? NicIndex
            // GraphQL -> nicIndex: Int! (scalar)
            if (this.NicIndex != null)
            {
                 s += ind + "nicIndex\n";

            }
            //      C# -> System.String? VappNetworkName
            // GraphQL -> vappNetworkName: String (scalar)
            if (this.VappNetworkName != null)
            {
                 s += ind + "vappNetworkName\n";

            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo != null)
            {
                 s += ind + "pageInfo\n";

                 s += ind + "{\n" + 
                 this.PageInfo.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> VappVmIpAddressingMode? AddressingMode
            // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
            if (this.AddressingMode != null)
            {
                 s += ind + "addressingMode\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String (scalar)
            if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress$"))
            {
                this.IpAddress = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsConnected
            // GraphQL -> isConnected: Boolean! (scalar)
            if (this.IsConnected == null && Exploration.Includes(parent + ".isConnected$"))
            {
                this.IsConnected = new System.Boolean();
            }
            //      C# -> System.String? MacAddress
            // GraphQL -> macAddress: String (scalar)
            if (this.MacAddress == null && Exploration.Includes(parent + ".macAddress$"))
            {
                this.MacAddress = new System.String("FETCH");
            }
            //      C# -> System.String? NetworkAdapterType
            // GraphQL -> networkAdapterType: String (scalar)
            if (this.NetworkAdapterType == null && Exploration.Includes(parent + ".networkAdapterType$"))
            {
                this.NetworkAdapterType = new System.String("FETCH");
            }
            //      C# -> System.Int32? NicIndex
            // GraphQL -> nicIndex: Int! (scalar)
            if (this.NicIndex == null && Exploration.Includes(parent + ".nicIndex$"))
            {
                this.NicIndex = new System.Int32();
            }
            //      C# -> System.String? VappNetworkName
            // GraphQL -> vappNetworkName: String (scalar)
            if (this.VappNetworkName == null && Exploration.Includes(parent + ".vappNetworkName$"))
            {
                this.VappNetworkName = new System.String("FETCH");
            }
            //      C# -> PageInfo? PageInfo
            // GraphQL -> pageInfo: PageInfo! (type)
            if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
            {
                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFragment(parent + ".pageInfo");
            }
            //      C# -> VappVmIpAddressingMode? AddressingMode
            // GraphQL -> addressingMode: VappVmIpAddressingMode! (enum)
            if (this.AddressingMode == null && Exploration.Includes(parent + ".addressingMode$"))
            {
                this.AddressingMode = new VappVmIpAddressingMode();
            }
        }


    #endregion

    } // class VappVmNetworkConnection
    #endregion

    public static class ListVappVmNetworkConnectionExtensions
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
            this List<VappVmNetworkConnection> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappVmNetworkConnection> list, 
            String parent = "")
        {
            var item = new VappVmNetworkConnection();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types