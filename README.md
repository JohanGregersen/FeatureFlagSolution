# FeatureFlagSolution
My solution to IBM feature flags.
Spent roughly 5 hours on the project.

Should be runnable on the local IIS
Otherwise it runs hosted here https://featureflagshowcasewebsite.azurewebsites.net/

## Toggles
It is possible toggle locally in appsettings.json.

**NewWebsite** - should add a link to a new secret subpage.

**LoginRegistration** - should remove the possibility register.

**AzureFeatureTogglingEnable** - toggle using AzureAppConfigurations and using the featureManagement in Azure instead of appsettings *requires a republish/rebuild at the moment.

**Beta** - No real functionality, shows how easy it is to setup Percentage based features -can be used for testing purposes.

**HalloweenPage** - No real functionality, shows how easy it is to setup a time based features.

## Login Features
Email confirmations and retrieval skeleton.

Faked email confirmation.

## Azure Setup

Azure SQL db for the login database.

AzureAppConfigurations.

Azure App Service with the website hosted.
