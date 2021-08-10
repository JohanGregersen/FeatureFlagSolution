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

## Justification for choice
I have chosen to make the Feature Toggle project as it the only one I have 0 experience with. I chose that because I saw it as a possibility to learn something while also demonstrating one of my greater attributes (according to myself) which is the ability to learn quickly and adapt. Ill gladly talk about the other cases at the interview if necessary.

I chose to work with C# and the microsoft stack as it is where I have to most experience, I did not want to write in a language I was uncomfortable with when creating a case-study like this. Especially considering my choice of project. I've focused solely on the Backend/devops side of the program as that was the most appealing side, and what I have by far the most experience with.
