#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SeekAndDestroy/SeekAndDestroy.csproj", "SeekAndDestroy/"]
COPY ["SAD.App/SAD.App.csproj", "SAD.App/"]
COPY ["SAD.Domain/SAD.Domain.csproj", "SAD.Domain/"]
COPY ["SAD.Infrastructure/SAD.Infrastructure.csproj", "SAD.Infrastructure/"]
RUN dotnet restore "./SeekAndDestroy/./SeekAndDestroy.csproj"
COPY . .
WORKDIR "/src/SeekAndDestroy"
RUN dotnet build "./SeekAndDestroy.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SeekAndDestroy.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SeekAndDestroy.dll"]