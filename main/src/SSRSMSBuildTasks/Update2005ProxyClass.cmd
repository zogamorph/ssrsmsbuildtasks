@echo off

SET ReportingServer=%1/ReportService2005.asmx

IF "%ReportingServer%"=="?" GOTO :Error
IF "%ReportingServer%"=="" GOTO :Error

@Wsdl /language:c#  /protocol:SOAP /namespace:ssrsmsbuildtasks.DeploymentManger.Proxy.Native  /out:.\ssrsmsbuildtasks\DeploymentManger\Proxy\Native\MSReportingService2005.cs %1

GOTO :End 

:Error
@Echo Usage:
@Echo "Update2005ProxyClass.cmd http://<ReportServer>/<ReportServerVirtualDirecory>"
GOTO :End

:End
pause


