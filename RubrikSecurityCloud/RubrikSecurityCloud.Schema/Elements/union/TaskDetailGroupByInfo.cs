// TaskDetailGroupByInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:20.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region TaskDetailGroupByInfo
    public interface TaskDetailGroupByInfo: IFragment {} // class TaskDetailGroupByInfo
    #endregion

    public static class ListTaskDetailGroupByInfoExtensions
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
            this List<TaskDetailGroupByInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<TaskDetailGroupByInfo> list, 
            String parent = "")
        {
            var item = (TaskDetailGroupByInfo)InterfaceHelper.CreateInstanceOfFirstType(typeof(TaskDetailGroupByInfo));
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types