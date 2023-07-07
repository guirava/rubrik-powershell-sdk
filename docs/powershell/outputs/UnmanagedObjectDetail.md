### UnmanagedObjectDetail
UnmanagedObjectDetails.

- archiveStorage: System.Int64
  - Storage on the archival location.
- hasSnapshotsWithPolicy: System.Boolean
  - Any of the snapshots are retained by a SLA.
- id: System.String
  - Snappable id.
- isRemote: System.Boolean
  - Whether the object is remote or local.
- localStorage: System.Int64
  - Storage on the local location.
- name: System.String
  - Unmanaged object name.
- objectType: ManagedObjectType
  - Type of the unmanaged object.
- physicalLocation: list of LocationPathPoints
  - Physical path to this object.
- recoveryInfo: SnappableRecoveryInfo
  - Recovery information for the reader archival locations.
- retentionSlaDomainId: System.String
  - SLA Domain retention policy ID.
- retentionSlaDomainName: System.String
  - SLA Domain retention policy name.
- retentionSlaDomainPolarisManagedId: System.String
  - Polaris SLA Domain ID.
- snapshotCount: System.Int64
  - Snapshot count.
- unmanagedStatus: UnmanagedObjectAvailabilityFilter
  - Unmanaged Status of this object.
- effectiveSlaDomain: SlaDomain
  - The effective SLA Domain of the unmanaged object.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- clusterUuid: System.String
  - Cluster UUID of the object.