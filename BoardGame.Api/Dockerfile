FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 5050
EXPOSE 5051

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BoardGame.Api/BoardGame.Api.csproj", "BoardGame.Api/"]
COPY ["BoardGame.Application/BoardGame.Application.csproj", "BoardGame.Application/"]
COPY ["BoardGame.Models/BoardGame.Models.csproj", "BoardGame.Models/"]
COPY ["BoardGame.Persistence.Migrations/BoardGame.Persistence.Migrations.csproj", "BoardGame.Persistence.Migrations/"]
COPY ["BoardGame.Persistence/BoardGame.Persistence.csproj", "BoardGame.Persistence/"]
COPY ["BoardGame.Extensions.Options/BoardGame.Extensions.Options.csproj", "BoardGame.Extensions.Options/"]
RUN dotnet restore "BoardGame.Api/BoardGame.Api.csproj"
COPY . .
WORKDIR "/src/BoardGame.Api"
RUN dotnet build "./BoardGame.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BoardGame.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BoardGame.Api.dll"]
