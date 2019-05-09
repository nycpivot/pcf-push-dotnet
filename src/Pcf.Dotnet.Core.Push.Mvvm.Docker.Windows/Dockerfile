FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows/*.csproj ./Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows/
RUN dotnet restore

# copy everything else and build app
COPY Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows/. ./Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows/
WORKDIR /app/Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/Pcf.Dotnet.Core.Push.Mvvm.Docker.Windows/out ./

EXPOSE 8080/tcp
ENV ASPNETCORE_URLS=http://*:8080
ENTRYPOINT ["dotnet", "run", "--server-urls", "http://*:8080"]