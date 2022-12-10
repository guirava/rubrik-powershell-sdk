// RecoverableRangeInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:43.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region RecoverableRangeInput

    public class RecoverableRangeInput
    {
        #region members
        //      C# -> System.String? Source
        // GraphQL -> source: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("source")]
        public System.String? Source { get; set; }

        //      C# -> List<System.String>? Databases
        // GraphQL -> databases: [UUID!] (scalar)
        [JsonProperty("databases")]
        public List<System.String>? Databases { get; set; }

        //      C# -> List<System.String>? Collections
        // GraphQL -> collections: [UUID!] (scalar)
        [JsonProperty("collections")]
        public List<System.String>? Collections { get; set; }

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

    } // class RecoverableRangeInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types