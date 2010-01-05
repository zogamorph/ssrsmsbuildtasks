@echo off

SET ReportingServer=%1

IF "%ReportingServer%"=="?" GOTO :Error
IF "%ReportingServer%"=="" GOTO :Error

@%WinDir%\microsoft.net\Framework\v2.0.50727\MSBuild SSRSMSBuildTaskDemo_Native.msbuild /t:FullDepoly /p:ReportingServerURL=%ReportingServer%
GOTO :End 

:Error
@Echo Usage:
@Echo "NativeUploadReports http://<ReportServer>/<ReportServerVirtualDirecory>"
GOTO :End

:End
pause

