FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5131

ENV ASPNETCORE_URLS=http://+:5131

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["OpenRemoteManage.GatewayAPI/OpenRemoteManage.GatewayAPI.csproj", "OpenRemoteManage.GatewayAPI/"]
RUN dotnet restore "OpenRemoteManage.GatewayAPI/OpenRemoteManage.GatewayAPI.csproj"
COPY . .
WORKDIR "/src/OpenRemoteManage.GatewayAPI"
RUN dotnet build "OpenRemoteManage.GatewayAPI.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "OpenRemoteManage.GatewayAPI.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenRemoteManage.GatewayAPI.dll"]
