# PutridParrot.UnitsApi

This is a WEB API version of the Nuget Package PutridParrot.Units

## Reminder on how to set up on Azure via the Azure client

* az login
* az acr build -t unitsapi:ver01 -r registryname .
* az acr repository list --name registryname
