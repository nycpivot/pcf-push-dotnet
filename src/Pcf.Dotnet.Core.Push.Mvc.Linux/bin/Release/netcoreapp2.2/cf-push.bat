cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-mvc-linux -r -f
pause

cf push
pause