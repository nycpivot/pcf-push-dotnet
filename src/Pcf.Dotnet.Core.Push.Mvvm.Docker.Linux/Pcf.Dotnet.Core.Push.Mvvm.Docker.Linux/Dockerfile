FROM mcr.microsoft.com/dotnet/core/sdk:2.2-alpine AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./pcf-dotnet-core-push-mvvm-docker-linux/
RUN dotnet restore pcf-dotnet-core-push-mvvm-docker-linux/Pcf.Dotnet.Core.Push.Mvvm.Docker.Linux.csproj

# Copy everything else and build
COPY . ./pcf-dotnet-core-push-mvvm-docker-linux/
WORKDIR /app/pcf-dotnet-core-push-mvvm-docker-linux
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-alpine AS runtime
COPY --from=build /app/pcf-dotnet-core-push-mvvm-docker-linux/out ./

EXPOSE 8080/tcp
ENV ASPNETCORE_URLS=http://*:8080 
ENTRYPOINT ["dotnet", "Pcf.Dotnet.Core.Push.Mvvm.Docker.Linux.dll"]