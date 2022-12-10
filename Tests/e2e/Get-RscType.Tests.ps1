& "$PSScriptRoot\..\import.ps1"
. "$PSScriptRoot\..\serviceaccount.ps1"

Describe 'Get-RscType' {
    Context 'When called with the -ListAvailable parameter' {
        It 'Should return a list of valid Rsc types' {
            $result = Get-RscType -ListAvailable
            $result | Should -BeOfType [RubrikSecurityCloud.PowerShell.Models.RscTypeSummary]
            $result.Count | Should -BeGreaterThan 0
        }
    }

    Context 'When called with the -Name parameter' {
        It 'Should return an empty object of the specified Rsc type' {
            $result = Get-RscType -Name "AccountSetting"
            $result | Should -BeOfType Rubrik.SecurityCloud.Types.AccountSetting
            $result | Should -Not -BeNull
        }

        It 'Should initialize specified properties if -InitialProperties parameter is used' {
            $result = Get-RscType -Name "AccountSetting" -InitialProperties @("IsEulaAccepted")
            $result | Should -BeOfType Rubrik.SecurityCloud.Types.AccountSetting
            $result | Should -Not -BeNull
            $result.IsEulaAccepted | Should -Be $true
        }

        It 'Should throw an exception if the specified Rsc type is not found' {
            {Get-RscType -Name "InvalidType"} | Should -Throw "No type found that matches InvalidType*"
        }

        It -Name 'Return object with specific values in fields' -Test {
            $userCredentials = Get-RscType -Name "UserCredentials" -InitialValues @{"Username"= "admin"; "Password"= "pass"}
            $authInfo = Get-RscType -Name "AuthInfoInput" -InitialValues @{"UserCredentials" = $userCredentials}
            $authInfo.UserCredentials.Username | Should -Be "admin"
            $authInfo.UserCredentials.Password | Should -Be "pass"
          }
    }
}
