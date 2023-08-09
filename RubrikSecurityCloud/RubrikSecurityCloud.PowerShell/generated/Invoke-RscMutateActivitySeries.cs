// Invoke-RscMutateActivitySeries.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscMutateActivitySeries",
        DefaultParameterSetName = "Cancel")
    ]
    public class Invoke_RscMutateActivitySeries : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // Cancel parameter set
        //
        // [GraphQL: cancelActivitySeries]
        //
        [Parameter(
            ParameterSetName = "Cancel",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
@"Cancel an activity series.
[GraphQL: cancelActivitySeries]",
            Position = 0
        )]
        public SwitchParameter Cancel { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "Cancel":
                        this.ProcessRecord_Cancel();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // cancelActivitySeries.
        protected void ProcessRecord_Cancel()
        {
            this._logger.name += " -Cancel";
            // Invoke graphql operation cancelActivitySeries
            InvokeMutationCancelActivitySeries();
        }


        // Invoke GraphQL Mutation:
        // cancelActivitySeries(input: CancelActivitySeriesInput!): Boolean!
        protected void InvokeMutationCancelActivitySeries()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "CancelActivitySeriesInput!"),
            };
            System.Boolean? fieldSpecObj = null ;
            if (this.Field != null) {
                if (this.Field is PSObject psObject) {
                    fieldSpecObj = (System.Boolean)psObject.BaseObject;
                } else {
                    fieldSpecObj = (System.Boolean)this.Field;
                }
            }
            string fieldSpecDoc = Mutation.CancelActivitySeries(ref fieldSpecObj);
            Initialize(
                argDefs,
                fieldSpecObj,
                "mutation",
                "MutationCancelActivitySeries",
                "($input: CancelActivitySeriesInput!)",
                fieldSpecDoc,
                "System.Boolean"
            );
        }


    } // class Invoke_RscMutateActivitySeries
}