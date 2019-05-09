cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-mvvm-docker-windows -r -f
pause

cf push pcf-dotnet-core-push-mvvm-docker-windows --docker-image nycpivot/pcf-dotnet-core-push-mvvm-docker-windows
pause