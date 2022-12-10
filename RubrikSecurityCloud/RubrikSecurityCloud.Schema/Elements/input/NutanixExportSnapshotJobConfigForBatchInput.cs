// NutanixExportSnapshotJobConfigForBatchInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:35.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region NutanixExportSnapshotJobConfigForBatchInput

    public class NutanixExportSnapshotJobConfigForBatchInput
    {
        #region members
        //      C# -> DateTime? SnapshotAfterDate
        // GraphQL -> snapshotAfterDate: DateTime (scalar)
        [JsonProperty("snapshotAfterDate")]
        public DateTime? SnapshotAfterDate { get; set; }

        //      C# -> DateTime? SnapshotBeforeDate
        // GraphQL -> snapshotBeforeDate: DateTime (scalar)
        [JsonProperty("snapshotBeforeDate")]
        public DateTime? SnapshotBeforeDate { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? VmNamePrefix
        // GraphQL -> vmNamePrefix: String (scalar)
        [JsonProperty("vmNamePrefix")]
        public System.String? VmNamePrefix { get; set; }

        //      C# -> NutanixVmExportSnapshotJobConfigInput? ExportConfig
        // GraphQL -> exportConfig: NutanixVmExportSnapshotJobConfigInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("exportConfig")]
        public NutanixVmExportSnapshotJobConfigInput? ExportConfig { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

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

    } // class NutanixExportSnapshotJobConfigForBatchInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types