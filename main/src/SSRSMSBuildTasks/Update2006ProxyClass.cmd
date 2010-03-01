@echo off

SET ReportingServer=%1/ReportService2006.asmx

IF "%ReportingServer%"=="?" GOTO :Error
IF "%ReportingServer%"=="" GOTO :Error

@Wsdl /language:c#  /protocol:SOAP /namespace:ssrsmsbuildtasks.DeploymentManger.Proxy.Itergrated /out:.\ssrsmsbuildtasks\DeploymentManger\Proxy\Itergrated\MSReportingService2006.cs %1

GOTO :End 

:Error
@Echo Usage:
@Echo "Update2006ProxyClass.cmd http://<ReportServer>/<ReportServerVirtualDirecory>"
GOTO :End

:End
pause


