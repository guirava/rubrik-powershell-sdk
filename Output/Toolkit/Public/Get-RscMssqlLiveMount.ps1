#Requires -Version 3
function Get-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>
    [CmdletBinding()]
    Param(        
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [String]$MountedDatabaseName,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$MssqlDatabase,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlLiveMount field profile: $fieldProfile"
        
        #region Create Query
        $query = New-RscQueryMssql -Operation DatabaseLiveMounts -FieldProfile $fieldProfile
        #endregion

        #region Filters
        $query.Var.filters = @()
        $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
        $nameFilter.Field = "MOUNTED_DATABASE_NAME"
        $nameFilter.texts = $MountedDatabaseName
        $query.Var.filters += $nameFilter

        If ( $PSBoundParameters.ContainsKey('MssqlDatabase') ) {
            $sourceDatabaseFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
            $sourceDatabaseFilter.Field = "SOURCE_DATABASE_ID"
            $sourceDatabaseFilter.Texts = $MssqlDatabase.Id
            $query.Var.filters += $sourceDatabaseFilter
        }
        #endregion

        $result = $query.Invoke()
        $result = $result.Nodes | Where-Object { $_.isReady -eq "true" }
        $result
    } 
}
