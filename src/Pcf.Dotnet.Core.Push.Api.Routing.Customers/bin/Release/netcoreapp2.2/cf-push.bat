cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-api-routing-customers -r -f
pause

cf push
pause