@echo off

SET SharePointSiteUrl=%1

IF "%SharePointSiteUrl%"=="?" GOTO :Error
IF "%SharePointSiteUrl%"=="" GOTO :Error

@%WinDir%\microsoft.net\Framework\v2.0.50727\MSBuild SSRSMSBuildTaskDemoR2_Integrated.msbuild /t:FullDepoly /p:SharePointSiteUrl=%SharePointSiteUrl%
GOTO :End 

:Error
@Echo Usage:
@Echo "IntegratedUploadReports http://<SharePointServer>"
GOTO :End

:End
pause

