FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 4000
EXPOSE 4443 
EXPOSE 9229

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["BoardGame.View/BoardGame.View.csproj", "BoardGame.View/"]
COPY ["BoardGame.Models/BoardGame.Models.csproj", "BoardGame.Models/"]
RUN dotnet restore "BoardGame.View/BoardGame.View.csproj"
COPY . .
WORKDIR "/src/BoardGame.View"
RUN dotnet build "./BoardGame.View.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BoardGame.View.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
RUN apt-get update && apt-get install -y ca-certificates
COPY --from=build /src/certs/api.crt /usr/local/share/ca-certificates/
RUN update-ca-certificates
ENTRYPOINT ["dotnet", "BoardGame.View.dll"]
