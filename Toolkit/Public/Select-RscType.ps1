#Requires -Version 3
function Select-RscType {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory=$true, ValueFromPipeline=$true, Position=0)]
        $FromInterfaceField,

        [Parameter(Mandatory=$true, Position=1)]
        [string]$TypeName
    )

    Process {
        if ($FromInterfaceField -is [System.Collections.IList]) {
            # Input is a list
            foreach ($item in $FromInterfaceField) {
                if ($item.GetType().Name -eq $TypeName) {
                    Write-Output $item
                }
            }
        } elseif ($FromInterfaceField -isnot [System.Collections.IList] -and $FromInterfaceField.GetType().GetMethod("GetNext")) {
            # Input is not a list, but has a GetNext() method
            $current = $FromInterfaceField
            while ($current) {
                if ($current.GetType().Name -eq $TypeName) {
                    Write-Output $current
                }
                $current = $current.GetNext()
            }
        } else {
            Write-Error "Input must be a list or a composite."
        }
    }
    
}
