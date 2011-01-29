@echo off

IF "%1"=="?" GOTO :Error
IF "%1"=="" GOTO :Error

SET ReportingServer=%1/ReportService2010.asmx
@Wsdl /language:c#  /protocol:SOAP /namespace:ssrsmsbuildtasks.DeploymentManger.Proxy.Native /out:.\ssrsmsbuildtasks\DeploymentManger\Proxy\NativeR2\MSReportingService2010.cs %1

GOTO :End 

:Error
@Echo Usage:
@Echo "Update2006ProxyClass.cmd http://<ReportServer>/<ReportServerVirtualDirecory>"
GOTO :End

:End
pause


