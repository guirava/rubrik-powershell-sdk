// SmbDomainFilterInput.cs
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
    #region SmbDomainFilterInput

    public class SmbDomainFilterInput: IInput
    {
        #region members

        //      C# -> SmbDomainFilterField? Field
        // GraphQL -> field: SmbDomainFilterField (enum)
        [JsonProperty("field")]
        public SmbDomainFilterField? Field { get; set; }

        //      C# -> List<System.String>? Texts
        // GraphQL -> texts: [String!] (scalar)
        [JsonProperty("texts")]
        public List<System.String>? Texts { get; set; }


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

    } // class SmbDomainFilterInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types