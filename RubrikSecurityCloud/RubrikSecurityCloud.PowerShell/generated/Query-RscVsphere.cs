// Query-RscVsphere.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:43.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Rubrik.SecurityCloud.NetSDK.Library.HelperClasses;
using Rubrik.SecurityCloud.Operations;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Query",
        "RscVsphere",
        DefaultParameterSetName = "Host")
    ]
    public class Query_RscVsphere : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // VCenter parameter set
        //
        // GraphQL operation: vSphereVCenter(fid: UUID!):VsphereVcenter!
        //
        [Parameter(
            ParameterSetName = "VCenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVCenter(fid: UUID!):VsphereVcenter!",
            Position = 0
        )]
        public SwitchParameter VCenter { get; set; }

        [Parameter(
            ParameterSetName = "VCenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fid: UUID!"
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Datacenter parameter set
        //
        // GraphQL operation: vSphereDatacenter(fid: UUID!):VsphereDatacenter!
        //
        [Parameter(
            ParameterSetName = "Datacenter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereDatacenter(fid: UUID!):VsphereDatacenter!",
            Position = 0
        )]
        public SwitchParameter Datacenter { get; set; }

        
        // -------------------------------------------------------------------
        // ComputeCluster parameter set
        //
        // GraphQL operation: vSphereComputeCluster(fid: UUID!):VsphereComputeCluster!
        //
        [Parameter(
            ParameterSetName = "ComputeCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereComputeCluster(fid: UUID!):VsphereComputeCluster!",
            Position = 0
        )]
        public SwitchParameter ComputeCluster { get; set; }

        
        // -------------------------------------------------------------------
        // ResourcePool parameter set
        //
        // GraphQL operation: vSphereResourcePool(fid: UUID!):VsphereResourcePool!
        //
        [Parameter(
            ParameterSetName = "ResourcePool",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereResourcePool(fid: UUID!):VsphereResourcePool!",
            Position = 0
        )]
        public SwitchParameter ResourcePool { get; set; }

        
        // -------------------------------------------------------------------
        // Folder parameter set
        //
        // GraphQL operation: vSphereFolder(fid: UUID!):VsphereFolder!
        //
        [Parameter(
            ParameterSetName = "Folder",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereFolder(fid: UUID!):VsphereFolder!",
            Position = 0
        )]
        public SwitchParameter Folder { get; set; }

        
        // -------------------------------------------------------------------
        // Host parameter set
        //
        // GraphQL operation: vSphereHost(fid: UUID!):VsphereHost!
        //
        [Parameter(
            ParameterSetName = "Host",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereHost(fid: UUID!):VsphereHost!",
            Position = 0
        )]
        public new SwitchParameter Host { get; set; }

        
        // -------------------------------------------------------------------
        // DatastoreCluster parameter set
        //
        // GraphQL operation: vSphereDatastoreCluster(fid: UUID!):VsphereDatastoreCluster!
        //
        [Parameter(
            ParameterSetName = "DatastoreCluster",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereDatastoreCluster(fid: UUID!):VsphereDatastoreCluster!",
            Position = 0
        )]
        public SwitchParameter DatastoreCluster { get; set; }

        
        // -------------------------------------------------------------------
        // Datastore parameter set
        //
        // GraphQL operation: vSphereDatastore(fid: UUID!):VsphereDatastore!
        //
        [Parameter(
            ParameterSetName = "Datastore",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereDatastore(fid: UUID!):VsphereDatastore!",
            Position = 0
        )]
        public SwitchParameter Datastore { get; set; }

        
        // -------------------------------------------------------------------
        // HostsByFid parameter set
        //
        // GraphQL operation: vSphereHostsByFids(fids: [UUID!]!):[VsphereHost!]!
        //
        [Parameter(
            ParameterSetName = "HostsByFid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereHostsByFids(fids: [UUID!]!):[VsphereHost!]!",
            Position = 0
        )]
        public SwitchParameter HostsByFid { get; set; }

        [Parameter(
            ParameterSetName = "HostsByFid",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument fids: [UUID!]!"
        )]
        public List<System.String>? Fids { get; set; }
        
        // -------------------------------------------------------------------
        // VmNew parameter set
        //
        // GraphQL operation: vSphereVmNew(fid: UUID!):VsphereVm!
        //
        [Parameter(
            ParameterSetName = "VmNew",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVmNew(fid: UUID!):VsphereVm!",
            Position = 0
        )]
        public SwitchParameter VmNew { get; set; }

        
        // -------------------------------------------------------------------
        // Tag parameter set
        //
        // GraphQL operation: vSphereTag(fid: UUID!):VsphereTag!
        //
        [Parameter(
            ParameterSetName = "Tag",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereTag(fid: UUID!):VsphereTag!",
            Position = 0
        )]
        public SwitchParameter Tag { get; set; }

        
        // -------------------------------------------------------------------
        // TagCategory parameter set
        //
        // GraphQL operation: vSphereTagCategory(fid: UUID!):VsphereTagCategory!
        //
        [Parameter(
            ParameterSetName = "TagCategory",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereTagCategory(fid: UUID!):VsphereTagCategory!",
            Position = 0
        )]
        public SwitchParameter TagCategory { get; set; }

        
        // -------------------------------------------------------------------
        // Network parameter set
        //
        // GraphQL operation: vSphereNetwork(fid: UUID!):VsphereNetwork!
        //
        [Parameter(
            ParameterSetName = "Network",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereNetwork(fid: UUID!):VsphereNetwork!",
            Position = 0
        )]
        public SwitchParameter Network { get; set; }

        
        // -------------------------------------------------------------------
        // TopLevelDescendantsConnection parameter set
        //
        // GraphQL operation: vSphereTopLevelDescendantsConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):CdmHierarchyObjectConnection!
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereTopLevelDescendantsConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):CdmHierarchyObjectConnection!",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendantsConnection { get; set; }

        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument first: Int"
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument after: String"
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortBy: HierarchySortByField"
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument sortOrder: SortOrder"
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]"
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendantsConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument filter: [Filter!]"
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // RootRecoveryHierarchy parameter set
        //
        // GraphQL operation: vSphereRootRecoveryHierarchy(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CdmHierarchyObjectConnection!
        //
        [Parameter(
            ParameterSetName = "RootRecoveryHierarchy",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereRootRecoveryHierarchy(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):CdmHierarchyObjectConnection!",
            Position = 0
        )]
        public SwitchParameter RootRecoveryHierarchy { get; set; }

        
        // -------------------------------------------------------------------
        // VCenterConnection parameter set
        //
        // GraphQL operation: vSphereVCenterConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVcenterConnection!
        //
        [Parameter(
            ParameterSetName = "VCenterConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVCenterConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVcenterConnection!",
            Position = 0
        )]
        public SwitchParameter VCenterConnection { get; set; }

        
        // -------------------------------------------------------------------
        // VmNewConnection parameter set
        //
        // GraphQL operation: vSphereVmNewConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVmConnection!
        //
        [Parameter(
            ParameterSetName = "VmNewConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVmNewConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereVmConnection!",
            Position = 0
        )]
        public SwitchParameter VmNewConnection { get; set; }

        
        // -------------------------------------------------------------------
        // HostConnection parameter set
        //
        // GraphQL operation: vSphereHostConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereHostConnection!
        //
        [Parameter(
            ParameterSetName = "HostConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereHostConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereHostConnection!",
            Position = 0
        )]
        public SwitchParameter HostConnection { get; set; }

        
        // -------------------------------------------------------------------
        // DatastoreConnection parameter set
        //
        // GraphQL operation: vSphereDatastoreConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereDatastoreConnection!
        //
        [Parameter(
            ParameterSetName = "DatastoreConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereDatastoreConnection(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):VsphereDatastoreConnection!",
            Position = 0
        )]
        public SwitchParameter DatastoreConnection { get; set; }

        
        // -------------------------------------------------------------------
        // LiveMount parameter set
        //
        // GraphQL operation: vSphereLiveMounts(,   first: Int,   after: String,   filter: [VsphereLiveMountFilterInput!],   sortBy: VsphereLiveMountSortBy, ):VsphereLiveMountConnection!
        //
        [Parameter(
            ParameterSetName = "LiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereLiveMounts(,   first: Int,   after: String,   filter: [VsphereLiveMountFilterInput!],   sortBy: VsphereLiveMountSortBy, ):VsphereLiveMountConnection!",
            Position = 0
        )]
        public SwitchParameter LiveMount { get; set; }

        
        // -------------------------------------------------------------------
        // MountConnection parameter set
        //
        // GraphQL operation: vSphereMountConnection(,   first: Int,   after: String,   filter: VSphereMountFilter,   sortBy: VsphereMountSortBy,   sortOrder: SortOrder, ):VsphereMountConnection!
        //
        [Parameter(
            ParameterSetName = "MountConnection",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereMountConnection(,   first: Int,   after: String,   filter: VSphereMountFilter,   sortBy: VsphereMountSortBy,   sortOrder: SortOrder, ):VsphereMountConnection!",
            Position = 0
        )]
        public SwitchParameter MountConnection { get; set; }

        
        // -------------------------------------------------------------------
        // VMRecoverableRange parameter set
        //
        // GraphQL operation: vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!
        //
        [Parameter(
            ParameterSetName = "VMRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!",
            Position = 0
        )]
        public SwitchParameter VMRecoverableRange { get; set; }

        [Parameter(
            ParameterSetName = "VMRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument snappableFid: UUID!"
        )]
        public System.String? SnappableFid { get; set; }
        [Parameter(
            ParameterSetName = "VMRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument beforeTime: DateTime"
        )]
        public DateTime? BeforeTime { get; set; }
        [Parameter(
            ParameterSetName = "VMRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument afterTime: DateTime"
        )]
        public DateTime? AfterTime { get; set; }
        
        // -------------------------------------------------------------------
        // VMRecoverableRangeInBatch parameter set
        //
        // GraphQL operation: vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!):BatchVmwareVmRecoverableRanges!
        //
        [Parameter(
            ParameterSetName = "VMRecoverableRangeInBatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!):BatchVmwareVmRecoverableRanges!",
            Position = 0
        )]
        public SwitchParameter VMRecoverableRangeInBatch { get; set; }

        [Parameter(
            ParameterSetName = "VMRecoverableRangeInBatch",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument requestInfo: BatchVmwareVmRecoverableRangesRequestInput!"
        )]
        public BatchVmwareVmRecoverableRangesRequestInput? RequestInfo { get; set; }
        
        // -------------------------------------------------------------------
        // VMMissedRecoverableRange parameter set
        //
        // GraphQL operation: vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!
        //
        [Parameter(
            ParameterSetName = "VMMissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime):RecoverableRangeResponse!",
            Position = 0
        )]
        public SwitchParameter VMMissedRecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // VmwareCdpLiveInfo parameter set
        //
        // GraphQL operation: vsphereVmwareCdpLiveInfo(ids: [String!]!):BatchVmwareCdpLiveInfo!
        //
        [Parameter(
            ParameterSetName = "VmwareCdpLiveInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vsphereVmwareCdpLiveInfo(ids: [String!]!):BatchVmwareCdpLiveInfo!",
            Position = 0
        )]
        public SwitchParameter VmwareCdpLiveInfo { get; set; }

        [Parameter(
            ParameterSetName = "VmwareCdpLiveInfo",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument ids: [String!]!"
        )]
        public List<System.String>? Ids { get; set; }
        
        // -------------------------------------------------------------------
        // Mount parameter set
        //
        // GraphQL operation: vSphereMount(fid: UUID!):VsphereMount!
        //
        [Parameter(
            ParameterSetName = "Mount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereMount(fid: UUID!):VsphereMount!",
            Position = 0
        )]
        public SwitchParameter Mount { get; set; }

        
        // -------------------------------------------------------------------
        // VMAsyncRequestStatus parameter set
        //
        // GraphQL operation: vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!):AsyncRequestStatus!
        //
        [Parameter(
            ParameterSetName = "VMAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!):AsyncRequestStatus!",
            Position = 0
        )]
        public SwitchParameter VMAsyncRequestStatus { get; set; }

        [Parameter(
            ParameterSetName = "VMAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument clusterUuid: UUID!"
        )]
        public System.String? ClusterUuid { get; set; }
        [Parameter(
            ParameterSetName = "VMAsyncRequestStatus",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument id: String!"
        )]
        public System.String? Id { get; set; }
        
        // -------------------------------------------------------------------
        // HostDetail parameter set
        //
        // GraphQL operation: vSphereHostDetails(input: GetVmwareHostInput!):VmwareHostDetail!
        //
        [Parameter(
            ParameterSetName = "HostDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL operation: vSphereHostDetails(input: GetVmwareHostInput!):VmwareHostDetail!",
            Position = 0
        )]
        public SwitchParameter HostDetail { get; set; }

        [Parameter(
            ParameterSetName = "HostDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage = "GraphQL argument input: GetVmwareHostInput!"
        )]
        public GetVmwareHostInput? Input { get; set; }

        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "VCenter":
                        this.ProcessRecord_VCenter();
                        break;
                    case "Datacenter":
                        this.ProcessRecord_Datacenter();
                        break;
                    case "ComputeCluster":
                        this.ProcessRecord_ComputeCluster();
                        break;
                    case "ResourcePool":
                        this.ProcessRecord_ResourcePool();
                        break;
                    case "Folder":
                        this.ProcessRecord_Folder();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "DatastoreCluster":
                        this.ProcessRecord_DatastoreCluster();
                        break;
                    case "Datastore":
                        this.ProcessRecord_Datastore();
                        break;
                    case "HostsByFid":
                        this.ProcessRecord_HostsByFid();
                        break;
                    case "VmNew":
                        this.ProcessRecord_VmNew();
                        break;
                    case "Tag":
                        this.ProcessRecord_Tag();
                        break;
                    case "TagCategory":
                        this.ProcessRecord_TagCategory();
                        break;
                    case "Network":
                        this.ProcessRecord_Network();
                        break;
                    case "TopLevelDescendantsConnection":
                        this.ProcessRecord_TopLevelDescendantsConnection();
                        break;
                    case "RootRecoveryHierarchy":
                        this.ProcessRecord_RootRecoveryHierarchy();
                        break;
                    case "VCenterConnection":
                        this.ProcessRecord_VCenterConnection();
                        break;
                    case "VmNewConnection":
                        this.ProcessRecord_VmNewConnection();
                        break;
                    case "HostConnection":
                        this.ProcessRecord_HostConnection();
                        break;
                    case "DatastoreConnection":
                        this.ProcessRecord_DatastoreConnection();
                        break;
                    case "LiveMount":
                        this.ProcessRecord_LiveMount();
                        break;
                    case "MountConnection":
                        this.ProcessRecord_MountConnection();
                        break;
                    case "VMRecoverableRange":
                        this.ProcessRecord_VMRecoverableRange();
                        break;
                    case "VMRecoverableRangeInBatch":
                        this.ProcessRecord_VMRecoverableRangeInBatch();
                        break;
                    case "VMMissedRecoverableRange":
                        this.ProcessRecord_VMMissedRecoverableRange();
                        break;
                    case "VmwareCdpLiveInfo":
                        this.ProcessRecord_VmwareCdpLiveInfo();
                        break;
                    case "Mount":
                        this.ProcessRecord_Mount();
                        break;
                    case "VMAsyncRequestStatus":
                        this.ProcessRecord_VMAsyncRequestStatus();
                        break;
                    case "HostDetail":
                        this.ProcessRecord_HostDetail();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Query-RscVsphere",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenter.
        protected void ProcessRecord_VCenter()
        {
            this._logger.name += " -VCenter";
            // Invoke graphql operation vSphereVCenter
            InvokeQueryVsphereVcenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatacenter.
        protected void ProcessRecord_Datacenter()
        {
            this._logger.name += " -Datacenter";
            // Invoke graphql operation vSphereDatacenter
            InvokeQueryVsphereDatacenter();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereComputeCluster.
        protected void ProcessRecord_ComputeCluster()
        {
            this._logger.name += " -ComputeCluster";
            // Invoke graphql operation vSphereComputeCluster
            InvokeQueryVsphereComputeCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereResourcePool.
        protected void ProcessRecord_ResourcePool()
        {
            this._logger.name += " -ResourcePool";
            // Invoke graphql operation vSphereResourcePool
            InvokeQueryVsphereResourcePool();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereFolder.
        protected void ProcessRecord_Folder()
        {
            this._logger.name += " -Folder";
            // Invoke graphql operation vSphereFolder
            InvokeQueryVsphereFolder();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHost.
        protected void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Invoke graphql operation vSphereHost
            InvokeQueryVsphereHost();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreCluster.
        protected void ProcessRecord_DatastoreCluster()
        {
            this._logger.name += " -DatastoreCluster";
            // Invoke graphql operation vSphereDatastoreCluster
            InvokeQueryVsphereDatastoreCluster();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastore.
        protected void ProcessRecord_Datastore()
        {
            this._logger.name += " -Datastore";
            // Invoke graphql operation vSphereDatastore
            InvokeQueryVsphereDatastore();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostsByFids.
        protected void ProcessRecord_HostsByFid()
        {
            this._logger.name += " -HostsByFid";
            // Invoke graphql operation vSphereHostsByFids
            InvokeQueryVsphereHostsByFids();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVmNew.
        protected void ProcessRecord_VmNew()
        {
            this._logger.name += " -VmNew";
            // Invoke graphql operation vSphereVmNew
            InvokeQueryVsphereVmNew();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTag.
        protected void ProcessRecord_Tag()
        {
            this._logger.name += " -Tag";
            // Invoke graphql operation vSphereTag
            InvokeQueryVsphereTag();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTagCategory.
        protected void ProcessRecord_TagCategory()
        {
            this._logger.name += " -TagCategory";
            // Invoke graphql operation vSphereTagCategory
            InvokeQueryVsphereTagCategory();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereNetwork.
        protected void ProcessRecord_Network()
        {
            this._logger.name += " -Network";
            // Invoke graphql operation vSphereNetwork
            InvokeQueryVsphereNetwork();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereTopLevelDescendantsConnection.
        protected void ProcessRecord_TopLevelDescendantsConnection()
        {
            this._logger.name += " -TopLevelDescendantsConnection";
            // Invoke graphql operation vSphereTopLevelDescendantsConnection
            InvokeQueryVsphereTopLevelDescendantsConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereRootRecoveryHierarchy.
        protected void ProcessRecord_RootRecoveryHierarchy()
        {
            this._logger.name += " -RootRecoveryHierarchy";
            // Invoke graphql operation vSphereRootRecoveryHierarchy
            InvokeQueryVsphereRootRecoveryHierarchy();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVCenterConnection.
        protected void ProcessRecord_VCenterConnection()
        {
            this._logger.name += " -VCenterConnection";
            // Invoke graphql operation vSphereVCenterConnection
            InvokeQueryVsphereVcenterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVmNewConnection.
        protected void ProcessRecord_VmNewConnection()
        {
            this._logger.name += " -VmNewConnection";
            // Invoke graphql operation vSphereVmNewConnection
            InvokeQueryVsphereVmNewConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostConnection.
        protected void ProcessRecord_HostConnection()
        {
            this._logger.name += " -HostConnection";
            // Invoke graphql operation vSphereHostConnection
            InvokeQueryVsphereHostConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereDatastoreConnection.
        protected void ProcessRecord_DatastoreConnection()
        {
            this._logger.name += " -DatastoreConnection";
            // Invoke graphql operation vSphereDatastoreConnection
            InvokeQueryVsphereDatastoreConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereLiveMounts.
        protected void ProcessRecord_LiveMount()
        {
            this._logger.name += " -LiveMount";
            // Invoke graphql operation vSphereLiveMounts
            InvokeQueryVsphereLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMountConnection.
        protected void ProcessRecord_MountConnection()
        {
            this._logger.name += " -MountConnection";
            // Invoke graphql operation vSphereMountConnection
            InvokeQueryVsphereMountConnection();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRange.
        protected void ProcessRecord_VMRecoverableRange()
        {
            this._logger.name += " -VMRecoverableRange";
            // Invoke graphql operation vsphereVMRecoverableRange
            InvokeQueryVsphereVmRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMRecoverableRangeInBatch.
        protected void ProcessRecord_VMRecoverableRangeInBatch()
        {
            this._logger.name += " -VMRecoverableRangeInBatch";
            // Invoke graphql operation vsphereVMRecoverableRangeInBatch
            InvokeQueryVsphereVmRecoverableRangeInBatch();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVMMissedRecoverableRange.
        protected void ProcessRecord_VMMissedRecoverableRange()
        {
            this._logger.name += " -VMMissedRecoverableRange";
            // Invoke graphql operation vsphereVMMissedRecoverableRange
            InvokeQueryVsphereVmMissedRecoverableRange();
        }

        // This parameter set invokes a single graphql operation:
        // vsphereVmwareCdpLiveInfo.
        protected void ProcessRecord_VmwareCdpLiveInfo()
        {
            this._logger.name += " -VmwareCdpLiveInfo";
            // Invoke graphql operation vsphereVmwareCdpLiveInfo
            InvokeQueryVsphereVmwareCdpLiveInfo();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereMount.
        protected void ProcessRecord_Mount()
        {
            this._logger.name += " -Mount";
            // Invoke graphql operation vSphereMount
            InvokeQueryVsphereMount();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereVMAsyncRequestStatus.
        protected void ProcessRecord_VMAsyncRequestStatus()
        {
            this._logger.name += " -VMAsyncRequestStatus";
            // Invoke graphql operation vSphereVMAsyncRequestStatus
            InvokeQueryVsphereVmAsyncRequestStatus();
        }

        // This parameter set invokes a single graphql operation:
        // vSphereHostDetails.
        protected void ProcessRecord_HostDetail()
        {
            this._logger.name += " -HostDetail";
            // Invoke graphql operation vSphereHostDetails
            InvokeQueryVsphereHostDetails();
        }


        // Invoke GraphQL Query:
        // vSphereVCenter(fid: UUID!): VsphereVcenter!
        protected void InvokeQueryVsphereVcenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereVcenter? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVcenter)psObject.BaseObject;
                } else {
                    fields = (VsphereVcenter)this.Field;
                }
            }
            string document = Query.VsphereVcenter(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVcenter");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVcenter" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVcenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVcenter> task = this._rbkClient.InvokeGenericCallAsync<VsphereVcenter>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatacenter(fid: UUID!): VsphereDatacenter!
        protected void InvokeQueryVsphereDatacenter()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatacenter? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereDatacenter)psObject.BaseObject;
                } else {
                    fields = (VsphereDatacenter)this.Field;
                }
            }
            string document = Query.VsphereDatacenter(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatacenter");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatacenter" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatacenter",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereDatacenter> task = this._rbkClient.InvokeGenericCallAsync<VsphereDatacenter>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereComputeCluster(fid: UUID!): VsphereComputeCluster!
        protected void InvokeQueryVsphereComputeCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereComputeCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereComputeCluster)psObject.BaseObject;
                } else {
                    fields = (VsphereComputeCluster)this.Field;
                }
            }
            string document = Query.VsphereComputeCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereComputeCluster");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereComputeCluster" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereComputeCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereComputeCluster> task = this._rbkClient.InvokeGenericCallAsync<VsphereComputeCluster>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereResourcePool(fid: UUID!): VsphereResourcePool!
        protected void InvokeQueryVsphereResourcePool()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereResourcePool? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereResourcePool)psObject.BaseObject;
                } else {
                    fields = (VsphereResourcePool)this.Field;
                }
            }
            string document = Query.VsphereResourcePool(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereResourcePool");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereResourcePool" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereResourcePool",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereResourcePool> task = this._rbkClient.InvokeGenericCallAsync<VsphereResourcePool>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereFolder(fid: UUID!): VsphereFolder!
        protected void InvokeQueryVsphereFolder()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereFolder? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereFolder)psObject.BaseObject;
                } else {
                    fields = (VsphereFolder)this.Field;
                }
            }
            string document = Query.VsphereFolder(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereFolder");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereFolder" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereFolder",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereFolder> task = this._rbkClient.InvokeGenericCallAsync<VsphereFolder>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHost(fid: UUID!): VsphereHost!
        protected void InvokeQueryVsphereHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereHost? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereHost)psObject.BaseObject;
                } else {
                    fields = (VsphereHost)this.Field;
                }
            }
            string document = Query.VsphereHost(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHost");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHost" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHost",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereHost> task = this._rbkClient.InvokeGenericCallAsync<VsphereHost>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreCluster(fid: UUID!): VsphereDatastoreCluster!
        protected void InvokeQueryVsphereDatastoreCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatastoreCluster? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereDatastoreCluster)psObject.BaseObject;
                } else {
                    fields = (VsphereDatastoreCluster)this.Field;
                }
            }
            string document = Query.VsphereDatastoreCluster(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatastoreCluster");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatastoreCluster" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatastoreCluster",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereDatastoreCluster> task = this._rbkClient.InvokeGenericCallAsync<VsphereDatastoreCluster>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatastore(fid: UUID!): VsphereDatastore!
        protected void InvokeQueryVsphereDatastore()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereDatastore? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereDatastore)psObject.BaseObject;
                } else {
                    fields = (VsphereDatastore)this.Field;
                }
            }
            string document = Query.VsphereDatastore(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatastore");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatastore" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatastore",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereDatastore> task = this._rbkClient.InvokeGenericCallAsync<VsphereDatastore>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHostsByFids(fids: [UUID!]!): [VsphereHost!]!
        protected void InvokeQueryVsphereHostsByFids()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            List<VsphereHost>? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (List<VsphereHost>)psObject.BaseObject;
                } else {
                    fields = (List<VsphereHost>)this.Field;
                }
            }
            string document = Query.VsphereHostsByFids(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHostsByFids");
            string parameters = "($fids: [UUID!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHostsByFids" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHostsByFids",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<List<VsphereHost>> task = this._rbkClient.InvokeGenericCallAsync<List<VsphereHost>>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVmNew(fid: UUID!): VsphereVm!
        protected void InvokeQueryVsphereVmNew()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereVm? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVm)psObject.BaseObject;
                } else {
                    fields = (VsphereVm)this.Field;
                }
            }
            string document = Query.VsphereVmNew(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmNew");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmNew" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmNew",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVm> task = this._rbkClient.InvokeGenericCallAsync<VsphereVm>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereTag(fid: UUID!): VsphereTag!
        protected void InvokeQueryVsphereTag()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereTag? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereTag)psObject.BaseObject;
                } else {
                    fields = (VsphereTag)this.Field;
                }
            }
            string document = Query.VsphereTag(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereTag");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereTag" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereTag",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereTag> task = this._rbkClient.InvokeGenericCallAsync<VsphereTag>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereTagCategory(fid: UUID!): VsphereTagCategory!
        protected void InvokeQueryVsphereTagCategory()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereTagCategory? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereTagCategory)psObject.BaseObject;
                } else {
                    fields = (VsphereTagCategory)this.Field;
                }
            }
            string document = Query.VsphereTagCategory(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereTagCategory");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereTagCategory" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereTagCategory",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereTagCategory> task = this._rbkClient.InvokeGenericCallAsync<VsphereTagCategory>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereNetwork(fid: UUID!): VsphereNetwork!
        protected void InvokeQueryVsphereNetwork()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereNetwork? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereNetwork)psObject.BaseObject;
                } else {
                    fields = (VsphereNetwork)this.Field;
                }
            }
            string document = Query.VsphereNetwork(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereNetwork");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereNetwork" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereNetwork",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereNetwork> task = this._rbkClient.InvokeGenericCallAsync<VsphereNetwork>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereTopLevelDescendantsConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        protected void InvokeQueryVsphereTopLevelDescendantsConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CdmHierarchyObjectConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CdmHierarchyObjectConnection)psObject.BaseObject;
                } else {
                    fields = (CdmHierarchyObjectConnection)this.Field;
                }
            }
            string document = Query.VsphereTopLevelDescendantsConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereTopLevelDescendantsConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereTopLevelDescendantsConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereTopLevelDescendantsConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CdmHierarchyObjectConnection> task = this._rbkClient.InvokeGenericCallAsync<CdmHierarchyObjectConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereRootRecoveryHierarchy(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): CdmHierarchyObjectConnection!
        protected void InvokeQueryVsphereRootRecoveryHierarchy()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            CdmHierarchyObjectConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (CdmHierarchyObjectConnection)psObject.BaseObject;
                } else {
                    fields = (CdmHierarchyObjectConnection)this.Field;
                }
            }
            string document = Query.VsphereRootRecoveryHierarchy(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereRootRecoveryHierarchy");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereRootRecoveryHierarchy" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereRootRecoveryHierarchy",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<CdmHierarchyObjectConnection> task = this._rbkClient.InvokeGenericCallAsync<CdmHierarchyObjectConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVCenterConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVcenterConnection!
        protected void InvokeQueryVsphereVcenterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereVcenterConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVcenterConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereVcenterConnection)this.Field;
                }
            }
            string document = Query.VsphereVcenterConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVcenterConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVcenterConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVcenterConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVcenterConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereVcenterConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVmNewConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereVmConnection!
        protected void InvokeQueryVsphereVmNewConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereVmConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereVmConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereVmConnection)this.Field;
                }
            }
            string document = Query.VsphereVmNewConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmNewConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmNewConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmNewConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereVmConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereVmConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHostConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereHostConnection!
        protected void InvokeQueryVsphereHostConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereHostConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereHostConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereHostConnection)this.Field;
                }
            }
            string document = Query.VsphereHostConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHostConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHostConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHostConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereHostConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereHostConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereDatastoreConnection(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): VsphereDatastoreConnection!
        protected void InvokeQueryVsphereDatastoreConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            VsphereDatastoreConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereDatastoreConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereDatastoreConnection)this.Field;
                }
            }
            string document = Query.VsphereDatastoreConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereDatastoreConnection");
            string parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereDatastoreConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereDatastoreConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereDatastoreConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereDatastoreConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereLiveMounts(
        //     first: Int
        //     after: String
        //     filter: [VsphereLiveMountFilterInput!]
        //     sortBy: VsphereLiveMountSortBy
        //   ): VsphereLiveMountConnection!
        protected void InvokeQueryVsphereLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "[VsphereLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "VsphereLiveMountSortBy"),
            };
            VsphereLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereLiveMountConnection)this.Field;
                }
            }
            string document = Query.VsphereLiveMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereLiveMounts");
            string parameters = "($first: Int,$after: String,$filter: [VsphereLiveMountFilterInput!],$sortBy: VsphereLiveMountSortBy)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereLiveMounts" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereLiveMounts",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereLiveMountConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereLiveMountConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereMountConnection(
        //     first: Int
        //     after: String
        //     filter: VSphereMountFilter
        //     sortBy: VsphereMountSortBy
        //     sortOrder: SortOrder
        //   ): VsphereMountConnection!
        protected void InvokeQueryVsphereMountConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filter", "VSphereMountFilter"),
                Tuple.Create("sortBy", "VsphereMountSortBy"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            VsphereMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereMountConnection)psObject.BaseObject;
                } else {
                    fields = (VsphereMountConnection)this.Field;
                }
            }
            string document = Query.VsphereMountConnection(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereMountConnection");
            string parameters = "($first: Int,$after: String,$filter: VSphereMountFilter,$sortBy: VsphereMountSortBy,$sortOrder: SortOrder)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereMountConnection" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereMountConnection",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereMountConnection> task = this._rbkClient.InvokeGenericCallAsync<VsphereMountConnection>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        protected void InvokeQueryVsphereVmRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            RecoverableRangeResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (RecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.VsphereVmRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmRecoverableRange");
            string parameters = "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmRecoverableRange",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RecoverableRangeResponse> task = this._rbkClient.InvokeGenericCallAsync<RecoverableRangeResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVMRecoverableRangeInBatch(requestInfo: BatchVmwareVmRecoverableRangesRequestInput!): BatchVmwareVmRecoverableRanges!
        protected void InvokeQueryVsphereVmRecoverableRangeInBatch()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("requestInfo", "BatchVmwareVmRecoverableRangesRequestInput!"),
            };
            BatchVmwareVmRecoverableRanges? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchVmwareVmRecoverableRanges)psObject.BaseObject;
                } else {
                    fields = (BatchVmwareVmRecoverableRanges)this.Field;
                }
            }
            string document = Query.VsphereVmRecoverableRangeInBatch(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmRecoverableRangeInBatch");
            string parameters = "($requestInfo: BatchVmwareVmRecoverableRangesRequestInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmRecoverableRangeInBatch" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmRecoverableRangeInBatch",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchVmwareVmRecoverableRanges> task = this._rbkClient.InvokeGenericCallAsync<BatchVmwareVmRecoverableRanges>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVMMissedRecoverableRange(snappableFid: UUID!, beforeTime: DateTime, afterTime: DateTime): RecoverableRangeResponse!
        protected void InvokeQueryVsphereVmMissedRecoverableRange()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("snappableFid", "UUID!"),
                Tuple.Create("beforeTime", "DateTime"),
                Tuple.Create("afterTime", "DateTime"),
            };
            RecoverableRangeResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (RecoverableRangeResponse)psObject.BaseObject;
                } else {
                    fields = (RecoverableRangeResponse)this.Field;
                }
            }
            string document = Query.VsphereVmMissedRecoverableRange(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmMissedRecoverableRange");
            string parameters = "($snappableFid: UUID!,$beforeTime: DateTime,$afterTime: DateTime)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmMissedRecoverableRange" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmMissedRecoverableRange",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<RecoverableRangeResponse> task = this._rbkClient.InvokeGenericCallAsync<RecoverableRangeResponse>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vsphereVmwareCdpLiveInfo(ids: [String!]!): BatchVmwareCdpLiveInfo!
        protected void InvokeQueryVsphereVmwareCdpLiveInfo()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("ids", "[String!]!"),
            };
            BatchVmwareCdpLiveInfo? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (BatchVmwareCdpLiveInfo)psObject.BaseObject;
                } else {
                    fields = (BatchVmwareCdpLiveInfo)this.Field;
                }
            }
            string document = Query.VsphereVmwareCdpLiveInfo(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmwareCdpLiveInfo");
            string parameters = "($ids: [String!]!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmwareCdpLiveInfo" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmwareCdpLiveInfo",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<BatchVmwareCdpLiveInfo> task = this._rbkClient.InvokeGenericCallAsync<BatchVmwareCdpLiveInfo>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereMount(fid: UUID!): VsphereMount!
        protected void InvokeQueryVsphereMount()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            VsphereMount? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VsphereMount)psObject.BaseObject;
                } else {
                    fields = (VsphereMount)this.Field;
                }
            }
            string document = Query.VsphereMount(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereMount");
            string parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereMount" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereMount",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VsphereMount> task = this._rbkClient.InvokeGenericCallAsync<VsphereMount>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereVMAsyncRequestStatus(clusterUuid: UUID!, id: String!): AsyncRequestStatus!
        protected void InvokeQueryVsphereVmAsyncRequestStatus()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusterUuid", "UUID!"),
                Tuple.Create("id", "String!"),
            };
            AsyncRequestStatus? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (AsyncRequestStatus)psObject.BaseObject;
                } else {
                    fields = (AsyncRequestStatus)this.Field;
                }
            }
            string document = Query.VsphereVmAsyncRequestStatus(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereVmAsyncRequestStatus");
            string parameters = "($clusterUuid: UUID!,$id: String!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereVmAsyncRequestStatus" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereVmAsyncRequestStatus",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<AsyncRequestStatus> task = this._rbkClient.InvokeGenericCallAsync<AsyncRequestStatus>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }

        // Invoke GraphQL Query:
        // vSphereHostDetails(input: GetVmwareHostInput!): VmwareHostDetail!
        protected void InvokeQueryVsphereHostDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetVmwareHostInput!"),
            };
            VmwareHostDetail? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject) {
                    var psObject = (PSObject)this.Field;
                    fields = (VmwareHostDetail)psObject.BaseObject;
                } else {
                    fields = (VmwareHostDetail)this.Field;
                }
            }
            string document = Query.VsphereHostDetails(ref fields);
            this._input.Initialize(argDefs, fields, "Query.VsphereHostDetails");
            string parameters = "($input: GetVmwareHostInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryVsphereHostDetails" + parameters + "{" + document + "}",
                OperationName = "QueryVsphereHostDetails",
            };
            OperationVariableSet vars = new OperationVariableSet();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            Task<VmwareHostDetail> task = this._rbkClient.InvokeGenericCallAsync<VmwareHostDetail>(request, vars, this._logger);
            task.Wait();
            this._logger.Flush();
            WriteObject(task.Result, true);
        }


    } // class Query_RscVsphere
}