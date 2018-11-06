# AzureKuduApplicationEndTest

This project illustrates issue with Azure App service configuration settings. 
Settings set through Azure Portal and not avaliable in ASP.NET application Application_End event handler for some reason.

Steps to reproduce the issue:
1) Clone the repo
2) Deploy to new Azure App Service
3) Enabled Application Logging to file system with Infomration level in App Service settings
4) Observe that application root url when opened shows this information "connectionStringValue=ConnectionStringValueFromWebConfig settingValue=MySettingValueFromWebConfig"
5) Go to Azure portal App Service Application Settings tab and add new Application Setting "MySetting" with "MySettingValueFromAzurePortal"
6) In Azure Portal in Application Settings add new connection string "ApplicationEndKuduTest.Properties.Settings.MyConnectionString" with type "Custom" and value "MyConnectionStringValueFromAzurePortal"
7) Save Application Settings in Azure Portal
8) Observe that application root url when opened shows this information "connectionStringValue=MyConnectionStringValueFromAzurePortal settingValue=MySettingValueFromAzurePortal"
9) Open Log Stream in Azure Portal and switch to Application Log, wait until Log Stream is connected
10) In sepparate browser tab stop App Service using Azure Portal
11) Observe than Log stream and find these entries

2018-11-06T08:20:40  PID[20532] Information connectionStringValue=ConnectionStringValueFromWebConfig
2018-11-06T08:20:40  PID[20532] Information settingValue=MySettingValueFromWebConfig

EXPECTED: Log stream should show connectionStringValue=MyConnectionStringValueFromAzurePortal and settingValue=MySettingValueFromAzurePortal
ACTUAL: : Log stream should show connectionStringValue=ConnectionStringValueFromWebConfig and settingValue=MySettingValueFromWebConfig

