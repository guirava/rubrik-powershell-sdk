### ClusterSlaDomain
Metadata for rendering a Rubrik cluster SLA Domain.

- name: System.String
  - Rubrik Cluster SLA Domain name.
- version: System.String
  - Version for the SLA Domain.
- fid: System.String
  - FID.
- snapshotSchedule: SnapshotSchedule
  - Snapshot schedule for the SLA Domain.
- baseFrequency: Duration
  - Base frequency for the SLA Domain.
- localRetentionLimit: Duration
  - Local retention limit.
- archivalSpec: ClusterArchivalSpec
  - Archiving specification for the SLA Domain.
- archivalSpecs: list of ClusterArchivalSpecs
  - List of archival specifications for SLA Domain.
- replicationSpec: ReplicationSpec
  - Replication specification for the SLA Domain.
- replicationSpecsV2: list of ReplicationSpecV2s
  - Replication specification for the SLA Domain.
- firstFullBackupWindows: list of BackupWindows
  - First full backup windows.
- backupWindows: list of BackupWindows
  - Backup windows for the SLA Domain.
- polarisManagedId: System.String
  - Rubrik SaaS managed ID for the SLA Domain.
- protectedObjectCount: System.Int32
  - Protected object count for the SLA Domain.
- upgradeInfo: SlaUpgradeInfo
  - SLA Domain upgrade information.
- isRetentionLockedSla: System.Boolean
  - Specifies if this SLA Domain is Retention Locked or not.
- objectSpecificConfigs: ObjectSpecificConfigs
  - The object-specific configurations of the SLA Domain.
- cluster: Cluster
  - Rubrik cluster ID of SLA Domain.
- id: System.String
  - ID of Rubrik cluster SLA Domain.
- cdmId: System.String
  - ID of the Rubrik cluster.
- ownerOrgName: System.String
  - This field is deprecated.
- ownerOrg: SlaAssociatedOrganization
  - Specifies the owner organization of the SLA Domain.