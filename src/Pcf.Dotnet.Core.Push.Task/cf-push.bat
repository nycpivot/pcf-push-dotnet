cf target -s pcf-dotnet-push
pause

cf delete pcf-dotnet-core-push-task -r -f
pause

cf push
pause

cf stop pcf-dotnet-core-push-task
pause

cf run-task pcf-dotnet-core-push-task "cd ${HOME} && exec dotnet ./Pcf.Dotnet.Core.Push.Task.dll --server.urls http://0.0.0.0:${PORT}" --name "pcf-dotnet-core-push-task"
pause