echo "# AzureProductService" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/yogendra-singh-7b/AzureProductService.git
git push -u origin main


git remote add origin https://github.com/yogendra-singh-7b/AzureProductService.git
git branch -M main
git push -u origin main
_________________________
Now we have pipeline and we have the agent which is locally running as window service

Dotnnet core --- > github  ----- > devops ------> 


Service connection : azserviceconnection

Azure Service Name: devapp-service





________________________________________________________________
trigger:
  main

pool:
  name: sandeepTraining

steps:
   task: UseDotNet@2
  inputs:
    packageType: 'sdk'
    version: '10.x'

script: dotnet restore src/productservice/productservice.csproj
  displayName: 'Restore'

script: dotnet build src/productservice/productservice.csproj --no-restore
  displayName: 'Build'

script: dotnet test test/Mytests/Mytests.csproj
  displayName: 'Test'

script: dotnet publish src/productservice/productservice.csproj -c Release -o $(Build.ArtifactStagingDirectory)
  displayName: 'Publish'

- task: AzureWebApp@1
  inputs:
    azureSubscription: 'Azure-CICD'
    appType: 'webApp'
    appName: 'cicdapps'
    package: '$(Build.ArtifactStagingDirectory)'

cicdapps ---webapp name

Azure-CICD'-----service connection name
____________________________________________________