// UpdateReplicationTargetInput.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:20.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    #region UpdateReplicationTargetInput

    public class UpdateReplicationTargetInput
    {
        #region members
        //      C# -> ReplicationGatewayInfo? SourceGateway
        // GraphQL -> sourceGateway: ReplicationGatewayInfo (input)
        [JsonProperty("sourceGateway")]
        public ReplicationGatewayInfo? SourceGateway { get; set; }

        //      C# -> ReplicationGatewayInfo? TargetGateway
        // GraphQL -> targetGateway: ReplicationGatewayInfo (input)
        [JsonProperty("targetGateway")]
        public ReplicationGatewayInfo? TargetGateway { get; set; }

        //      C# -> System.String? SourceClusterUuid
        // GraphQL -> sourceClusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("sourceClusterUuid")]
        public System.String? SourceClusterUuid { get; set; }

        //      C# -> System.String? TargetClusterUuid
        // GraphQL -> targetClusterUuid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetClusterUuid")]
        public System.String? TargetClusterUuid { get; set; }

        //      C# -> ReplicationSetupType? SetupType
        // GraphQL -> setupType: ReplicationSetupType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("setupType")]
        public ReplicationSetupType? SetupType { get; set; }

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

    } // class UpdateReplicationTargetInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types