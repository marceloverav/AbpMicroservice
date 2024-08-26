#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/identity/NuGet.Config", "services/identity/"]
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["shared/XassCorePlatform.DbMigrator/XassCorePlatform.DbMigrator.csproj", "shared/XassCorePlatform.DbMigrator/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Application.Contracts/XassCorePlatform.Administration.Application.Contracts.csproj", "services/administration/src/XassCorePlatform.Administration.Application.Contracts/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Domain.Shared/XassCorePlatform.Administration.Domain.Shared.csproj", "services/administration/src/XassCorePlatform.Administration.Domain.Shared/"]
COPY ["services/administration/src/XassCorePlatform.Administration.EntityFrameworkCore/XassCorePlatform.Administration.EntityFrameworkCore.csproj", "services/administration/src/XassCorePlatform.Administration.EntityFrameworkCore/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Domain/XassCorePlatform.Administration.Domain.csproj", "services/administration/src/XassCorePlatform.Administration.Domain/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.Application.Contracts/XassCorePlatform.IdentityService.Application.Contracts.csproj", "services/identity/src/XassCorePlatform.IdentityService.Application.Contracts/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.Domain.Shared/XassCorePlatform.IdentityService.Domain.Shared.csproj", "services/identity/src/XassCorePlatform.IdentityService.Domain.Shared/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.EntityFrameworkCore/XassCorePlatform.IdentityService.EntityFrameworkCore.csproj", "services/identity/src/XassCorePlatform.IdentityService.EntityFrameworkCore/"]
COPY ["services/identity/src/XassCorePlatform.IdentityService.Domain/XassCorePlatform.IdentityService.Domain.csproj", "services/identity/src/XassCorePlatform.IdentityService.Domain/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Application.Contracts/XassCorePlatform.SaaS.Application.Contracts.csproj", "services/saas/src/XassCorePlatform.SaaS.Application.Contracts/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Domain.Shared/XassCorePlatform.SaaS.Domain.Shared.csproj", "services/saas/src/XassCorePlatform.SaaS.Domain.Shared/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.EntityFrameworkCore/XassCorePlatform.SaaS.EntityFrameworkCore.csproj", "services/saas/src/XassCorePlatform.SaaS.EntityFrameworkCore/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Domain/XassCorePlatform.SaaS.Domain.csproj", "services/saas/src/XassCorePlatform.SaaS.Domain/"]
COPY ["shared/XassCorePlatform.Microservice.Shared/XassCorePlatform.Microservice.Shared.csproj", "shared/XassCorePlatform.Microservice.Shared/"]
COPY ["shared/XassCorePlatform.Hosting.Shared/XassCorePlatform.Hosting.Shared.csproj", "shared/XassCorePlatform.Hosting.Shared/"]
RUN dotnet restore "shared/XassCorePlatform.DbMigrator/XassCorePlatform.DbMigrator.csproj"
COPY . .
WORKDIR "/src/shared/XassCorePlatform.DbMigrator"
RUN dotnet build "XassCorePlatform.DbMigrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XassCorePlatform.DbMigrator.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XassCorePlatform.DbMigrator.dll"]