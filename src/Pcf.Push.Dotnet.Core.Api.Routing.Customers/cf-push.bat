cf target -s pcf-push-dotnet
pause

cf delete pcf-push-dotnet-core-api-routing-customers -r -f
pause

cf push
pause