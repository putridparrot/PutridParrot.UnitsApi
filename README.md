# PutridParrot.UnitsApi

[![Build PutridParrot.UnitsApi](https://github.com/putridparrot/PutridParrot.UnitsApi/actions/workflows/build.yml/badge.svg)](https://github.com/putridparrot/PutridParrot.UnitsApi/actions/workflows/build.yml)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/putridparrot/PutridParrot.UnitsApi/blob/master/LICENSE.md)
[![GitHub Releases](https://img.shields.io/github/release/putridparrot/PutridParrot.UnitsApi.svg)](https://github.com/putridparrot/PutridParrot.UnitsApi/releases)
[![GitHub Issues](https://img.shields.io/github/issues/putridparrot/PutridParrot.UnitsApi.svg)](https://github.com/putridparrot/PutridParrot.UnitsApi/issues)


This is a WEB API version of the Nuget Package PutridParrot.Units

## Reminder on how to set up on Azure via the Azure client

Don't forget to change the registryname below to your registry and the version should be updated as well

* az login
* az acr build -t unitsapi:ver01 -r registryname .
* az acr repository list --name registryname
