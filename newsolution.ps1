param(
    [Parameter(Mandatory)][string]$i,

    [Parameter(Mandatory)][string]$n
)

$ns = ($n -creplace '([A-Z])', '-$1').ToLower().TrimStart("-")
$fn = "$i.$ns.cs"

$lc = Get-Content -Path "./LeetCode/_templates.cs"
$lc = $lc.Replace("__name__", $n)
Set-Content -Path "./LeetCode/$fn" -Value $lc

$tc = Get-Content -Path "./Tests/_templates.cs"
$tc = $tc.Replace("__name__", $n)
Set-Content -Path "./Tests/$fn" -Value $tc

