# Etapa base: contiene el runtime de ASP.NET Core
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

# Etapa de build: contiene el SDK de .NET para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["proyecto-si8811a-2024-ii-u1-desarrollo-api-back.csproj", "."]
RUN dotnet restore "./proyecto-si8811a-2024-ii-u1-desarrollo-api-back.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./proyecto-si8811a-2024-ii-u1-desarrollo-api-back.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Etapa de publicación: genera los artefactos listos para producción
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./proyecto-si8811a-2024-ii-u1-desarrollo-api-back.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Etapa final: solo incluye el runtime y los artefactos publicados
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "proyecto-si8811a-2024-ii-u1-desarrollo-api-back.dll"]