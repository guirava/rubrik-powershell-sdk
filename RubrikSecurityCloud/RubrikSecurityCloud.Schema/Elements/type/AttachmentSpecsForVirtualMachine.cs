// AttachmentSpecsForVirtualMachine.cs
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
    #region AttachmentSpecsForVirtualMachine
    public class AttachmentSpecsForVirtualMachine: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsExcludedFromSnapshot
        // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
        [JsonProperty("isExcludedFromSnapshot")]
        public System.Boolean? IsExcludedFromSnapshot { get; set; }

        //      C# -> System.Boolean? IsOsDisk
        // GraphQL -> isOsDisk: Boolean! (scalar)
        [JsonProperty("isOsDisk")]
        public System.Boolean? IsOsDisk { get; set; }

        //      C# -> System.Int32? Lun
        // GraphQL -> lun: Int! (scalar)
        [JsonProperty("lun")]
        public System.Int32? Lun { get; set; }

        //      C# -> System.String? ManagedDiskId
        // GraphQL -> managedDiskId: String! (scalar)
        [JsonProperty("managedDiskId")]
        public System.String? ManagedDiskId { get; set; }

        #endregion

    #region methods

    public AttachmentSpecsForVirtualMachine Set(
        System.Boolean? IsExcludedFromSnapshot = null,
        System.Boolean? IsOsDisk = null,
        System.Int32? Lun = null,
        System.String? ManagedDiskId = null
    ) 
    {
        if ( IsExcludedFromSnapshot != null ) {
            this.IsExcludedFromSnapshot = IsExcludedFromSnapshot;
        }
        if ( IsOsDisk != null ) {
            this.IsOsDisk = IsOsDisk;
        }
        if ( Lun != null ) {
            this.Lun = Lun;
        }
        if ( ManagedDiskId != null ) {
            this.ManagedDiskId = ManagedDiskId;
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
            //      C# -> System.Boolean? IsExcludedFromSnapshot
            // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
            if (this.IsExcludedFromSnapshot != null)
            {
                 s += ind + "isExcludedFromSnapshot\n";

            }
            //      C# -> System.Boolean? IsOsDisk
            // GraphQL -> isOsDisk: Boolean! (scalar)
            if (this.IsOsDisk != null)
            {
                 s += ind + "isOsDisk\n";

            }
            //      C# -> System.Int32? Lun
            // GraphQL -> lun: Int! (scalar)
            if (this.Lun != null)
            {
                 s += ind + "lun\n";

            }
            //      C# -> System.String? ManagedDiskId
            // GraphQL -> managedDiskId: String! (scalar)
            if (this.ManagedDiskId != null)
            {
                 s += ind + "managedDiskId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsExcludedFromSnapshot
            // GraphQL -> isExcludedFromSnapshot: Boolean! (scalar)
            if (this.IsExcludedFromSnapshot == null && Exploration.Includes(parent + ".isExcludedFromSnapshot$"))
            {
                this.IsExcludedFromSnapshot = new System.Boolean();
            }
            //      C# -> System.Boolean? IsOsDisk
            // GraphQL -> isOsDisk: Boolean! (scalar)
            if (this.IsOsDisk == null && Exploration.Includes(parent + ".isOsDisk$"))
            {
                this.IsOsDisk = new System.Boolean();
            }
            //      C# -> System.Int32? Lun
            // GraphQL -> lun: Int! (scalar)
            if (this.Lun == null && Exploration.Includes(parent + ".lun$"))
            {
                this.Lun = new System.Int32();
            }
            //      C# -> System.String? ManagedDiskId
            // GraphQL -> managedDiskId: String! (scalar)
            if (this.ManagedDiskId == null && Exploration.Includes(parent + ".managedDiskId$"))
            {
                this.ManagedDiskId = new System.String("FETCH");
            }
        }


    #endregion

    } // class AttachmentSpecsForVirtualMachine
    #endregion

    public static class ListAttachmentSpecsForVirtualMachineExtensions
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
            this List<AttachmentSpecsForVirtualMachine> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AttachmentSpecsForVirtualMachine> list, 
            String parent = "")
        {
            var item = new AttachmentSpecsForVirtualMachine();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types