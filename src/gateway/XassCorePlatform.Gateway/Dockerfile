#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["gateway/XassCorePlatform.Gateway/XassCorePlatform.Gateway.csproj", "gateway/XassCorePlatform.Gateway/"]
RUN dotnet restore "gateway/XassCorePlatform.Gateway/XassCorePlatform.Gateway.csproj"
COPY . .
WORKDIR "/src/gateway/XassCorePlatform.Gateway"
RUN dotnet build "XassCorePlatform.Gateway.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "XassCorePlatform.Gateway.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "XassCorePlatform.Gateway.dll"]