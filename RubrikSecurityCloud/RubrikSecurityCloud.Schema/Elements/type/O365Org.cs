// O365Org.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:51.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region O365Org
 
    public class O365Org: IFragment, HierarchyObject, PolarisHierarchyObject
    {
        #region members
        //      C# -> System.String? ExocomputeId
        // GraphQL -> exocomputeId: String! (scalar)
        [JsonProperty("exocomputeId")]
        public System.String? ExocomputeId { get; set; }

        //      C# -> System.Boolean? HasSharePointLegacySnapshots
        // GraphQL -> hasSharePointLegacySnapshots: Boolean! (scalar)
        [JsonProperty("hasSharePointLegacySnapshots")]
        public System.Boolean? HasSharePointLegacySnapshots { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? Past1DayMailboxComplianceCount
        // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxComplianceCount")]
        public System.Int32? Past1DayMailboxComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
        // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayMailboxOutOfComplianceCount")]
        public System.Int32? Past1DayMailboxOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveComplianceCount
        // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveComplianceCount")]
        public System.Int32? Past1DayOnedriveComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
        // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayOnedriveOutOfComplianceCount")]
        public System.Int32? Past1DayOnedriveOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointComplianceCount
        // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointComplianceCount")]
        public System.Int32? Past1DaySharepointComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
        // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySharepointOutOfComplianceCount")]
        public System.Int32? Past1DaySharepointOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListComplianceCount
        // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListComplianceCount")]
        public System.Int32? Past1DaySpListComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
        // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpListOutOfComplianceCount")]
        public System.Int32? Past1DaySpListOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
        // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpSiteCollectionComplianceCount")]
        public System.Int32? Past1DaySpSiteCollectionComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
        // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DaySpSiteCollectionOutOfComplianceCount")]
        public System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsComplianceCount
        // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsComplianceCount")]
        public System.Int32? Past1DayTeamsComplianceCount { get; set; }

        //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
        // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
        [JsonProperty("past1DayTeamsOutOfComplianceCount")]
        public System.Int32? Past1DayTeamsOutOfComplianceCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.Int32? UnprotectedUsersCount
        // GraphQL -> unprotectedUsersCount: Int! (scalar)
        [JsonProperty("unprotectedUsersCount")]
        public System.Int32? UnprotectedUsersCount { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> O365UserConnection? ChildConnection
        // GraphQL -> childConnection: O365UserConnection! (type)
        [JsonProperty("childConnection")]
        public O365UserConnection? ChildConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> O365OrgDescendantConnection? SearchDescendantConnection
        // GraphQL -> searchDescendantConnection: O365OrgDescendantConnection! (type)
        [JsonProperty("searchDescendantConnection")]
        public O365OrgDescendantConnection? SearchDescendantConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> OrgStatus? Status
        // GraphQL -> status: OrgStatus! (enum)
        [JsonProperty("status")]
        public OrgStatus? Status { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        #endregion

    #region methods

    public O365Org Set(
        System.String? ExocomputeId = null,
        System.Boolean? HasSharePointLegacySnapshots = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? Past1DayMailboxComplianceCount = null,
        System.Int32? Past1DayMailboxOutOfComplianceCount = null,
        System.Int32? Past1DayOnedriveComplianceCount = null,
        System.Int32? Past1DayOnedriveOutOfComplianceCount = null,
        System.Int32? Past1DaySharepointComplianceCount = null,
        System.Int32? Past1DaySharepointOutOfComplianceCount = null,
        System.Int32? Past1DaySpListComplianceCount = null,
        System.Int32? Past1DaySpListOutOfComplianceCount = null,
        System.Int32? Past1DaySpSiteCollectionComplianceCount = null,
        System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount = null,
        System.Int32? Past1DayTeamsComplianceCount = null,
        System.Int32? Past1DayTeamsOutOfComplianceCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.Int32? UnprotectedUsersCount = null,
        List<Org>? AllOrgs = null,
        O365UserConnection? ChildConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        List<PathNode>? LogicalPath = null,
        List<PathNode>? PhysicalPath = null,
        O365OrgDescendantConnection? SearchDescendantConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        List<Operation>? AuthorizedOperations = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        OrgStatus? Status = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null
    ) 
    {
        if ( ExocomputeId != null ) {
            this.ExocomputeId = ExocomputeId;
        }
        if ( HasSharePointLegacySnapshots != null ) {
            this.HasSharePointLegacySnapshots = HasSharePointLegacySnapshots;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( Past1DayMailboxComplianceCount != null ) {
            this.Past1DayMailboxComplianceCount = Past1DayMailboxComplianceCount;
        }
        if ( Past1DayMailboxOutOfComplianceCount != null ) {
            this.Past1DayMailboxOutOfComplianceCount = Past1DayMailboxOutOfComplianceCount;
        }
        if ( Past1DayOnedriveComplianceCount != null ) {
            this.Past1DayOnedriveComplianceCount = Past1DayOnedriveComplianceCount;
        }
        if ( Past1DayOnedriveOutOfComplianceCount != null ) {
            this.Past1DayOnedriveOutOfComplianceCount = Past1DayOnedriveOutOfComplianceCount;
        }
        if ( Past1DaySharepointComplianceCount != null ) {
            this.Past1DaySharepointComplianceCount = Past1DaySharepointComplianceCount;
        }
        if ( Past1DaySharepointOutOfComplianceCount != null ) {
            this.Past1DaySharepointOutOfComplianceCount = Past1DaySharepointOutOfComplianceCount;
        }
        if ( Past1DaySpListComplianceCount != null ) {
            this.Past1DaySpListComplianceCount = Past1DaySpListComplianceCount;
        }
        if ( Past1DaySpListOutOfComplianceCount != null ) {
            this.Past1DaySpListOutOfComplianceCount = Past1DaySpListOutOfComplianceCount;
        }
        if ( Past1DaySpSiteCollectionComplianceCount != null ) {
            this.Past1DaySpSiteCollectionComplianceCount = Past1DaySpSiteCollectionComplianceCount;
        }
        if ( Past1DaySpSiteCollectionOutOfComplianceCount != null ) {
            this.Past1DaySpSiteCollectionOutOfComplianceCount = Past1DaySpSiteCollectionOutOfComplianceCount;
        }
        if ( Past1DayTeamsComplianceCount != null ) {
            this.Past1DayTeamsComplianceCount = Past1DayTeamsComplianceCount;
        }
        if ( Past1DayTeamsOutOfComplianceCount != null ) {
            this.Past1DayTeamsOutOfComplianceCount = Past1DayTeamsOutOfComplianceCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( UnprotectedUsersCount != null ) {
            this.UnprotectedUsersCount = UnprotectedUsersCount;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( ChildConnection != null ) {
            this.ChildConnection = ChildConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( SearchDescendantConnection != null ) {
            this.SearchDescendantConnection = SearchDescendantConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? ExocomputeId
            // GraphQL -> exocomputeId: String! (scalar)
            if (this.ExocomputeId != null)
            {
                 s += ind + "exocomputeId\n";

            }
            //      C# -> System.Boolean? HasSharePointLegacySnapshots
            // GraphQL -> hasSharePointLegacySnapshots: Boolean! (scalar)
            if (this.HasSharePointLegacySnapshots != null)
            {
                 s += ind + "hasSharePointLegacySnapshots\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants != null)
            {
                 s += ind + "numWorkloadDescendants\n";

            }
            //      C# -> System.Int32? Past1DayMailboxComplianceCount
            // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxComplianceCount != null)
            {
                 s += ind + "past1DayMailboxComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
            // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxOutOfComplianceCount != null)
            {
                 s += ind + "past1DayMailboxOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayOnedriveComplianceCount
            // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveComplianceCount != null)
            {
                 s += ind + "past1DayOnedriveComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
            // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveOutOfComplianceCount != null)
            {
                 s += ind + "past1DayOnedriveOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySharepointComplianceCount
            // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointComplianceCount != null)
            {
                 s += ind + "past1DaySharepointComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
            // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointOutOfComplianceCount != null)
            {
                 s += ind + "past1DaySharepointOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySpListComplianceCount
            // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
            if (this.Past1DaySpListComplianceCount != null)
            {
                 s += ind + "past1DaySpListComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
            // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySpListOutOfComplianceCount != null)
            {
                 s += ind + "past1DaySpListOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
            // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
            if (this.Past1DaySpSiteCollectionComplianceCount != null)
            {
                 s += ind + "past1DaySpSiteCollectionComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
            // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySpSiteCollectionOutOfComplianceCount != null)
            {
                 s += ind + "past1DaySpSiteCollectionOutOfComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayTeamsComplianceCount
            // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsComplianceCount != null)
            {
                 s += ind + "past1DayTeamsComplianceCount\n";

            }
            //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
            // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsOutOfComplianceCount != null)
            {
                 s += ind + "past1DayTeamsOutOfComplianceCount\n";

            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus != null)
            {
                 s += ind + "slaPauseStatus\n";

            }
            //      C# -> System.Int32? UnprotectedUsersCount
            // GraphQL -> unprotectedUsersCount: Int! (scalar)
            if (this.UnprotectedUsersCount != null)
            {
                 s += ind + "unprotectedUsersCount\n";

            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs != null)
            {
                 s += ind + "allOrgs\n";

                 s += ind + "{\n" + 
                 this.AllOrgs.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> O365UserConnection? ChildConnection
            // GraphQL -> childConnection: O365UserConnection! (type)
            if (this.ChildConnection != null)
            {
                 s += ind + "childConnection\n";

                 s += ind + "{\n" + 
                 this.ChildConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject != null)
            {
                 s += ind + "effectiveSlaSourceObject\n";

                 s += ind + "{\n" + 
                 this.EffectiveSlaSourceObject.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath != null)
            {
                 s += ind + "logicalPath\n";

                 s += ind + "{\n" + 
                 this.LogicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath != null)
            {
                 s += ind + "physicalPath\n";

                 s += ind + "{\n" + 
                 this.PhysicalPath.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> O365OrgDescendantConnection? SearchDescendantConnection
            // GraphQL -> searchDescendantConnection: O365OrgDescendantConnection! (type)
            if (this.SearchDescendantConnection != null)
            {
                 s += ind + "searchDescendantConnection\n";

                 s += ind + "{\n" + 
                 this.SearchDescendantConnection.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution != null)
            {
                 s += ind + "snapshotDistribution\n";

                 s += ind + "{\n" + 
                 this.SnapshotDistribution.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations != null)
            {
                 s += ind + "authorizedOperations\n";

            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType != null)
            {
                 s += ind + "objectType\n";

            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment != null)
            {
                 s += ind + "slaAssignment\n";

            }
            //      C# -> OrgStatus? Status
            // GraphQL -> status: OrgStatus! (enum)
            if (this.Status != null)
            {
                 s += ind + "status\n";

            }
                        //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain != null)
            {
                s += ind + "configuredSlaDomain\n";
                s += ind + "{\n";

                string typename = this.ConfiguredSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.ConfiguredSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain != null)
            {
                s += ind + "effectiveRetentionSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveRetentionSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveRetentionSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
                        //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain != null)
            {
                s += ind + "effectiveSlaDomain\n";
                s += ind + "{\n";

                string typename = this.EffectiveSlaDomain.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.EffectiveSlaDomain.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ExocomputeId
            // GraphQL -> exocomputeId: String! (scalar)
            if (this.ExocomputeId == null && Exploration.Includes(parent + ".exocomputeId$"))
            {
                this.ExocomputeId = new System.String("FETCH");
            }
            //      C# -> System.Boolean? HasSharePointLegacySnapshots
            // GraphQL -> hasSharePointLegacySnapshots: Boolean! (scalar)
            if (this.HasSharePointLegacySnapshots == null && Exploration.Includes(parent + ".hasSharePointLegacySnapshots$"))
            {
                this.HasSharePointLegacySnapshots = new System.Boolean();
            }
            //      C# -> System.String? Id
            // GraphQL -> id: UUID! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.Int32? NumWorkloadDescendants
            // GraphQL -> numWorkloadDescendants: Int! (scalar)
            if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants$"))
            {
                this.NumWorkloadDescendants = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayMailboxComplianceCount
            // GraphQL -> past1DayMailboxComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxComplianceCount == null && Exploration.Includes(parent + ".past1DayMailboxComplianceCount$"))
            {
                this.Past1DayMailboxComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayMailboxOutOfComplianceCount
            // GraphQL -> past1DayMailboxOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayMailboxOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DayMailboxOutOfComplianceCount$"))
            {
                this.Past1DayMailboxOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayOnedriveComplianceCount
            // GraphQL -> past1DayOnedriveComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveComplianceCount == null && Exploration.Includes(parent + ".past1DayOnedriveComplianceCount$"))
            {
                this.Past1DayOnedriveComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayOnedriveOutOfComplianceCount
            // GraphQL -> past1DayOnedriveOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayOnedriveOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DayOnedriveOutOfComplianceCount$"))
            {
                this.Past1DayOnedriveOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySharepointComplianceCount
            // GraphQL -> past1DaySharepointComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointComplianceCount == null && Exploration.Includes(parent + ".past1DaySharepointComplianceCount$"))
            {
                this.Past1DaySharepointComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySharepointOutOfComplianceCount
            // GraphQL -> past1DaySharepointOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySharepointOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DaySharepointOutOfComplianceCount$"))
            {
                this.Past1DaySharepointOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySpListComplianceCount
            // GraphQL -> past1DaySpListComplianceCount: Int! (scalar)
            if (this.Past1DaySpListComplianceCount == null && Exploration.Includes(parent + ".past1DaySpListComplianceCount$"))
            {
                this.Past1DaySpListComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySpListOutOfComplianceCount
            // GraphQL -> past1DaySpListOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySpListOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DaySpListOutOfComplianceCount$"))
            {
                this.Past1DaySpListOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySpSiteCollectionComplianceCount
            // GraphQL -> past1DaySpSiteCollectionComplianceCount: Int! (scalar)
            if (this.Past1DaySpSiteCollectionComplianceCount == null && Exploration.Includes(parent + ".past1DaySpSiteCollectionComplianceCount$"))
            {
                this.Past1DaySpSiteCollectionComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DaySpSiteCollectionOutOfComplianceCount
            // GraphQL -> past1DaySpSiteCollectionOutOfComplianceCount: Int! (scalar)
            if (this.Past1DaySpSiteCollectionOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DaySpSiteCollectionOutOfComplianceCount$"))
            {
                this.Past1DaySpSiteCollectionOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayTeamsComplianceCount
            // GraphQL -> past1DayTeamsComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsComplianceCount == null && Exploration.Includes(parent + ".past1DayTeamsComplianceCount$"))
            {
                this.Past1DayTeamsComplianceCount = new System.Int32();
            }
            //      C# -> System.Int32? Past1DayTeamsOutOfComplianceCount
            // GraphQL -> past1DayTeamsOutOfComplianceCount: Int! (scalar)
            if (this.Past1DayTeamsOutOfComplianceCount == null && Exploration.Includes(parent + ".past1DayTeamsOutOfComplianceCount$"))
            {
                this.Past1DayTeamsOutOfComplianceCount = new System.Int32();
            }
            //      C# -> System.Boolean? SlaPauseStatus
            // GraphQL -> slaPauseStatus: Boolean! (scalar)
            if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus$"))
            {
                this.SlaPauseStatus = new System.Boolean();
            }
            //      C# -> System.Int32? UnprotectedUsersCount
            // GraphQL -> unprotectedUsersCount: Int! (scalar)
            if (this.UnprotectedUsersCount == null && Exploration.Includes(parent + ".unprotectedUsersCount$"))
            {
                this.UnprotectedUsersCount = new System.Int32();
            }
            //      C# -> List<Org>? AllOrgs
            // GraphQL -> allOrgs: [Org!]! (type)
            if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
            {
                this.AllOrgs = new List<Org>();
                this.AllOrgs.ApplyExploratoryFragment(parent + ".allOrgs");
            }
            //      C# -> O365UserConnection? ChildConnection
            // GraphQL -> childConnection: O365UserConnection! (type)
            if (this.ChildConnection == null && Exploration.Includes(parent + ".childConnection"))
            {
                this.ChildConnection = new O365UserConnection();
                this.ChildConnection.ApplyExploratoryFragment(parent + ".childConnection");
            }
            //      C# -> PathNode? EffectiveSlaSourceObject
            // GraphQL -> effectiveSlaSourceObject: PathNode (type)
            if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
            {
                this.EffectiveSlaSourceObject = new PathNode();
                this.EffectiveSlaSourceObject.ApplyExploratoryFragment(parent + ".effectiveSlaSourceObject");
            }
            //      C# -> List<PathNode>? LogicalPath
            // GraphQL -> logicalPath: [PathNode!]! (type)
            if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
            {
                this.LogicalPath = new List<PathNode>();
                this.LogicalPath.ApplyExploratoryFragment(parent + ".logicalPath");
            }
            //      C# -> List<PathNode>? PhysicalPath
            // GraphQL -> physicalPath: [PathNode!]! (type)
            if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
            {
                this.PhysicalPath = new List<PathNode>();
                this.PhysicalPath.ApplyExploratoryFragment(parent + ".physicalPath");
            }
            //      C# -> O365OrgDescendantConnection? SearchDescendantConnection
            // GraphQL -> searchDescendantConnection: O365OrgDescendantConnection! (type)
            if (this.SearchDescendantConnection == null && Exploration.Includes(parent + ".searchDescendantConnection"))
            {
                this.SearchDescendantConnection = new O365OrgDescendantConnection();
                this.SearchDescendantConnection.ApplyExploratoryFragment(parent + ".searchDescendantConnection");
            }
            //      C# -> SnapshotDistribution? SnapshotDistribution
            // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
            if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
            {
                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFragment(parent + ".snapshotDistribution");
            }
            //      C# -> List<Operation>? AuthorizedOperations
            // GraphQL -> authorizedOperations: [Operation!]! (enum)
            if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations$"))
            {
                this.AuthorizedOperations = new List<Operation>();
            }
            //      C# -> HierarchyObjectTypeEnum? ObjectType
            // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
            if (this.ObjectType == null && Exploration.Includes(parent + ".objectType$"))
            {
                this.ObjectType = new HierarchyObjectTypeEnum();
            }
            //      C# -> SlaAssignmentTypeEnum? SlaAssignment
            // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
            if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment$"))
            {
                this.SlaAssignment = new SlaAssignmentTypeEnum();
            }
            //      C# -> OrgStatus? Status
            // GraphQL -> status: OrgStatus! (enum)
            if (this.Status == null && Exploration.Includes(parent + ".status$"))
            {
                this.Status = new OrgStatus();
            }
            //      C# -> SlaDomain? ConfiguredSlaDomain
            // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
            if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
            {
                this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.ConfiguredSlaDomain.ApplyExploratoryFragment(parent + ".configuredSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveRetentionSlaDomain
            // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
            if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
            {
                this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveRetentionSlaDomain.ApplyExploratoryFragment(parent + ".effectiveRetentionSlaDomain");
            }
            //      C# -> SlaDomain? EffectiveSlaDomain
            // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
            if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
            {
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.CreateInstanceOfFirstType(typeof(SlaDomain));
                this.EffectiveSlaDomain.ApplyExploratoryFragment(parent + ".effectiveSlaDomain");
            }
        }


    #endregion

    } // class O365Org
    #endregion

    public static class ListO365OrgExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<O365Org> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365Org> list, 
            String parent = "")
        {
            var item = new O365Org();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types