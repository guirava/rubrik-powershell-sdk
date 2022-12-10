// ContextFilterInputField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:35.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region ContextFilterInputField

    public class ContextFilterInputField
    {
        #region members
        //      C# -> System.String? Field
        // GraphQL -> field: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("field")]
        public System.String? Field { get; set; }

        //      C# -> System.String? Text
        // GraphQL -> text: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("text")]
        public System.String? Text { get; set; }

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

    } // class ContextFilterInputField
    #endregion

} // namespace Rubrik.SecurityCloud.Types