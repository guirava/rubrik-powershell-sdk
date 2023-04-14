// UpdateCustomReportInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateCustomReportInput

    public class UpdateCustomReportInput: IInput
    {
        #region members

        //      C# -> System.Int32? Id
        // GraphQL -> id: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.Int32? Id { get; set; }

        //      C# -> CustomReportCreate? Config
        // GraphQL -> config: CustomReportCreate! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("config")]
        public CustomReportCreate? Config { get; set; }


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

    } // class UpdateCustomReportInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types