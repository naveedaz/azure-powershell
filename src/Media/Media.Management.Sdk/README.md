# Overall
This directory contains management plane service clients of Az.Storage module.

## Run Generation
In this directory, run AutoRest:
```
autorest --reset
autorest --use:@autorest/powershell@4.x
```

### AutoRest Configuration
> see https://aka.ms/autorest
``` yaml
isSdkGenerator: true
powershell: true
clear-output-folder: true
reflect-api-versions: true
openapi-type: arm
azure-arm: true
license-header: MICROSOFT_MIT_NO_VERSION
```



###
``` yaml
commit: 3586e2989d502434c4f607dd38d40e46aabede5c
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/$(commit)/arm-mediaservices/2015-10-01/swagger/media.json

output-folder: Generated

namespace: Microsoft.Azure.Management.Media
```