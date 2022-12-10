// UpdateBadDiskLedStatusInput.cs
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
    #region UpdateBadDiskLedStatusInput

    public class UpdateBadDiskLedStatusInput
    {
        #region members
        //      C# -> System.String? DiskSerial
        // GraphQL -> diskSerial: String (scalar)
        [JsonProperty("diskSerial")]
        public System.String? DiskSerial { get; set; }

        //      C# -> System.Boolean? TurnOff
        // GraphQL -> turnOff: Boolean (scalar)
        [JsonProperty("turnOff")]
        public System.Boolean? TurnOff { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

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

    } // class UpdateBadDiskLedStatusInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types