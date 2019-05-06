cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-empty -r -f
pause

cf push
pause