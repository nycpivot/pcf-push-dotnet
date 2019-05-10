cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-mvvm-docker-linux -r -f
pause

cf push pcf-dotnet-core-push-mvvm-docker-linux --docker-image nycpivot/pcf-dotnet-core-push-mvvm-docker-linux
pause