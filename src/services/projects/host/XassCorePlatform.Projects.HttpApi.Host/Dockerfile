#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["services/projects/NuGet.Config", "services/projects/"]
COPY ["services/projects/host/XassCorePlatform.Projects.HttpApi.Host/XassCorePlatform.Projects.HttpApi.Host.csproj", "services/projects/host/XassCorePlatform.Projects.HttpApi.Host/"]
COPY ["services/projects/src/XassCorePlatform.Projects.HttpApi/XassCorePlatform.Projects.HttpApi.csproj", "services/projects/src/XassCorePlatform.Projects.HttpApi/"]
COPY ["services/projects/src/XassCorePlatform.Projects.Application.Contracts/XassCorePlatform.Projects.Application.Contracts.csproj", "services/projects/src/XassCorePlatform.Projects.Application.Contracts/"]
COPY ["services/projects/src/XassCorePlatform.Projects.Domain.Shared/XassCorePlatform.Projects.Domain.Shared.csproj", "services/projects/src/XassCorePlatform.Projects.Domain.Shared/"]
COPY ["services/projects/src/XassCorePlatform.Projects.Application/XassCorePlatform.Projects.Application.csproj", "services/projects/src/XassCorePlatform.Projects.Application/"]
COPY ["services/projects/src/XassCorePlatform.Projects.Domain/XassCorePlatform.Projects.Domain.csproj", "services/projects/src/XassCorePlatform.Projects.Domain/"]
COPY ["services/projects/src/XassCorePlatform.Projects.EntityFrameworkCore/XassCorePlatform.Projects.EntityFrameworkCore.csproj", "services/projects/src/XassCorePlatform.Projects.EntityFrameworkCore/"]
RUN dotnet restore "services/projects/host/XassCorePlatform.Projects.HttpApi.Host/XassCorePlatform.Projects.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/projects/host/XassCorePlatform.Projects.HttpApi.Host"
RUN dotnet build "XassCorePlatform.Projects.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XassCorePlatform.Projects.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XassCorePlatform.Projects.HttpApi.Host.dll"]