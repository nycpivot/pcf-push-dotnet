cf target -s pcf-push-dotnet
pause

cf delete pcf-push-dotnet-core-mvc-linux -r -f
pause

cf push
pause