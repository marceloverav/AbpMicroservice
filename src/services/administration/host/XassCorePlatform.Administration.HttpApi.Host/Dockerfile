#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/administration/host/XassCorePlatform.Administration.HttpApi.Host/XassCorePlatform.Administration.HttpApi.Host.csproj", "services/administration/host/XassCorePlatform.Administration.HttpApi.Host/"]
COPY ["shared/XassCorePlatform.Hosting.Shared/XassCorePlatform.Hosting.Shared.csproj", "shared/XassCorePlatform.Hosting.Shared/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.Application.Contracts/XassCorePlatform.IdentityService.Application.Contracts.csproj", "services/identity/src/XassCorePlatform.IdentityService.Application.Contracts/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.Domain.Shared/XassCorePlatform.IdentityService.Domain.Shared.csproj", "services/identity/src/XassCorePlatform.IdentityService.Domain.Shared/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.EntityFrameworkCore/XassCorePlatform.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/XassCorePlatform.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.Domain/XassCorePlatform.IdentityService.Domain.csproj", "services/identity/src/XassCorePlatform.IdentityService.Domain/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Application.Contracts/XassCorePlatform.SaaS.Application.Contracts.csproj", "services/saas/src/XassCorePlatform.SaaS.Application.Contracts/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Domain.Shared/XassCorePlatform.SaaS.Domain.Shared.csproj", "services/saas/src/XassCorePlatform.SaaS.Domain.Shared/"]
COPY ["services/administration/src/XassCorePlatform.Administration.HttpApi/XassCorePlatform.Administration.HttpApi.csproj", "services/administration/src/XassCorePlatform.Administration.HttpApi/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Application.Contracts/XassCorePlatform.Administration.Application.Contracts.csproj", "services/administration/src/XassCorePlatform.Administration.Application.Contracts/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Domain.Shared/XassCorePlatform.Administration.Domain.Shared.csproj", "services/administration/src/XassCorePlatform.Administration.Domain.Shared/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Application/XassCorePlatform.Administration.Application.csproj", "services/administration/src/XassCorePlatform.Administration.Application/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Domain/XassCorePlatform.Administration.Domain.csproj", "services/administration/src/XassCorePlatform.Administration.Domain/"]
COPY ["services/administration/src/XassCorePlatform.Administration.EntityFrameworkCore/XassCorePlatform.Administration.EntityFrameworkCore.csproj", "services/administration/src/XassCorePlatform.Administration.EntityFrameworkCore/"]
RUN dotnet restore "services/administration/host/XassCorePlatform.Administration.HttpApi.Host/XassCorePlatform.Administration.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/administration/host/XassCorePlatform.Administration.HttpApi.Host"
RUN dotnet build "XassCorePlatform.Administration.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XassCorePlatform.Administration.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XassCorePlatform.Administration.HttpApi.Host.dll"]