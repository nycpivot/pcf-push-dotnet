cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-api-routing-products -r -f
pause

cf push
pause