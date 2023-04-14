// FailoverClusterNodeConnectionStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum FailoverClusterNodeConnectionStatus
    {
        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_CONNECTED")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_CONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_CONNECTING")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_CONNECTING,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_CONNECTOR_NOT_DEPLOYED")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_CONNECTOR_NOT_DEPLOYED,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_DELETED")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_DELETED,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_DELETING")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_DELETING,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_DISCONNECTED")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_DISCONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_PARTIALLY_CONNECTED")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_PARTIALLY_CONNECTED,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_REFRESHING")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_REFRESHING,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_REPLICATION_TARGET")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_REPLICATION_TARGET,

        [EnumMember(Value = "FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_SECONDARY_CLUSTER")]
        FAILOVER_CLUSTER_NODE_CONNECTION_STATUS_SECONDARY_CLUSTER


    } // enum FailoverClusterNodeConnectionStatus

} // namespace Rubrik.SecurityCloud.Types