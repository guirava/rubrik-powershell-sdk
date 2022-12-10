// ExportOracleDatabaseInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:34.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ExportOracleDatabaseInput

    public class ExportOracleDatabaseInput
    {
        #region members
        //      C# -> CreateExportOracleDbInput? Request
        // GraphQL -> request: CreateExportOracleDbInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("request")]
        public CreateExportOracleDbInput? Request { get; set; }

        //      C# -> List<AdvancedRecoveryConfigMap>? AdvancedRecoveryConfigMap
        // GraphQL -> advancedRecoveryConfigMap: [AdvancedRecoveryConfigMap!] (input)
        [JsonProperty("advancedRecoveryConfigMap")]
        public List<AdvancedRecoveryConfigMap>? AdvancedRecoveryConfigMap { get; set; }

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

    } // class ExportOracleDatabaseInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types