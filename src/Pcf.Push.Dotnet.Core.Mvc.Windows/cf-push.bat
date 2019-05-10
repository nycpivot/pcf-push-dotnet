cf target -s pcf-push-dotnet
pause

cf delete pcf-push-dotnet-core-mvc-windows -r -f
pause

cf push
pause