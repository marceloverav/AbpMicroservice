#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["services/saas/NuGet.Config", "services/saas/"]
COPY ["services/administration/NuGet.Config", "services/administration/"]
COPY ["services/saas/host/XassCorePlatform.SaaS.HttpApi.Host/XassCorePlatform.SaaS.HttpApi.Host.csproj", "services/saas/host/XassCorePlatform.SaaS.HttpApi.Host/"]
COPY ["shared/XassCorePlatform.Hosting.Shared/XassCorePlatform.Hosting.Shared.csproj", "shared/XassCorePlatform.Hosting.Shared/"]
COPY ["services/administration/src/XassCorePlatform.Administration.EntityFrameworkCore/XassCorePlatform.Administration.EntityFrameworkCore.csproj", "services/administration/src/XassCorePlatform.Administration.EntityFrameworkCore/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Domain/XassCorePlatform.Administration.Domain.csproj", "services/administration/src/XassCorePlatform.Administration.Domain/"]
COPY ["services/administration/src/XassCorePlatform.Administration.Domain.Shared/XassCorePlatform.Administration.Domain.Shared.csproj", "services/administration/src/XassCorePlatform.Administration.Domain.Shared/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.HttpApi/XassCorePlatform.SaaS.HttpApi.csproj", "services/saas/src/XassCorePlatform.SaaS.HttpApi/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Application.Contracts/XassCorePlatform.SaaS.Application.Contracts.csproj", "services/saas/src/XassCorePlatform.SaaS.Application.Contracts/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Domain.Shared/XassCorePlatform.SaaS.Domain.Shared.csproj", "services/saas/src/XassCorePlatform.SaaS.Domain.Shared/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Application/XassCorePlatform.SaaS.Application.csproj", "services/saas/src/XassCorePlatform.SaaS.Application/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.Domain/XassCorePlatform.SaaS.Domain.csproj", "services/saas/src/XassCorePlatform.SaaS.Domain/"]
COPY ["services/saas/src/XassCorePlatform.SaaS.EntityFrameworkCore/XassCorePlatform.SaaS.EntityFrameworkCore.csproj", "services/saas/src/XassCorePlatform.SaaS.EntityFrameworkCore/"]
RUN dotnet restore "services/saas/host/XassCorePlatform.SaaS.HttpApi.Host/XassCorePlatform.SaaS.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/services/saas/host/XassCorePlatform.SaaS.HttpApi.Host"
RUN dotnet build "XassCorePlatform.SaaS.HttpApi.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XassCorePlatform.SaaS.HttpApi.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XassCorePlatform.SaaS.HttpApi.Host.dll"]