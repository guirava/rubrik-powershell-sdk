### AzureO365ExocomputeCluster
Azure O365 Exocompute cluster details.

- id: System.String
- tenantId: System.String
- subscriptionId: System.String
- groupName: System.String
- regionName: System.String
- aksId: System.String
- acrId: System.String
- storageId: System.String
- kmsId: System.String
- isProvisioned: System.Boolean
- scaleRuntime: ScaleRuntime
- orgId: System.String
- orgName: System.String
- orgStatus: System.String
- aksVersion: System.String
- setupConfiguration: System.String
- azureAppId: System.String
- polarisAccount: System.String
- orgTenantId: System.String
- azureCloudType: O365AzureCloudType
- hostType: AzureHostType
- storageIds: ExocomputeStorageAccountIds
- kmsSpec: KmsSpec
  - KMS and key details.
- kmsHostType: AzureHostType
  - KMS host type details. The possible values are RUBRIK_HOST and CUSTOMER_HOST.
- saasFeature: SaasFeature
  - Rubrik SaaS feature type using the Exocompute cluster.
- colossusBackupStorageAccountId: System.String
  - Storage account used for the backup of Colossus metadata.