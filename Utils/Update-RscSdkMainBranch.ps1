param(
    [switch]$Dry = $false,
    [switch]$SkipBuild = $false
)

# Change to the root of the repository
Set-Location $PSScriptRoot\..

# Check for a clean repo
$gitStatus = git status --porcelain
if ($gitStatus) {
    throw "Repository is not clean. Please commit or stash changes before running this script."
}

# Checkout main branch
try {
    git checkout main
}
catch {
    throw "Failed to checkout 'main' branch."
}

# Merge devel into main without commit
try {
    git merge devel --no-commit --no-ff
}
catch {
    throw "Failed to merge 'devel' into 'main'."
}

# Restore Output directory
try {
    git restore --source=HEAD --staged -- Output/
    git restore --source=HEAD -- Output/
}
catch {
    throw "Failed to restore 'Output/' directory."
}

# Build the SDK
try {
    if (-not $SkipBuild) {
        .\Utils\Build-RscSdk.ps1
    }
}
catch {
    throw "Failed to build the SDK."
}

$changelogContent = Get-Content -Path .\CHANGELOG.md -Raw

# Use regex to capture the latest version entry
$hits = [regex]::Match($changelogContent, "(## Version .+?)(?=\r?\n## Version |\z)", 'Singleline')
if ($hits.Success -and $hits.Groups.Count -gt 1) {
    $latestVersionEntry = $hits.Groups[1].Value
    # Remove the initial "## " for the version string
    $latestVersionEntry = $latestVersionEntry -replace '## ', ''
    Write-Host "Latest version entry: `"$latestVersionEntry`""
    # Extract the version tag from the first line
    $versionTag = ($latestVersionEntry -split "`n")[0] -replace ' ', '_'
    Write-Host "Version tag: `"$versionTag`""
    
    # Commit changes with the latest version entry as the commit message
    try {
        if ($Dry) {
            Write-Host "Dry run: git commit -am `"$latestVersionEntry`""
        }
        else {
            git commit -am "$latestVersionEntry"
        }
    }
    catch {
        throw "Failed to commit changes."
    }

    # Create a new GitHub release
    try {
        if ($Dry) {
            Write-Host "Dry run: gh release create $versionTag -t $versionTag -n `"$latestVersionEntry`""
            return
        }
        else {
            gh release create $versionTag -t $versionTag -n "$latestVersionEntry"
        }
    }
    catch {
        throw "Failed to create GitHub release."
    }
}
else {
    throw "Failed to find the latest version entry in CHANGELOG.md."
}

Write-Host "Build and release process completed successfully."