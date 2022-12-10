// NewComputeConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:32.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region NewComputeConfig

    public class NewComputeConfig
    {
        #region members
        //      C# -> System.String? VnetName
        // GraphQL -> vnetName: String (scalar)
        [JsonProperty("vnetName")]
        public System.String? VnetName { get; set; }

        //      C# -> System.String? SubnetName
        // GraphQL -> subnetName: String (scalar)
        [JsonProperty("subnetName")]
        public System.String? SubnetName { get; set; }

        //      C# -> System.String? SecurityGroupName
        // GraphQL -> securityGroupName: String (scalar)
        [JsonProperty("securityGroupName")]
        public System.String? SecurityGroupName { get; set; }

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

    } // class NewComputeConfig
    #endregion

} // namespace Rubrik.SecurityCloud.Types