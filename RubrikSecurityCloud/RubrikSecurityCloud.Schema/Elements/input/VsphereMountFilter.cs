// VsphereMountFilter.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:08.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region VsphereMountFilter

    public class VsphereMountFilter
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? ClusterUuid
        // GraphQL -> clusterUuid: [UUID!] (scalar)
        [JsonProperty("clusterUuid")]
        public List<System.String>? ClusterUuid { get; set; }

        //      C# -> List<System.Boolean>? PowerStatus
        // GraphQL -> powerStatus: [Boolean!] (scalar)
        [JsonProperty("powerStatus")]
        public List<System.Boolean>? PowerStatus { get; set; }

        //      C# -> System.String? SourceVmId
        // GraphQL -> sourceVmId: UUID (scalar)
        [JsonProperty("sourceVmId")]
        public System.String? SourceVmId { get; set; }

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

    } // class VsphereMountFilter
    #endregion

} // namespace Rubrik.SecurityCloud.Types