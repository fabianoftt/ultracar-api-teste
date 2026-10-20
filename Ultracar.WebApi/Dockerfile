# Base runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copia os csproj de cada projeto
COPY Ultracar.WebApi/Ultracar.API/Ultracar.API.csproj Ultracar.WebApi/Ultracar.API/
COPY Ultracar.Application/Ultracar.Application.csproj Ultracar.Application/
COPY Ultracar.Domain/Ultracar.Domain.csproj Ultracar.Domain/
COPY Ultracar.Infrastructure/Ultracar.Infrastructure.csproj Ultracar.Infrastructure/

# Restaura dependências
RUN dotnet restore Ultracar.WebApi/Ultracar.API/Ultracar.API.csproj

# Copia o restante do código
COPY . .

# Define o diretório de trabalho para build
WORKDIR /src/Ultracar.WebApi/Ultracar.API
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

# Publish stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Ultracar.API.dll"]
