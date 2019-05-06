cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-framework-push-webforms-windows -r -f
pause

cf push
pause