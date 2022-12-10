// UploadDatabaseSnapshotToBlobstoreInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:16.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UploadDatabaseSnapshotToBlobstoreInput

    public class UploadDatabaseSnapshotToBlobstoreInput
    {
        #region members
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> TargetStorageAccountConfigInput? TargetStorageAccountConfigInput
        // GraphQL -> targetStorageAccountConfigInput: TargetStorageAccountConfigInput (input)
        [JsonProperty("targetStorageAccountConfigInput")]
        public TargetStorageAccountConfigInput? TargetStorageAccountConfigInput { get; set; }

        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class UploadDatabaseSnapshotToBlobstoreInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types