$instance = Invoke-RestMethod -Headers @{"Metadata"="true"} -Method GET -Proxy $Null -Uri "http://169.254.169.254/metadata/instance?api-version=2020-09-01" | ConvertTo-Json -Depth 64

$instanceObject = ConvertFrom-Json –InputObject $instance

$compparam= read-host -Prom "Please Enter Compute Metadata instance Parameter eg. osProfile,azEnvironment,location,name etc"

$instanceObject.compute.$compparam | ConvertTo-Json
