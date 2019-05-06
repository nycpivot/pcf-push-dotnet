cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-mvc-docker-linux -r -f
pause

cf push --docker-image ?
pause