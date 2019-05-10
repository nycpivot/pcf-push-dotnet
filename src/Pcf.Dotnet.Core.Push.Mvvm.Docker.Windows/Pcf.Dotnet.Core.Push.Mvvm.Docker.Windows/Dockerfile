FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./pcf-dotnet-core-push-mvvm-docker-windows/
RUN dotnet restore pcf-dotnet-core-push-mvvm-docker-windows/Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows.csproj

# Copy everything else and build
COPY . ./pcf-dotnet-core-push-mvvm-docker-windows/
WORKDIR /app/pcf-dotnet-core-push-mvvm-docker-windows
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
COPY --from=build /app/pcf-dotnet-core-push-mvvm-docker-windows/out ./

EXPOSE 8080/tcp
ENV ASPNETCORE_URLS=http://*:8080 
ENTRYPOINT ["dotnet", "Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows.dll", "--server-urls", "http://*:8080"]