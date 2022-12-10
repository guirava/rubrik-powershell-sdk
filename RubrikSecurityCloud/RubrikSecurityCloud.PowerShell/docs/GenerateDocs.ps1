<#
This script will parse the RubrikSecurityCloud.PowerShell.xml file
and output a MAML file that will be used by PowerShell to display 
the module help contant for Get-Help.
The Rubrik.SecurityCloud.PowerShell.xml file is generated by the
dotnet build process for the PowerShell module.
#>

param (

    [Parameter(Mandatory=$true, Position=0)]
    [ValidateNotNullOrEmpty()]
    [string]$sourceXml,

    [Parameter(Mandatory=$true, Position=1)]
    [ValidateNotNullOrEmpty()]
    [string]$ModuleFilePath,

    [Parameter(Mandatory=$true, Position=2)]
    [ValidateNotNullOrEmpty()]
    [string]$ModuleName,

    [Parameter(Mandatory=$true, Position=3)]
    [ValidateNotNullOrEmpty()]
    [string]$OutputPath
)

if ($null -eq (Get-Module -ListAvailable | Where-Object {$_.Name -eq "PlatyPS"})){
    Write-Output("PSModule PlatyPS Is not installed and available to load. Attempting install")
    Set-PSRepository -Name PSGallery -InstallationPolicy Trusted
    Install-Module -Name PlatyPS -Confirm:$false
    if ($null -eq (Get-Module -ListAvailable | Where-Object {$_.Name -eq "PlatyPS"})){
        Write-Output("PlatyPS Module Installation Failed. Exiting...")
        exit 1
    }
}

Import-Module -Name PlatyPS
Import-Module $ModuleFilePath

#Generate markdown from Module Binary
New-MarkdownHelp -Module $ModuleName -OutputFolder ./tmp_help/
Get-Item ./tmp_help/

# Read the documentation XML generated by C# as xml
$xml = [xml](Get-Content $sourceXml)
#$maml = Get-Content "./tmp_help/$($(Get-Module -Name $ModuleName).RootModule)-help.xml"

#Remove-Item ./tmp_help -Force -Confirm:$false -Recurse:$true

# Iterate through elements in XML. We need to fill in the gaps within the markdown
foreach ($memberItem in $xml.doc.members.member){
    # Elements will look like: <member name="T:Rubrik.SecurityCloud.PowerShell.Cmdlets.Connect_Rsc">
    # The T infers that this is a type. A P infers a property.
    # Determine if the current element in the foreach loop is a type in the Cmdlets namespace
    $nameArr = $memberItem.name.split(":")
    if ($nameArr[0] -eq "T" -And $nameArr[1].Contains("Cmdlets")){
        
        $cmdletName = $nameArr[1].split(".")[$_.count -1]
        $cmdletName = $cmdLetName.Replace("_","-")
        Write-Output("`nFound Cmdlet: " + $cmdletName);
        Write-Output("Opening markdownd for $cmdletName")
        $cmdletMarkdown = Get-Content -Path "tmp_help/$($cmdletName).md" -Raw

        # Get the help text and exmaples for the Cmdlet
        $shortName = $nameArr[1].split(".")[$_.count - 1]
        $synopsis = $memberItem.summary 
        $description = $memberItem.description
        $examples = $memberItem.example

        #Fill in the cmdlet synopsis
        $synopsis = $synopsis -replace '\s+', ' '
        $cmdletMarkdown = $cmdletMarkdown -replace "{{ Fill in the Synopsis }}", $synopsis

        #Fill in the cmdlet description
        $description = $description -replace '\s+', ' '
        $cmdletMarkdown = $cmdletMarkdown -replace "{{ Fill in the Description }}", $description

        #Write the examples
        $exampleText = ""
        if ($examples.count -gt 1){
            for ($i = 0; $i -le $examples.count -1; $i++ ){            
                $exampleText += "### Example $($i+1)"
                $exampleText += "`n```````n"
                $exampleText += $examples[$i].code
                $exampleText += "`n```````n"
                $exampleText += "$($($examples[$i].'#text') -replace '\s+', ' ')`n`n"
            }
        }else{
            $exampleText += "### Example 1"
            $exampleText += "`n```````n"
            $exampleText += $examples.code
            $exampleText += "`n```````n"
            $exampleText += "$($($examples.'#text') -replace '\s+', ' ')`n`n"
        }

        #$exampleText
        #$cmdletMarkdown = $cmdletMarkdown -replace '###.+Example.+\n```.+\n.*\n```\n+{{.+}}', $exampleText
        $cmdletMarkdown = $cmdletMarkdown -replace '#{3}\sExample.*\n.*\n.*\n.*\n*.*\n{{ Add example description here }}', $exampleText.ToString()

        if ($cmdletName -eq "Disconnect-Rsc"){
            $cmdletMarkdown
        }
        

        #Update the markdown file
        $cmdletMarkdown | Set-Content -Path "tmp_help/$($cmdletName).md" -Force:$true

        # Get the properties for the cmdlet
        Write-Output("Getting properties for Cmdlet: $cmdletName")
        $properties = $xml.doc.members.member | Where-Object {$_.name.split(":")[0] -eq "P"}
        $properties = $properties | Where-Object {$_.name.split(":")[1].Contains($shortName)}

        foreach ($prop in $properties){
            $propsummary = $prop.summary -replace '\s+', ' '
            ($(Get-Content -Path "tmp_help/$($cmdletName).md" -Raw) -replace "{{ Fill $($prop.name.Split(":")[1].Split(".")[$_.Count -1]) Description }}", $propsummary) | Set-Content -Path "tmp_help/$($cmdletName).md" -Force:$true
            #$cmdletMarkdown.Replace("{{ Fill $($prop.name.Split(":")[1].Split(".")[$_.Count -1]) Description }}", $prop.summary, [StringComparison]::CurrentCultureIgnoreCase)
        }
    }
}

#Generate the .dll-help.xml file from the temporary Markdown files
New-ExternalHelp -Path ./tmp_help -OutputPath $OutputPath -Force:$true

#Remove the temporary .md files.
Remove-Item -Recurse:$true -Force -Path ./tmp_help