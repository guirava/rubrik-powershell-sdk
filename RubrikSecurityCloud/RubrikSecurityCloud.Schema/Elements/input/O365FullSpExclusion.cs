// O365FullSpExclusion.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:33.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region O365FullSpExclusion

    public class O365FullSpExclusion
    {
        #region members
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: URL! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> SharePointDescendantType? ObjectType
        // GraphQL -> objectType: SharePointDescendantType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("objectType")]
        public SharePointDescendantType? ObjectType { get; set; }

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

    } // class O365FullSpExclusion
    #endregion

} // namespace Rubrik.SecurityCloud.Types