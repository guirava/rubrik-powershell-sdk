// BulkDeleteFilesetTemplateInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region BulkDeleteFilesetTemplateInput

    public class BulkDeleteFilesetTemplateInput
    {
        #region members
        //      C# -> System.Boolean? PreserveSnapshots
        // GraphQL -> preserveSnapshots: Boolean (scalar)
        [JsonProperty("preserveSnapshots")]
        public System.Boolean? PreserveSnapshots { get; set; }

        //      C# -> List<System.String>? Ids
        // GraphQL -> ids: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("ids")]
        public List<System.String>? Ids { get; set; }

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

    } // class BulkDeleteFilesetTemplateInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types